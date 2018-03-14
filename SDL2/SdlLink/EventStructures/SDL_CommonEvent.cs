// ReSharper disable InconsistentNaming
namespace SDL2.SdlLink.EventStructures {
	/**
	 *  \brief Fields shared by every event
	 */
	public struct SDL_CommonEvent
	{
		public uint type;
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
	}
}