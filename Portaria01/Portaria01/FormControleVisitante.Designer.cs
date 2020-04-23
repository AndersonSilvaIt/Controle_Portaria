namespace Portaria01 {
	partial class FormControleVisitante {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControleVisitante));
			this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
			this.txtDtEntrada = new System.Windows.Forms.MaskedTextBox();
			this.txtHoraSaida = new System.Windows.Forms.MaskedTextBox();
			this.txtDataSaida = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ddlVisitante = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.imgPessoa = new System.Windows.Forms.PictureBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgPessoa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtHoraEntrada
			// 
			this.txtHoraEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraEntrada.Location = new System.Drawing.Point(127, 169);
			this.txtHoraEntrada.Mask = "00:00";
			this.txtHoraEntrada.Name = "txtHoraEntrada";
			this.txtHoraEntrada.Size = new System.Drawing.Size(45, 27);
			this.txtHoraEntrada.TabIndex = 35;
			this.txtHoraEntrada.ValidatingType = typeof(System.DateTime);
			// 
			// txtDtEntrada
			// 
			this.txtDtEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDtEntrada.Location = new System.Drawing.Point(34, 169);
			this.txtDtEntrada.Mask = "00/00/0000";
			this.txtDtEntrada.Name = "txtDtEntrada";
			this.txtDtEntrada.Size = new System.Drawing.Size(87, 27);
			this.txtDtEntrada.TabIndex = 34;
			this.txtDtEntrada.ValidatingType = typeof(System.DateTime);
			// 
			// txtHoraSaida
			// 
			this.txtHoraSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHoraSaida.Location = new System.Drawing.Point(370, 169);
			this.txtHoraSaida.Mask = "00:00";
			this.txtHoraSaida.Name = "txtHoraSaida";
			this.txtHoraSaida.Size = new System.Drawing.Size(47, 27);
			this.txtHoraSaida.TabIndex = 33;
			this.txtHoraSaida.ValidatingType = typeof(System.DateTime);
			// 
			// txtDataSaida
			// 
			this.txtDataSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDataSaida.Location = new System.Drawing.Point(282, 169);
			this.txtDataSaida.Mask = "00/00/0000";
			this.txtDataSaida.Name = "txtDataSaida";
			this.txtDataSaida.Size = new System.Drawing.Size(82, 27);
			this.txtDataSaida.TabIndex = 32;
			this.txtDataSaida.ValidatingType = typeof(System.DateTime);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 148);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 18);
			this.label2.TabIndex = 41;
			this.label2.Text = "Entrada";
			// 
			// ddlVisitante
			// 
			this.ddlVisitante.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ddlVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ddlVisitante.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ddlVisitante.FormattingEnabled = true;
			this.ddlVisitante.Location = new System.Drawing.Point(35, 87);
			this.ddlVisitante.MaxLength = 1;
			this.ddlVisitante.Name = "ddlVisitante";
			this.ddlVisitante.Size = new System.Drawing.Size(382, 27);
			this.ddlVisitante.TabIndex = 30;
			this.ddlVisitante.SelectionChangeCommitted += new System.EventHandler(this.ddlVisitante_SelectionChangeCommitted);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(279, 148);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 18);
			this.label4.TabIndex = 38;
			this.label4.Text = "Saída";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(32, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 18);
			this.label3.TabIndex = 37;
			this.label3.Text = "Visitante";
			// 
			// imgPessoa
			// 
			this.imgPessoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgPessoa.Location = new System.Drawing.Point(468, 87);
			this.imgPessoa.Name = "imgPessoa";
			this.imgPessoa.Size = new System.Drawing.Size(146, 188);
			this.imgPessoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgPessoa.TabIndex = 42;
			this.imgPessoa.TabStop = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.Location = new System.Drawing.Point(35, 225);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(54, 49);
			this.btnSalvar.TabIndex = 43;
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.Location = new System.Drawing.Point(95, 226);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(54, 49);
			this.btnEditar.TabIndex = 44;
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.Location = new System.Drawing.Point(156, 226);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(54, 49);
			this.btnExcluir.TabIndex = 45;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(130, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 33);
			this.label1.TabIndex = 46;
			this.label1.Text = "Cadastro E/S Visitante";
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.Location = new System.Drawing.Point(421, 85);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(32, 30);
			this.btnAdd.TabIndex = 47;
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 34);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 48;
			this.pictureBox1.TabStop = false;
			// 
			// FormControleVisitante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(654, 302);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.imgPessoa);
			this.Controls.Add(this.txtHoraEntrada);
			this.Controls.Add(this.txtDtEntrada);
			this.Controls.Add(this.txtHoraSaida);
			this.Controls.Add(this.txtDataSaida);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ddlVisitante);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Name = "FormControleVisitante";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registro de Visitantes";
			((System.ComponentModel.ISupportInitialize)(this.imgPessoa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
		private System.Windows.Forms.MaskedTextBox txtDtEntrada;
		private System.Windows.Forms.MaskedTextBox txtHoraSaida;
		private System.Windows.Forms.MaskedTextBox txtDataSaida;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ddlVisitante;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox imgPessoa;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}