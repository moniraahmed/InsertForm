using System.ComponentModel.DataAnnotations.Schema;

namespace InsertForm
{
    public class UserForm
    {
        public int Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;

        [NotMapped]
        public IFormFile? File { get; set; }

    }
}
