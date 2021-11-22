
namespace ControleDeCursos
{
    partial class FrmTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigoTurma = new System.Windows.Forms.Label();
            this.lbl_dataTermino = new System.Windows.Forms.Label();
            this.lbl_dataInicio = new System.Windows.Forms.Label();
            this.dtp_dataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataTermino = new System.Windows.Forms.DateTimePicker();
            this.lbl_horaInicio = new System.Windows.Forms.Label();
            this.lbl_horaTermino = new System.Windows.Forms.Label();
            this.pnl_botoes = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.txt_horaInicio = new System.Windows.Forms.TextBox();
            this.txt_termino = new System.Windows.Forms.TextBox();
            this.lbl_curso = new System.Windows.Forms.Label();
            this.cmb_curso = new System.Windows.Forms.ComboBox();
            this.cmb_professor = new System.Windows.Forms.ComboBox();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.pnl_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(116, 6);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 14;
            // 
            // lbl_codigoTurma
            // 
            this.lbl_codigoTurma.AutoSize = true;
            this.lbl_codigoTurma.Location = new System.Drawing.Point(12, 9);
            this.lbl_codigoTurma.Name = "lbl_codigoTurma";
            this.lbl_codigoTurma.Size = new System.Drawing.Size(91, 13);
            this.lbl_codigoTurma.TabIndex = 13;
            this.lbl_codigoTurma.Text = "Código da Turma:";
            // 
            // lbl_dataTermino
            // 
            this.lbl_dataTermino.AutoSize = true;
            this.lbl_dataTermino.Location = new System.Drawing.Point(242, 46);
            this.lbl_dataTermino.Name = "lbl_dataTermino";
            this.lbl_dataTermino.Size = new System.Drawing.Size(89, 13);
            this.lbl_dataTermino.TabIndex = 10;
            this.lbl_dataTermino.Text = "Data de Término:";
            // 
            // lbl_dataInicio
            // 
            this.lbl_dataInicio.AutoSize = true;
            this.lbl_dataInicio.Location = new System.Drawing.Point(12, 46);
            this.lbl_dataInicio.Name = "lbl_dataInicio";
            this.lbl_dataInicio.Size = new System.Drawing.Size(78, 13);
            this.lbl_dataInicio.TabIndex = 12;
            this.lbl_dataInicio.Text = "Data de Início:";
            // 
            // dtp_dataInicio
            // 
            this.dtp_dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataInicio.Location = new System.Drawing.Point(116, 40);
            this.dtp_dataInicio.Name = "dtp_dataInicio";
            this.dtp_dataInicio.Size = new System.Drawing.Size(100, 20);
            this.dtp_dataInicio.TabIndex = 15;
            // 
            // dtp_dataTermino
            // 
            this.dtp_dataTermino.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataTermino.Location = new System.Drawing.Point(347, 40);
            this.dtp_dataTermino.Name = "dtp_dataTermino";
            this.dtp_dataTermino.Size = new System.Drawing.Size(100, 20);
            this.dtp_dataTermino.TabIndex = 16;
            // 
            // lbl_horaInicio
            // 
            this.lbl_horaInicio.AutoSize = true;
            this.lbl_horaInicio.Location = new System.Drawing.Point(12, 81);
            this.lbl_horaInicio.Name = "lbl_horaInicio";
            this.lbl_horaInicio.Size = new System.Drawing.Size(78, 13);
            this.lbl_horaInicio.TabIndex = 18;
            this.lbl_horaInicio.Text = "Hora de Início:";
            // 
            // lbl_horaTermino
            // 
            this.lbl_horaTermino.AutoSize = true;
            this.lbl_horaTermino.Location = new System.Drawing.Point(242, 81);
            this.lbl_horaTermino.Name = "lbl_horaTermino";
            this.lbl_horaTermino.Size = new System.Drawing.Size(89, 13);
            this.lbl_horaTermino.TabIndex = 17;
            this.lbl_horaTermino.Text = "Hora de Término:";
            // 
            // pnl_botoes
            // 
            this.pnl_botoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_botoes.Controls.Add(this.btn_cadastrar);
            this.pnl_botoes.Controls.Add(this.btn_alterar);
            this.pnl_botoes.Controls.Add(this.btn_listar);
            this.pnl_botoes.Controls.Add(this.btn_excluir);
            this.pnl_botoes.Location = new System.Drawing.Point(15, 149);
            this.pnl_botoes.Name = "pnl_botoes";
            this.pnl_botoes.Size = new System.Drawing.Size(432, 57);
            this.pnl_botoes.TabIndex = 21;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(27, 13);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(90, 30);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "CADASTRAR ";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(123, 13);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(90, 30);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.Text = "ALTERAR";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(318, 13);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(90, 30);
            this.btn_listar.TabIndex = 9;
            this.btn_listar.Text = "LISTAR";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(222, 13);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 30);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.Location = new System.Drawing.Point(15, 228);
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.Size = new System.Drawing.Size(432, 150);
            this.dgv_turmas.TabIndex = 22;
            this.dgv_turmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_turmas_CellContentClick);
            // 
            // txt_horaInicio
            // 
            this.txt_horaInicio.Location = new System.Drawing.Point(116, 78);
            this.txt_horaInicio.Name = "txt_horaInicio";
            this.txt_horaInicio.Size = new System.Drawing.Size(100, 20);
            this.txt_horaInicio.TabIndex = 23;
            // 
            // txt_termino
            // 
            this.txt_termino.Location = new System.Drawing.Point(347, 78);
            this.txt_termino.Name = "txt_termino";
            this.txt_termino.Size = new System.Drawing.Size(100, 20);
            this.txt_termino.TabIndex = 24;
            // 
            // lbl_curso
            // 
            this.lbl_curso.AutoSize = true;
            this.lbl_curso.Location = new System.Drawing.Point(291, 9);
            this.lbl_curso.Name = "lbl_curso";
            this.lbl_curso.Size = new System.Drawing.Size(37, 13);
            this.lbl_curso.TabIndex = 25;
            this.lbl_curso.Text = "Curso:";
            // 
            // cmb_curso
            // 
            this.cmb_curso.FormattingEnabled = true;
            this.cmb_curso.Location = new System.Drawing.Point(347, 5);
            this.cmb_curso.Name = "cmb_curso";
            this.cmb_curso.Size = new System.Drawing.Size(100, 21);
            this.cmb_curso.TabIndex = 26;
            // 
            // cmb_professor
            // 
            this.cmb_professor.FormattingEnabled = true;
            this.cmb_professor.Location = new System.Drawing.Point(116, 114);
            this.cmb_professor.Name = "cmb_professor";
            this.cmb_professor.Size = new System.Drawing.Size(100, 21);
            this.cmb_professor.TabIndex = 28;
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(12, 117);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(66, 13);
            this.lbl_professor.TabIndex = 27;
            this.lbl_professor.Text = "Professor(a):";
            // 
            // FrmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 394);
            this.Controls.Add(this.cmb_professor);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.cmb_curso);
            this.Controls.Add(this.lbl_curso);
            this.Controls.Add(this.txt_termino);
            this.Controls.Add(this.txt_horaInicio);
            this.Controls.Add(this.dgv_turmas);
            this.Controls.Add(this.pnl_botoes);
            this.Controls.Add(this.lbl_horaInicio);
            this.Controls.Add(this.lbl_horaTermino);
            this.Controls.Add(this.dtp_dataTermino);
            this.Controls.Add(this.dtp_dataInicio);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigoTurma);
            this.Controls.Add(this.lbl_dataInicio);
            this.Controls.Add(this.lbl_dataTermino);
            this.Name = "FrmTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TURMAS";
            this.pnl_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigoTurma;
        private System.Windows.Forms.Label lbl_dataTermino;
        private System.Windows.Forms.Label lbl_dataInicio;
        private System.Windows.Forms.DateTimePicker dtp_dataInicio;
        private System.Windows.Forms.DateTimePicker dtp_dataTermino;
        private System.Windows.Forms.Label lbl_horaInicio;
        private System.Windows.Forms.Label lbl_horaTermino;
        private System.Windows.Forms.Panel pnl_botoes;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.TextBox txt_horaInicio;
        private System.Windows.Forms.TextBox txt_termino;
        private System.Windows.Forms.Label lbl_curso;
        private System.Windows.Forms.ComboBox cmb_curso;
        private System.Windows.Forms.ComboBox cmb_professor;
        private System.Windows.Forms.Label lbl_professor;
    }
}