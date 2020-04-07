using System.Windows.Forms;

namespace Portaria01 {
	public partial class FormUtil: Form {
		public FormUtil() {
			InitializeComponent();
		}

		private void FormUtil_Load(object sender, System.EventArgs e) {

		}

		public static void ClearFields2(Control control) {
			foreach(var item in control.Controls) {
				if(item is TextBox)
					((TextBox)item).Text = "";

				if(item is GroupBox)
					ClearFields2((GroupBox)item);

				if(item is MaskedTextBox)
					((MaskedTextBox)item).Text = "";

				if(item is ComboBox)
					((ComboBox)item).SelectedIndex = 0;
			}
		}

		public static void ClearFields(Control control) {
			foreach(var item in control.Controls) {
				if(item is TextBox)
					((TextBox)item).Text = "";

				if(item is GroupBox)
					ClearFields2((GroupBox)item);

				if(item is MaskedTextBox)
					((MaskedTextBox)item).Text = "";

				if(item is ComboBox)
					((ComboBox)item).SelectedIndex = 0;
			}
		}

		public static void EnableFields02(Control control, bool enable) {
			foreach(var item in control.Controls) {
				if(item is TextBox)
					((TextBox)item).Enabled = enable;

				if(item is GroupBox)
					EnableFields02((GroupBox)item, enable);

				if(item is MaskedTextBox)
					((MaskedTextBox)item).Enabled = enable;

				if(item is ComboBox)
					((ComboBox)item).Enabled = enable;

				if(item is CheckBox)
					((CheckBox)item).Enabled = enable;
			}
		}

		public static void EnableFields(Control control, bool enable) {
			foreach(var item in control.Controls) {
				if(item is TextBox)
					((TextBox)item).Enabled = enable;

				if(item is GroupBox)
					EnableFields02((GroupBox)item, enable);

				if(item is MaskedTextBox)
					((MaskedTextBox)item).Enabled = enable;

				if(item is ComboBox)
					((ComboBox)item).Enabled = enable;

				if(item is CheckBox)
					((CheckBox)item).Enabled = enable;
			}
		}


	}
}
