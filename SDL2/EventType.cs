using SDL2.SdlLink;

namespace SDL2 {
	public enum EventType {
		/// <summary>
		/// User-requested quit
		/// </summary>
		Quit           = (int)SDL_EventType.SDL_QUIT,
	
		/// <summary>
		/// The application is being terminated by the OS
		/// Called on iOS in applicationWillTerminate()
		/// Called on Android in onDestroy()
		/// </summary>
		AppTerminating = (int)SDL_EventType.SDL_APP_TERMINATING,
		
		/// <summary>
		/// The application is low on memory, free memory if possible.
		/// Called on iOS in applicationDidReceiveMemoryWarning()
		/// Called on Android in onLowMemory()
		/// </summary>
		AppLowMemory = (int)SDL_EventType.SDL_APP_LOWMEMORY,
		
		/// <summary>
		/// The application is about to enter the background
		/// Called on iOS in applicationWillResignActive()
		/// Called on Android in onPause()
		/// </summary>
		AppWillEnterBackground = (int)SDL_EventType.SDL_APP_WILLENTERBACKGROUND,
		
		/// <summary>
		/// The application did enter the background and may not get CPU for some time
		/// Called on iOS in applicationDidEnterBackground()
		/// Called on Android in onPause()
		/// </summary>
		AppDidEnterBackground = (int)SDL_EventType.SDL_APP_DIDENTERBACKGROUND,
		
		/// <summary>
		/// The application is about to enter the foreground
		/// Called on iOS in applicationWillEnterForeground()
		/// Called on Android in onResume()
		/// </summary>
		AppWillEnterForeground = (int)SDL_EventType.SDL_APP_WILLENTERFOREGROUND,
		
		/// <summary>
		/// The application is now interactive
		/// Called on iOS in applicationDidBecomeActive()
		/// Called on Android in onResume()
		/// </summary>
		AppDidEnterForeground = (int)SDL_EventType.SDL_APP_DIDENTERFOREGROUND,
	
		/* Window events */
		WindowEvent = (int)SDL_EventType.SDL_WINDOWEVENT, /**< Window state change */
		SysWmEvent = (int)SDL_EventType.SDL_SYSWMEVENT,             /**< System specific event */
	
		/* Keyboard events */
		KeyDown = (int)SDL_EventType.SDL_KEYDOWN, /**< Key pressed */
		KeyUp = (int)SDL_EventType.SDL_KEYUP,                  /**< Key released */
		TextEditing = (int)SDL_EventType.SDL_TEXTEDITING,            /**< Keyboard text editing (composition) */
		TextInput = (int)SDL_EventType.SDL_TEXTINPUT,              /**< Keyboard text input */
		KeyMapChanged = (int)SDL_EventType.SDL_KEYMAPCHANGED,          /**< Keymap changed due to a system event such as an
										 input language or keyboard layout change.
									*/
	
		/* Mouse events */
		MouseMotion = (int)SDL_EventType.SDL_MOUSEMOTION, /**< Mouse moved */
		MouseButtonDown = (int)SDL_EventType.SDL_MOUSEBUTTONDOWN,        /**< Mouse button pressed */
		MouseButtonUp = (int)SDL_EventType.SDL_MOUSEBUTTONUP,          /**< Mouse button released */
		MouseWheel = (int)SDL_EventType.SDL_MOUSEWHEEL,             /**< Mouse wheel motion */
	
		/* Joystick events */
		JoyAxisMotion = (int)SDL_EventType.SDL_JOYAXISMOTION, /**< Joystick axis motion */
		JoyBallMotion = (int)SDL_EventType.SDL_JOYBALLMOTION,          /**< Joystick trackball motion */
		JoyHatMotion = (int)SDL_EventType.SDL_JOYHATMOTION,           /**< Joystick hat position change */
		JoyButtonDown = (int)SDL_EventType.SDL_JOYBUTTONDOWN,          /**< Joystick button pressed */
		JoyButtonUp = (int)SDL_EventType.SDL_JOYBUTTONUP,            /**< Joystick button released */
		JoyDeviceAdded = (int)SDL_EventType.SDL_JOYDEVICEADDED,         /**< A new joystick has been inserted into the system */
		JoyDeviceRemoved = (int)SDL_EventType.SDL_JOYDEVICEREMOVED,       /**< An opened joystick has been removed */
	
		/* Game controller events */
		ControllerAxisMotion = (int)SDL_EventType.SDL_CONTROLLERAXISMOTION, /**< Game controller axis motion */
		ControllerButtonDown = (int)SDL_EventType.SDL_CONTROLLERBUTTONDOWN,          /**< Game controller button pressed */
		ControllerButtonUp = (int)SDL_EventType.SDL_CONTROLLERBUTTONUP,            /**< Game controller button released */
		ControllerDeviceAdded = (int)SDL_EventType.SDL_CONTROLLERDEVICEADDED,         /**< A new Game controller has been inserted into the system */
		ControllerDeviceRemoved = (int)SDL_EventType.SDL_CONTROLLERDEVICEREMOVED,       /**< An opened Game controller has been removed */
		ControllerDeviceRemapped = (int)SDL_EventType.SDL_CONTROLLERDEVICEREMAPPED,      /**< The controller mapping was updated */
	
		/* Touch events */
		FingerDown = (int)SDL_EventType.SDL_FINGERDOWN,
		FingerUp = (int)SDL_EventType.SDL_FINGERUP,
		FingerMotion = (int)SDL_EventType.SDL_FINGERMOTION,
	
		/* Gesture events */
		DollarGesture = (int)SDL_EventType.SDL_DOLLARGESTURE,
		DollarRecord = (int)SDL_EventType.SDL_DOLLARRECORD,
		Multigesture = (int)SDL_EventType.SDL_MULTIGESTURE,
	
		/* Clipboard events */
		ClipboardUpdate = (int)SDL_EventType.SDL_CLIPBOARDUPDATE, /**< The clipboard changed */
	
		/* Drag and drop events */
		DropFile = (int)SDL_EventType.SDL_DROPFILE, /**< The system requests a file open */
		DropText = (int)SDL_EventType.SDL_DROPTEXT,                 /**< text/plain drag-and-drop event */
		DropBegin = (int)SDL_EventType.SDL_DROPBEGIN,                /**< A new set of drops is beginning (NULL filename) */
		DropComplete = (int)SDL_EventType.SDL_DROPCOMPLETE,             /**< Current set of drops is now complete (NULL filename) */
	
		/* Audio hotplug events */
		AudioDeviceAdded = (int)SDL_EventType.SDL_AUDIODEVICEADDED, /**< A new audio device is available */
		AudioDeviceRemoved = (int)SDL_EventType.SDL_AUDIODEVICEREMOVED,        /**< An audio device has been removed. */
	
		/* Render events */
		RenderTargetsReset = (int)SDL_EventType.SDL_RENDER_TARGETS_RESET, /**< The render targets have been reset and their contents need to be updated */
		RenderDeviceReset = (int)SDL_EventType.SDL_RENDER_DEVICE_RESET, /**< The device has been reset and all textures need to be recreated */
	
		/** Events ::SDL_USEREVENT through ::SDL_LASTEVENT are for your use,
		 *  and should be allocated with SDL_RegisterEvents()
		 */
		UserEvent = (int)SDL_EventType.SDL_USEREVENT
	}
}