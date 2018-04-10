using System;
using System.Drawing;
using System.IO;
using SDL2.SdlImageLink;
using SDL2.SdlLink;
using SDL2.SdlTtfLink;

namespace SDL2 {
	public class SdlRenderer : IRenderer {
		private readonly IntPtr _handle;

		public SdlRenderer(IntPtr handle) {
			_handle = handle;
		}

		public Size LogicalSize {
			get {
				Sdl.RenderGetLogicalSize(_handle, out var w, out var h);
				return new Size(w, h);
			}
			set => Sdl.RenderSetLogicalSize(_handle, value.Width, value.Height);
		}

		public bool IntegerScale {
			get => Sdl.RenderGetIntegerScale(_handle);
			set => Sdl.RenderSetIntegerScale(_handle, value);
		}

		public SizeF Scale {
			get {
				Sdl.RenderGetScale(_handle, out var x, out var y);
				return new SizeF(x, y);
			}
			set => Sdl.RenderSetScale(_handle, value.Width, value.Height);
		}

		public Rectangle Viewport {
			get {
				Sdl.RenderGetViewport(_handle, out var viewport);
				return new Rectangle(viewport.x, viewport.y, viewport.w, viewport.h);
			}
			set {
				var rect = new SDL_Rect {
					x = value.X,
					y = value.Y,
					w = value.Width,
					h = value.Height
				};
				if (Sdl.RenderSetViewport(_handle, ref rect) != 0) throw new SdlException(nameof(Sdl.RenderSetViewport));
			}
		}

		public void ResetViewport() {
			if (Sdl.RenderSetViewport(_handle, IntPtr.Zero) != 0) throw new SdlException(nameof(Sdl.RenderSetViewport));

		}

		public Rectangle ClipRectangle {
			get {
				Sdl.RenderGetClipRect(_handle, out var viewport);
				return new Rectangle(viewport.x, viewport.y, viewport.w, viewport.h);
			}
			set {
				var rect = new SDL_Rect {
					x = value.X,
					y = value.Y,
					w = value.Width,
					h = value.Height
				};
				if (Sdl.RenderSetClipRect(_handle, ref rect) != 0) throw new SdlException(nameof(Sdl.RenderSetClipRect));
			}
		}

		public bool ClipRectangleIsEnabled => Sdl.RenderIsClipEnabled(_handle);

		public void DisableClip() {
			if (Sdl.RenderSetClipRect(_handle, IntPtr.Zero) != 0) throw new SdlException(nameof(Sdl.RenderSetClipRect));
		}

		public void Clear() {
			Sdl.RenderClear(_handle);
		}

		public void Present() {
			Sdl.RenderPresent(_handle);
		}

		public ITexture LoadTexture(string filePath) {
			var texture = Img.LoadTexture(_handle, filePath);
			if (texture == null) throw new SdlException("IMG_LoadTexture");
			return new SdlTexture(texture);
		}

		public ITexture CreateTexture(ISurface surface) {
			var texture = Sdl.CreateTextureFromSurface(_handle, ((SdlSurface) surface).Handle);
			if (texture == IntPtr.Zero) throw new SdlException(nameof(Sdl.CreateTextureFromSurface));
			return new SdlTexture(texture);
		}

		public IFont OpenFont(Stream fontStream, int fontSize) {
			using (var br = new BinaryReader(fontStream)) {
				var bytes = br.ReadBytes((int)fontStream.Length);
				var fontData = Sdl.RWFromMem(bytes);
				var font = Ttf.OpenFontRW(fontData, 1, fontSize);
				if (font == IntPtr.Zero) {
					fontData.Dispose();
					throw new SdlException("TTF_OpenFontRW");
				}
				
				var sdlFont = new SdlFontWithResources(font);
				sdlFont.AddResources(fontData);
				return sdlFont;
			}
		}

		public IFont OpenFont(string fontPath, int fontSize) {
			var font = Ttf.OpenFont(fontPath, fontSize);
			if (font == null) throw new SdlException("TTF_OpenFont");
			return new SdlFont(font);
		}

		public Color DrawColor {
			get {
				Sdl.GetRenderDrawColor(_handle, out var r, out var g, out var b, out var a);
				return Color.FromArgb(a, r, g, b);
			}
			set => Sdl.SetRenderDrawColor(_handle, value.R, value.G, value.B, value.A);
		}

		public void DrawPoint(Point point) {
			if (Sdl.RenderDrawPoint(_handle, point.X, point.Y) != 0) throw new SdlException(nameof(Sdl.RenderDrawPoint));
		}

		public void DrawLine(Point a, Point b) {
			var result = Sdl.RenderDrawLine(_handle, a.X, a.Y, b.X, b.Y);
			if (result != 0) throw new SdlException(nameof(Sdl.RenderDrawLine));
		}

		public void DrawRectangle(Rectangle rectangle) {
			var rect = new SDL_Rect {
				x = rectangle.X,
				y = rectangle.Y,
				w = rectangle.Width,
				h = rectangle.Height
			};
			if (Sdl.RenderDrawRect(_handle, ref rect) != 0) throw new SdlException(nameof(Sdl.RenderDrawRect));
		}

		public void FillRectangle(Rectangle rectangle) {
			var rect = new SDL_Rect {
				x = rectangle.X,
				y = rectangle.Y,
				w = rectangle.Width,
				h = rectangle.Height
			};
			if (Sdl.RenderFillRect(_handle, ref rect) != 0) throw new SdlException(nameof(Sdl.RenderFillRect));
		}

		public void DrawTexture(ITexture texture, Rectangle source, Rectangle destination, double angle, Point center, Flip flip) {
			var textureHandle = ((SdlTexture) texture).Handle;
			var srcRect = source.ToSdlRect();
			var dstRect = destination.ToSdlRect();
			var centerPoint = center.ToSdlPoint();
			var result = Sdl.RenderCopyEx(_handle, textureHandle, ref srcRect, ref dstRect, angle, ref centerPoint, (SDL_RendererFlip) flip);
			if (result != 0) throw new SdlException(nameof(Sdl.RenderCopyEx));
		}

		private void ReleaseUnmanagedResources() {
			Sdl.DestroyRenderer(_handle);
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