using System.ComponentModel.DataAnnotations;

namespace Domain.Entittes
{
    public class ProductSlider
    {
        [Key]
        public int Id { get; set; }
        public string PathPic { get; set; }
        public string HPic { get; set; }
        public string PPic { get; set; }
    }
}
