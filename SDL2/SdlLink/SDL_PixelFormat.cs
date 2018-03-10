using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_PixelFormat
	{
		public uint format;
		public IntPtr palette;
		public byte BitsPerPixel;
		public byte BytesPerPixel;
		public byte padding0;
		public byte padding1;
		public uint Rmask;
		public uint Gmask;
		public uint Bmask;
		public uint Amask;
		public byte Rloss;
		public byte Gloss;
		public byte Bloss;
		public byte Aloss;
		public byte Rshift;
		public byte Gshift;
		public byte Bshift;
		public byte Ashift;
		public int refcount;
		public IntPtr next;
	}
}