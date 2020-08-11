using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueNaoFiscal.Domain.Models.Base
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime ?DataAtualizacao { get; set; }

    }
}
