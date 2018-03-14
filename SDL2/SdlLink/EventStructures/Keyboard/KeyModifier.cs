using System;

namespace SDL2.SdlLink.EventStructures.Keyboard {
	/// <summary>
	/// Enumeration of valid key mods (possibly OR'd together).
	/// </summary>
	[Flags]
	public enum KeyModifier
	{
		None = 0x0000,
		LShift = 0x0001,
		RShift = 0x0002,
		LCtrl = 0x0040,
		RCtrl = 0x0080,
		LAlt = 0x0100,
		RAlt = 0x0200,
		LGui = 0x0400,
		RGui = 0x0800,
		Num = 0x1000,
		Caps = 0x2000,
		Mode = 0x4000,
		Reserved = 0x8000,
		
		Ctrl = LCtrl|RCtrl,
		Shift = LShift|RShift,
		Alt =   LAlt|RAlt,
		Gui =   LGui|RGui
	}
}