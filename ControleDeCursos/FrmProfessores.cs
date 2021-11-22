using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeCursos
{
    public partial class FrmProfessores : Form
    {
        Professor objProfessor = new Professor();

        public FrmProfessores()
        {
            InitializeComponent();
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            objProfessor.nomeCompleto = txt_nomeCompleto.Text;
            objProfessor.telefone = txt_telefone.Text;
            objProfessor.valorHoraAula = double.Parse(txt_horaAula.Text);

            objProfessor.CadastrarProfessor();
            MessageBox.Show("Cadastro Concluído");

            txt_horaAula.Clear();
            txt_nomeCompleto.Clear();
            txt_telefone.Clear();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_professores.DataSource = objProfessor.ListarProfessor();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txt_codigo.Text);
            objProfessor.nomeCompleto = txt_nomeCompleto.Text;
            objProfessor.telefone = txt_telefone.Text;
            objProfessor.valorHoraAula = double.Parse(txt_horaAula.Text);

            objProfessor.ExcluirProfessor();
            MessageBox.Show("Cadastro Excluido");

            objProfessor.ListarProfessor();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            objProfessor.codigoProfessor = int.Parse(txt_codigo.Text);
            objProfessor.nomeCompleto = txt_nomeCompleto.Text;
            objProfessor.telefone = txt_telefone.Text;
            objProfessor.valorHoraAula = double.Parse(txt_horaAula.Text);

            objProfessor.AlterarProfessor();
            MessageBox.Show("Cadastro Alterado");

            objProfessor.ListarProfessor();
        }

        private void dgv_professores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_professores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomeCompleto.Text = dgv_professores.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_horaAula.Text = dgv_professores.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_telefone.Text = dgv_professores.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
