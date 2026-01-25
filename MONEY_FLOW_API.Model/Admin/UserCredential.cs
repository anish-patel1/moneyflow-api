using System.ComponentModel.DataAnnotations;

namespace MONEY_FLOW_API.Model
{
    public class UserCredential
    {
        [Required]
        public string? UserName { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
