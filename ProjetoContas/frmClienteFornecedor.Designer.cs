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
            System.Windows.Forms.Label sg_tipoLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.Windows.Forms.Label nm_usuarioLabel;
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
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tb_usuarioTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tb_usuarioTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.nm_usuarioTextBox = new System.Windows.Forms.TextBox();
            cd_usuarioLabel = new System.Windows.Forms.Label();
            ds_usuarioLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            sg_tipoLabel = new System.Windows.Forms.Label();
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
            ds_usuarioLabel.Location = new System.Drawing.Point(81, 143);
            ds_usuarioLabel.Name = "ds_usuarioLabel";
            ds_usuarioLabel.Size = new System.Drawing.Size(24, 13);
            ds_usuarioLabel.TabIndex = 42;
            ds_usuarioLabel.Text = "tipo";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Location = new System.Drawing.Point(53, 169);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(52, 13);
            ds_enderecoLabel.TabIndex = 44;
            ds_enderecoLabel.Text = "endereço";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Location = new System.Drawing.Point(66, 195);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(39, 13);
            nm_cidadeLabel.TabIndex = 46;
            nm_cidadeLabel.Text = "cidade";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Location = new System.Drawing.Point(72, 221);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(33, 13);
            nm_bairroLabel.TabIndex = 48;
            nm_bairroLabel.Text = "bairro";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Location = new System.Drawing.Point(66, 247);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(39, 13);
            sg_estadoLabel.TabIndex = 50;
            sg_estadoLabel.Text = "estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Location = new System.Drawing.Point(80, 273);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(25, 13);
            cd_cepLabel.TabIndex = 52;
            cd_cepLabel.Text = "cep";
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Location = new System.Drawing.Point(60, 299);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(45, 13);
            ds_telefoneLabel.TabIndex = 54;
            ds_telefoneLabel.Text = "telefone";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Location = new System.Drawing.Point(74, 325);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(31, 13);
            ds_emailLabel.TabIndex = 56;
            ds_emailLabel.Text = "email";
            // 
            // sg_tipoLabel
            // 
            sg_tipoLabel.AutoSize = true;
            sg_tipoLabel.Location = new System.Drawing.Point(81, 351);
            sg_tipoLabel.Name = "sg_tipoLabel";
            sg_tipoLabel.Size = new System.Drawing.Size(24, 13);
            sg_tipoLabel.TabIndex = 58;
            sg_tipoLabel.Text = "tipo";
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
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(111, 518);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 518);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(261, 518);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(336, 518);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 35;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Info;
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(411, 518);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 34;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(111, 488);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 33;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(186, 488);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 32;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(261, 488);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 31;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(336, 488);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 30;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(411, 488);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 29;
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
            this.cd_usuarioTextBox.MaxLength = 10000;
            this.cd_usuarioTextBox.Name = "cd_usuarioTextBox";
            this.cd_usuarioTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_usuarioTextBox.TabIndex = 41;
            // 
            // ds_usuarioTextBox
            // 
            this.ds_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_usuario", true));
            this.ds_usuarioTextBox.Location = new System.Drawing.Point(111, 140);
            this.ds_usuarioTextBox.MaxLength = 1;
            this.ds_usuarioTextBox.Name = "ds_usuarioTextBox";
            this.ds_usuarioTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_usuarioTextBox.TabIndex = 43;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(111, 166);
            this.ds_enderecoTextBox.MaxLength = 50;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_enderecoTextBox.TabIndex = 45;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(111, 192);
            this.nm_cidadeTextBox.MaxLength = 50;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(375, 20);
            this.nm_cidadeTextBox.TabIndex = 47;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(111, 218);
            this.nm_bairroTextBox.MaxLength = 50;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(375, 20);
            this.nm_bairroTextBox.TabIndex = 49;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(111, 244);
            this.sg_estadoTextBox.MaxLength = 2;
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(375, 20);
            this.sg_estadoTextBox.TabIndex = 51;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Location = new System.Drawing.Point(111, 270);
            this.cd_cepTextBox.MaxLength = 11;
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_cepTextBox.TabIndex = 53;
            // 
            // ds_telefoneTextBox
            // 
            this.ds_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_telefone", true));
            this.ds_telefoneTextBox.Location = new System.Drawing.Point(111, 296);
            this.ds_telefoneTextBox.MaxLength = 15;
            this.ds_telefoneTextBox.Name = "ds_telefoneTextBox";
            this.ds_telefoneTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_telefoneTextBox.TabIndex = 55;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "ds_email", true));
            this.ds_emailTextBox.Location = new System.Drawing.Point(111, 322);
            this.ds_emailTextBox.MaxLength = 20;
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(375, 20);
            this.ds_emailTextBox.TabIndex = 57;
            // 
            // sg_tipoTextBox
            // 
            this.sg_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "sg_tipo", true));
            this.sg_tipoTextBox.Location = new System.Drawing.Point(111, 348);
            this.sg_tipoTextBox.MaxLength = 20;
            this.sg_tipoTextBox.Name = "sg_tipoTextBox";
            this.sg_tipoTextBox.Size = new System.Drawing.Size(375, 20);
            this.sg_tipoTextBox.TabIndex = 59;
            // 
            // cd_cpfTextBox
            // 
            this.cd_cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_cpf", true));
            this.cd_cpfTextBox.Location = new System.Drawing.Point(111, 374);
            this.cd_cpfTextBox.MaxLength = 12;
            this.cd_cpfTextBox.Name = "cd_cpfTextBox";
            this.cd_cpfTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_cpfTextBox.TabIndex = 61;
            // 
            // cd_cnpjTextBox
            // 
            this.cd_cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_cnpj", true));
            this.cd_cnpjTextBox.Location = new System.Drawing.Point(111, 400);
            this.cd_cnpjTextBox.MaxLength = 15;
            this.cd_cnpjTextBox.Name = "cd_cnpjTextBox";
            this.cd_cnpjTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_cnpjTextBox.TabIndex = 63;
            // 
            // cd_rgTextBox
            // 
            this.cd_rgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_rg", true));
            this.cd_rgTextBox.Location = new System.Drawing.Point(111, 426);
            this.cd_rgTextBox.MaxLength = 15;
            this.cd_rgTextBox.Name = "cd_rgTextBox";
            this.cd_rgTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_rgTextBox.TabIndex = 65;
            // 
            // cd_ieTextBox
            // 
            this.cd_ieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "cd_ie", true));
            this.cd_ieTextBox.Location = new System.Drawing.Point(111, 452);
            this.cd_ieTextBox.MaxLength = 20;
            this.cd_ieTextBox.Name = "cd_ieTextBox";
            this.cd_ieTextBox.Size = new System.Drawing.Size(375, 20);
            this.cd_ieTextBox.TabIndex = 67;
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
            // nm_usuarioLabel
            // 
            nm_usuarioLabel.AutoSize = true;
            nm_usuarioLabel.Location = new System.Drawing.Point(74, 118);
            nm_usuarioLabel.Name = "nm_usuarioLabel";
            nm_usuarioLabel.Size = new System.Drawing.Size(33, 13);
            nm_usuarioLabel.TabIndex = 67;
            nm_usuarioLabel.Text = "nome";
            // 
            // nm_usuarioTextBox
            // 
            this.nm_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_usuarioBindingSource, "nm_usuario", true));
            this.nm_usuarioTextBox.Location = new System.Drawing.Point(111, 114);
            this.nm_usuarioTextBox.Name = "nm_usuarioTextBox";
            this.nm_usuarioTextBox.Size = new System.Drawing.Size(375, 20);
            this.nm_usuarioTextBox.TabIndex = 68;
            // 
            // frmClienteFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 600);
            this.ControlBox = false;
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
            this.Controls.Add(sg_tipoLabel);
            this.Controls.Add(this.sg_tipoTextBox);
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
    }
}