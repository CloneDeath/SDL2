using System.Drawing;
using FluentAssertions;
using Xunit;

namespace SDL2.Tests {
	public class WindowTests {
		private readonly SdlEngine _sdl;
		private readonly IWindow _window;

		public WindowTests() {
			_sdl = new SdlEngine();
			_window = _sdl.CreateWindow();
		}

		~WindowTests() {
			_window.Dispose();
			_sdl.Dispose();
		}
		
		[Fact]
		public void AbleToGetAndSetTheWindowTitle() {
			_window.Title = "hello world";
			_window.Title.Should().Be("hello world");
		}

		[Fact]
		public void AbleToGetAndSetTheWindowPosition() {
			_window.Position = new Point(100, 200);
			var position = _window.Position;
			position.X.Should().Be(100);
			position.Y.Should().Be(200);
		}

		[Fact]
		public void AbleToGetAndSetTheWindowSize() {
			_window.Size = new Size(641, 482);
			_window.Size.Width.Should().Be(641);
			_window.Size.Height.Should().Be(482);
		}

		[Fact]
		public void AbleToGetAndSetTheMinimumSize() {
			_window.MinimumSize = new Size(10, 11);
			_window.MinimumSize.Width.Should().Be(10);
			_window.MinimumSize.Height.Should().Be(11);
		}

		[Fact]
		public void TheWindowSizeIsBoundByTheMinimumSize() {
			_window.MinimumSize = new Size(10, 11);
			_window.Size = new Size(5, 5);
			_window.Size.Width.Should().Be(10);
			_window.Size.Height.Should().Be(11);
		}

		[Fact]
		public void AbleToGetAndSetTheMaximumSize() {
			_window.MaximumSize = new Size(100, 101);
			_window.MaximumSize.Should().Be(new Size(100, 101));
		}

		[Fact]
		public void TheWindowSizeIsBoundByTheMaximumSize() {
			_window.MaximumSize = new Size(100, 101);
			_window.Size = new Size(640, 480);
			_window.Size.Should().Be(new Size(100, 101));
		}

		[Fact]
		public void AbleToGetAndSetTheBorder() {
			_window.Bordered = true;
			_window.Bordered.Should().BeTrue();

			_window.Bordered = false;
			_window.Bordered.Should().BeFalse();
		}

		[Fact]
		public void AbleToGetAndSetResizable() {
			_window.Resizable = true;
			_window.Resizable.Should().BeTrue();

			_window.Resizable = false;
			_window.Resizable.Should().BeFalse();
		}

		[Fact]
		public void AbleToGetAndSetVisibility() {
			_window.Visible = true;
			_window.Visible.Should().BeTrue();

			_window.Visible = false;
			_window.Visible.Should().BeFalse();
		}

		[Fact]
		public void ShowMakesWindowVisible() {
			_window.Show();
			_window.Visible.Should().BeTrue();
		}

		[Fact]
		public void HideMakesWindowNotVisible() {
			_window.Hide();
			_window.Visible.Should().BeFalse();
		}
	}
}