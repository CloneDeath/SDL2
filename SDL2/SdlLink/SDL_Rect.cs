// ReSharper disable InconsistentNaming

using System.Drawing;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Rect
	{
		public int x, y;
		public int w, h;
	}

	public static class SDL_RectExtensions {
		public static SDL_Rect ToSdlRect(this Rectangle self) {
			return new SDL_Rect {
				x = self.X,
				y = self.Y,
				w = self.Width,
				h = self.Height
			};
		}
	}
}