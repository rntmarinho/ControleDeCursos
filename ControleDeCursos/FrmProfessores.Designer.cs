
namespace ControleDeCursos
{
    partial class FrmProfessores
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
            this.txt_nomeCompleto = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_horaAula = new System.Windows.Forms.TextBox();
            this.lbl_horaAula = new System.Windows.Forms.Label();
            this.pnl_botoes = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_professores = new System.Windows.Forms.DataGridView();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.lbl_professor = new System.Windows.Forms.Label();
            this.pnl_botoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nomeCompleto
            // 
            this.txt_nomeCompleto.Location = new System.Drawing.Point(116, 41);
            this.txt_nomeCompleto.Name = "txt_nomeCompleto";
            this.txt_nomeCompleto.Size = new System.Drawing.Size(328, 20);
            this.txt_nomeCompleto.TabIndex = 5;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(12, 44);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(85, 13);
            this.lbl_nome.TabIndex = 6;
            this.lbl_nome.Text = "Nome Completo:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Location = new System.Drawing.Point(116, 6);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 4;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(12, 9);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(105, 13);
            this.lbl_codigo.TabIndex = 3;
            this.lbl_codigo.Text = "Código do Professor:";
            // 
            // txt_horaAula
            // 
            this.txt_horaAula.Location = new System.Drawing.Point(116, 79);
            this.txt_horaAula.Name = "txt_horaAula";
            this.txt_horaAula.Size = new System.Drawing.Size(100, 20);
            this.txt_horaAula.TabIndex = 8;
            // 
            // lbl_horaAula
            // 
            this.lbl_horaAula.AutoSize = true;
            this.lbl_horaAula.Location = new System.Drawing.Point(12, 82);
            this.lbl_horaAula.Name = "lbl_horaAula";
            this.lbl_horaAula.Size = new System.Drawing.Size(98, 13);
            this.lbl_horaAula.TabIndex = 7;
            this.lbl_horaAula.Text = "Valor da hora/aula:";
            // 
            // pnl_botoes
            // 
            this.pnl_botoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_botoes.Controls.Add(this.btn_cadastrar);
            this.pnl_botoes.Controls.Add(this.btn_alterar);
            this.pnl_botoes.Controls.Add(this.btn_listar);
            this.pnl_botoes.Controls.Add(this.btn_excluir);
            this.pnl_botoes.Location = new System.Drawing.Point(12, 113);
            this.pnl_botoes.Name = "pnl_botoes";
            this.pnl_botoes.Size = new System.Drawing.Size(432, 57);
            this.pnl_botoes.TabIndex = 22;
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
            // dgv_professores
            // 
            this.dgv_professores.AllowDrop = true;
            this.dgv_professores.BackgroundColor = System.Drawing.Color.White;
            this.dgv_professores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_professores.Location = new System.Drawing.Point(12, 186);
            this.dgv_professores.Name = "dgv_professores";
            this.dgv_professores.Size = new System.Drawing.Size(432, 150);
            this.dgv_professores.TabIndex = 23;
            this.dgv_professores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_professores_CellContentClick);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(345, 79);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 25;
            // 
            // lbl_professor
            // 
            this.lbl_professor.AutoSize = true;
            this.lbl_professor.Location = new System.Drawing.Point(286, 82);
            this.lbl_professor.Name = "lbl_professor";
            this.lbl_professor.Size = new System.Drawing.Size(52, 13);
            this.lbl_professor.TabIndex = 24;
            this.lbl_professor.Text = "Telefone:";
            // 
            // FrmProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 351);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.lbl_professor);
            this.Controls.Add(this.dgv_professores);
            this.Controls.Add(this.pnl_botoes);
            this.Controls.Add(this.txt_horaAula);
            this.Controls.Add(this.lbl_horaAula);
            this.Controls.Add(this.txt_nomeCompleto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.lbl_codigo);
            this.Name = "FrmProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROFESSORES";
            this.pnl_botoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_professores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeCompleto;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_horaAula;
        private System.Windows.Forms.Label lbl_horaAula;
        private System.Windows.Forms.Panel pnl_botoes;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_professores;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label lbl_professor;
    }
}