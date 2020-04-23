namespace Portaria01 {
	partial class FormListaControleVisitante {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaControleVisitante));
			this.grdRegistro = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DatSaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PessoaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PessoaCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtHoraRetornoAte = new System.Windows.Forms.MaskedTextBox();
			this.txtRetornoAte = new System.Windows.Forms.MaskedTextBox();
			this.txtHoraRetornoDe = new System.Windows.Forms.MaskedTextBox();
			this.txtRetornoDe = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtHoraSaidaAte = new System.Windows.Forms.MaskedTextBox();
			this.txtDataSaidaAte = new System.Windows.Forms.MaskedTextBox();
			this.txtHoraSaidaDe = new System.Windows.Forms.MaskedTextBox();
			this.txtDataSaidaDe = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.ddlSituacao = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdRegistro)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// grdRegistro
			// 
			this.grdRegistro.AllowUserToAddRows = false;
			this.grdRegistro.AllowUserToDeleteRows = false;
			this.grdRegistro.AllowUserToResizeColumns = false;
			this.grdRegistro.AllowUserToResizeRows = false;
			this.grdRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdRegistro.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.grdRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdPessoa,
            this.Tipo,
            this.DataEntrada,
            this.DatSaida,
            this.Veiculo,
            this.PessoaNome,
            this.CadasterDate,
            this.PessoaCPF});
			this.grdRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grdRegistro.Location = new System.Drawing.Point(17, 268);
			this.grdRegistro.MultiSelect = false;
			this.grdRegistro.Name = "grdRegistro";
			this.grdRegistro.RowHeadersVisible = false;
			this.grdRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdRegistro.ShowCellErrors = false;
			this.grdRegistro.ShowCellToolTips = false;
			this.grdRegistro.ShowEditingIcon = false;
			this.grdRegistro.ShowRowErrors = false;
			this.grdRegistro.Size = new System.Drawing.Size(760, 268);
			this.grdRegistro.TabIndex = 19;
			this.grdRegistro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRegistro_CellDoubleClick);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// IdPessoa
			// 
			this.IdPessoa.DataPropertyName = "IdPessoa";
			this.IdPessoa.HeaderText = "IdPessoa";
			this.IdPessoa.Name = "IdPessoa";
			this.IdPessoa.Visible = false;
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "Tipo";
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.Visible = false;
			// 
			// DataEntrada
			// 
			this.DataEntrada.DataPropertyName = "DataEntrada";
			this.DataEntrada.HeaderText = "Data Entrada";
			this.DataEntrada.Name = "DataEntrada";
			// 
			// DatSaida
			// 
			this.DatSaida.DataPropertyName = "DataSaida";
			this.DatSaida.HeaderText = "Data Saída";
			this.DatSaida.Name = "DatSaida";
			// 
			// Veiculo
			// 
			this.Veiculo.DataPropertyName = "Veiculo";
			this.Veiculo.HeaderText = "Veiculo";
			this.Veiculo.Name = "Veiculo";
			this.Veiculo.Visible = false;
			// 
			// PessoaNome
			// 
			this.PessoaNome.DataPropertyName = "PessoaNome";
			this.PessoaNome.HeaderText = "Visitante";
			this.PessoaNome.Name = "PessoaNome";
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.Visible = false;
			// 
			// PessoaCPF
			// 
			this.PessoaCPF.DataPropertyName = "PessoaCPF";
			this.PessoaCPF.HeaderText = "PessoaCPF";
			this.PessoaCPF.Name = "PessoaCPF";
			this.PessoaCPF.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ddlSituacao);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCPF);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.txtHoraRetornoAte);
			this.groupBox1.Controls.Add(this.txtRetornoAte);
			this.groupBox1.Controls.Add(this.txtHoraRetornoDe);
			this.groupBox1.Controls.Add(this.txtRetornoDe);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtHoraSaidaAte);
			this.groupBox1.Controls.Add(this.txtDataSaidaAte);
			this.groupBox1.Controls.Add(this.txtHoraSaidaDe);
			this.groupBox1.Controls.Add(this.txtDataSaidaDe);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(17, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 178);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(118, 127);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(46, 39);
			this.btnBuscar.TabIndex = 48;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(492, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 18);
			this.label5.TabIndex = 47;
			this.label5.Text = "CPF";
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(529, 24);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(208, 27);
			this.txtCPF.TabIndex = 46;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(545, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(28, 18);
			this.label7.TabIndex = 45;
			this.label7.Text = "até";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(551, 65);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 18);
			this.label8.TabIndex = 44;
			this.label8.Text = "de";
			// 
			// txtHoraRetornoAte
			// 
			this.txtHoraRetornoAte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraRetornoAte.Location = new System.Drawing.Point(669, 94);
			this.txtHoraRetornoAte.Mask = "00:00";
			this.txtHoraRetornoAte.Name = "txtHoraRetornoAte";
			this.txtHoraRetornoAte.Size = new System.Drawing.Size(47, 27);
			this.txtHoraRetornoAte.TabIndex = 43;
			this.txtHoraRetornoAte.ValidatingType = typeof(System.DateTime);
			// 
			// txtRetornoAte
			// 
			this.txtRetornoAte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRetornoAte.Location = new System.Drawing.Point(581, 94);
			this.txtRetornoAte.Mask = "00/00/0000";
			this.txtRetornoAte.Name = "txtRetornoAte";
			this.txtRetornoAte.Size = new System.Drawing.Size(82, 27);
			this.txtRetornoAte.TabIndex = 42;
			this.txtRetornoAte.ValidatingType = typeof(System.DateTime);
			// 
			// txtHoraRetornoDe
			// 
			this.txtHoraRetornoDe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraRetornoDe.Location = new System.Drawing.Point(669, 61);
			this.txtHoraRetornoDe.Mask = "00:00";
			this.txtHoraRetornoDe.Name = "txtHoraRetornoDe";
			this.txtHoraRetornoDe.Size = new System.Drawing.Size(47, 27);
			this.txtHoraRetornoDe.TabIndex = 41;
			this.txtHoraRetornoDe.ValidatingType = typeof(System.DateTime);
			// 
			// txtRetornoDe
			// 
			this.txtRetornoDe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRetornoDe.Location = new System.Drawing.Point(581, 61);
			this.txtRetornoDe.Mask = "00/00/0000";
			this.txtRetornoDe.Name = "txtRetornoDe";
			this.txtRetornoDe.Size = new System.Drawing.Size(82, 27);
			this.txtRetornoDe.TabIndex = 40;
			this.txtRetornoDe.ValidatingType = typeof(System.DateTime);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(82, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(28, 18);
			this.label6.TabIndex = 39;
			this.label6.Text = "até";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(88, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 18);
			this.label3.TabIndex = 38;
			this.label3.Text = "de";
			// 
			// txtHoraSaidaAte
			// 
			this.txtHoraSaidaAte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraSaidaAte.Location = new System.Drawing.Point(206, 94);
			this.txtHoraSaidaAte.Mask = "00:00";
			this.txtHoraSaidaAte.Name = "txtHoraSaidaAte";
			this.txtHoraSaidaAte.Size = new System.Drawing.Size(47, 27);
			this.txtHoraSaidaAte.TabIndex = 37;
			this.txtHoraSaidaAte.ValidatingType = typeof(System.DateTime);
			// 
			// txtDataSaidaAte
			// 
			this.txtDataSaidaAte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataSaidaAte.Location = new System.Drawing.Point(118, 94);
			this.txtDataSaidaAte.Mask = "00/00/0000";
			this.txtDataSaidaAte.Name = "txtDataSaidaAte";
			this.txtDataSaidaAte.Size = new System.Drawing.Size(82, 27);
			this.txtDataSaidaAte.TabIndex = 36;
			this.txtDataSaidaAte.ValidatingType = typeof(System.DateTime);
			// 
			// txtHoraSaidaDe
			// 
			this.txtHoraSaidaDe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraSaidaDe.Location = new System.Drawing.Point(206, 61);
			this.txtHoraSaidaDe.Mask = "00:00";
			this.txtHoraSaidaDe.Name = "txtHoraSaidaDe";
			this.txtHoraSaidaDe.Size = new System.Drawing.Size(47, 27);
			this.txtHoraSaidaDe.TabIndex = 31;
			this.txtHoraSaidaDe.ValidatingType = typeof(System.DateTime);
			// 
			// txtDataSaidaDe
			// 
			this.txtDataSaidaDe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataSaidaDe.Location = new System.Drawing.Point(118, 61);
			this.txtDataSaidaDe.Mask = "00/00/0000";
			this.txtDataSaidaDe.Name = "txtDataSaidaDe";
			this.txtDataSaidaDe.Size = new System.Drawing.Size(82, 27);
			this.txtDataSaidaDe.TabIndex = 30;
			this.txtDataSaidaDe.ValidatingType = typeof(System.DateTime);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(487, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 35;
			this.label2.Text = "Retorno";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 18);
			this.label4.TabIndex = 34;
			this.label4.Text = "Saída";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(80, 24);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(382, 27);
			this.txtNome.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Nome";
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(17, 224);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(46, 39);
			this.btnAdd.TabIndex = 21;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.Location = new System.Drawing.Point(731, 223);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(46, 39);
			this.btnClear.TabIndex = 22;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(145, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(327, 33);
			this.label9.TabIndex = 23;
			this.label9.Text = "Lista Registro E/S Visitantes";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 34);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// ddlSituacao
			// 
			this.ddlSituacao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlSituacao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlSituacao.FormattingEnabled = true;
			this.ddlSituacao.Items.AddRange(new object[] {
            " ",
            "Aberto",
            "Fechado"});
			this.ddlSituacao.Location = new System.Drawing.Point(307, 133);
			this.ddlSituacao.Name = "ddlSituacao";
			this.ddlSituacao.Size = new System.Drawing.Size(155, 27);
			this.ddlSituacao.TabIndex = 49;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(304, 112);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(114, 18);
			this.label10.TabIndex = 50;
			this.label10.Text = "Situação Registro";
			// 
			// FormListaControleVisitante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(789, 558);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.grdRegistro);
			this.Name = "FormListaControleVisitante";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listagem Controle Visitante";
			((System.ComponentModel.ISupportInitialize)(this.grdRegistro)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdRegistro;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.MaskedTextBox txtHoraRetornoAte;
		private System.Windows.Forms.MaskedTextBox txtRetornoAte;
		private System.Windows.Forms.MaskedTextBox txtHoraRetornoDe;
		private System.Windows.Forms.MaskedTextBox txtRetornoDe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtHoraSaidaAte;
		private System.Windows.Forms.MaskedTextBox txtDataSaidaAte;
		private System.Windows.Forms.MaskedTextBox txtHoraSaidaDe;
		private System.Windows.Forms.MaskedTextBox txtDataSaidaDe;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdPessoa;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataEntrada;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatSaida;
		private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn PessoaNome;
		private System.Windows.Forms.DataGridViewTextBoxColumn CadasterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn PessoaCPF;
		private System.Windows.Forms.ComboBox ddlSituacao;
		private System.Windows.Forms.Label label10;
	}
}