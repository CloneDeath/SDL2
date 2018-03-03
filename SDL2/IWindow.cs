using System;
using System.Drawing;

namespace SDL2 {
	public interface IWindow : IDisposable {
		string Title { get; set; }
		Point Position { get; set; }
		Size Size { get; set; }
		Size MinimumSize { get; set; }
		Size MaximumSize { get; set; }
		bool Bordered { set; }
		bool Resizable { set; }

		void Show();
		void Hide();
		void Raise();
		void Maximize();
		void Minimize();
		void Restore();
		
		WindowMode Mode { set; }
	}
}