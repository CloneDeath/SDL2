// ReSharper disable InconsistentNaming

using System.Drawing;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Point {
		public int x;
		public int y;
	}

	public static class SDL_PointExceptions {
		public static SDL_Point ToSdlPoint(this Point self) {
			return new SDL_Point {
				x = self.X,
				y = self.Y
			};
		}
	}
}