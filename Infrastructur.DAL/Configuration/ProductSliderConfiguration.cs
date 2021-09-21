using Domain.Entittes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructur.DAL.Configuration
{
    class ProductSliderConfiguration : IEntityTypeConfiguration<ProductSlider>
    {
        public void Configure(EntityTypeBuilder<ProductSlider> builder)
        {
            builder.Property(a => a.PPic).HasColumnType("varchar(400)");
        }
    }
}
