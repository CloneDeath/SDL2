using System;
using SDL2.SdlLink;

namespace SDL2.Events {
	public class SdlEvent : IEvent {
		private readonly SDL_Event _handle;

		public SdlEvent(SDL_Event handle) {
			_handle = handle;
		}

		public EventType Type => (EventType) _handle.Type;
		public TimeSpan Timestamp => TimeSpan.FromMilliseconds(_handle.common.timestamp);
		public IKeyboardEvent Key => new SdlKeyboardEvent(_handle.key);
		public IMouseMotionEvent Motion => new SdlMouseMotionEvent(_handle.motion);
		public IMouseButtonEvent Button => new SdlMouseButtonEvent(_handle.button);
		public IMouseWheelEvent Wheel => new SdlMouseWheelEvent(_handle.wheel);
	}
}