using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormListaControleVeiculo: FormUtil {

		private List<RegistroEntradaSaida> ListRegistro;

		public FormListaControleVeiculo() {
			InitializeComponent();

			AtualizaFormulario();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			new FormControleVeiculo().ShowDialog();


			AtualizaFormulario();
		}

		private void AtualizaFormulario() {

			ListRegistro = RegistroESRepository.GetAll().ToList();

			var a = ListRegistro;
			var binding = new BindingList<RegistroEntradaSaida>(a);
			grdRegistro.DataSource = binding;
			grdRegistro.Refresh();
		}

		private void grdRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

			if(e.RowIndex > -1 && e.ColumnIndex > -1) {
				var _registro = (RegistroEntradaSaida)grdRegistro.Rows[e.RowIndex].DataBoundItem;

				new FormControleVeiculo(_registro).ShowDialog();

				AtualizaFormulario();
			}

		}

		private void btnClear_Click(object sender, EventArgs e) {

			ClearFields(this);
			AtualizaFormulario();
		}

		private void btnBuscar_Click(object sender, EventArgs e) {

			try {

				DateTime dtSaidaDe = DateTime.Parse(txtDataSaidaDe.Text) + DateTime.Parse(txtHoraSaidaDe.Text).TimeOfDay;
				DateTime dtSaidaAte = DateTime.Parse(txtDataSaidaAte.Text) + DateTime.Parse(txtHoraSaidaAte.Text).TimeOfDay;
				DateTime dtRetornoDe = DateTime.Parse(txtRetornoDe.Text) + DateTime.Parse(txtHoraRetornoDe.Text).TimeOfDay;
				DateTime dtRetornoAte = DateTime.Parse(txtDataSaidaAte.Text) + DateTime.Parse(txtHoraSaidaDe.Text).TimeOfDay;



			} catch(ErrorMessageException eme) {

				MessageBox.Show(eme.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ValidateFiltro() {

			DateTime dtValidation = DateTime.MinValue; 

			if(!string.IsNullOrWhiteSpace(txtDataSaidaDe.Text.Replace(":", "")) &&
				!DateTime.TryParse(txtDataSaidaDe.Text, out dtValidation)){
				txtDataSaidaDe.Focus();
				throw new ErrorMessageException("Data Inválida");
			}

			if(!string.IsNullOrWhiteSpace(txtDataSaidaAte.Text.Replace(":", "")) &&
				!DateTime.TryParse(txtDataSaidaAte.Text, out dtValidation)) {
				txtDataSaidaAte.Focus();
				throw new ErrorMessageException("Data Inválida");
			}

			if(!string.IsNullOrWhiteSpace(txtRetornoDe.Text.Replace(":", "")) &&
				!DateTime.TryParse(txtRetornoDe.Text, out dtValidation)) {
				txtRetornoDe.Focus();
				throw new ErrorMessageException("Data Inválida");
			}

			if(!string.IsNullOrWhiteSpace(txtRetornoAte.Text.Replace(":", "")) &&
				!DateTime.TryParse(txtRetornoAte.Text, out dtValidation)) {
				txtRetornoAte.Focus();
				throw new ErrorMessageException("Data Inválida");
			}


			//Validação das Horas
			if(!string.IsNullOrWhiteSpace(txtHoraSaidaDe.Text.Replace(":", "")) &&
					!DateTime.TryParse(txtHoraSaidaDe.Text, out dtValidation)) {
				txtHoraSaidaDe.Focus();
				throw new ErrorMessageException("Hora Inválida");
			}

			if(!string.IsNullOrWhiteSpace(txtHoraSaidaAte.Text.Replace(":", "")) &&
					!DateTime.TryParse(txtHoraSaidaAte.Text, out dtValidation)) {
				txtHoraSaidaAte.Focus();
				throw new ErrorMessageException("Hora Inválida");
			}

			if(!string.IsNullOrWhiteSpace(txtHoraRetornoDe.Text.Replace(":", "")) &&
					!DateTime.TryParse(txtHoraRetornoDe.Text, out dtValidation)) {
				txtHoraRetornoDe.Focus();
				throw new ErrorMessageException("Hora Inválida");
			}

			if(!string.IsNullOrWhiteSpace(txtHoraRetornoAte.Text.Replace(":", "")) &&
					!DateTime.TryParse(txtHoraRetornoAte.Text, out dtValidation)) {
				txtHoraRetornoAte.Focus();
				throw new ErrorMessageException("Hora Inválida");
			}
		}
	}
}
