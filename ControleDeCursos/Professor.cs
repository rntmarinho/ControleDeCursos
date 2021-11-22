using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Professor
    {
        public int    codigoProfessor;
        public string nomeCompleto, telefone;
        public double valorHoraAula;
        public string tabela = "tbl_professores";
        Conexao objConexao = new Conexao();

        public void CadastrarProfessor()
        {
            string inserir = $@"insert into {tabela} values (null, '{nomeCompleto}',
                             '{valorHoraAula}','{telefone}');";

            objConexao.ExecutarComando(inserir);

        }

        public void AlterarProfessor()
        {
            string alterar = $@"update {tabela} set nome='{nomeCompleto}',
                             valorHoraAula ='{valorHoraAula}', telefone='{telefone}'
                              where codigo='{codigoProfessor}';";
            objConexao.ExecutarComando(alterar);
        }
        public void ExcluirProfessor()
        {
            string excluir = $"delete from {tabela} where codigo='{codigoProfessor}'; ";
            objConexao.ExecutarComando(excluir);
        }
        public DataTable ListarProfessor()
        {
    
            string listar = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(listar);
        }
    }
}