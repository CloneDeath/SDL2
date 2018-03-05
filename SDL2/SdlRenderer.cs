using System;
using System.Drawing;
using SDL2.SdlLink;

namespace SDL2 {
	public class SdlRenderer : IRenderer {
		private readonly IntPtr _handle;

		public SdlRenderer(IntPtr handle) {
			_handle = handle;
		}
		
		public void Clear() {
			throw new NotImplementedException();
		}

		public void Present() {
			throw new NotImplementedException();
		}

		public ITexture CreateTexture(string filePath) {
			throw new NotImplementedException();
		}

		public ITexture CreateTexture(ISurface surface) {
			throw new NotImplementedException();
		}

		public IFont CreateFont(string fontPath, int fontSize) {
			throw new NotImplementedException();
		}

		public void SetDrawColor(Color color) {
			throw new NotImplementedException();
		}

		public void DrawRectangle(Rectangle rectangle) {
			throw new NotImplementedException();
		}

		private void ReleaseUnmanagedResources() {
			SdlInternal.SDL_DestroyRenderer(_handle);
		}

		#region Dispose

		protected virtual void Dispose(bool disposing) {
			ReleaseUnmanagedResources();
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~SdlRenderer() {
			Dispose(false);
		}

		#endregion
	}
}