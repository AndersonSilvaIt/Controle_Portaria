namespace Portaria01 {
	partial class FormMenu {
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
			this.btnListPessoa = new System.Windows.Forms.Button();
			this.btnControleVeiculo = new System.Windows.Forms.Button();
			this.btnControleVisitante = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnListPessoa
			// 
			this.btnListPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListPessoa.Location = new System.Drawing.Point(34, 55);
			this.btnListPessoa.Name = "btnListPessoa";
			this.btnListPessoa.Size = new System.Drawing.Size(117, 91);
			this.btnListPessoa.TabIndex = 1;
			this.btnListPessoa.Text = "Listagem de Pessoas / Visitantes";
			this.btnListPessoa.UseVisualStyleBackColor = true;
			this.btnListPessoa.Click += new System.EventHandler(this.btnListPessoa_Click);
			// 
			// btnControleVeiculo
			// 
			this.btnControleVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnControleVeiculo.Location = new System.Drawing.Point(34, 152);
			this.btnControleVeiculo.Name = "btnControleVeiculo";
			this.btnControleVeiculo.Size = new System.Drawing.Size(117, 91);
			this.btnControleVeiculo.TabIndex = 2;
			this.btnControleVeiculo.Text = "Controle Veículo";
			this.btnControleVeiculo.UseVisualStyleBackColor = true;
			this.btnControleVeiculo.Click += new System.EventHandler(this.btnControleVeiculo_Click);
			// 
			// btnControleVisitante
			// 
			this.btnControleVisitante.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnControleVisitante.Location = new System.Drawing.Point(166, 152);
			this.btnControleVisitante.Name = "btnControleVisitante";
			this.btnControleVisitante.Size = new System.Drawing.Size(108, 91);
			this.btnControleVisitante.TabIndex = 3;
			this.btnControleVisitante.Text = "Controle Visitantes";
			this.btnControleVisitante.UseVisualStyleBackColor = true;
			this.btnControleVisitante.Click += new System.EventHandler(this.btnControleVisitante_Click);
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 298);
			this.Controls.Add(this.btnControleVisitante);
			this.Controls.Add(this.btnControleVeiculo);
			this.Controls.Add(this.btnListPessoa);
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMenu";
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btnListPessoa;
		private System.Windows.Forms.Button btnControleVeiculo;
		private System.Windows.Forms.Button btnControleVisitante;
	}
}