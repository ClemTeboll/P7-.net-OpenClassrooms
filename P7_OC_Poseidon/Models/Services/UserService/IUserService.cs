using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto?> GetSingleUser(int id);
        Task<List<User>> RegisterUser(UserDto userDto);
        Task<string> LoginUser(AuthDto userDto);
        Task<List<User>> UpdateUser(int id, UserDto userDto);
        Task<List<User>> DeleteUser(int id);
    }
}
