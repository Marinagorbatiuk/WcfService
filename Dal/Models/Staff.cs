using System.ComponentModel.DataAnnotations;
namespace Dal
{
    public class Staff
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual WorkPosition WorkPosition { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}