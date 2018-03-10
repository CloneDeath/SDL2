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
			get => Sdl.GetWindowTitle(_handle);
			set => Sdl.SetWindowTitle(_handle, value);
		}

		public Point Position {
			get {
				Sdl.GetWindowPosition(_handle, out var x, out var y);
				return new Point(x, y);
			}
			set => Sdl.SetWindowPosition(_handle, value.X, value.Y);
		}

		public Size Size {
			get {
				Sdl.GetWindowSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => Sdl.SetWindowSize(_handle, value.Width, value.Height);
		}

		public Size MinimumSize {
			get {
				Sdl.GetWindowMinimumSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => Sdl.SetWindowMinimumSize(_handle, value.Width, value.Height);
		}

		public Size MaximumSize {
			get {
				Sdl.GetWindowMaximumSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => Sdl.SetWindowMaximumSize(_handle, value.Width, value.Height);
		}
		
		public bool Bordered {
			get => !Sdl.GetWindowFlags(_handle).HasFlag(SDL_WindowFlags.SDL_WINDOW_BORDERLESS);
			set => Sdl.SetWindowBordered(_handle, value);
		}

		public bool Resizable {
			get => Sdl.GetWindowFlags(_handle).HasFlag(SDL_WindowFlags.SDL_WINDOW_RESIZABLE);
			set => Sdl.SetWindowResizable(_handle, value);
		}

		public bool Visible {
			get => Sdl.GetWindowFlags(_handle).HasFlag(SDL_WindowFlags.SDL_WINDOW_SHOWN);
			set {
				if (value) {
					Show();
				}
				else {
					Hide();
				}
			}
		}
		
		public void Show() {
			Sdl.ShowWindow(_handle);
		}

		public void Hide() {
			Sdl.HideWindow(_handle);
		}

		public void Raise() {
			Sdl.RaiseWindow(_handle);
		}

		public void Maximize() {
			Sdl.MaximizeWindow(_handle);
		}

		public void Minimize() {
			Sdl.MinimizeWindow(_handle);
		}

		public void Restore() {
			Sdl.RestoreWindow(_handle);
		}

		public WindowMode Mode {
			set {
				switch (value) {
						case WindowMode.FullScreen:
							Sdl.SetWindowFullscreen(_handle, SDL_WindowFlags.SDL_WINDOW_FULLSCREEN);
							break;
						case WindowMode.FullScreenBorderlessWindow:
							Sdl.SetWindowFullscreen(_handle, SDL_WindowFlags.SDL_WINDOW_FULLSCREEN_DESKTOP);
							break;
						case WindowMode.Window:
							Sdl.SetWindowFullscreen(_handle, 0);
							break;
				}
			}
		}

		public IRenderer CreateRenderer() {
			var renderer = Sdl.CreateRenderer(_handle, -1, SDL_RendererFlags.SDL_RENDERER_ACCELERATED 
			                                                           | SDL_RendererFlags.SDL_RENDERER_PRESENTVSYNC);
			if (renderer == IntPtr.Zero) throw new SdlException(nameof(Sdl.CreateRenderer));
			return new SdlRenderer(renderer);
		}

		public ISurface Surface {
			get {
				var surface = Sdl.GetWindowSurface(_handle);
				if (surface == IntPtr.Zero) throw new SdlException("SDL_GetWindowSurface");
				return new SdlSurfaceReference(surface);
			}
		}

		public void UpdateWindowSurface() {
			if (Sdl.UpdateWindowSurface(_handle) != 0) throw new SdlException(nameof(Sdl.UpdateWindowSurface));
		}

		private void ReleaseUnmanagedResources() {
			Sdl.DestroyWindow(_handle);
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