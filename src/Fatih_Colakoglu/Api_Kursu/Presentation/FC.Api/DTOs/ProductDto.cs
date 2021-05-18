using System;
using System.ComponentModel.DataAnnotations;

namespace FC.Api.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir")]
        public string Name { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "{0} alanı 0dan büyük değer olmalıdır.")]
        public int Stock { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "{0} alanı 0dan büyük değer olmalıdır.")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
