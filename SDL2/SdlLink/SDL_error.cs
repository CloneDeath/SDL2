using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_GetError")]
		public static extern IntPtr SDL_GetError();

		public static string GetError() {
			var errorPointer = SDL_GetError();
			var errorStringBytes = new List<byte>();
			for (var i = 0;; i++) {
				var errorByte = new byte[1];
				Marshal.Copy(errorPointer + i, errorByte, 0, 1);
				if (errorByte[0] == 0) break;
				errorStringBytes.Add(errorByte[0]);
			}

			var errorText = Encoding.UTF8.GetString(errorStringBytes.ToArray());
			return errorText;
		}
	}
}