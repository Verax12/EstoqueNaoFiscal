using EstoqueNaoFiscal.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Domain.Models
{
    public class Users : BaseModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}
