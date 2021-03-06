using System.ComponentModel.DataAnnotations;

namespace FlowerStoreAPI.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Adres { get; set; }

        [Required]
        public string Region { get; set; }
    }
}