using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_Surface
	{
		public uint flags;           	/**< Read-only */
		public IntPtr format;    		/**< Read-only */
		public SDL_PixelFormat Format => Marshal.PtrToStructure<SDL_PixelFormat>(format);
		
		public int w, h;                /**< Read-only */
		public int pitch;               /**< Read-only */
		public IntPtr pixels;           /**< Read-write */
	
		/** Application data associated with the surface */
		public IntPtr userdata;             /**< Read-write */
	
		/** information needed for surfaces requiring locks */
		public int locked;                 /**< Read-only */
		public IntPtr lock_data;            /**< Read-only */
	
		/** clipping information */
		public SDL_Rect clip_rect;         /**< Read-only */
	
		/** info for fast blit mapping to other surfaces */
		public IntPtr map;    /**< Private */
	
		/** Reference count -- used when freeing surface */
		public int refcount;               /**< Read-mostly */
	}

	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_FreeSurface")]
		public static extern void FreeSurface(IntPtr surface);
		
		[DllImport(SdlName, EntryPoint = "SDL_LockSurface")]
		public static extern int LockSurface(IntPtr surface);
		
		[DllImport(SdlName, EntryPoint = "SDL_UnlockSurface")]
		public static extern void UnlockSurface(IntPtr surface);
		
		[DllImport(SdlName, EntryPoint = "SDL_CreateRGBSurfaceWithFormat")]
		public static extern IntPtr CreateRgbSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);
		
		[DllImport(SdlName, EntryPoint = "SDL_MasksToPixelFormatEnum")]
		public static extern uint MasksToPixelFormatEnum(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask);
	}
}