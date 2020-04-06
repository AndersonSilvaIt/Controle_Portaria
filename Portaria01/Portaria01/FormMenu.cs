using System;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormMenu: Form {
		public FormMenu() {
			InitializeComponent();
		}

		private void btnListPessoa_Click(object sender, EventArgs e) {
			new FormListPessoa().ShowDialog();
		}

		private void btnControleVeiculo_Click(object sender, EventArgs e) {
			new FormListaControleVeiculo().ShowDialog();
		}

		private void btnControleVisitante_Click(object sender, EventArgs e) {
			new FormControleVisitante().ShowDialog();
		}
	}
}
