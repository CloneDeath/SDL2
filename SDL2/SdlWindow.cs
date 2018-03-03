using System;
using SDL2.SdlLink;

namespace SDL2 {
	public class SdlWindow : IWindow {
		private readonly IntPtr _handle;

		public SdlWindow(IntPtr handle) {
			_handle = handle;
		}

		public string Title {
			get => SdlInternal.SDL_GetWindowTitle(_handle);
			set => SdlInternal.SDL_SetWindowTitle(_handle, value);
		}

		private void ReleaseUnmanagedResources() {
			SdlInternal.SDL_DestroyWindow(_handle);
		}

		#region Dispose

		protected virtual void Dispose(bool disposing) {
			ReleaseUnmanagedResources();
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~SdlWindow() {
			Dispose(false);
		}

		#endregion
	}
}