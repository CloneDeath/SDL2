using System;
using System.Collections.Generic;

namespace SDL2 {
	public class SdlFontWithResources : SdlFont {
		private readonly List<IDisposable> _resources = new List<IDisposable>();
		
		public SdlFontWithResources(IntPtr handle) : base(handle) { }

		public void AddResources(IDisposable resource) {
			_resources.Add(resource);
		}

		protected override void Dispose(bool disposing) {
			base.Dispose(disposing);

			foreach (var disposable in _resources) {
				disposable.Dispose();
			}
		}
	}
}