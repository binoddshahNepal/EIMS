using System.ComponentModel.DataAnnotations;

namespace EIMS.Models
{
    public class users
    {
        [Key]
        public int  userId { get; set; }
        public string userName { get; set; }

        [DataType(DataType.Password)]
        public String password { get; set; }
        public String role { get; set; }
    }
}
