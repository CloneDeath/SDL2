namespace SDL2.Events {
	public interface IMouseWheelEvent : ICommonEvent {
		int X { get; }
		int Y { get; }
	}
}