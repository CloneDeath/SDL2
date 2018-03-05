using System;
using System.Drawing;
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

		public Point Position {
			get {
				SdlInternal.SDL_GetWindowPosition(_handle, out var x, out var y);
				return new Point(x, y);
			}
			set => SdlInternal.SDL_SetWindowPosition(_handle, value.X, value.Y);
		}

		public Size Size {
			get {
				SdlInternal.SDL_GetWindowSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => SdlInternal.SDL_SetWindowSize(_handle, value.Width, value.Height);
		}

		public Size MinimumSize {
			get {
				SdlInternal.SDL_GetWindowMinimumSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => SdlInternal.SDL_SetWindowMinimumSize(_handle, value.Width, value.Height);
		}

		public Size MaximumSize {
			get {
				SdlInternal.SDL_GetWindowMaximumSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => SdlInternal.SDL_SetWindowMaximumSize(_handle, value.Width, value.Height);
		}
		
		public bool Bordered {
			set => SdlInternal.SDL_SetWindowBordered(_handle, value);
		}
		
		public bool Resizable {
			set => SdlInternal.SDL_SetWindowResizable(_handle, value);
		}
		
		public void Show() {
			SdlInternal.SDL_ShowWindow(_handle);
		}

		public void Hide() {
			SdlInternal.SDL_HideWindow(_handle);
		}

		public void Raise() {
			SdlInternal.SDL_RaiseWindow(_handle);
		}

		public void Maximize() {
			SdlInternal.SDL_MaximizeWindow(_handle);
		}

		public void Minimize() {
			SdlInternal.SDL_MinimizeWindow(_handle);
		}

		public void Restore() {
			SdlInternal.SDL_RestoreWindow(_handle);
		}

		public WindowMode Mode {
			set {
				switch (value) {
						case WindowMode.FullScreen:
							SdlInternal.SDL_SetWindowFullscreen(_handle, SDL_WindowFlags.SDL_WINDOW_FULLSCREEN);
							break;
						case WindowMode.FullScreenBorderlessWindow:
							SdlInternal.SDL_SetWindowFullscreen(_handle, SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP);
							break;
						case WindowMode.Window:
							SdlInternal.SDL_SetWindowFullscreen(_handle, 0);
							break;
				}
			}
		}

		public IRenderer CreateRenderer() {
			var renderer = SdlInternal.SDL_CreateRenderer(_handle, -1, SDL_RendererFlags.SDL_RENDERER_ACCELERATED 
			                                                           | SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
			if (renderer == IntPtr.Zero) throw new SdlException(nameof(SdlInternal.SDL_CreateRenderer));
			return new SdlRenderer(renderer);
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