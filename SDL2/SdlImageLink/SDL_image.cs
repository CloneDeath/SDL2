using System.Runtime.InteropServices;

namespace SDL2.SdlImageLink {
	public static partial class ImgInternal {
		public const string ImgName = "SDL2_image";
		
		[DllImport(ImgName)]
		public static extern int IMG_Init(IMG_InitFlags flags);

		[DllImport(ImgName)]
		public static extern void IMG_Quit();
	}
}