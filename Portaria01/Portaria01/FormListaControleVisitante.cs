﻿using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormListaControleVisitante: FormUtil {

		private List<RegistroEntradaSaida> ListRegistro;

		public FormListaControleVisitante() {
			InitializeComponent();

			AtualizaFormulario();
		}

		private void AtualizaFormulario() {

			Search();
		}

		private void grdRegistro_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

			if(e.RowIndex > -1 && e.ColumnIndex > -1) {
				var _registro = (RegistroEntradaSaida)grdRegistro.Rows[e.RowIndex].DataBoundItem;

				new FormControleVisitante(_registro).ShowDialog();
				this.Close();
				AtualizaFormulario();
			}
		}


		private void Search() {

			try {
				DateTime dtSaidaDe = DateTime.MinValue;
				DateTime dtSaidaAte = DateTime.MinValue;
				DateTime dtRetornoDe = DateTime.MinValue;
				DateTime dtRetornoAte = DateTime.MinValue;

				if(!string.IsNullOrWhiteSpace(txtDataSaidaDe.Text.Replace("/", ""))) {
					dtSaidaDe = DateTime.Parse(txtDataSaidaDe.Text);

					if(!string.IsNullOrWhiteSpace(txtHoraSaidaDe.Text.Replace(":", "")))
						dtSaidaDe += DateTime.Parse(txtHoraSaidaDe.Text).TimeOfDay;
				}

				if(!string.IsNullOrWhiteSpace(txtDataSaidaAte.Text.Replace("/", ""))) {

					dtSaidaAte = DateTime.Parse(txtDataSaidaAte.Text);
					if(!string.IsNullOrWhiteSpace(txtHoraSaidaAte.Text.Replace(":", "")))
						dtSaidaAte += DateTime.Parse(txtHoraSaidaAte.Text).TimeOfDay;
				}

				if(!string.IsNullOrWhiteSpace(txtRetornoDe.Text.Replace("/", ""))) {

					dtRetornoDe = DateTime.Parse(txtRetornoDe.Text);

					if(!string.IsNullOrWhiteSpace(txtHoraRetornoDe.Text.Replace(":", "")))
						dtRetornoDe += DateTime.Parse(txtHoraRetornoDe.Text).TimeOfDay;
				}

				if(!string.IsNullOrWhiteSpace(txtRetornoAte.Text.Replace("/", ""))) {

					dtRetornoAte = DateTime.Parse(txtRetornoAte.Text);

					if(!string.IsNullOrWhiteSpace(txtHoraRetornoAte.Text.Replace(":", "")))
						dtRetornoAte += DateTime.Parse(txtHoraRetornoAte.Text).TimeOfDay;
				}

				string nome = txtNome.Text;
				string cpf = txtCPF.Text;
				var listRegistro = RegistroESRepository.SearchRegistro(nome, "", dtSaidaDe, dtSaidaAte, dtRetornoDe, dtRetornoAte, 1, cpf);

				if(!string.IsNullOrWhiteSpace(ddlSituacao.Text)) {
					if(listRegistro.Count > 0) {

						string situacao = ddlSituacao.Text;

						if(situacao == "Aberto") {
							listRegistro = listRegistro.Where(x => x.DataSaida == DateTime.MinValue).ToList();
						} else {
							listRegistro = listRegistro.Where(x => x.DataSaida != DateTime.MinValue).ToList();
						}
					}
				}

				var binding = new BindingList<RegistroEntradaSaida>(listRegistro);
				grdRegistro.DataSource = binding;
				grdRegistro.Refresh();

			} catch(ErrorMessageException eme) {

				MessageBox.Show(eme.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			} catch(Exception ex) {
				MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}
	
		private void btnAdd_Click(object sender, EventArgs e) {
			new FormControleVisitante().ShowDialog();

			this.Close();

			AtualizaFormulario();
		}

		private void btnClear_Click(object sender, EventArgs e) {
			ClearFields(this);
			AtualizaFormulario();
		}

		private void btnBuscar_Click(object sender, EventArgs e) {
			Search();
		}
	}
}
