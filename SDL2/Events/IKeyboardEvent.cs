namespace SDL2.Events {
	public interface IKeyboardEvent : ICommonEvent {
		KeyState State { get; }
		bool Repeat { get; }
		IKeySymbol KeySymbol { get; }
	}
}