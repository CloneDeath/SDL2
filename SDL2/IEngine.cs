using System;

namespace SDL2 {
	public interface IEngine : IDisposable {
		IWindow CreateWindow();
		ISurface CreateSurface(int width, int height);
		bool ScreenSaverEnabled { get; set; }
	}
}