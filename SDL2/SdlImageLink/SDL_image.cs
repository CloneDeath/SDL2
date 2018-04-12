using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlImageLink {
	public static class Img {
		public const string ImgName = "SDL2_image";
		
		[DllImport(ImgName, EntryPoint = "IMG_Init")]
		public static extern int Init(IMG_InitFlags flags);

		[DllImport(ImgName, EntryPoint = "IMG_Quit")]
		public static extern void Quit();
		
		[DllImport(ImgName, EntryPoint = "IMG_LoadTexture")]
		public static extern IntPtr LoadTexture(IntPtr renderer, string file);
		
		[DllImport(ImgName, EntryPoint = "IMG_LoadTexture_RW")]
		public static extern IntPtr LoadTextureRw(IntPtr renderer, IntPtr src, int freesrc);
	}
}