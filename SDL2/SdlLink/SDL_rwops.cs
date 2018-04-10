using System;
using System.Runtime.InteropServices;
using SDL2.SdlLink.RWMemoryInfo;

// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_RWFromMem")]
		public static extern IntPtr RWFromMem(IntPtr mem, int size);

		[DllImport(SdlName, EntryPoint = "SDL_FreeRW")]
		public static extern int SDL_FreeRW(IntPtr rwMem);

		public static IMemory RWFromMem(byte[] memory) {
			var memoryPtr = Marshal.AllocHGlobal(memory.Length);
			Marshal.Copy(memory, 0, memoryPtr, memory.Length);

			var rwPtr = RWFromMem(memoryPtr, memory.Length);
			return new DynamicAllocMemory(memoryPtr, rwPtr);
		}
	}
}