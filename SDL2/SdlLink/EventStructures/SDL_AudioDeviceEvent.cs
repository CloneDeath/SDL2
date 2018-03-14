using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink.EventStructures {
	[StructLayout(LayoutKind.Sequential)]
	public struct SDL_AudioDeviceEvent
	{
		public uint type;        /**< ::SDL_AUDIODEVICEADDED, or ::SDL_AUDIODEVICEREMOVED */
		public uint timestamp;   /**< In milliseconds, populated using SDL_GetTicks() */
		public uint which;       /**< The audio device index for the ADDED event (valid until next SDL_GetNumAudioDevices() call), SDL_AudioDeviceID for the REMOVED event */
		public byte iscapture;    /**< zero if an output device, non-zero if a capture device. */
		public byte padding1;
		public byte padding2;
		public byte padding3;
	}
}