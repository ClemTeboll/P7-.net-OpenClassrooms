using Microsoft.EntityFrameworkCore;

namespace P7_OC_Poseidon.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(cp =>
            {
                cp.HasKey(x => x.Id);
                cp.ToTable(nameof(User));
            });
        }
    }
}
