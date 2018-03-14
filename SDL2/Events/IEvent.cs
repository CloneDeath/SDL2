namespace SDL2.Events {
	public interface IEvent : ICommonEvent {
		IKeyboardEvent Key { get; }
		IMouseMotionEvent Motion { get; }
		IMouseButtonEvent Button { get; }
		IMouseWheelEvent Wheel { get; }
	}
}