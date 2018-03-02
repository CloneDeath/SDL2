using System.Runtime.InteropServices;

namespace SDL2.SdlTtfLink {
	public static partial class TtfInternal {
		public const string TtfName = "SDL2_ttf";
		
		[DllImport(TtfName)]
		public static extern int TTF_Init();
		
		[DllImport(TtfName)]
		public static extern void TTF_Quit();
	}
}