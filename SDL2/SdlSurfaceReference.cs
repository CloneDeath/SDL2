using System;

namespace SDL2 {
	public class SdlSurfaceReference : SdlSurface {
		public SdlSurfaceReference(IntPtr surface) : base(surface) { }

		protected override void ReleaseUnmanagedResources() {
			
		}
	}
}