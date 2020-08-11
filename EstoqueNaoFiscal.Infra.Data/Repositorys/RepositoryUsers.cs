using EstoqueNaoFiscal.Domain.IRepositorys;
using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Infra.Data.Context;
using EstoqueNaoFiscal.Infra.Data.Repositorys.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Infra.Data.Repositorys
{
  public  class RepositoryUsers : RepositoryBase<Users>, IRepositoryUsers
    {
        private readonly EstoqueNaoFiscalContext _context;
        public RepositoryUsers(EstoqueNaoFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
