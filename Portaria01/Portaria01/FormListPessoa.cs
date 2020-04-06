using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormListPessoa: Form {
		private List<Pessoa> ListPessoa; 

		public FormListPessoa() {
			InitializeComponent();

			ListPessoa = PessoaRepository.GetAll().ToList();

			var a = ListPessoa.OrderBy(p => p.Nome).ToList();
			var binding = new BindingList<Pessoa>(a);

			grdPessoa.DataSource = binding;
			grdPessoa.Refresh();
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			FormPessoa frmPessoa = new FormPessoa();
			frmPessoa.ShowDialog();
		}

		private void grdPessoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {

			if(e.RowIndex > -1 && e.ColumnIndex > -1) {
				var _pessoa = (Pessoa)grdPessoa.Rows[e.RowIndex].DataBoundItem;

				FormPessoa frmPessoa = new FormPessoa(_pessoa);
				frmPessoa.ShowDialog();
			}

		}

	
		private void btnBuscar_Click(object sender, EventArgs e) {

		}
	}
}
