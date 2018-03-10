// ReSharper disable InconsistentNaming

using System;

namespace SDL2.SdlLink {
	[Flags]
	public enum SDL_RendererFlip
	{
		SDL_FLIP_NONE = 0x00000000,     /**< Do not flip */
		SDL_FLIP_HORIZONTAL = 0x00000001,    /**< flip horizontally */
		SDL_FLIP_VERTICAL = 0x00000002     /**< flip vertically */
	}
}