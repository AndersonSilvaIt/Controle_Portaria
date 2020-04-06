namespace Portaria01 {
	partial class FormImage {
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
			this.imagemZoom = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imagemZoom)).BeginInit();
			this.SuspendLayout();
			// 
			// imagemZoom
			// 
			this.imagemZoom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imagemZoom.Location = new System.Drawing.Point(0, 0);
			this.imagemZoom.Name = "imagemZoom";
			this.imagemZoom.Size = new System.Drawing.Size(749, 430);
			this.imagemZoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imagemZoom.TabIndex = 0;
			this.imagemZoom.TabStop = false;
			// 
			// FormImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 430);
			this.Controls.Add(this.imagemZoom);
			this.Name = "FormImage";
			this.Text = "FormImage";
			((System.ComponentModel.ISupportInitialize)(this.imagemZoom)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox imagemZoom;
	}
}