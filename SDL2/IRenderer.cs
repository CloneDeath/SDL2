using System;
using System.Drawing;
using System.IO;

namespace SDL2 {
	public interface IRenderer : IDisposable {
		Size LogicalSize { get; set; }
		bool IntegerScale { get; set; }
		SizeF Scale { get; set; }
		
		Rectangle Viewport { get; set; }
		void ResetViewport();
		
		Rectangle ClipRectangle { get; set; }
		bool ClipRectangleIsEnabled { get; }
		void DisableClip();
		
		void Clear();
		void Present();
		ITexture LoadTexture(string filePath);
		ITexture CreateTexture(ISurface surface);
		IFont OpenFont(Stream font, int fontSize);
		IFont OpenFont(string fontPath, int fontSize);

		Color DrawColor { get; set; }

		void DrawPoint(Point point);
		void DrawLine(Point a, Point b);
		void DrawRectangle(Rectangle rectangle);
		void FillRectangle(Rectangle rectangle);
		
		void DrawTexture(ITexture texture, Rectangle source, Rectangle destination, double angle, Point center, Flip flip);
	}

	public static class RendererExtensions {
		public static void DrawPoint(this IRenderer self, int x, int y) {
			self.DrawPoint(new Point(x, y));
		}
		
		public static void DrawTexture(this IRenderer self, ITexture texture, Point destination) {
			self.DrawTexture(texture, destination, 0, Point.Empty, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle destination) {
			self.DrawTexture(texture, destination, 0, Point.Empty, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle source, Rectangle destination) {
			self.DrawTexture(texture, source, destination, 0, Point.Empty, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Point destination, double angle) {
			self.DrawTexture(texture, destination, angle, Point.Empty, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle destination, double angle) {
			self.DrawTexture(texture, destination, angle, Point.Empty, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle source, Rectangle destination, double angle) {
			self.DrawTexture(texture, source, destination, angle, Point.Empty, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Point destination, double angle, Point center) {
			self.DrawTexture(texture, destination, angle, center, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle destination, double angle, Point center) {
			self.DrawTexture(texture, destination, angle, center, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle source, Rectangle destination, double angle, Point center) {
			self.DrawTexture(texture, source, destination, angle, center, Flip.None);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Point destination, double angle, Point center, Flip flip) {
			var srcRect = new Rectangle(Point.Empty, texture.Size);
			var destRect = new Rectangle(destination, texture.Size);
			self.DrawTexture(texture, srcRect, destRect, angle, center, flip);
		}

		public static void DrawTexture(this IRenderer self, ITexture texture, Rectangle destination, double angle, Point center, Flip flip) {
			var srcRect = new Rectangle(Point.Empty, texture.Size);
			self.DrawTexture(texture, srcRect, destination, angle, center, flip);
		}
	}
}