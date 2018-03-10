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