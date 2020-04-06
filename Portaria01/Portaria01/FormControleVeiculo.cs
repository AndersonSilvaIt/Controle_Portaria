using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormControleVeiculo: Form {

		private List<Pessoa> ListPessoa;
		private RegistroEntradaSaida _registro;

		public FormControleVeiculo() {
			InitializeComponent();

			ListPessoa = new List<Pessoa>() { new Pessoa() { Nome = "", Id = 0 } };
			ListPessoa.AddRange(PessoaRepository.GetAll().ToList());
			
			var a = ListPessoa.OrderBy(p => p.Nome).ToList();
			ddlFuncionario.DataSource = a;
			this.ddlFuncionario.DisplayMember = "Nome";
			this.ddlFuncionario.ValueMember = "Id";

			txtDataRetorno.Text = "";
			txtHoraRetorno.Text = "";
		}

		private void FormControleVeiculo_Load(object sender, EventArgs e) {

			//txtDataRetorno.Text = "";
			//txtHoraRetorno.Text = "";
			
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			new FormListPessoa().ShowDialog();
		}

		private void btnSalvar_Click(object sender, EventArgs e) {

			try {

				TratarCampos();
				_registro = new RegistroEntradaSaida();

			}catch(ErrorMessageException eme) {
				MessageBox.Show(eme.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}catch(Exception ex) {

			}
		}

		private void TratarCampos() {

			DateTime dataValidation;
			if(!DateTime.TryParse(txtHoraSaida.Text, out dataValidation)) {
				txtDataRetorno.Focus();
				throw new ErrorMessageException("Informe a Data de Saída");
			}

			var hora = txtHoraSaida.Text.Replace(":", "").Trim();
			if(string.IsNullOrWhiteSpace(hora)) {
				txtDataSaida.Focus();
				throw new ErrorMessageException("Por gentileza, informe a Hora da consulta.");
			}
			
			DateTime hora02 = DateTime.Now;
			if(!DateTime.TryParse(txtHoraSaida.Text, out hora02)) {
				txtDataRetorno.Focus();
				throw new ErrorMessageException("Hora da consulta inválida, verifique!");
			}

		}
	}
}
