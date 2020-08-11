using EstoqueNaoFiscal.Domain.IRepositorys;
using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Services.Interfaces;
using EstoqueNaoFiscal.Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Services.Services
{
    public class ServiceUsers : ServicesBase<Users>, IServiceUsers
    {
        public readonly IRepositoryUsers _repositoryUsers;

        public ServiceUsers(IRepositoryUsers RepositoryUsers) : base(RepositoryUsers)
        {
            _repositoryUsers = RepositoryUsers;
        }

    }
}
