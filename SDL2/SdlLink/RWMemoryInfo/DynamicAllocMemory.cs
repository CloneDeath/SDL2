using System;
using System.Runtime.InteropServices;

namespace SDL2.SdlLink.RWMemoryInfo {
	public class DynamicAllocMemory : IMemory{
		private readonly IntPtr _hglobalMem;

		public DynamicAllocMemory(IntPtr hglobalMem, IntPtr rwPtr) {
			_hglobalMem = hglobalMem;
			SdlRwPtr = rwPtr;
		}
		
		public void Dispose() {
			Marshal.FreeHGlobal(_hglobalMem);
			Sdl.SDL_FreeRW(SdlRwPtr);
		}

		public IntPtr SdlRwPtr { get; }
	}
}