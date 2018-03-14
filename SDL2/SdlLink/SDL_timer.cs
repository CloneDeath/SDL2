using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_Delay")]
		public static extern void Delay(uint ms);
	}
}