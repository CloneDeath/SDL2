// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures.Keyboard {
	/**
	 *  \brief The SDL keysym structure, used in key events.
	 *
	 *  \note  If you are looking for translated character input, see the ::SDL_TEXTINPUT event.
	 */
	public struct SDL_Keysym
	{
		public Scancode scancode;      /**< SDL physical key code - see ::SDL_Scancode for details */
		public Keycode sym;            /**< SDL virtual key code - see ::SDL_Keycode for details */
		public ushort mod;                 /**< current key modifiers */
		public uint unused;
	}
}