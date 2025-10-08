using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class UnidadeBLL
    {
        private List <UnidadeDTO> _unidades = Database.Unidades;
        public void CadastrarUnidade(UnidadeDTO unidadeDTO)
        {
            if (string.IsNullOrWhiteSpace(unidadeDTO.Nome))
                throw new Exception("Nome é obrigatório");

            Database.Unidades.Add(unidadeDTO);
        }

        public List<UnidadeDTO> ListarUnidades() => Database.Unidades;

        public UnidadeDTO GetbyId(int id)
        {
            return _unidades.FirstOrDefault(unidade => unidade.Id == id);
        }
    }
}
