using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Dtos.FlowerDTOS
{
    public class FlowerCreateDto
    {      
        [Required]
        public string Name { get; set; }
       
        [Required]
        public string Color { get; set; }

        [Required]
        public double Price { get; set; }
        
    }
}