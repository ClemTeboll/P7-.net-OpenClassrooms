using AutoMapper;
using Microsoft.EntityFrameworkCore;
using P7_OC_Poseidon.Data;
using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<User>> AddUser(UserDto userDto)
        {
            userDto.Password = BCrypt.Net.BCrypt.HashPassword(userDto.Password);
            User newUser = _mapper.Map<UserDto, User>(userDto);

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<User> LoginUser(UserDto userDto)
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
                return user;
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
    }
}
