using System;
using SDL2.SdlLink.EventStructures;

namespace SDL2.Events {
	public class SdlMouseButtonEvent : IMouseButtonEvent {
		private readonly SDL_MouseButtonEvent _handle;

		public SdlMouseButtonEvent(SDL_MouseButtonEvent handle) {
			_handle = handle;
		}

		public EventType Type => (EventType)_handle.type;
		public TimeSpan Timestamp => TimeSpan.FromMilliseconds(_handle.timestamp);
		public MouseButton Button => (MouseButton)_handle.button;
		public KeyState State => (KeyState)_handle.state;
		public int Clicks => _handle.clicks;
		public int X => _handle.x;
		public int Y => _handle.y;
	}
}