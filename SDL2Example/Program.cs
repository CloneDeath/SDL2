using System.Threading;
using SDL2;

namespace SDL2Example {
	public class Program {
		public static void Main() {
			using (var sdl = new SdlEngine()) {
				Thread.Sleep(3000);
			}
//			Console.WriteLine("Hello World!");
//			if (SdlInternal.SDL_Init(SdlInternal.SDL_INIT_EVERYTHING) != 0) {
//				Console.WriteLine("Error initializing SDL");
//			}
//			else {
//				Console.WriteLine("Success!");
//			}
//
//			var window = SdlInternal.SDL_CreateWindow("hello world", 0, 0, 640, 480, SDL_WindowFlags.SDL_WINDOW_SHOWN);
//			if (window == IntPtr.Zero) {
//				Console.WriteLine("Couldn't open window");
//			}
//			else {
//				Console.WriteLine("Window:" + window);
//			}
//
//			Thread.Sleep(10000);
//
//			SdlInternal.SDL_DestroyWindow(window);
//			SdlInternal.SDL_Quit();
		}
	}
}