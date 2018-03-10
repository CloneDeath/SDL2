using System;
using SDL2.SdlLink;

namespace SDL2 {
	[Flags]
	public enum Flip {
		None = SDL_RendererFlip.SDL_FLIP_NONE,
		Vertical = SDL_RendererFlip.SDL_FLIP_VERTICAL,
		Horizontal = SDL_RendererFlip.SDL_FLIP_HORIZONTAL
	}
}