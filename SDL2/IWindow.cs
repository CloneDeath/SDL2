using System;

namespace SDL2 {
	public interface IWindow : IDisposable {
		string Title { get; set; }
	}
}