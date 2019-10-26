namespace ProjetoContas
{
    partial class frmClienteFornecedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_usuarioLabel;
            System.Windows.Forms.Label ds_usuarioLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            System.Windows.Forms.Label ds_emailLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteFornecedor));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.cd_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.ds_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.ds_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.sg_tipoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cpfTextBox = new System.Windows.Forms.TextBox();
            this.cd_cnpjTextBox = new System.Windows.Forms.TextBox();
            this.cd_rgTextBox = new System.Windows.Forms.TextBox();
            this.cd_ieTextBox = new System.Windows.Forms.TextBox();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.tb_usuarioTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tb_usuarioTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            ds_usuarioLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            nm_usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_usuarioLabel
            // 
            cd_usuarioLabel.AutoSize = true;
            cd_usuarioLabel.Location = new System.Drawing.Point(66, 93);
            cd_usuarioLabel.Name = "cd_usuarioLabel";
            cd_usuarioLabel.Size = new System.Drawing.Size(39, 13);
            cd_usuarioLabel.TabIndex = 40;
            cd_usuarioLabel.Text = "código";
            // 
            // ds_usuarioLabel
            // 
            ds_usuarioLabel.AutoSize = true;
            ds_usuarioLabel.Location = new System.Drawing.Point(81, 167);
            ds_usuarioLabel.Name = "ds_usuarioLabel";
            ds_usuarioLabel.Size = new System.Drawing.Size(24, 13);
            ds_usuarioLabel.TabIndex = 42;
            ds_usuarioLabel.Text = "tipo";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Location = new System.Drawing.Point(53, 193);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(52, 13);
            ds_enderecoLabel.TabIndex = 44;
            ds_enderecoLabel.Text = "endereço";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Location = new System.Drawing.Point(66, 219);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(39, 13);
            nm_cidadeLabel.TabIndex = 46;
            nm_cidadeLabel.Text = "cidade";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Location = new System.Drawing.Point(72, 245);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(33, 13);
            nm_bairroLabel.TabIndex = 48;
            nm_bairroLabel.Text = "bairro";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Location = new System.Drawing.Point(66, 271);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(39, 13);
            sg_estadoLabel.TabIndex = 50;
            sg_estadoLabel.Text = "estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Location = new System.Drawing.Point(80, 297);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(25, 13);
            cd_cepLabel.TabIndex = 52;
            cd_cepLabel.Text = "cep";
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Location = new System.Drawing.Point(60, 323);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(45, 13);
            ds_telefoneLabel.TabIndex = 54;
            ds_telefoneLabel.Text = "telefone";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Location = new System.Drawing.Point(74, 349);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(31, 13);
            ds_emailLabel.TabIndex = 56;
            ds_emailLabel.Text = "email";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Location = new System.Drawing.Point(83, 377);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(22, 13);
            cd_cpfLabel.TabIndex = 60;
            cd_cpfLabel.Text = "cpf";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Location = new System.Drawing.Point(78, 403);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(27, 13);
            cd_cnpjLabel.TabIndex = 62;
            cd_cnpjLabel.Text = "cnpj";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Location = new System.Drawing.Point(89, 429);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(16, 13);
            cd_rgLabel.TabIndex = 64;
            cd_rgLabel.Text = "rg";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Location = new System.Drawing.Point(90, 455);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(15, 13);
            cd_ieLabel.TabIndex = 66;
            cd_ieLabel.Text = "ie";
            // 
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Location = new System.Drawing.Point(74, 118);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(33, 13);
            nm_usuarioLabel.TabIndex = 67;
            nm_usuarioLabel.Text = "nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(111, 546);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 546);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(261, 546);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(336, 546);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 22;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Info;
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(411, 546);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 23;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(111, 516);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(186, 516);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 15;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(261, 516);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(336, 516);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(411, 516);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelTitle.Location = new System.Drawing.Point(143, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(305, 51);
            this.labelTitle.TabIndex = 40;
            this.labelTitle.Text = "Fornecedores";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelTitle.UseCompatibleTextRendering = true;
            // 
            // cd_usuarioTextBox
            // 
            this.cd_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_usuario", true));
            this.cd_usuarioTextBox.Location = new System.Drawing.Point(111, 90);
            this.cd_usuarioTextBox.MaxLength = 9999;
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_usuarioTextBox.TabIndex = 41;
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataMember = "tb_usuario";
            this.tb_usuarioBindingSource.DataSource = this.contasDataSet;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_usuarioTextBox
            // 
            this.ds_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_usuario", true));
            this.ds_usuarioTextBox.Location = new System.Drawing.Point(111, 164);
            this.ds_usuarioTextBox.MaxLength = 1;
            this.ds_usuarioTextBox.Name = "ds_usuarioTextBox";
            this.ds_usuarioTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_usuarioTextBox.TabIndex = 2;
            this.ds_usuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaFisicoJuridico);
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(111, 190);
            this.ds_enderecoTextBox.MaxLength = 50;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_enderecoTextBox.TabIndex = 3;
            this.ds_enderecoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaEndereco);
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(111, 216);
            this.nm_cidadeTextBox.MaxLength = 50;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(375, 20);
            this.nm_cidadeTextBox.TabIndex = 4;
            this.nm_cidadeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaCidade);
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(111, 242);
            this.nm_bairroTextBox.MaxLength = 50;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(375, 20);
            this.nm_bairroTextBox.TabIndex = 5;
            this.nm_bairroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaCidade);
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(111, 268);
            this.sg_estadoTextBox.MaxLength = 2;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(375, 20);
            this.sg_estadoTextBox.TabIndex = 6;
            this.sg_estadoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaCidade);
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Location = new System.Drawing.Point(111, 294);
            this.cd_cepTextBox.MaxLength = 9;
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_cepTextBox.TabIndex = 7;
            this.cd_cepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApenasNumeros);
            // 
            // ds_telefoneTextBox
            // 
            this.ds_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_telefone", true));
            this.ds_telefoneTextBox.Location = new System.Drawing.Point(111, 320);
            this.ds_telefoneTextBox.MaxLength = 11;
            this.ds_telefoneTextBox.Name = "ds_telefoneTextBox";
            this.ds_telefoneTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_telefoneTextBox.TabIndex = 8;
            this.ds_telefoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApenasNumeros);
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_email", true));
            this.ds_emailTextBox.Location = new System.Drawing.Point(111, 346);
            this.ds_emailTextBox.MaxLength = 20;
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_emailTextBox.TabIndex = 9;
            this.ds_emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaEmail);
            // 
            // sg_tipoTextBox
            // 
            this.sg_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "sg_tipo", true));
            this.sg_tipoTextBox.Location = new System.Drawing.Point(111, 452);
            this.sg_tipoTextBox.MaxLength = 20;
            this.sg_tipoTextBox.Name = "sg_tipoTextBox";
            this.sg_tipoTextBox.Size = new System.Drawing.Size(375, 20);
            this.sg_tipoTextBox.TabIndex = 59;
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_cpf", true));
            this.cd_cpfTextBox.Location = new System.Drawing.Point(111, 374);
            this.cd_cpfTextBox.MaxLength = 11;
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_cpfTextBox.TabIndex = 10;
            this.cd_cpfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApenasNumeros);
            // 
            // cd_cnpjTextBox
            // 
            this.cd_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_cnpj", true));
            this.cd_cnpjTextBox.Location = new System.Drawing.Point(111, 400);
            this.cd_cnpjTextBox.MaxLength = 14;
            this.cd_cnpjTextBox.Name = "cd_cnpjTextBox";
            this.cd_cnpjTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_cnpjTextBox.TabIndex = 11;
            this.cd_cnpjTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApenasNumeros);
            // 
            // cd_rgTextBox
            // 
            this.cd_rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_rg", true));
            this.cd_rgTextBox.Location = new System.Drawing.Point(111, 426);
            this.cd_rgTextBox.MaxLength = 9;
            this.cd_rgTextBox.Name = "cd_rgTextBox";
            this.cd_rgTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_rgTextBox.TabIndex = 12;
            this.cd_rgTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApenasNumeros);
            // 
            // cd_ieTextBox
            // 
            this.cd_ieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_ie", true));
            this.cd_ieTextBox.Location = new System.Drawing.Point(111, 452);
            this.cd_ieTextBox.MaxLength = 15;
            this.cd_ieTextBox.Name = "cd_ieTextBox";
            this.cd_ieTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_ieTextBox.TabIndex = 13;
            this.cd_ieTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApenasNumeros);
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(111, 114);
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(375, 20);
            this.nm_usuarioTextBox.TabIndex = 1;
            this.nm_usuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validaNome);
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_administradorTableAdapter = null;
            this.tableAdapterManager.tb_contaTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = this.tb_usuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(110, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "\"f\" para fisico ou \"j\" para jurídico";
            // 
            // frmClienteFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 600);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(nm_usuarioLabel);
            this.Controls.Add(this.nm_usuarioTextBox);
            this.Controls.Add(cd_usuarioLabel);
            this.Controls.Add(this.cd_usuarioTextBox);
            this.Controls.Add(ds_usuarioLabel);
            this.Controls.Add(this.ds_usuarioTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(this.ds_telefoneTextBox);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(this.ds_emailTextBox);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(this.cd_cpfTextBox);
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(this.cd_cnpjTextBox);
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(this.cd_rgTextBox);
            this.Controls.Add(cd_ieLabel);
            this.Controls.Add(this.cd_ieTextBox);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.sg_tipoTextBox);
            this.Name = "frmClienteFornecedor";
            this.Load += new System.EventHandler(this.frmClienteFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private contasDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox cd_usuarioTextBox;
        private System.Windows.Forms.TextBox ds_usuarioTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox ds_telefoneTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
        private System.Windows.Forms.TextBox sg_tipoTextBox;
        private System.Windows.Forms.TextBox cd_cpfTextBox;
        private System.Windows.Forms.TextBox cd_cnpjTextBox;
        private System.Windows.Forms.TextBox cd_rgTextBox;
        private System.Windows.Forms.TextBox cd_ieTextBox;
        private System.Windows.Forms.TextBox nm_usuarioTextBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
    }
}