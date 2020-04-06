using Data.Entidades;
using Data.RepositorioSQLite;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormPessoa: Form {

		//Utilitários
		
		public Pessoa _pessoa;
		public FormPessoa() {
			InitializeComponent();
		}

		public FormPessoa(Pessoa pessoa) {
			InitializeComponent();

			this._pessoa = pessoa;
			DirtyFields();
		}

		private void FormPessoa_Load(object sender, EventArgs e) {

			
		}

		private void btnSalvar_Click(object sender, EventArgs e) {

			try {
				_pessoa = new Pessoa();
				_pessoa.Nome = txtNome.Text;
				_pessoa.CPF = txtCPF.Text;
				_pessoa.FoneComercial = txtFoneComercial.Text;
				_pessoa.FoneCelular = txtCelular.Text;
				_pessoa.Email = txtEmail.Text;
				_pessoa.Rua = txtRua.Text;
				_pessoa.Numero = txtNumero.Text;
				_pessoa.Bairro = txtBairro.Text;
				_pessoa.Cidade = txtCidade.Text;
				_pessoa.UF = ddlUF.Text;
				_pessoa.CEP = txtCEP.Text;

				_pessoa.Tipo = radioButtonVisitante.Checked ? "Visitante" : "Funcionario";
				if(imgPessoa.Image != null) {
					var imageByte = ImageToByte(imgPessoa.Image, ImageFormat.Jpeg);
					_pessoa.Imagem = imageByte;
				}

				PessoaRepository.Save(_pessoa);
			}catch(Exception ex) {

			}
			//Chamar o método para Salvar
		}

		private void btnEditar_Click(object sender, EventArgs e) {



		}

		private void btnExcluir_Click(object sender, EventArgs e) {



		}

		private void btnImagem_Click(object sender, EventArgs e) {
			openFileDialog.FileName = "teste";
			openFileDialog.Title = "Escolha a foto";
			openFileDialog.Filter = "JPEG|*.JPG|PNG|*.png";
			openFileDialog.ShowDialog();
		}

		private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

			imgPessoa.Image = Image.FromFile(openFileDialog.FileName);
		}

		private void DirtyFields() {

			if(_pessoa != null) {
				txtNome.Text = _pessoa.Nome;
				txtCPF.Text = _pessoa.CPF;
				txtFoneComercial.Text = _pessoa.FoneComercial;
				txtCelular.Text = _pessoa.FoneCelular;
				txtEmail.Text = _pessoa.Email;
				txtRua.Text = _pessoa.Rua;
				txtNumero.Text = _pessoa.Numero;
				txtBairro.Text = _pessoa.Bairro;
				txtCidade.Text = _pessoa.Cidade;
				ddlUF.Text = _pessoa.UF;
				txtCEP.Text = _pessoa.CEP;

				if(_pessoa.Imagem != null) {
					imgPessoa.Image = ByteToImage(_pessoa.Imagem);
				}
			}
		}

		public byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format) {
			using(MemoryStream ms = new MemoryStream()) {
				// Convert Image to byte[]
				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();
				return imageBytes;
			}
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
