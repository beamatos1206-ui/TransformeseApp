using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class CursoBLL
    {
        private List<CursoDTO> _cursos = Database.Cursos;
        public void CadastrarCurso(CursoDTO cursoDTO)
        {
            //  Validação antes de salvar o curso
            if (string.IsNullOrWhiteSpace(cursoDTO.Nome))
                throw new Exception("Nome é obrigatório");

            Database.Cursos.Add(cursoDTO);
        }

        public List<CursoDTO> ListarCursos() => Database.Cursos;

        public CursoDTO GetbyId(int id)
        {
            return _cursos.FirstOrDefault(curso => curso.Id == id);
        }
    }
}
