using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming

namespace SDL2.SdlLink
{
    public static partial class SdlInternal {
	    public const string SdlName = "SDL2";

        public const uint SDL_INIT_TIMER = 0x00000001u;
	    public const uint SDL_INIT_AUDIO = 0x00000010u;
        public const uint SDL_INIT_VIDEO = 0x00000020u;  /**< SDL_INIT_VIDEO implies SDL_INIT_EVENTS */
	    public const uint SDL_INIT_JOYSTICK = 0x00000200u;  /**< SDL_INIT_JOYSTICK implies SDL_INIT_EVENTS */
	    public const uint SDL_INIT_HAPTIC = 0x00001000u;
	    public const uint SDL_INIT_GAMECONTROLLER = 0x00002000u;  /**< SDL_INIT_GAMECONTROLLER implies SDL_INIT_JOYSTICK */
	    public const uint SDL_INIT_EVENTS = 0x00004000u;
	    public const uint SDL_INIT_NOPARACHUTE = 0x00100000u;  /**< compatibility; this flag is ignored. */
	    public const uint SDL_INIT_EVERYTHING = SDL_INIT_TIMER | SDL_INIT_AUDIO | SDL_INIT_VIDEO | SDL_INIT_EVENTS |
	                                            SDL_INIT_JOYSTICK | SDL_INIT_HAPTIC | SDL_INIT_GAMECONTROLLER;
	    
        [DllImport(SdlName)]
        public static extern int SDL_Init(uint flags);
        
        [DllImport(SdlName)]
        public static extern void SDL_Quit();
    }
}
