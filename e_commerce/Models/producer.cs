using System.ComponentModel.DataAnnotations;

namespace e_commerce.Models
{
    public class Producer

    {

        [Key]
        public int id { get; set; }

        public string profilepictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}
