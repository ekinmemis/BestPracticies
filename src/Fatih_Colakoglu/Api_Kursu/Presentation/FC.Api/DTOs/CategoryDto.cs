using System.ComponentModel.DataAnnotations;

namespace FC.Api.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
