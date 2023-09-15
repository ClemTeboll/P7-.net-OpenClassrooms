namespace P7_OC_Poseidon.Models.Dtos
{
    public record struct AuthDto
    (
        string? Name,
        string Password,
        string Email
    );
}
