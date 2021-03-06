﻿using System;
using SDL2.Events;
using SDL2.SdlImageLink;
using SDL2.SdlLink;
using SDL2.SdlTtfLink;

namespace SDL2 {
	public class SdlEngine : IEngine {
		public SdlEngine() {
			if (Sdl.Init(Sdl.SDL_INIT_EVERYTHING) != 0) {
				throw new SdlException(nameof(Sdl.Init));
			}

			if (Img.Init(IMG_InitFlags.IMG_INIT_PNG) == 0) {
				Sdl.Quit();
				throw new SdlException(nameof(Img.Init));
			}
			
			// ReSharper disable once InvertIf
			if (Ttf.Init() != 0){
				Img.Quit();
				Sdl.Quit();
				throw new SdlException(nameof(Ttf.Init));
			}
		}
		
		public IWindow CreateWindow() {
			var window = Sdl.CreateWindow("", 0, 0, 640, 480, SDL_WindowFlags.SDL_WINDOW_HIDDEN);
			if (window == IntPtr.Zero) throw new SdlException(nameof(Sdl.CreateWindow));
			return new SdlWindow(window);
		}

		public ISurface CreateSurface(int width, int height) {
			var format = Sdl.MasksToPixelFormatEnum(32, 0x00_00_00_FF, 0x00_00_FF_00, 0x00_FF_00_00, 0xFF_00_00_00);
			if (format == 0) throw new SdlException(nameof(Sdl.MasksToPixelFormatEnum));
			var surface = Sdl.CreateRgbSurfaceWithFormat(0, width, height, 0, format);
			if (surface == IntPtr.Zero) throw new SdlException(nameof(Sdl.CreateRgbSurfaceWithFormat));
			return new SdlSurface(surface);
		}

		public bool ScreenSaverEnabled {
			get => Sdl.IsScreenSaverEnabled();
			set {
				if (value) {
					Sdl.EnableScreenSaver();
				}
				else {
					Sdl.DisableScreenSaver();
				}
			}
		}

		public void Delay(TimeSpan amount) {
			Sdl.Delay((uint)amount.TotalMilliseconds);
		}

		public IEvent PollEvent() {
			var sdlEvent = Sdl.PollEvent();
			return sdlEvent == null ? null : new SdlEvent(sdlEvent);
		}

		protected virtual void ReleaseUnmanagedResources() {
			Ttf.Quit();
			Img.Quit();
			Sdl.Quit();
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