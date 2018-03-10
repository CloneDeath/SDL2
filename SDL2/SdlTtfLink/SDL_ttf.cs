using System;
using System.Runtime.InteropServices;
using SDL2.SdlLink;

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
		
		[DllImport(TtfName, EntryPoint = "TTF_RenderUTF8_Blended")]
		public static extern IntPtr RenderUTF8_Blended(IntPtr font, string text, SDL_Color fg);
			
		[DllImport(TtfName, EntryPoint = "TTF_RenderUTF8_Blended_Wrapped")]
		public static extern IntPtr RenderUTF8_Blended_Wrapped(IntPtr font, string text, SDL_Color fg, int wrapLength);
		
		[DllImport(TtfName, EntryPoint = "TTF_RenderUTF8_Shaded")]
		public static extern IntPtr RenderUTF8_Shaded(IntPtr font, string text, SDL_Color fg, SDL_Color bg);
		
		[DllImport(TtfName, EntryPoint = "TTF_SizeUTF8")]
		public static extern int SizeUTF8(IntPtr font, string text, out int w, out int h);
		
		[DllImport(TtfName, EntryPoint = "TTF_GlyphIsProvided")]
		public static extern int GlyphIsProvided(IntPtr font, ushort ch);
			
		[DllImport(TtfName, EntryPoint = "TTF_FontFaceIsFixedWidth")]
		public static extern int FontFaceIsFixedWidth(IntPtr font);
		
		[DllImport(TtfName, EntryPoint = "TTF_FontHeight")]
		public static extern int FontHeight(IntPtr font);
		
		[DllImport(TtfName, EntryPoint = "TTF_GetFontOutline")]
		public static extern int GetFontOutline(IntPtr font);
		
		[DllImport(TtfName, EntryPoint = "TTF_SetFontOutline")]
		public static extern void SetFontOutline(IntPtr font, int outline);
	}
}