using System;

namespace Portaria01 {
	public class ErrorMessageException : Exception {

		public ErrorMessageException(string mensagem)
			: base(mensagem)
		{

		}

	}
}
