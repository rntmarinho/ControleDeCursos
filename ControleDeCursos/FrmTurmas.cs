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
    public partial class FrmTurmas : Form
    {
        Turmas objTurmas = new Turmas();
        Professor objProfessor = new Professor();
        Curso objCurso = new Curso();

        public void Exibir()
        {
            cmb_curso.DataSource = objCurso.ListarCursos();
            cmb_curso.DisplayMember = "nomeCurso";
            cmb_curso.ValueMember = "codigo";
            cmb_professor.DataSource = objProfessor.ListarProfessor();
            cmb_professor.DisplayMember = "nome";
            cmb_professor.ValueMember = "codigo";
        }
        public FrmTurmas()
        {
            InitializeComponent();
            Exibir();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            objTurmas.curso = Convert.ToInt32(cmb_curso.SelectedValue);
            objTurmas.dataInicio = dtp_dataInicio.Value.ToString("yyyy-MM-dd");
            objTurmas.dataTermino = dtp_dataTermino.Value.ToString("yyyy-MM-dd");
            objTurmas.horaInicio = txt_horaInicio.Text;
            objTurmas.horaTermino = txt_termino.Text;
            objTurmas.professor = Convert.ToInt32(cmb_professor.SelectedValue);

            objTurmas.CadastrarTurma();
            MessageBox.Show("Cadastro Realizado");

            txt_codigo.Clear();
            txt_horaInicio.Clear();
            txt_termino.Clear();

            objTurmas.ListarTurma();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            dgv_turmas.DataSource = objTurmas.ListarTurma();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            objTurmas.codigoTurma = int.Parse(txt_codigo.Text);
            objTurmas.curso = Convert.ToInt32(cmb_curso.SelectedValue);
            objTurmas.dataInicio = dtp_dataInicio.Value.ToString("yyyy-MM-dd");
            objTurmas.dataTermino = dtp_dataTermino.Value.ToString("yyyy-MM-dd");
            objTurmas.horaInicio = txt_horaInicio.Text;
            objTurmas.horaTermino = txt_termino.Text;
            objTurmas.professor = Convert.ToInt32(cmb_professor.SelectedValue);

            objTurmas.AlterarTurma();
            MessageBox.Show("Cadastro Alterado");

            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            objTurmas.codigoTurma = int.Parse(txt_codigo.Text);
            objTurmas.curso = Convert.ToInt32(cmb_curso.SelectedValue);
            objTurmas.dataInicio = dtp_dataInicio.Value.ToString("yyyy-MM-dd");
            objTurmas.dataTermino = dtp_dataTermino.Value.ToString("yyyy-MM-dd");
            objTurmas.horaInicio = txt_horaInicio.Text;
            objTurmas.horaTermino = txt_termino.Text;
            objTurmas.professor = Convert.ToInt32(cmb_professor.SelectedValue);

            objTurmas.ExcluirTurma();
            MessageBox.Show("Cadastro Excluido");

            objTurmas.ListarTurma();
        }

        private void dgv_turmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dgv_turmas.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_curso.SelectedValue = dgv_turmas.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtp_dataInicio.Text = dgv_turmas.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtp_dataTermino.Text = dgv_turmas.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_horaInicio.Text = dgv_turmas.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_termino.Text = dgv_turmas.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmb_professor.SelectedValue = dgv_turmas.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
