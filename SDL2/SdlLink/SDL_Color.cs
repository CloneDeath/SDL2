using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Color
	{
		public byte r;
		public byte g;
		public byte b;
		public byte a;
	}
}