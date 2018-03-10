using System;
using System.Drawing;
using SDL2.SdlLink;
using SDL2.SdlTtfLink;

namespace SDL2 {
	public class SdlFont : IFont {
		private readonly IntPtr _handle;

		public SdlFont(IntPtr handle) {
			_handle = handle;
		}

		public ISurface RenderText(string message, Color color) {
			var surface = Ttf.RenderUTF8_Blended(_handle, message, color.ToSdlColor());
			if (surface == IntPtr.Zero) throw new SdlException(nameof(Ttf.RenderUTF8_Blended));
			return new SdlSurface(surface);
		}

		public ISurface RenderTextWrapped(string message, Color color, int maxWidth) {
			var surface = Ttf.RenderUTF8_Blended_Wrapped(_handle, message, color.ToSdlColor(), maxWidth);
			if (surface == IntPtr.Zero) throw new SdlException(nameof(Ttf.RenderUTF8_Blended_Wrapped));
			return new SdlSurface(surface);
		}

		public ISurface RenderText(string message, Color color, Color background) {
			var surface = Ttf.RenderUTF8_Shaded(_handle, message, color.ToSdlColor(), background.ToSdlColor());
			if (surface == IntPtr.Zero) throw new SdlException(nameof(Ttf.RenderUTF8_Shaded));
			return new SdlSurface(surface);
		}

		public Size GetTextSize(string message) {
			var result = Ttf.SizeUTF8(_handle, message, out var w, out var h);
			if (result != 0) throw new SdlException(nameof(Ttf.SizeUTF8));
			return new Size(w, h);
		}

		public bool CharacterIsProvided(char glyph) {
			return Ttf.GlyphIsProvided(_handle, glyph) != 0;
		}

		public bool IsFixedWidth => Ttf.FontFaceIsFixedWidth(_handle) != 0;
		
		public int Height => Ttf.FontHeight(_handle);
		
		public int Outline {
			get => Ttf.GetFontOutline(_handle);
			set => Ttf.SetFontOutline(_handle, value);
		}

		private void ReleaseUnmanagedResources() {
			Ttf.CloseFont(_handle);
		}

		#region Dispose

		protected virtual void Dispose(bool disposing) {
			ReleaseUnmanagedResources();
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~SdlFont() {
			Dispose(false);
		}

		#endregion
	}
}