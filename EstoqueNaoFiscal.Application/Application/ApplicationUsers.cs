using EstoqueNaoFiscal.Application.Interfaces;
using EstoqueNaoFiscal.Domain.Models;
using EstoqueNaoFiscal.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Application.Application
{
    public class ApplicationUsers : IApplicationUsers
    {
        public IServiceUsers _serviceUsers;


        public ApplicationUsers(IServiceUsers serviceUsers)
        {
            _serviceUsers = serviceUsers;
        }

        public void Add(Users obj)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Users> GetAll()
        {
            return _serviceUsers.GetAll();
        }

        public Users GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Users obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Users obj)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            _serviceUsers.Dispose();
        }

        public List<Users> GetUserWhitAddress()
        {
            return _serviceUsers.GetUserWhitAddress();
        }
    }
}
