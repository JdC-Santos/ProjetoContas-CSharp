namespace ProjetoContas
{
    partial class frmContasPagar
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
            System.Windows.Forms.Label cd_contaLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label vl_compraLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label ds_obsLabel;
            System.Windows.Forms.Label id_usuarioLabel;
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
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.tb_contaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_compraTextBox = new System.Windows.Forms.TextBox();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.ds_obsTextBox = new System.Windows.Forms.TextBox();
            this.ds_tipoTextBox = new System.Windows.Forms.TextBox();
            this.id_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.tb_contaTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tb_contaTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            cd_contaLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            vl_compraLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            ds_obsLabel = new System.Windows.Forms.Label();
            id_usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Location = new System.Drawing.Point(28, 84);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(87, 13);
            cd_contaLabel.TabIndex = 30;
            cd_contaLabel.Text = "código da conta:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Location = new System.Drawing.Point(28, 111);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(87, 13);
            dt_emissaoLabel.TabIndex = 32;
            dt_emissaoLabel.Text = "data de emissao:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Location = new System.Drawing.Point(11, 137);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(104, 13);
            dt_vencimentoLabel.TabIndex = 34;
            dt_vencimentoLabel.Text = "data de vencimento:";
            // 
            // vl_compraLabel
            // 
            vl_compraLabel.AutoSize = true;
            vl_compraLabel.Location = new System.Drawing.Point(29, 162);
            vl_compraLabel.Name = "vl_compraLabel";
            vl_compraLabel.Size = new System.Drawing.Size(86, 13);
            vl_compraLabel.TabIndex = 36;
            vl_compraLabel.Text = "valor de compra:";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Location = new System.Drawing.Point(13, 189);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(102, 13);
            dt_pagamentoLabel.TabIndex = 38;
            dt_pagamentoLabel.Text = "data de pagamento:";
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Location = new System.Drawing.Point(55, 214);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(60, 13);
            vl_pagoLabel.TabIndex = 40;
            vl_pagoLabel.Text = "valor pago:";
            // 
            // ds_obsLabel
            // 
            ds_obsLabel.AutoSize = true;
            ds_obsLabel.Location = new System.Drawing.Point(88, 240);
            ds_obsLabel.Name = "ds_obsLabel";
            ds_obsLabel.Size = new System.Drawing.Size(27, 13);
            ds_obsLabel.TabIndex = 42;
            ds_obsLabel.Text = "obs:";
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Location = new System.Drawing.Point(71, 268);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(44, 13);
            id_usuarioLabel.TabIndex = 46;
            id_usuarioLabel.Text = "usuario:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(117, 390);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(192, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(267, 390);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 27;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(344, 390);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Info;
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(419, 390);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 25;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(117, 360);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnAnterior.TabIndex = 24;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(192, 360);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 23;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(267, 360);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 22;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(344, 360);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(419, 360);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contaBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Location = new System.Drawing.Point(117, 81);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(377, 20);
            this.cd_contaTextBox.TabIndex = 31;
            // 
            // tb_contaBindingSource
            // 
            this.tb_contaBindingSource.DataMember = "tb_conta";
            this.tb_contaBindingSource.DataSource = this.contasDataSet;
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contaBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(117, 107);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(377, 20);
            this.dt_emissaoDateTimePicker.TabIndex = 33;
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contaBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(117, 133);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(377, 20);
            this.dt_vencimentoDateTimePicker.TabIndex = 35;
            // 
            // vl_compraTextBox
            // 
            this.vl_compraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contaBindingSource, "vl_compra", true));
            this.vl_compraTextBox.Location = new System.Drawing.Point(117, 159);
            this.vl_compraTextBox.MaxLength = 10;
            this.vl_compraTextBox.Name = "vl_compraTextBox";
            this.vl_compraTextBox.Size = new System.Drawing.Size(377, 20);
            this.vl_compraTextBox.TabIndex = 37;
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contaBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(117, 185);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(377, 20);
            this.dt_pagamentoDateTimePicker.TabIndex = 39;
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contaBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Location = new System.Drawing.Point(117, 211);
            this.vl_pagoTextBox.MaxLength = 10;
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(377, 20);
            this.vl_pagoTextBox.TabIndex = 41;
            // 
            // ds_obsTextBox
            // 
            this.ds_obsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contaBindingSource, "ds_obs", true));
            this.ds_obsTextBox.Location = new System.Drawing.Point(117, 237);
            this.ds_obsTextBox.MaxLength = 25;
            this.ds_obsTextBox.Name = "ds_obsTextBox";
            this.ds_obsTextBox.Size = new System.Drawing.Size(377, 20);
            this.ds_obsTextBox.TabIndex = 43;
            // 
            // ds_tipoTextBox
            // 
            this.ds_tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contaBindingSource, "ds_tipo", true));
            this.ds_tipoTextBox.Location = new System.Drawing.Point(117, 293);
            this.ds_tipoTextBox.Name = "ds_tipoTextBox";
            this.ds_tipoTextBox.Size = new System.Drawing.Size(377, 20);
            this.ds_tipoTextBox.TabIndex = 45;
            // 
            // id_usuarioTextBox
            // 
            this.id_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contaBindingSource, "id_usuario", true));
            this.id_usuarioTextBox.Location = new System.Drawing.Point(117, 265);
            this.id_usuarioTextBox.MaxLength = 5;
            this.id_usuarioTextBox.Name = "id_usuarioTextBox";
            this.id_usuarioTextBox.Size = new System.Drawing.Size(377, 20);
            this.id_usuarioTextBox.TabIndex = 47;
            // 
            // tb_contaTableAdapter
            // 
            this.tb_contaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_administradorTableAdapter = null;
            this.tableAdapterManager.tb_contaTableAdapter = this.tb_contaTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.ControlBox = false;
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(vl_compraLabel);
            this.Controls.Add(this.vl_compraTextBox);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(ds_obsLabel);
            this.Controls.Add(this.ds_obsTextBox);
            this.Controls.Add(this.ds_tipoTextBox);
            this.Controls.Add(id_usuarioLabel);
            this.Controls.Add(this.id_usuarioTextBox);
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
            this.Name = "frmContasPagar";
            this.Text = "Contas a pagar";
            this.Load += new System.EventHandler(this.frmContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_contaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tb_contaBindingSource;
        private contasDataSetTableAdapters.tb_contaTableAdapter tb_contaTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_compraTextBox;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox ds_obsTextBox;
        private System.Windows.Forms.TextBox ds_tipoTextBox;
        private System.Windows.Forms.TextBox id_usuarioTextBox;
    }
}