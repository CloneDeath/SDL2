using System;
using System.Drawing;
using SDL2.SdlLink;

namespace SDL2 {
	public interface ITexture : IDisposable {
		Size Size { get; }
		
		Color DrawColor { get; set; }
		SDL_BlendMode BlendMode { get; set; }
	}
}