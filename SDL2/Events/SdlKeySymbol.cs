using SDL2.SdlLink.EventStructures.Keyboard;

namespace SDL2.Events {
	public class SdlKeySymbol : IKeySymbol {
		private readonly SDL_Keysym _handle;

		public SdlKeySymbol(SDL_Keysym handle) {
			_handle = handle;
		}

		public Scancode Scancode => _handle.scancode;
		public Keycode Symbol => _handle.sym;
		public KeyModifier Modifier => (KeyModifier)_handle.mod;
	}
}