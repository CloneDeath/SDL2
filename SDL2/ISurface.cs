using System;
using System.Drawing;

namespace SDL2 {
	public interface ISurface : IDisposable {
		Size Size { get; }
		
		Color this[int x, int y] { get; set; }
		Color GetPixel(int x, int y);
		void SetPixel(int x, int y, Color color);

		IRenderer CreateSoftwareRenderer();
	}
}