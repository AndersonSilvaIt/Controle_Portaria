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
			//new FormListaControleVeiculo().ShowDialog();
			var telaControleVeiculo = new FormListaControleVeiculo();
			telaControleVeiculo.ShowDialog();
		}

		private void btnControleVisitante_Click(object sender, EventArgs e) {
			new FormListaControleVisitante().ShowDialog();
		}
	}
}
