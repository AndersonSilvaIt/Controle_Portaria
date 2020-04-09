using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Portaria01 {

	public partial class FormControleVeiculo: FormUtil {

		private List<Pessoa> ListPessoa;
		private RegistroEntradaSaida _registro;

		public FormControleVeiculo() {
			InitializeComponent();

			AtualizaFormulario();
		}

		public FormControleVeiculo(RegistroEntradaSaida registro) {
			InitializeComponent();

			this._registro = registro;

			AtualizaFormulario();
			FillFields();
			EnableFields(this, false);

			btnSalvar.Visible = false;
			btnEditar.Visible = true;
			btnExcluir.Visible = true;
			btnAdd.Visible = false;
		}

		private void AtualizaFormulario() {

			ListPessoa = new List<Pessoa>() { new Pessoa() { Nome = "", Id = 0 } };
			ListPessoa.AddRange(PessoaRepository.GetAll().Where(x => x.Tipo == "Funcionario").ToList());

			var a = ListPessoa.OrderBy(p => p.Nome).ToList();
			ddlFuncionario.DataSource = a;

			this.ddlFuncionario.DisplayMember = "Nome";
			this.ddlFuncionario.ValueMember = "Id";
			if(_registro == null) {
				DateTime dtNow = DateTime.Now;
				txtDataSaida.Text = dtNow.ToString("dd/MM/yyyy");
				txtHoraSaida.Text = dtNow.ToString("HH:mm");
			}
		}

		private void FillFields() {

			txtDataSaida.Text = _registro.DataSaida.ToString("dd/MM/yyyy");
			txtHoraSaida.Text = _registro.DataSaida.ToString("HH:mm");

			if(_registro.DataEntrada != DateTime.MinValue) {
				txtDataRetorno.Text = _registro.DataEntrada.ToString("dd/MM/yyyy");
				txtHoraRetorno.Text = _registro.DataEntrada.ToString("HH:mm");
			}

			ddlFuncionario.Text = _registro.PessoaNome;
			ddlVeiculo.Text = _registro.Veiculo;
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			new FormListPessoa().ShowDialog();

			ListPessoa = new List<Pessoa>() { new Pessoa() { Nome = "", Id = 0 } };
			ListPessoa.AddRange(PessoaRepository.GetAll().ToList());

			var a = ListPessoa.OrderBy(p => p.Nome).ToList();
			ddlFuncionario.DataSource = a;
		}

		private void btnSalvar_Click(object sender, EventArgs e) {

			try {
				TratarCampos();
				//Preencher classe antes de ir para o banco
				DirtyFields();
				
				if(_registro.Id == 0) {
					RegistroESRepository.Save(_registro);
					MessageBox.Show("Registro salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				} else {
					RegistroESRepository.Update(_registro);
					MessageBox.Show("Registro atualizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				this.Close();

			} catch(ErrorMessageException eme) {
				MessageBox.Show(eme.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}catch(Exception ex) {
				MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void DirtyFields() {

			if(_registro == null)
				_registro = new RegistroEntradaSaida();

			_registro.IdPessoa = int.Parse(ddlFuncionario.SelectedValue.ToString());
			_registro.PessoaNome = ddlFuncionario.Text;
			var pessoa = ddlFuncionario.SelectedItem as Pessoa;
			if(pessoa != null)
				_registro.PesoaCPF = pessoa.CPF;

			_registro.Tipo = 0;
			DateTime dtSaida = DateTime.Parse(txtDataSaida.Text) + DateTime.Parse(txtHoraSaida.Text).TimeOfDay;
			_registro.DataSaida = dtSaida;

			if(!string.IsNullOrEmpty(txtDataSaida.Text.Replace("/", "")) &&
				!string.IsNullOrWhiteSpace(txtHoraRetorno.Text.Replace(":", ""))) {

				DateTime dtRetorno = DateTime.Parse(txtDataRetorno.Text) + DateTime.Parse(txtHoraRetorno.Text).TimeOfDay;
				_registro.DataEntrada = dtRetorno;
			}

			_registro.Veiculo = (string)ddlVeiculo.SelectedItem;
		}

		//Validaçãod de Campos
		private void TratarCampos() {

			DateTime dataValidation = DateTime.MinValue;
			DateTime horavalidator = DateTime.MinValue;
			DateTime dtSaida = DateTime.MinValue;
			DateTime dtRetorno = DateTime.MinValue;

			if(string.IsNullOrEmpty(txtDataSaida.Text.Replace("/", ""))) {
				txtDataSaida.Focus();
				throw new ErrorMessageException("Informe a Data de Saída");
			}

			if(!DateTime.TryParse(txtDataSaida.Text, out dataValidation)) {
				txtDataSaida.Focus();
				throw new ErrorMessageException("Data Saida inválida");
			}

			if(!DateTime.TryParse(txtHoraSaida.Text, out dataValidation)) {
				txtHoraSaida.Focus();
				throw new ErrorMessageException("Informe a Data de Saída");
			}

			var hora = txtHoraSaida.Text.Replace(":", "").Trim();
			if(string.IsNullOrWhiteSpace(hora)) {
				txtDataSaida.Focus();
				throw new ErrorMessageException("Por gentileza, informe a Hora da consulta.");
			}
			
			if(!DateTime.TryParse(txtHoraSaida.Text, out horavalidator)) {
				txtDataRetorno.Focus();
				throw new ErrorMessageException("Informe a Data de Saída");
			}
		
		    dataValidation = DateTime.MinValue;
		    horavalidator = DateTime.MinValue;

			//Validação data/hora retorno

			if(!string.IsNullOrEmpty(txtDataSaida.Text.Replace("/", "")) ||
				!string.IsNullOrWhiteSpace(txtHoraRetorno.Text.Replace(":", ""))){

				if(string.IsNullOrEmpty(txtDataSaida.Text.Replace("/", "")))
					throw new ErrorMessageException("Preencha a data de retorno");

				if(string.IsNullOrEmpty(txtHoraSaida.Text.Replace(":", "")))
					throw new ErrorMessageException("Preencha a hora de retorno");

				if(!string.IsNullOrEmpty(txtDataSaida.Text.Replace("/", "")) &&
					!DateTime.TryParse(txtDataSaida.Text, out dataValidation)) {
					txtDataRetorno.Focus();
					throw new ErrorMessageException("Data Retorno inválida");
				}

				if(!string.IsNullOrWhiteSpace(txtHoraRetorno.Text.Replace(":", "")) &&
					!DateTime.TryParse(txtHoraSaida.Text, out horavalidator)) {
					txtDataRetorno.Focus();
					throw new ErrorMessageException("Hora Retorno inválida");
				}
			}

			string funcionario = ddlFuncionario.SelectedValue.ToString();
			if(string.IsNullOrWhiteSpace(funcionario) || funcionario == "0")
				throw new ErrorMessageException("Escolha um funcionário");

			var veiculo = (string)ddlVeiculo.SelectedItem;
			if(string.IsNullOrWhiteSpace(veiculo))
				throw new ErrorMessageException("Escolha um veículo");
		}

		private void btnEditar_Click(object sender, EventArgs e) {

			btnEditar.Visible = false;
			btnSalvar.Visible = true;
			btnExcluir.Visible = true;
			btnAdd.Visible = true;

			EnableFields(this, true);
		}

		private void btnExcluir_Click(object sender, EventArgs e) {
			try {
				var confirm = MessageBox.Show("Confirma exclusão de registro? ", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if(confirm  == DialogResult.Yes) {

					RegistroESRepository.Delete(_registro);
					MessageBox.Show("Registro excluído com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
			}catch(Exception ex) {

				MessageBox.Show("Erro ao excluir registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ddlFuncionario_SelectionChangeCommitted(object sender, EventArgs e) {

			Pessoa pessoa = ((ComboBox)sender).SelectedItem as Pessoa;
			if(pessoa != null && pessoa.Imagem != null && pessoa.Imagem.Count() > 0)
				imgPessoa.Image = ByteToImage(pessoa.Imagem);
		}

		public Image ByteToImage(byte[] imageBytes) {
			// Convert byte[] to Image
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
			ms.Write(imageBytes, 0, imageBytes.Length);
			Image image = new Bitmap(ms);
			return image;
		}
	}
}
