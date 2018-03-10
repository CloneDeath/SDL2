using System;
using System.Drawing;

namespace SDL2 {
	public interface IFont : IDisposable {
		ISurface RenderText(string message, Color color);
		ISurface RenderTextWrapped(string message, Color color, int maxWidth);
		ISurface RenderText(string message, Color color, Color background);
		Size GetTextSize(string message);
		bool CharacterIsProvided(char glyph);
		bool IsFixedWidth { get; }
		int Height { get; }
		int Outline { get; set; }
	}
}