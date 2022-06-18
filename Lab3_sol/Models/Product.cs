using System.ComponentModel.DataAnnotations;

namespace Lab3_sol.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(20, ErrorMessage = "NAme Must be less than 25 char")]

        public string Name { get; set; }

        [Required]
        [Range(minimum: 200, maximum: 700, ErrorMessage = "Price Must Be betwwen 2000 : 7000")]
        public int Price { get; set; }
        [Required]
        public string Image { get; set; }
        public int Cat_Id { get; set; }
       
    }
}
