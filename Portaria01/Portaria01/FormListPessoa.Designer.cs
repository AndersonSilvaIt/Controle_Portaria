namespace Portaria01 {
	partial class FormListPessoa {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListPessoa));
			this.grdPessoa = new System.Windows.Forms.DataGridView();
			this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Imagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CadasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoneComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FoneCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.ddlUF = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.radioButtonTodos = new System.Windows.Forms.RadioButton();
			this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
			this.radioButtonVisitante = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCEP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdPessoa)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// grdPessoa
			// 
			this.grdPessoa.AllowUserToAddRows = false;
			this.grdPessoa.AllowUserToDeleteRows = false;
			this.grdPessoa.AllowUserToResizeColumns = false;
			this.grdPessoa.AllowUserToResizeRows = false;
			this.grdPessoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdPessoa.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.grdPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdPessoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Imagem,
            this.Id,
            this.CadasterDate,
            this.CPF,
            this.FoneComercial,
            this.FoneCelular,
            this.Email,
            this.Rua,
            this.Numero,
            this.Bairro,
            this.Cidade,
            this.CEP,
            this.UF,
            this.Tipo});
			this.grdPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grdPessoa.Location = new System.Drawing.Point(12, 250);
			this.grdPessoa.MultiSelect = false;
			this.grdPessoa.Name = "grdPessoa";
			this.grdPessoa.RowHeadersVisible = false;
			this.grdPessoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grdPessoa.ShowCellErrors = false;
			this.grdPessoa.ShowCellToolTips = false;
			this.grdPessoa.ShowEditingIcon = false;
			this.grdPessoa.ShowRowErrors = false;
			this.grdPessoa.Size = new System.Drawing.Size(760, 324);
			this.grdPessoa.TabIndex = 20;
			this.grdPessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPessoa_CellDoubleClick);
			// 
			// Nome
			// 
			this.Nome.DataPropertyName = "Nome";
			this.Nome.HeaderText = "Nome";
			this.Nome.Name = "Nome";
			// 
			// Imagem
			// 
			this.Imagem.DataPropertyName = "Imagem";
			this.Imagem.HeaderText = "Imagem";
			this.Imagem.Name = "Imagem";
			this.Imagem.Visible = false;
			// 
			// Id
			// 
			this.Id.DataPropertyName = "Id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// CadasterDate
			// 
			this.CadasterDate.DataPropertyName = "CadasterDate";
			this.CadasterDate.HeaderText = "CadasterDate";
			this.CadasterDate.Name = "CadasterDate";
			this.CadasterDate.Visible = false;
			// 
			// CPF
			// 
			this.CPF.DataPropertyName = "CPF";
			this.CPF.HeaderText = "CPF";
			this.CPF.Name = "CPF";
			this.CPF.Visible = false;
			// 
			// FoneComercial
			// 
			this.FoneComercial.DataPropertyName = "FoneComercial";
			this.FoneComercial.HeaderText = "FoneComercial";
			this.FoneComercial.Name = "FoneComercial";
			// 
			// FoneCelular
			// 
			this.FoneCelular.DataPropertyName = "FoneCelular";
			this.FoneCelular.HeaderText = "FoneCelular";
			this.FoneCelular.Name = "FoneCelular";
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.Name = "Email";
			this.Email.Visible = false;
			// 
			// Rua
			// 
			this.Rua.DataPropertyName = "Rua";
			this.Rua.HeaderText = "Rua";
			this.Rua.Name = "Rua";
			this.Rua.Visible = false;
			// 
			// Numero
			// 
			this.Numero.DataPropertyName = "Numero";
			this.Numero.HeaderText = "Numero";
			this.Numero.Name = "Numero";
			this.Numero.Visible = false;
			// 
			// Bairro
			// 
			this.Bairro.DataPropertyName = "Bairro";
			this.Bairro.HeaderText = "Bairro";
			this.Bairro.Name = "Bairro";
			this.Bairro.Visible = false;
			// 
			// Cidade
			// 
			this.Cidade.DataPropertyName = "Cidade";
			this.Cidade.HeaderText = "Cidade";
			this.Cidade.Name = "Cidade";
			// 
			// CEP
			// 
			this.CEP.DataPropertyName = "CEP";
			this.CEP.HeaderText = "CEP";
			this.CEP.Name = "CEP";
			this.CEP.Visible = false;
			// 
			// UF
			// 
			this.UF.DataPropertyName = "UF";
			this.UF.HeaderText = "UF";
			this.UF.Name = "UF";
			// 
			// Tipo
			// 
			this.Tipo.DataPropertyName = "Tipo";
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBuscar);
			this.groupBox1.Controls.Add(this.ddlUF);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.radioButtonTodos);
			this.groupBox1.Controls.Add(this.radioButtonFuncionario);
			this.groupBox1.Controls.Add(this.radioButtonVisitante);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.txtCPF);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCEP);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtCidade);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 44);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(760, 155);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Filtro";
			// 
			// btnBuscar
			// 
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.Location = new System.Drawing.Point(80, 109);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(46, 39);
			this.btnBuscar.TabIndex = 42;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// ddlUF
			// 
			this.ddlUF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlUF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlUF.FormattingEnabled = true;
			this.ddlUF.Items.AddRange(new object[] {
            " ",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
			this.ddlUF.Location = new System.Drawing.Point(524, 72);
			this.ddlUF.Name = "ddlUF";
			this.ddlUF.Size = new System.Drawing.Size(48, 27);
			this.ddlUF.TabIndex = 41;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(495, 76);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 18);
			this.label10.TabIndex = 40;
			this.label10.Text = "UF";
			// 
			// radioButtonTodos
			// 
			this.radioButtonTodos.AutoSize = true;
			this.radioButtonTodos.Checked = true;
			this.radioButtonTodos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radioButtonTodos.Location = new System.Drawing.Point(655, 75);
			this.radioButtonTodos.Name = "radioButtonTodos";
			this.radioButtonTodos.Size = new System.Drawing.Size(55, 17);
			this.radioButtonTodos.TabIndex = 39;
			this.radioButtonTodos.TabStop = true;
			this.radioButtonTodos.Text = "Todos";
			this.radioButtonTodos.UseVisualStyleBackColor = true;
			// 
			// radioButtonFuncionario
			// 
			this.radioButtonFuncionario.AutoSize = true;
			this.radioButtonFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radioButtonFuncionario.Location = new System.Drawing.Point(655, 121);
			this.radioButtonFuncionario.Name = "radioButtonFuncionario";
			this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
			this.radioButtonFuncionario.TabIndex = 38;
			this.radioButtonFuncionario.Text = "Funcionário";
			this.radioButtonFuncionario.UseVisualStyleBackColor = true;
			// 
			// radioButtonVisitante
			// 
			this.radioButtonVisitante.AutoSize = true;
			this.radioButtonVisitante.Cursor = System.Windows.Forms.Cursors.Hand;
			this.radioButtonVisitante.Location = new System.Drawing.Point(655, 98);
			this.radioButtonVisitante.Name = "radioButtonVisitante";
			this.radioButtonVisitante.Size = new System.Drawing.Size(65, 17);
			this.radioButtonVisitante.TabIndex = 37;
			this.radioButtonVisitante.Text = "Visitante";
			this.radioButtonVisitante.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(618, 79);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 13);
			this.label12.TabIndex = 36;
			this.label12.Text = "Tipo:";
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(524, 24);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(216, 27);
			this.txtCPF.TabIndex = 34;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(488, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 18);
			this.label5.TabIndex = 35;
			this.label5.Text = "CPF";
			// 
			// txtCEP
			// 
			this.txtCEP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCEP.Location = new System.Drawing.Point(359, 72);
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(103, 27);
			this.txtCEP.TabIndex = 30;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(322, 76);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 18);
			this.label6.TabIndex = 31;
			this.label6.Text = "CEP";
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
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(80, 72);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(236, 27);
			this.txtCidade.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 18);
			this.label3.TabIndex = 13;
			this.label3.Text = "Cidade";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(230, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(300, 33);
			this.label9.TabIndex = 22;
			this.label9.Text = "Lista Cadastro de Pessoas";
			// 
			// btnClear
			// 
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.Location = new System.Drawing.Point(726, 205);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(46, 39);
			this.btnClear.TabIndex = 23;
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(12, 205);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(46, 39);
			this.btnAdd.TabIndex = 24;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// FormListPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(785, 586);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.grdPessoa);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormListPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Listagem de Cadastro de Pessoas";
			((System.ComponentModel.ISupportInitialize)(this.grdPessoa)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView grdPessoa;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCEP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.RadioButton radioButtonTodos;
		private System.Windows.Forms.RadioButton radioButtonFuncionario;
		private System.Windows.Forms.RadioButton radioButtonVisitante;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn Imagem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn CadasterDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
		private System.Windows.Forms.DataGridViewTextBoxColumn FoneComercial;
		private System.Windows.Forms.DataGridViewTextBoxColumn FoneCelular;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
		private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
		private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
		private System.Windows.Forms.DataGridViewTextBoxColumn UF;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.ComboBox ddlUF;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnAdd;
	}
}