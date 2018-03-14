using SDL2.SdlLink.EventStructures.Keyboard;

namespace SDL2.Events {
	public interface IKeySymbol {
		Scancode Scancode { get; }
		Keycode Symbol { get; }
		KeyModifier Modifier { get; }
	}
}