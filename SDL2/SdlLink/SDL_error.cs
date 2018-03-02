using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class SdlInternal {
		[DllImport(SdlName)]
		public static extern string SDL_GetError();
	}
}