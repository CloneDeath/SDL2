namespace SDL2.Events {
	public interface IMouseButtonEvent : ICommonEvent {
		MouseButton Button { get; }
		KeyState State { get; }
		int Clicks { get; }
		int X { get; }
		int Y { get; }
	}
}