using System.Drawing;
using FluentAssertions;
using Xunit;

namespace SDL2.Tests {
	public class RendererTests {
		private readonly SdlEngine _sdl;
		private readonly ISurface _surface;
		private readonly IRenderer _renderer;

		public RendererTests() {
			_sdl = new SdlEngine();
			_surface = _sdl.CreateSurface(10, 10);
			_renderer = _surface.CreateSoftwareRenderer();
			_renderer.DrawColor = Color.Black;
			_renderer.Clear();
		}

		~RendererTests() {
			_renderer.Dispose();
			_surface.Dispose();
			_sdl.Dispose();
		}

		[Fact]
		public void AbleToGetAndSetTheDrawColor() {
			_renderer.DrawColor = Color.HotPink;
			_renderer.DrawColor.R.Should().Be(Color.HotPink.R);
			_renderer.DrawColor.G.Should().Be(Color.HotPink.G);
			_renderer.DrawColor.B.Should().Be(Color.HotPink.B);
		}

		[Fact]
		public void AbleToSetTheBackgroundColorOfASurface() {
			_renderer.DrawColor = Color.FromArgb(255, 100, 50, 250);
			_renderer.Clear();

			var color = _surface.GetPixel(0, 0);
			color.Should().Be(Color.FromArgb(255, 100, 50, 250));
		}

		[Fact]
		public void AbleToRenderARectangle() {
			_renderer.DrawColor = Color.White;
			_renderer.DrawRectangle(new Rectangle(0, 0, 10, 10));

			_surface.GetPixel(0, 0).Should().Be(Color.FromArgb(255, 255, 255, 255));
			_surface.GetPixel(1, 1).Should().Be(Color.FromArgb(255, 0, 0, 0));
		}

		[Fact]
		public void AbleToGetAndSetTheLogicalSize() {
			_renderer.LogicalSize = new Size(3, 3);
			_renderer.LogicalSize.Should().Be(new Size(3, 3));
		}

		[Fact]
		public void AbleTogetAndSetTheIntegerScale() {
			_renderer.IntegerScale = true;
			_renderer.IntegerScale.Should().BeTrue();

			_renderer.IntegerScale = false;
			_renderer.IntegerScale.Should().BeFalse();
		}

		[Fact]
		public void SettingTheLogicalSizeAndIntegerScalingCorrectlyRendersStill() {
			_renderer.IntegerScale = true;
			_renderer.LogicalSize = new Size(5, 5);
			_renderer.DrawColor = Color.Black;
			_renderer.Clear();
			_renderer.DrawColor = Color.White;
			_renderer.DrawRectangle(new Rectangle(0, 0, 5, 5));

			_surface.GetPixel(9, 9).Should().Be(Color.FromArgb(255, 255, 255, 255));
		}

		[Fact]
		public void AbleToGetAndSetTheViewport() {
			_renderer.Viewport = new Rectangle(1, 2, 3, 4);
			_renderer.Viewport.Should().Be(new Rectangle(1, 2, 3, 4));
		}

		[Fact]
		public void AbleToSetViewPort() {
			_renderer.Viewport = new Rectangle(1, 1, 2, 2);
			_renderer.DrawColor = Color.White;
			_renderer.DrawRectangle(new Rectangle(0, 0, 5, 5));

			_surface.GetPixel(1, 1).Should().Be(Color.FromArgb(255, 255, 255, 255));
			_surface.GetPixel(3, 1).Should().Be(Color.FromArgb(255, 0, 0, 0));
		}

		[Fact]
		public void ResettingTheViewportMakesItTheSizeOfTheSurface() {
			_renderer.Viewport = new Rectangle(1, 1, 2, 2);
			_renderer.ResetViewport();
			_renderer.Viewport.Should().Be(new Rectangle(0, 0, 10, 10));
		}

		[Fact]
		public void AbleToSetAndGetTheClipRectangle() {
			_renderer.ClipRectangle = new Rectangle(2, 4, 6, 7);
			_renderer.ClipRectangle.Should().Be(new Rectangle(2, 4, 6, 7));
		}

		[Fact]
		public void AbleToDisableTheClipRectangle() {
			_renderer.ClipRectangle = new Rectangle(1, 2, 3, 4);
			_renderer.DisableClip();
			_renderer.ClipRectangle.Should().Be(new Rectangle(0, 0, 0, 0));
			_renderer.ClipRectangleIsEnabled.Should().BeFalse();
		}

		[Fact]
		public void SettingTheClipRectangleEnablesClip() {
			_renderer.ClipRectangle = new Rectangle(0, 1, 5, 5);
			_renderer.ClipRectangleIsEnabled.Should().BeTrue();
		}

		[Fact]
		public void SettingTheClipRectRestrictsDrawing() {
			_renderer.ClipRectangle = new Rectangle(1, 0, 5, 5);
			_renderer.DrawColor = Color.White;
			_renderer.DrawRectangle(new Rectangle(0, 0, 10, 10));

			_surface[0, 0].Should().Be(Color.FromArgb(255, 0, 0, 0));
			_surface[1, 0].Should().Be(Color.FromArgb(255, 255, 255, 255));
		}

		[Fact]
		public void AbleToSetAndGetTheScale() {
			_renderer.Scale = new SizeF(10, 11);
			_renderer.Scale.Should().Be(new SizeF(10, 11));
		}

		[Fact]
		public void SettingTheScaleWillScaleTheInputValues() {
			_renderer.Scale = new SizeF(2, 2);
			_renderer.DrawColor = Color.White;
			_renderer.DrawRectangle(new Rectangle(0, 0, 5, 5));

			_surface[9, 9].Should().Be(Color.FromArgb(255, 255, 255));
		}

		[Fact]
		public void AbleToDrawAPoint() {
			_renderer.DrawColor = Color.Aqua;
			_renderer.DrawPoint(new Point(0, 1));

			_surface[0, 1].Should().Be(Color.FromArgb(Color.Aqua.ToArgb()));
		}

		[Fact]
		public void AbleToDrawALine() {
			_renderer.DrawColor = Color.Magenta;
			_renderer.DrawLine(new Point(0, 0), new Point(2, 0));

			_surface[1, 0].Should().Be(Color.FromArgb(Color.Magenta.ToArgb()));
		}

		[Fact]
		public void AbleToFillRectangle() {
			_renderer.DrawColor = Color.BurlyWood;
			_renderer.FillRectangle(new Rectangle(0, 0, 3, 3));

			_surface[1, 1].Should().Be(Color.FromArgb(Color.BurlyWood.ToArgb()));
		}

		[Fact]
		public void AbleToDrawATexture() {
			var tex = MakeTexture();
			_renderer.DrawTexture(tex, new Point(2, 2));

			_surface[2, 2].Should().Be(Color.FromArgb(Color.Red.ToArgb()));
			_surface[3, 2].Should().Be(Color.FromArgb(Color.Blue.ToArgb()));
		}

		private ITexture MakeTexture() {
			var surf = _sdl.CreateSurface(2, 2);
			var rend = surf.CreateSoftwareRenderer();
			rend.DrawColor = Color.Red;
			rend.DrawPoint(0, 0);
			rend.DrawPoint(1, 1);
			rend.DrawColor = Color.Blue;
			rend.DrawPoint(0, 1);
			rend.DrawPoint(1, 0);
			return _renderer.CreateTexture(surf);
		}
	}
}