using Domain.Contract;
using Domain.Entittes;
using Infrastructur.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Applicationservice
{
    public class ProductSliderFacade : IProductSliderFacade
    {
        IProductSliderRepository repository;
        public ProductSliderFacade()
        {
            repository = new ProductSliderRepository();
        }
        public int AddProductSlider(ProductSlider productSlider)
        {
            return repository.AddProductSlider(productSlider);
        }

        public List<ProductSlider> GetProductSliders()
        {
            return repository.GetProductSliders();
        }
    }
}
