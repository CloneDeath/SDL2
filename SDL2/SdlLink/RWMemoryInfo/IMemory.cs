using System;

namespace SDL2.SdlLink.RWMemoryInfo {
	public interface IMemory : IDisposable {
		IntPtr SdlRwPtr { get; }
	}
}