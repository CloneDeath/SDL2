using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlTtfLink {
	public static class Ttf {
		public const string TtfName = "SDL2_ttf";
		
		[DllImport(TtfName, EntryPoint = "TTF_Init")]
		public static extern int Init();
		
		[DllImport(TtfName, EntryPoint = "TTF_Quit")]
		public static extern void Quit();
		
		[DllImport(TtfName, EntryPoint = "TTF_OpenFont")]
		public static extern IntPtr OpenFont(string file, int ptsize);
		
		[DllImport(TtfName, EntryPoint = "TTF_CloseFont")]
		public static extern void CloseFont(IntPtr font);
	}
}