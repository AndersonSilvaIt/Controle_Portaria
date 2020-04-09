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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
			this.btnListPessoa = new System.Windows.Forms.Button();
			this.btnControleVisitante = new System.Windows.Forms.Button();
			this.btnControleVeiculo = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnListPessoa
			// 
			this.btnListPessoa.BackColor = System.Drawing.Color.White;
			this.btnListPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListPessoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnListPessoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnListPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btnListPessoa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListPessoa.Image = ((System.Drawing.Image)(resources.GetObject("btnListPessoa.Image")));
			this.btnListPessoa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnListPessoa.Location = new System.Drawing.Point(80, 74);
			this.btnListPessoa.Name = "btnListPessoa";
			this.btnListPessoa.Size = new System.Drawing.Size(161, 111);
			this.btnListPessoa.TabIndex = 1;
			this.btnListPessoa.Text = "Cadastro (Funcionário / Visitante) ";
			this.btnListPessoa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnListPessoa.UseVisualStyleBackColor = false;
			this.btnListPessoa.Click += new System.EventHandler(this.btnListPessoa_Click);
			// 
			// btnControleVisitante
			// 
			this.btnControleVisitante.BackColor = System.Drawing.Color.White;
			this.btnControleVisitante.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnControleVisitante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnControleVisitante.FlatAppearance.BorderSize = 5;
			this.btnControleVisitante.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnControleVisitante.Image = ((System.Drawing.Image)(resources.GetObject("btnControleVisitante.Image")));
			this.btnControleVisitante.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnControleVisitante.Location = new System.Drawing.Point(247, 191);
			this.btnControleVisitante.Name = "btnControleVisitante";
			this.btnControleVisitante.Size = new System.Drawing.Size(161, 109);
			this.btnControleVisitante.TabIndex = 3;
			this.btnControleVisitante.Text = "Controle Visitantes";
			this.btnControleVisitante.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnControleVisitante.UseVisualStyleBackColor = false;
			this.btnControleVisitante.Click += new System.EventHandler(this.btnControleVisitante_Click);
			// 
			// btnControleVeiculo
			// 
			this.btnControleVeiculo.BackColor = System.Drawing.Color.White;
			this.btnControleVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnControleVeiculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnControleVeiculo.FlatAppearance.BorderSize = 5;
			this.btnControleVeiculo.Font = new System.Drawing.Font("Calibri", 12F);
			this.btnControleVeiculo.Image = ((System.Drawing.Image)(resources.GetObject("btnControleVeiculo.Image")));
			this.btnControleVeiculo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnControleVeiculo.Location = new System.Drawing.Point(80, 191);
			this.btnControleVeiculo.Name = "btnControleVeiculo";
			this.btnControleVeiculo.Size = new System.Drawing.Size(161, 111);
			this.btnControleVeiculo.TabIndex = 2;
			this.btnControleVeiculo.Text = "Controle Veículo";
			this.btnControleVeiculo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnControleVeiculo.UseVisualStyleBackColor = false;
			this.btnControleVeiculo.Click += new System.EventHandler(this.btnControleVeiculo_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(139, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Controle Portaria";
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.MediumTurquoise;
			this.ClientSize = new System.Drawing.Size(499, 341);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnControleVisitante);
			this.Controls.Add(this.btnControleVeiculo);
			this.Controls.Add(this.btnListPessoa);
			this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu Principal";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnListPessoa;
		private System.Windows.Forms.Button btnControleVisitante;
		private System.Windows.Forms.Button btnControleVeiculo;
		private System.Windows.Forms.Label label1;
	}
}