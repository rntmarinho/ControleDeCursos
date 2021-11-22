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
    public partial class FrmCursos : Form
    {
        Curso objCurso = new Curso();
        public FrmCursos()
        {
            InitializeComponent();
            txtCodigo.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;

            objCurso.CadastrarCurso();
            MessageBox.Show("Cadastrado Realizado");

            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;

            objCurso.ExcluirCurso();
            MessageBox.Show("Cadastro Excluido");

            txtCodigo.Clear();
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();

            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            objCurso.codigoCurso = int.Parse(txtCodigo.Text);
            objCurso.nomeCurso = txtNomeCurso.Text;
            objCurso.conteudoProgramatico = txtConteudo.Text;
            objCurso.valorMensalidade = double.Parse(txtValorMensalidade.Text);
            objCurso.cargaHoraria = txtCargaHoraria.Text;

            objCurso.AlterarCurso();
            MessageBox.Show("Cadastro Alterado");

            txtCodigo.Clear();
            txtNomeCurso.Clear();
            txtConteudo.Clear();
            txtValorMensalidade.Clear();
            txtCargaHoraria.Clear();

            dtgCursos.DataSource = objCurso.ListarCursos();
        }

        private void dtgCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dtgCursos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeCurso.Text = dtgCursos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtConteudo.Text = dtgCursos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtValorMensalidade.Text = dtgCursos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCargaHoraria.Text = dtgCursos.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
