using System;
using SDL2.SdlTtfLink;

namespace SDL2 {
	public class SdlFont : IFont {
		private readonly IntPtr _handle;

		public SdlFont(IntPtr handle) {
			_handle = handle;
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