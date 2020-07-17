using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroCNPJ.Models
{
    public interface IEstabelecimento
    {
        IEnumerable<Estabelecimento> GetAllEstabelecimento();
        void AddEstabelecimento(Estabelecimento estabelecimento);
        void UpdateEstabelecimento(Estabelecimento estabelecimento);
        Estabelecimento GetEstabelecimento(int? id);
        void DeleteEstabelecimento(int? id);
    }
}
