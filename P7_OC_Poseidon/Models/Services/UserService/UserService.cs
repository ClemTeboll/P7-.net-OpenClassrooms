using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace P7_OC_Poseidon.Models.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public UserService(DataContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<List<User>> RegisterUser(UserDto userDto)
        {
            userDto.Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
            User newUser = _mapper.Map<UserDto, User>(userDto);

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<string> LoginUser(AuthDto userDto)
        {
            User user = await _context.Users
                    .Where(x => x.Email == userDto.Email)
                    .FirstOrDefaultAsync();

            if (user == null)
            {
                return null;
            }
            else if (BCrypt.Net.BCrypt.Verify(userDto.Password, user.Password))
            {
                userDto.Name = user.UserName;
                string token = CreateToken(userDto);
                return token;
            }
            else
            {
                return null;
            }
        }

        public async Task<List<User>> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return null;
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<UserDto>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            if (users == null)
                return null;

            List<UserDto> userDto = users.Select(_mapper.Map<UserDto>).ToList();

            return userDto;
        }

        public async Task<UserDto?> GetSingleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
                return null;

            UserDto userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task<List<User>> UpdateUser(int id, UserDto userDto)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
                return null;

            _mapper.Map(userDto, user);

            _context.Update(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        private string CreateToken(AuthDto user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Name!)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("Jwt:Token").Value!));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: credentials
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt!;
        }
    }
}
