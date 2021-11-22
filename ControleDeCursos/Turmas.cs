using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeCursos
{
    class Turmas
    {
        public int     codigoTurma, professor, curso;
        public string  horaInicio, horaTermino, dataInicio, dataTermino;
        public string  tabela = "tbl_turmas";
                                                 
        Conexao objConexao = new Conexao();

        public void CadastrarTurma()
        {
            string inserir = $@"insert into {tabela} values (null,
                             '{curso}', '{dataInicio}', '{dataTermino}',
                             '{horaInicio}', '{horaTermino}', '{professor}');";

            objConexao.ExecutarComando(inserir);
        }
        public void AlterarTurma()
        {
            string alterar = $@"update {tabela} set idCurso='{curso}',
                                dataInicio ='{dataInicio}', dataTermino='{dataTermino}',
                                horaInicio = '{horaInicio}', horaTermino = '{horaTermino}',
                                idProfessor  = '{professor}' where codigo='{codigoTurma}';";

            objConexao.ExecutarComando(alterar);
        }
        public void ExcluirTurma()
        {
            string excluir = $"delete from {tabela} where codigo='{codigoTurma}'; ";
            objConexao.ExecutarComando(excluir);
        }
        public DataTable ListarTurma()
        {

            string listar = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(listar);
        }

       
    }
}
