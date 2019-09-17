namespace ProjetoContas
{
    partial class frmCadastro
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCadLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.btnCadastrarAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(244, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nivel";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(60, 101);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(244, 20);
            this.txtNivel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // txtCadLogin
            // 
            this.txtCadLogin.Location = new System.Drawing.Point(60, 161);
            this.txtCadLogin.Name = "txtCadLogin";
            this.txtCadLogin.Size = new System.Drawing.Size(244, 20);
            this.txtCadLogin.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(63, 221);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(241, 20);
            this.txtSenha.TabIndex = 6;
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.Location = new System.Drawing.Point(60, 271);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastro.TabIndex = 8;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = true;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // btnCadastrarAdmin
            // 
            this.btnCadastrarAdmin.Location = new System.Drawing.Point(229, 271);
            this.btnCadastrarAdmin.Name = "btnCadastrarAdmin";
            this.btnCadastrarAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAdmin.TabIndex = 9;
            this.btnCadastrarAdmin.Text = "Cadastrar";
            this.btnCadastrarAdmin.UseVisualStyleBackColor = true;
            this.btnCadastrarAdmin.Click += new System.EventHandler(this.btnCadastrarAdmin_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 311);
            this.Controls.Add(this.btnCadastrarAdmin);
            this.Controls.Add(this.btnCancelarCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCadLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmCadastro";
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCadLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.Button btnCadastrarAdmin;
    }
}