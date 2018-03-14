using System;
using SDL2.SdlLink.EventStructures;

namespace SDL2.Events {
	public class SdlMouseMotionEvent : IMouseMotionEvent {
		private readonly SDL_MouseMotionEvent _handle;

		public SdlMouseMotionEvent(SDL_MouseMotionEvent handle) {
			_handle = handle;
		}

		public EventType Type => (EventType) _handle.type;
		public TimeSpan Timestamp => TimeSpan.FromMilliseconds(_handle.timestamp);
		public int X => _handle.x;
		public int Y => _handle.y;
		public int DeltaX => _handle.xrel;
		public int DeltaY => _handle.yrel;
	}
}