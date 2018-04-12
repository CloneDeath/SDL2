using System;
using System.Drawing;
using SDL2.SdlLink;

namespace SDL2 {
	public class SdlTexture : ITexture {
		public readonly IntPtr Handle;

		public SdlTexture(IntPtr handle) {
			Handle = handle;
		}

		public Size Size {
			get {
				var result = Sdl.QueryTexture(Handle, out var _, out var _, out var w, out var h);
				if (result != 0) throw new SdlException(nameof(Sdl.QueryTexture));
				return new Size(w, h);
			}
		}

		public Color DrawColor {
			get {
				if (Sdl.GetTextureColorMod(Handle, out var r, out var g, out var b) != 0) {
					throw new SdlException(nameof(Sdl.GetTextureColorMod));
				}

				if (Sdl.GetTextureAlphaMod(Handle, out var a) != 0) {
					throw new SdlException(nameof(Sdl.GetTextureAlphaMod));
				}
				return Color.FromArgb(a, r, g, b);
			}
			set {
				Sdl.SetTextureColorMod(Handle, value.R, value.G, value.B);
				Sdl.SetTextureAlphaMod(Handle, value.A);
			}
		}

		public SDL_BlendMode BlendMode {
			get {
				Sdl.GetTextureBlendMode(Handle, out var blendMode);
				return blendMode;
			}
			set => Sdl.SetTextureBlendMode(Handle, value);
		}

		private void ReleaseUnmanagedResources() {
			Sdl.DestroyTexture(Handle);
		}

		#region Dispose

		protected virtual void Dispose(bool disposing) {
			ReleaseUnmanagedResources();
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~SdlTexture() {
			Dispose(false);
		}

		#endregion
	}
}