using System;
using SDL2.SdlLink.EventStructures;

namespace SDL2.Events {
	public class SdlKeyboardEvent : IKeyboardEvent {
		private readonly SDL_KeyboardEvent _handle;

		public SdlKeyboardEvent(SDL_KeyboardEvent handle) {
			_handle = handle;
		}

		public EventType Type => (EventType) _handle.type;
		public TimeSpan Timestamp => TimeSpan.FromMilliseconds(_handle.timestamp);
		public KeyState State => (KeyState) _handle.state;
		public bool Repeat => _handle.repeat != 0;
		public IKeySymbol KeySymbol => new SdlKeySymbol(_handle.keysym);
	}
}