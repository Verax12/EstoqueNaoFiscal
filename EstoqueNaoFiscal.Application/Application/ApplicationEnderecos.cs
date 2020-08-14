using EstoqueNaoFiscal.Application.Interfaces;
using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Application.Application
{
    public class ApplicationEnderecos : IApplicationEnderecos
    {
        private readonly IServiceEnderecos _serviceEnderecos;

        public ApplicationEnderecos(IServiceEnderecos serviceEnderecos)
        {
            _serviceEnderecos = serviceEnderecos;
        }
        public void Add(Enderecos obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enderecos> GetAll()
        {
            return _serviceEnderecos.GetAll();
        }

        public Enderecos GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Enderecos obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Enderecos obj)
        {
            throw new NotImplementedException();
        }
    }
}
