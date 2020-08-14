using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Infra.Data.Map.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Infra.Data.Map
{
    public class EnderecosMap : BaseMap<Enderecos>
    {
        public override void Configure(EntityTypeBuilder<Enderecos> builder)
        {
            builder.HasOne(x => x.Users).WithMany(x => x.Endereco).HasForeignKey(x => x.UsersId);
        }
    }
}
