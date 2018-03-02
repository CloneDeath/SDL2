using System;
using SDL2.SdlLink;

namespace SDL2 {
	public class SdlException : Exception {
		public string FunctionName { get; }
		public string ErrorMessage { get; }
		
		public SdlException(string functionName) {
			FunctionName = functionName;
			ErrorMessage = SdlInternal.SDL_GetError();
		}

		public override string Message => $"{FunctionName}: {ErrorMessage}";
	}
}