using EstoqueNaoFiscal.Domain.IRepositorys;
using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Infra.Data.Context;
using EstoqueNaoFiscal.Infra.Data.Repositorys.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Infra.Data.Repositorys
{
  public class RepositoryEnderecos : RepositoryBase<Enderecos> , IRepositoryEnderecos
    {
        private readonly EstoqueNaoFiscalContext _context;
        public RepositoryEnderecos(EstoqueNaoFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
