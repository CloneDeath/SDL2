// ReSharper disable InconsistentNaming

using System;

namespace SDL2.SdlImageLink {
	[Flags]
	public enum IMG_InitFlags
	{
		IMG_INIT_JPG = 0x00000001,
		IMG_INIT_PNG = 0x00000002,
		IMG_INIT_TIF = 0x00000004,
		IMG_INIT_WEBP = 0x00000008
	}
}