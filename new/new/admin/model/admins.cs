using System.ComponentModel.DataAnnotations;

namespace admin.model
{
    public class admins
    {
        [Key]
        public string? username { get; set; }
        public string? password { get; set; }
    }
}
