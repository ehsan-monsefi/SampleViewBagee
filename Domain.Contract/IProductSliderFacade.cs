using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface IProductSliderFacade
    {
        List<ProductSlider> GetProductSliders();
        int AddProductSlider(ProductSlider productSlider);
    }
}
