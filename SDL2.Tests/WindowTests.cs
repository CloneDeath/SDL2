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
		public void WhenAWindowTitleIsSet_ItCanAlsoBeRetreived() {
			_window.Title = "hello world";
			_window.Title.Should().Be("hello world");
		}
	}
}