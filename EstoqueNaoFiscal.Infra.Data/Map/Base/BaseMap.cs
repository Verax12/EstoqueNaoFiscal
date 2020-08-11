using EstoqueNaoFiscal.Domain.Models.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Infra.Data.Map.Base
{
    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().HasColumnName("Id");
        }
    }
}
