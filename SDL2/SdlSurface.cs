using System;
using System.Drawing;
using System.Runtime.InteropServices;
using SDL2.SdlLink;

namespace SDL2 {
	public class SdlSurface : ISurface {
		public readonly IntPtr Handle;

		protected SDL_Surface Surface => Marshal.PtrToStructure<SDL_Surface>(Handle);
		
		public Size Size {
			get {
				var surface = Surface;
				return new Size(surface.w, surface.h);
			}
		}

		public Color this[int x, int y] {
			get => GetPixel(x, y);
			set => SetPixel(x, y, value);
		}

		protected uint GetPixelValue(int x, int y) {
			int bytesPerPixel = Surface.Format.BytesPerPixel;
			var pixel = Surface.pixels + y * Surface.pitch + x * bytesPerPixel;

			switch (bytesPerPixel) {
				case 1: return Marshal.ReadByte(pixel);
				case 2: return (uint)Marshal.ReadInt16(pixel);
				case 3:
					var b0 = Marshal.ReadByte(pixel, 0);
					var b1 = Marshal.ReadByte(pixel, 1);
					var b2 = Marshal.ReadByte(pixel, 2);
					return (uint)BitConverter.ToInt32(new byte[] {b0, b1, b2, 0}, 0);

				case 4: return (uint)Marshal.ReadInt32(pixel);
				default: throw new NotImplementedException();
			}
		}

		public Color GetPixel(int x, int y) {
			Lock();
			var value = GetPixelValue(x, y);
			Unlock();
			Sdl.GetRgba(value, Surface.format, out var r, out var g, out var b, out var a);
			return Color.FromArgb(a, r, g, b);
		}

		private void Unlock() {
			Sdl.UnlockSurface(Handle);
		}

		private void Lock() {
			if (Sdl.LockSurface(Handle) != 0) throw new SdlException("SDL_LockSurface");
		}

		public void SetPixel(int x, int y, Color color) {
			Lock();
			int bytesPerPixel = Surface.Format.BytesPerPixel;
			var pixel = Surface.pixels + y * Surface.pitch + x * bytesPerPixel;

			var sdlColor = Sdl.MapRgba(Surface.format, color.R, color.G, color.B, color.A);

			switch(bytesPerPixel) {
				case 1: 
					Marshal.WriteByte(pixel, (byte) sdlColor);
					break;
				case 2:
					Marshal.WriteInt16(pixel, (short) sdlColor);
					break;

				case 3:
					var bytes = BitConverter.GetBytes(sdlColor);
					Marshal.WriteByte(pixel, 0, bytes[0]);
					Marshal.WriteByte(pixel, 1, bytes[1]);
					Marshal.WriteByte(pixel, 2, bytes[2]);
					break;

				case 4:
					Marshal.WriteInt32(pixel, (int) sdlColor);
					break;
			}
			Unlock();
		}

		public IRenderer CreateSoftwareRenderer() {
			var renderer = Sdl.CreateSoftwareRenderer(Handle);
			if (renderer == IntPtr.Zero) throw new SdlException(nameof(Sdl.CreateSoftwareRenderer));
			return new SdlRenderer(renderer);
		}

		public SdlSurface(IntPtr surface) {
			Handle = surface;
		}

		protected virtual void ReleaseUnmanagedResources() {
			Sdl.FreeSurface(Handle);
		}

		#region Dispose

		protected virtual void Dispose(bool disposing) {
			ReleaseUnmanagedResources();
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~SdlSurface() {
			Dispose(false);
		}
		#endregion
	}
}