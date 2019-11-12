namespace ProjetoContas
{
    partial class formLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tb_administradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_administradorTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tb_administradorTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_administradorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(50, 163);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(256, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(50, 123);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(256, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(50, 25);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(256, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(50, 65);
            this.txtPw.MaxLength = 20;
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(256, 20);
            this.txtPw.TabIndex = 3;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_administradorBindingSource
            // 
            this.tb_administradorBindingSource.DataMember = "tb_administrador";
            this.tb_administradorBindingSource.DataSource = this.contasDataSet;
            // 
            // tb_administradorTableAdapter
            // 
            this.tb_administradorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_administradorTableAdapter = this.tb_administradorTableAdapter;
            this.tableAdapterManager.tb_contaTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 242);
            this.ControlBox = false;
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnSair);
            this.Name = "formLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_administradorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPw;
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tb_administradorBindingSource;
        private contasDataSetTableAdapters.tb_administradorTableAdapter tb_administradorTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

