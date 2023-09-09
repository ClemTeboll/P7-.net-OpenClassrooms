namespace P7_OC_Poseidon.Models.Dtos
{
    public record struct UserDto
    (
        int Id,
        string UserName,
        string Password,
        string Email,
        string FullName,
        string Role
    );
}
