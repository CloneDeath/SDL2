using System.Drawing;
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

	public static class SDL_ColorExtensions {
		public static SDL_Color ToSdlColor(this Color self) {
			return new SDL_Color {
				r = self.R,
				g = self.G,
				b = self.B,
				a = self.A
			};
		}
	}
}