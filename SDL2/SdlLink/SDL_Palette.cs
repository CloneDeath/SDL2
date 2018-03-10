using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Palette
	{
		public int ncolors;
		public IntPtr colors;
		
		public uint version;
		public int refcount;
	}
}