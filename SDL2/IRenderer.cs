using System;
using System.Drawing;

namespace SDL2 {
	public interface IRenderer : IDisposable {
		void Clear();
		void Present();
		ITexture CreateTexture(string filePath);
		ITexture CreateTexture(ISurface surface);
		IFont CreateFont(string fontPath, int fontSize);

		void SetDrawColor(Color color);

		void DrawRectangle(Rectangle rectangle);
	}
}