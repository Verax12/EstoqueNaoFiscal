using EstoqueNaoFiscal.Domain.Models.Base;
using System.Linq;

namespace EstoqueNaoFiscal.Domain.Models
{
    public class Enderecos : BaseModel
    {
        public TipoLogradouro TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string ?Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public int UsersId { get; set; }
        public virtual Users Users { get; set; }
    }
}