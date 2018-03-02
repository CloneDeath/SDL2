using System;

namespace SDL2 {
	public interface IEngine : IDisposable {
		IWindow CreateWindow();
	}
}