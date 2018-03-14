using System;

namespace SDL2.Events {
	public interface ICommonEvent {
		EventType Type { get; }
		TimeSpan Timestamp { get; }
	}
}