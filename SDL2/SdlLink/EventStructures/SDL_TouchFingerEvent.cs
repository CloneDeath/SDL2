using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_TouchFingerEvent
	{
		public uint type;        /**< ::SDL_FINGERMOTION or ::SDL_FINGERDOWN or ::SDL_FINGERUP */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public long touchId; /**< The touch device id */
		public long fingerId;
		public float x;            /**< Normalized in the range 0...1 */
		public float y;            /**< Normalized in the range 0...1 */
		public float dx;           /**< Normalized in the range -1...1 */
		public float dy;           /**< Normalized in the range -1...1 */
		public float pressure;     /**< Normalized in the range 0...1 */
	}
}