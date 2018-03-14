using System;
using System.Runtime.InteropServices;
using SDL2.SdlLink.EventStructures;
// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink {
	public static partial class Sdl {
		[DllImport(SdlName, EntryPoint = "SDL_PumpEvents")]
		public static extern void PumpEvents();
		
		[DllImport(SdlName, EntryPoint = "SDL_HasEvent")]
		public static extern bool HasEvent(uint type);
		
		[DllImport(SdlName, EntryPoint = "SDL_FlushEvent")]
		public static extern void FlushEvent(uint type);
		
		[DllImport(SdlName, EntryPoint = "SDL_PollEvent")]
		public static extern int PollEvent(IntPtr sdlEvent);
		public static SDL_Event PollEvent() {
			var location = Marshal.AllocHGlobal(SDL_Event.Length);
			var result = PollEvent(location);
			if (result == 0) {
				Marshal.FreeHGlobal(location);
				return null;
			}

			var rawData = new byte[SDL_Event.Length];
			Marshal.Copy(location, rawData, 0, SDL_Event.Length);
			Marshal.FreeHGlobal(location);
			return new SDL_Event(rawData);
		}
		
		[DllImport(SdlName, EntryPoint = "SDL_WaitEvent")]
		public static extern int WaitEvent(IntPtr sdlEvent);
		public static SDL_Event WaitEvent() {
			var location = Marshal.AllocHGlobal(SDL_Event.Length);
			var result = WaitEvent(location);
			if (result == 0) {
				Marshal.FreeHGlobal(location);
				return null;
			}

			var rawData = new byte[SDL_Event.Length];
			Marshal.Copy(location, rawData, 0, SDL_Event.Length);
			Marshal.FreeHGlobal(location);
			return new SDL_Event(rawData);
		}
			
		[DllImport(SdlName, EntryPoint = "SDL_WaitEventTimeout")]
		public static extern int WaitEventTimeout(IntPtr sdlEvent, int timeoutMs);
		public static SDL_Event WaitEventTimeout(TimeSpan timeout) {
			var location = Marshal.AllocHGlobal(SDL_Event.Length);
			var result = WaitEventTimeout(location, (int)timeout.TotalMilliseconds);
			if (result == 0) {
				Marshal.FreeHGlobal(location);
				return null;
			}

			var rawData = new byte[SDL_Event.Length];
			Marshal.Copy(location, rawData, 0, SDL_Event.Length);
			Marshal.FreeHGlobal(location);
			return new SDL_Event(rawData);
		}
	}
	
	
	public class SDL_Event {
		public const int Length = 56;
		
		/// <summary>
		/// Event type, shared with all events
		/// </summary>
		public SDL_EventType Type => (SDL_EventType)BitConverter.ToUInt32(Data, 0);
		
		public byte[] Data;
		public SDL_Event(byte[] rawData) {
			Data = rawData;
		}

		private T GetStruct<T>() {
			var location = Marshal.AllocHGlobal(Length);
			Marshal.Copy(Data, 0, location, Length);
			var result = Marshal.PtrToStructure<T>(location);
			Marshal.FreeHGlobal(location);
			return result;
		}
		
		public SDL_CommonEvent common => GetStruct<SDL_CommonEvent>();         /**< Common event data */
		public SDL_WindowEvent window => GetStruct<SDL_WindowEvent>();         /**< Window event data */
		public SDL_KeyboardEvent key => GetStruct<SDL_KeyboardEvent>();          /**< Keyboard event data */
		public SDL_TextEditingEvent edit => GetStruct<SDL_TextEditingEvent>();      /**< Text editing event data */
		public SDL_TextInputEvent text => GetStruct<SDL_TextInputEvent>();        /**< Text input event data */
		public SDL_MouseMotionEvent motion => GetStruct<SDL_MouseMotionEvent>();    /**< Mouse motion event data */
		public SDL_MouseButtonEvent button => GetStruct<SDL_MouseButtonEvent>();    /**< Mouse button event data */
		public SDL_MouseWheelEvent wheel => GetStruct<SDL_MouseWheelEvent>();      /**< Mouse wheel event data */
		public SDL_JoyAxisEvent jaxis => GetStruct<SDL_JoyAxisEvent>();         /**< Joystick axis event data */
		public SDL_JoyBallEvent jball => GetStruct<SDL_JoyBallEvent>();         /**< Joystick ball event data */
		public SDL_JoyHatEvent jhat => GetStruct<SDL_JoyHatEvent>();           /**< Joystick hat event data */
		public SDL_JoyButtonEvent jbutton => GetStruct<SDL_JoyButtonEvent>();     /**< Joystick button event data */
		public SDL_JoyDeviceEvent jdevice => GetStruct<SDL_JoyDeviceEvent>();     /**< Joystick device change event data */
		public SDL_ControllerAxisEvent caxis => GetStruct<SDL_ControllerAxisEvent>();      /**< Game Controller axis event data */
		public SDL_ControllerButtonEvent cbutton => GetStruct<SDL_ControllerButtonEvent>();  /**< Game Controller button event data */
		public SDL_ControllerDeviceEvent cdevice => GetStruct<SDL_ControllerDeviceEvent>();  /**< Game Controller device event data */
		public SDL_AudioDeviceEvent adevice => GetStruct<SDL_AudioDeviceEvent>();   /**< Audio device event data */
		public SDL_QuitEvent quit => GetStruct<SDL_QuitEvent>();             /**< Quit request event data */
		public SDL_UserEvent user => GetStruct<SDL_UserEvent>();             /**< Custom event data */
		public SDL_SysWMEvent syswm => GetStruct<SDL_SysWMEvent>();           /**< System dependent window event data */
		public SDL_TouchFingerEvent tfinger => GetStruct<SDL_TouchFingerEvent>();   /**< Touch finger event data */
		public SDL_MultiGestureEvent mgesture => GetStruct<SDL_MultiGestureEvent>(); /**< Gesture event data */
		public SDL_DollarGestureEvent dgesture => GetStruct<SDL_DollarGestureEvent>(); /**< Gesture event data */
		public SDL_DropEvent drop => GetStruct<SDL_DropEvent>();             /**< Drag and drop event data */
	}
}