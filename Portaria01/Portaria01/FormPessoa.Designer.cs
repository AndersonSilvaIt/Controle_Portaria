namespace Portaria01 {
	partial class FormPessoa {
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtFoneComercial = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.imgPessoa = new System.Windows.Forms.PictureBox();
			this.btnImagem = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ddlUF = new System.Windows.Forms.ComboBox();
			this.txtCEP = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.radioButtonVisitante = new System.Windows.Forms.RadioButton();
			this.radioButtonFuncionario = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgPessoa)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(16, 53);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(382, 27);
			this.txtNome.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 18);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtCelular);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtFoneComercial);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtCPF);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(23, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(633, 219);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dados Básicos";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(16, 173);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(477, 27);
			this.txtEmail.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 18);
			this.label5.TabIndex = 9;
			this.label5.Text = "E-mail";
			// 
			// txtCelular
			// 
			this.txtCelular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCelular.Location = new System.Drawing.Point(295, 114);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(198, 27);
			this.txtCelular.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(292, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Celular";
			// 
			// txtFoneComercial
			// 
			this.txtFoneComercial.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFoneComercial.Location = new System.Drawing.Point(16, 114);
			this.txtFoneComercial.Name = "txtFoneComercial";
			this.txtFoneComercial.Size = new System.Drawing.Size(198, 27);
			this.txtFoneComercial.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 18);
			this.label3.TabIndex = 5;
			this.label3.Text = "Fone Comercial";
			// 
			// txtCPF
			// 
			this.txtCPF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCPF.Location = new System.Drawing.Point(413, 53);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(199, 27);
			this.txtCPF.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(410, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "CPF";
			// 
			// imgPessoa
			// 
			this.imgPessoa.Location = new System.Drawing.Point(668, 20);
			this.imgPessoa.Name = "imgPessoa";
			this.imgPessoa.Size = new System.Drawing.Size(143, 164);
			this.imgPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgPessoa.TabIndex = 3;
			this.imgPessoa.TabStop = false;
			// 
			// btnImagem
			// 
			this.btnImagem.Location = new System.Drawing.Point(703, 195);
			this.btnImagem.Name = "btnImagem";
			this.btnImagem.Size = new System.Drawing.Size(75, 23);
			this.btnImagem.TabIndex = 4;
			this.btnImagem.Text = "Trocar";
			this.btnImagem.UseVisualStyleBackColor = true;
			this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ddlUF);
			this.groupBox2.Controls.Add(this.txtCEP);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtCidade);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.txtBairro);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtNumero);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.txtRua);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(23, 246);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(633, 226);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Endereço";
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
			this.ddlUF.Location = new System.Drawing.Point(568, 118);
			this.ddlUF.Name = "ddlUF";
			this.ddlUF.Size = new System.Drawing.Size(48, 27);
			this.ddlUF.TabIndex = 20;
			// 
			// txtCEP
			// 
			this.txtCEP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCEP.Location = new System.Drawing.Point(20, 177);
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(153, 27);
			this.txtCEP.TabIndex = 18;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(17, 156);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 18);
			this.label11.TabIndex = 19;
			this.label11.Text = "CEP";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(565, 97);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(24, 18);
			this.label10.TabIndex = 17;
			this.label10.Text = "UF";
			// 
			// txtCidade
			// 
			this.txtCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCidade.Location = new System.Drawing.Point(295, 118);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(198, 27);
			this.txtCidade.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(296, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 18);
			this.label6.TabIndex = 15;
			this.label6.Text = "Cidade";
			// 
			// txtBairro
			// 
			this.txtBairro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBairro.Location = new System.Drawing.Point(20, 118);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(243, 27);
			this.txtBairro.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 18);
			this.label7.TabIndex = 13;
			this.label7.Text = "Bairro";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.Location = new System.Drawing.Point(568, 57);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(48, 27);
			this.txtNumero.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(565, 36);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(24, 18);
			this.label8.TabIndex = 11;
			this.label8.Text = "Nª";
			// 
			// txtRua
			// 
			this.txtRua.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRua.Location = new System.Drawing.Point(20, 57);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(473, 27);
			this.txtRua.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(17, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 18);
			this.label9.TabIndex = 9;
			this.label9.Text = "Rua";
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(38, 484);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(72, 61);
			this.btnSalvar.TabIndex = 6;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(116, 484);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(72, 61);
			this.btnEditar.TabIndex = 7;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(194, 484);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(72, 61);
			this.btnExcluir.TabIndex = 8;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(676, 258);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(28, 13);
			this.label12.TabIndex = 9;
			this.label12.Text = "Tipo";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// radioButtonVisitante
			// 
			this.radioButtonVisitante.AutoSize = true;
			this.radioButtonVisitante.Checked = true;
			this.radioButtonVisitante.Location = new System.Drawing.Point(710, 258);
			this.radioButtonVisitante.Name = "radioButtonVisitante";
			this.radioButtonVisitante.Size = new System.Drawing.Size(65, 17);
			this.radioButtonVisitante.TabIndex = 11;
			this.radioButtonVisitante.TabStop = true;
			this.radioButtonVisitante.Text = "Visitante";
			this.radioButtonVisitante.UseVisualStyleBackColor = true;
			// 
			// radioButtonFuncionario
			// 
			this.radioButtonFuncionario.AutoSize = true;
			this.radioButtonFuncionario.Location = new System.Drawing.Point(710, 283);
			this.radioButtonFuncionario.Name = "radioButtonFuncionario";
			this.radioButtonFuncionario.Size = new System.Drawing.Size(80, 17);
			this.radioButtonFuncionario.TabIndex = 12;
			this.radioButtonFuncionario.Text = "Funcionário";
			this.radioButtonFuncionario.UseVisualStyleBackColor = true;
			// 
			// FormPessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(835, 558);
			this.Controls.Add(this.radioButtonFuncionario);
			this.Controls.Add(this.radioButtonVisitante);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnImagem);
			this.Controls.Add(this.imgPessoa);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormPessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pessoa";
			this.Load += new System.EventHandler(this.FormPessoa_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgPessoa)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtFoneComercial;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox imgPessoa;
		private System.Windows.Forms.Button btnImagem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtCEP;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.RadioButton radioButtonVisitante;
		private System.Windows.Forms.RadioButton radioButtonFuncionario;
		private System.Windows.Forms.ComboBox ddlUF;
	}
}