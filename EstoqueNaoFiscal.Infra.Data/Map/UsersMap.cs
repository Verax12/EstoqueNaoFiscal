﻿using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Infra.Data.Map.Base;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EstoqueNaoFiscal.Infra.Data.Map
{
    public class UsersMap : BaseMap<Users>
    {
        public override void Configure(EntityTypeBuilder<Users> builder)
        {

            
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Sobrenome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Ativo).HasDefaultValue(1);
            builder.HasMany(c => c.Endereco).WithOne(c => c.Users);
            base.Configure(builder);
        }
    }
}
