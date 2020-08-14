using EstoqueNaoFiscal.Domain.IRepositorys;
using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Services.Interfaces;
using EstoqueNaoFiscal.Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Services.Services
{
    public class ServiceEnderecos : ServicesBase<Enderecos>, IServiceEnderecos
    {
        public readonly IRepositoryEnderecos _repositoryEnderecos;

        public ServiceEnderecos(IRepositoryEnderecos repositoryEnderecos) : base(repositoryEnderecos)
        {
            _repositoryEnderecos = repositoryEnderecos;
        }
    }
}
