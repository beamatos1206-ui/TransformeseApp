using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformeseApp2.DTO
{
    public class AlunoDTO : PessoaDTO
    {
        public int cursoId;
        public bool unidadeId;

        public CursoDTO Curso { get; set; }
        public UnidadeDTO Unidade { get; set; }
        public int CursoId { get; set; }
        public int UnidadeId { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Aluno: {Nome}, Curso: {Curso.Nome}, Unidade: {Unidade.Nome}");
        }
    }
}
