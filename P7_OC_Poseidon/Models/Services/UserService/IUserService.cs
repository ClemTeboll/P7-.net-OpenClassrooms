using P7_OC_Poseidon.Models.Dtos;

namespace P7_OC_Poseidon.Models.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserDto>> GetAllUsers();
        Task<UserDto?> GetSingleUser(int id);
        Task<List<User>> AddUser(UserDto userDto);
        Task<User> LoginUser(UserDto userDto);
        Task<List<User>> UpdateUser(int id, UserDto userDto);
        Task<List<User>> DeleteUser(int id);
    }
}
