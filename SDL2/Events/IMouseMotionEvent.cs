namespace SDL2.Events {
	public interface IMouseMotionEvent : ICommonEvent {
		int X { get; }
		int Y { get; }
		int DeltaX { get; }
		int DeltaY { get; }
	}
}