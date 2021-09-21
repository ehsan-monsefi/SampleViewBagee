using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructur.DAL
{
    public class ProductSliderRepository : IProductSliderRepository
    {
        SmContext context;
        public ProductSliderRepository()
        {
            context = new SmContext();
        }
        public int AddProductSlider(ProductSlider productSlider)
        {
            context.ProductSliders.Add(productSlider);
            context.SaveChanges();
            return productSlider.Id;
        }

        public List<ProductSlider> GetProductSliders()
        {
            return context.ProductSliders.ToList();
        }
    }
}
