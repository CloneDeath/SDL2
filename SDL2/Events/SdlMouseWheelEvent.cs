using System;
using SDL2.SdlLink.EventStructures;

namespace SDL2.Events {
	public class SdlMouseWheelEvent : IMouseWheelEvent {
		private readonly SDL_MouseWheelEvent _handle;

		public SdlMouseWheelEvent(SDL_MouseWheelEvent handle) {
			_handle = handle;
		}

		public EventType Type => (EventType) _handle.type;
		public TimeSpan Timestamp => TimeSpan.FromMilliseconds(_handle.timestamp);
		public int X => _handle.x;
		public int Y => _handle.y;
	}
}