using System.Drawing;
using FluentAssertions;
using Xunit;

namespace SDL2.Tests {
	public class SurfaceTests {
		private readonly SdlEngine _sdl;
		private readonly IWindow _window;

		public SurfaceTests() {
			_sdl = new SdlEngine();
			_window = _sdl.CreateWindow();
		}

		~SurfaceTests() {
			_window.Dispose();
			_sdl.Dispose();
		}
		
		[Fact]
		public void AWindowsSurfaceHasTheSameDimensions() {
			_window.Size = new Size(10, 11);
			var surface = _window.Surface;
			surface.Size.Should().Be(new Size(10, 11));
		}

		[Fact]
		public void AbleToWriteAndReadAPixelFromASurface() {
			_window.Size = new Size(10, 11);
			var surface = _window.Surface;
			surface.SetPixel(0, 0, Color.FromArgb(255, 2, 3, 4));
			surface.GetPixel(0, 0).Should().Be(Color.FromArgb(255, 2, 3, 4));
		}
	}
}