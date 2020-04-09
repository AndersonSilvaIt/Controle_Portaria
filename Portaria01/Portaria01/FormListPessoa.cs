using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormListPessoa: FormUtil {
		private List<Pessoa> ListPessoa;

		public FormListPessoa() {
			InitializeComponent();
			AtualizaFormulario();
			Search();
		}

		private void grdPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

			if(e.RowIndex > -1 && e.ColumnIndex > -1) {
				var _pessoa = (Pessoa)grdPessoa.Rows[e.RowIndex].DataBoundItem;

				FormPessoa frmPessoa = new FormPessoa(_pessoa);
				frmPessoa.ShowDialog();

				AtualizaFormulario();
			}
		}


		private void Search() {
			string nome = txtNome.Text;
			string cpf = txtCPF.Text;
			string cidade = txtCidade.Text;
			string cep = txtCEP.Text;
			string tipo = "";
			string uf = ddlUF.Text;
			if(radioButtonTodos.Checked)
				tipo = "";
			else
				tipo = radioButtonFuncionario.Checked ? "Funcionario" : "Visitante";

			var lista = PessoaRepository.SearchPessoa(nome, cpf, cidade, cep, tipo, uf);
			var binding = new BindingList<Pessoa>(lista);
			grdPessoa.DataSource = binding;
			grdPessoa.Refresh();
		}

		private void AtualizaFormulario() {
			Search();
		}


		private void btnAdd_Click(object sender, EventArgs e) {
			FormPessoa frmPessoa = new FormPessoa();
			frmPessoa.ShowDialog();

			AtualizaFormulario();
		}

		private void btnClear_Click(object sender, EventArgs e) {
			ClearFields(this);

			AtualizaFormulario();
			radioButtonTodos.Checked = true;
		}

		private void btnBuscar_Click(object sender, EventArgs e) {
			Search();
		}
	}
}
