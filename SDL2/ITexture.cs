using System;
using System.Drawing;

namespace SDL2 {
	public interface ITexture : IDisposable {
		Size Size { get; }
	}
}