using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace ControleDeCursos
{
    class Curso
    {
        public int codigoCurso;
        public string nomeCurso, conteudoProgramatico, cargaHoraria;
        public double valorMensalidade;
        public string tabela = "tbl_cursos";
        Conexao objConexao = new Conexao();

        public void CadastrarCurso()
        {
            //Paso 1: comando sql
            string inserir = $@"Insert into {tabela} values (null, 
                            '{nomeCurso}', '{conteudoProgramatico}', 
                            '{valorMensalidade}', '{cargaHoraria}');";

            //Passo 2: executar o comando
            objConexao.ExecutarComando(inserir);

        }

        
        public void AlterarCurso()
        {
            string alterar = $@"update {tabela} set nomeCurso ='{nomeCurso}',
                                conteudo ='{conteudoProgramatico}', valorMensalidade = '{valorMensalidade}',
                                cargaHoraria='{cargaHoraria}' where codigo='{codigoCurso}';";

            objConexao.ExecutarComando(alterar);

        }

        public void ExcluirCurso()
        {
            string excluir = $"delete from {tabela} where codigo='{codigoCurso}'; ";
            objConexao.ExecutarComando(excluir);
        }

        public DataTable ListarCursos()    
        {
            string listar = $"select * from {tabela} order by codigo;";
            return objConexao.ExecutarConsulta(listar);
        }

    }
    
}
