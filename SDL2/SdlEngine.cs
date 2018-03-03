using System;
using SDL2.SdlImageLink;
using SDL2.SdlLink;
using SDL2.SdlTtfLink;

namespace SDL2 {
	public class SdlEngine : IEngine {
		public SdlEngine() {
			if (SdlInternal.SDL_Init(SdlInternal.SDL_INIT_EVERYTHING) != 0) {
				throw new SdlException(nameof(SdlInternal.SDL_Init));
			}

			if (ImgInternal.IMG_Init(IMG_InitFlags.IMG_INIT_PNG) == 0) {
				SdlInternal.SDL_Quit();
				throw new SdlException(nameof(ImgInternal.IMG_Init));
			}
			
			if (TtfInternal.TTF_Init() != 0){
				ImgInternal.IMG_Quit();
				SdlInternal.SDL_Quit();
				throw new SdlException(nameof(TtfInternal.TTF_Init));
			}
		}
		
		public IWindow CreateWindow() {
			var window = SdlInternal.SDL_CreateWindow("", 0, 0, 640, 480, SDL_WindowFlags.SDL_WINDOW_HIDDEN);
			if (window == IntPtr.Zero) throw new SdlException(nameof(SdlInternal.SDL_CreateWindow));
			return new SdlWindow(window);
		}

		public bool ScreenSaverEnabled {
			get => SdlInternal.SDL_IsScreenSaverEnabled();
			set {
				if (value) {
					SdlInternal.SDL_EnableScreenSaver();
				}
				else {
					SdlInternal.SDL_DisableScreenSaver();
				}
			}
		}

		protected virtual void ReleaseUnmanagedResources() {
			TtfInternal.TTF_Quit();
			ImgInternal.IMG_Quit();
			SdlInternal.SDL_Quit();
		}
		
		#region Dispose
		protected virtual void Dispose(bool disposing) {
			ReleaseUnmanagedResources();
		}

		public void Dispose() {
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		~SdlEngine() {
			Dispose(false);
		}
		#endregion
	}
}