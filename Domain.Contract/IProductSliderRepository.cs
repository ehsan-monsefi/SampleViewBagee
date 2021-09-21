using Domain.Entittes;
using System.Collections.Generic;

namespace Domain.Contract
{
    public interface IProductSliderRepository
    {
        List<ProductSlider> GetProductSliders();
        int AddProductSlider(ProductSlider productSlider);
    }
}
