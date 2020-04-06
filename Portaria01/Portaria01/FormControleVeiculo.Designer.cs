namespace Portaria01 {
	partial class FormControleVeiculo {
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
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.ddlVeiculo = new System.Windows.Forms.ComboBox();
			this.ddlFuncionario = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
			this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
			this.txtDataRetorno = new System.Windows.Forms.MaskedTextBox();
			this.txtHoraRetorno = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(199, 278);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 67);
			this.btnExcluir.TabIndex = 9;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(115, 278);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(75, 67);
			this.btnEditar.TabIndex = 8;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Location = new System.Drawing.Point(426, 81);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(22, 23);
			this.btnAdd.TabIndex = 22;
			this.btnAdd.Text = "+";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(34, 278);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(75, 67);
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(31, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 18);
			this.label4.TabIndex = 20;
			this.label4.Text = "Saída";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(35, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 18);
			this.label3.TabIndex = 16;
			this.label3.Text = "Funcionário";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(176, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "LOGO";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 18);
			this.label5.TabIndex = 26;
			this.label5.Text = "Veículo";
			// 
			// ddlVeiculo
			// 
			this.ddlVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlVeiculo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlVeiculo.FormattingEnabled = true;
			this.ddlVeiculo.Items.AddRange(new object[] {
            " ",
            "Carro",
            "Moto"});
			this.ddlVeiculo.Location = new System.Drawing.Point(38, 147);
			this.ddlVeiculo.Name = "ddlVeiculo";
			this.ddlVeiculo.Size = new System.Drawing.Size(155, 27);
			this.ddlVeiculo.TabIndex = 2;
			// 
			// ddlFuncionario
			// 
			this.ddlFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlFuncionario.FormattingEnabled = true;
			this.ddlFuncionario.Location = new System.Drawing.Point(38, 81);
			this.ddlFuncionario.MaxLength = 1;
			this.ddlFuncionario.Name = "ddlFuncionario";
			this.ddlFuncionario.Size = new System.Drawing.Size(382, 27);
			this.ddlFuncionario.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(262, 200);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 18);
			this.label2.TabIndex = 29;
			this.label2.Text = "Retorno";
			// 
			// txtDataSaida
			// 
			this.txtDataSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataSaida.Location = new System.Drawing.Point(34, 221);
			this.txtDataSaida.Mask = "00/00/0000";
			this.txtDataSaida.Name = "txtDataSaida";
			this.txtDataSaida.Size = new System.Drawing.Size(82, 27);
			this.txtDataSaida.TabIndex = 3;
			this.txtDataSaida.ValidatingType = typeof(System.DateTime);
			// 
			// txtHoraSaida
			// 
			this.txtHoraSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraSaida.Location = new System.Drawing.Point(122, 221);
			this.txtHoraSaida.Mask = "00:00";
			this.txtHoraSaida.Name = "txtHoraSaida";
			this.txtHoraSaida.Size = new System.Drawing.Size(47, 27);
			this.txtHoraSaida.TabIndex = 4;
			this.txtHoraSaida.ValidatingType = typeof(System.DateTime);
			// 
			// txtDataRetorno
			// 
			this.txtDataRetorno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataRetorno.Location = new System.Drawing.Point(265, 221);
			this.txtDataRetorno.Mask = "00/00/0000";
			this.txtDataRetorno.Name = "txtDataRetorno";
			this.txtDataRetorno.Size = new System.Drawing.Size(87, 27);
			this.txtDataRetorno.TabIndex = 5;
			this.txtDataRetorno.ValidatingType = typeof(System.DateTime);
			// 
			// txtHoraRetorno
			// 
			this.txtHoraRetorno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraRetorno.Location = new System.Drawing.Point(358, 221);
			this.txtHoraRetorno.Mask = "00:00";
			this.txtHoraRetorno.Name = "txtHoraRetorno";
			this.txtHoraRetorno.Size = new System.Drawing.Size(45, 27);
			this.txtHoraRetorno.TabIndex = 6;
			this.txtHoraRetorno.ValidatingType = typeof(System.DateTime);
			// 
			// FormControleVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 368);
			this.Controls.Add(this.txtHoraRetorno);
			this.Controls.Add(this.txtDataRetorno);
			this.Controls.Add(this.txtHoraSaida);
			this.Controls.Add(this.txtDataSaida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ddlFuncionario);
			this.Controls.Add(this.ddlVeiculo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "FormControleVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormControleVeiculo";
			this.Load += new System.EventHandler(this.FormControleVeiculo_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox ddlVeiculo;
		private System.Windows.Forms.ComboBox ddlFuncionario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox txtDataSaida;
		private System.Windows.Forms.MaskedTextBox txtHoraSaida;
		private System.Windows.Forms.MaskedTextBox txtDataRetorno;
		private System.Windows.Forms.MaskedTextBox txtHoraRetorno;
	}
}