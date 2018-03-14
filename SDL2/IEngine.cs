using System;
using SDL2.Events;

namespace SDL2 {
	public interface IEngine : IDisposable {
		IWindow CreateWindow();
		ISurface CreateSurface(int width, int height);
		bool ScreenSaverEnabled { get; set; }
		void Delay(TimeSpan amount);
		IEvent PollEvent();
	}
}