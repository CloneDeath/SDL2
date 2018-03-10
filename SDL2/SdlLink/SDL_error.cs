using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName)]
		public static extern string SDL_GetError();
	}
}