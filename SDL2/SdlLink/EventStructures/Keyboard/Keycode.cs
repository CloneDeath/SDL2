﻿namespace SDL2.SdlLink.EventStructures.Keyboard {
	public enum Keycode {
		Unknown = 0,
	
		Return = '\r',
		Escape = '\u001B',
		Backspace = '\b',
		Tab = '\t',
		Space = ' ',
		Exclaim = '!',
		QuoteDbl = '"',
		Hash = '#',
		Percent = '%',
		Dollar = '$',
		Ampersand = '&',
		Quote = '\'',
		LeftParen = '(',
		RightParen = ')',
		Asterisk = '*',
		Plus = '+',
		Comma = ',',
		Minus = '-',
		Period = '.',
		Slash = '/',
		D0 = '0',
		D1 = '1',
		D2 = '2',
		D3 = '3',
		D4 = '4',
		D5 = '5',
		D6 = '6',
		D7 = '7',
		D8 = '8',
		D9 = '9',
		Colon = ':',
		Semicolon = ';',
		Less = '<',
		Equal = '=',
		Greater = '>',
		Question = '?',
		At = '@',
		/*
		   Skip uppercase letters
		 */
		Leftbracket = '[',
		Backslash = '\\',
		Rightbracket = ']',
		Caret = '^',
		Underscore = '_',
		Backquote = '`',
		A = 'a',
		B = 'b',
		C = 'c',
		D = 'd',
		E = 'e',
		F = 'f',
		G = 'g',
		H = 'h',
		I = 'i',
		J = 'j',
		K = 'k',
		L = 'l',
		M = 'm',
		N = 'n',
		O = 'o',
		P = 'p',
		Q = 'q',
		R = 'r',
		S = 's',
		T = 't',
		U = 'u',
		V = 'v',
		W = 'w',
		X = 'x',
		Y = 'y',
		Z = 'z',
	
		Capslock = Scancode.Capslock | ScanCodeMask.Value,
	
		F1 = Scancode.F1 | ScanCodeMask.Value,
		F2 = Scancode.F2 | ScanCodeMask.Value,
		F3 = Scancode.F3 | ScanCodeMask.Value,
		F4 = Scancode.F4 | ScanCodeMask.Value,
		F5 = Scancode.F5 | ScanCodeMask.Value,
		F6 = Scancode.F6 | ScanCodeMask.Value,
		F7 = Scancode.F7 | ScanCodeMask.Value,
		F8 = Scancode.F8 | ScanCodeMask.Value,
		F9 = Scancode.F9 | ScanCodeMask.Value,
		F10 = Scancode.F10 | ScanCodeMask.Value,
		F11 = Scancode.F11 | ScanCodeMask.Value,
		F12 = Scancode.F12 | ScanCodeMask.Value,
	
		Printscreen = Scancode.Printscreen | ScanCodeMask.Value,
		ScrollLock = Scancode.ScrollLock | ScanCodeMask.Value,
		Pause = Scancode.Pause | ScanCodeMask.Value,
		Insert = Scancode.Insert | ScanCodeMask.Value,
		Home = Scancode.Home | ScanCodeMask.Value,
		PageUp = Scancode.PageUp | ScanCodeMask.Value,
		Delete = '\u007F',
		End = Scancode.End | ScanCodeMask.Value,
		PageDown = Scancode.PageDown | ScanCodeMask.Value,
		Right = Scancode.Right | ScanCodeMask.Value,
		Left = Scancode.Left | ScanCodeMask.Value,
		Down = Scancode.Down | ScanCodeMask.Value,
		Up = Scancode.Up | ScanCodeMask.Value,
	
		NumlockClear = Scancode.NumlockClear | ScanCodeMask.Value,
		KpDivide = Scancode.KpDivide | ScanCodeMask.Value,
		KpMultiply = Scancode.KpMultiply | ScanCodeMask.Value,
		KpMinus = Scancode.KpMinus | ScanCodeMask.Value,
		KpPlus = Scancode.KpPlus | ScanCodeMask.Value,
		KpEnter = Scancode.KpEnter | ScanCodeMask.Value,
		Kp1 = Scancode.Kp1 | ScanCodeMask.Value,
		Kp2 = Scancode.Kp2 | ScanCodeMask.Value,
		Kp3 = Scancode.Kp3 | ScanCodeMask.Value,
		Kp4 = Scancode.Kp4 | ScanCodeMask.Value,
		Kp5 = Scancode.Kp5 | ScanCodeMask.Value,
		Kp6 = Scancode.Kp6 | ScanCodeMask.Value,
		Kp7 = Scancode.Kp7 | ScanCodeMask.Value,
		Kp8 = Scancode.Kp8 | ScanCodeMask.Value,
		Kp9 = Scancode.Kp9 | ScanCodeMask.Value,
		Kp0 = Scancode.Kp0 | ScanCodeMask.Value,
		KpPeriod = Scancode.KpPeriod | ScanCodeMask.Value,
	
		Application = Scancode.Application | ScanCodeMask.Value,
		Power = Scancode.Power | ScanCodeMask.Value,
		KpEquals = Scancode.KpEquals | ScanCodeMask.Value,
		F13 = Scancode.F13 | ScanCodeMask.Value,
		F14 = Scancode.F14 | ScanCodeMask.Value,
		F15 = Scancode.F15 | ScanCodeMask.Value,
		F16 = Scancode.F16 | ScanCodeMask.Value,
		F17 = Scancode.F17 | ScanCodeMask.Value,
		F18 = Scancode.F18 | ScanCodeMask.Value,
		F19 = Scancode.F19 | ScanCodeMask.Value,
		F20 = Scancode.F20 | ScanCodeMask.Value,
		F21 = Scancode.F21 | ScanCodeMask.Value,
		F22 = Scancode.F22 | ScanCodeMask.Value,
		F23 = Scancode.F23 | ScanCodeMask.Value,
		F24 = Scancode.F24 | ScanCodeMask.Value,
		Execute = Scancode.Execute | ScanCodeMask.Value,
		Help = Scancode.Help | ScanCodeMask.Value,
		Menu = Scancode.Menu | ScanCodeMask.Value,
		Select = Scancode.Select | ScanCodeMask.Value,
		Stop = Scancode.Stop | ScanCodeMask.Value,
		Again = Scancode.Again | ScanCodeMask.Value,
		Undo = Scancode.Undo | ScanCodeMask.Value,
		Cut = Scancode.Cut | ScanCodeMask.Value,
		Copy = Scancode.Copy | ScanCodeMask.Value,
		Paste = Scancode.Paste | ScanCodeMask.Value,
		Find = Scancode.Find | ScanCodeMask.Value,
		Mute = Scancode.Mute | ScanCodeMask.Value,
		VolumeUp = Scancode.VolumeUp | ScanCodeMask.Value,
		VolumeDown = Scancode.VolumeDown | ScanCodeMask.Value,
		KpComma = Scancode.KpComma | ScanCodeMask.Value,
		KpEqualsAs400 =
			Scancode.KpEqualsas400 | ScanCodeMask.Value,
	
		AltErase = Scancode.Alterase | ScanCodeMask.Value,
		SysReq = Scancode.Sysreq | ScanCodeMask.Value,
		Cancel = Scancode.Cancel | ScanCodeMask.Value,
		Clear = Scancode.Clear | ScanCodeMask.Value,
		Prior = Scancode.Prior | ScanCodeMask.Value,
		Return2 = Scancode.Return2 | ScanCodeMask.Value,
		Separator = Scancode.Separator | ScanCodeMask.Value,
		Out = Scancode.Out | ScanCodeMask.Value,
		Oper = Scancode.Oper | ScanCodeMask.Value,
		ClearAgain = Scancode.Clearagain | ScanCodeMask.Value,
		Crsel = Scancode.Crsel | ScanCodeMask.Value,
		Exsel = Scancode.Exsel | ScanCodeMask.Value,
	
		Kp00 = Scancode.Kp00 | ScanCodeMask.Value,
		Kp000 = Scancode.Kp000 | ScanCodeMask.Value,
		ThousandsSeparator =
			Scancode.ThousandsSeparator | ScanCodeMask.Value,
		DecimalSeparator =
			Scancode.DecimalSeparator | ScanCodeMask.Value,
		CurrencyUnit = Scancode.CurrencyUnit | ScanCodeMask.Value,
		CurrencySubunit =
			Scancode.CurrencySubunit | ScanCodeMask.Value,
		KpLeftParen = Scancode.KpLeftParen | ScanCodeMask.Value,
		KpRightParen = Scancode.KpRightParen | ScanCodeMask.Value,
		KpLeftBrace = Scancode.KpLeftBrace | ScanCodeMask.Value,
		KpRightBrace = Scancode.KpRightBrace | ScanCodeMask.Value,
		KpTab = Scancode.KpTab | ScanCodeMask.Value,
		KpBackspace = Scancode.KpBackspace | ScanCodeMask.Value,
		KpA = Scancode.KpA | ScanCodeMask.Value,
		KpB = Scancode.KpB | ScanCodeMask.Value,
		KpC = Scancode.KpC | ScanCodeMask.Value,
		KpD = Scancode.KpD | ScanCodeMask.Value,
		KpE = Scancode.KpE | ScanCodeMask.Value,
		KpF = Scancode.KpF | ScanCodeMask.Value,
		KpXor = Scancode.KpXor | ScanCodeMask.Value,
		KpPower = Scancode.KpPower | ScanCodeMask.Value,
		KpPercent = Scancode.KpPercent | ScanCodeMask.Value,
		KpLess = Scancode.KpLess | ScanCodeMask.Value,
		KpGreater = Scancode.KpGreater | ScanCodeMask.Value,
		KpAmpersand = Scancode.KpAmpersand | ScanCodeMask.Value,
		KpDblAmpersand =
			Scancode.KpDblampersand | ScanCodeMask.Value,
		KpVerticalBar =
			Scancode.KpVerticalbar | ScanCodeMask.Value,
		KpDblVerticalBar =
			Scancode.KpDblverticalbar | ScanCodeMask.Value,
		KpColon = Scancode.KpColon | ScanCodeMask.Value,
		KpHash = Scancode.KpHash | ScanCodeMask.Value,
		KpSpace = Scancode.KpSpace | ScanCodeMask.Value,
		KpAt = Scancode.KpAt | ScanCodeMask.Value,
		KpExclam = Scancode.KpExclam | ScanCodeMask.Value,
		KpMemStore = Scancode.KpMemStore | ScanCodeMask.Value,
		KpMemRecall = Scancode.KpMemRecall | ScanCodeMask.Value,
		KpMemClear = Scancode.KpMemClear | ScanCodeMask.Value,
		KpMemAdd = Scancode.KpMemAdd | ScanCodeMask.Value,
		KpMemSubtract =
			Scancode.KpMemSubtract | ScanCodeMask.Value,
		KpMemMultiply =
			Scancode.KpMemMultiply | ScanCodeMask.Value,
		KpMemDivide = Scancode.KpMemDivide | ScanCodeMask.Value,
		KpPlusMinus = Scancode.KpPlusMinus | ScanCodeMask.Value,
		KpClear = Scancode.KpClear | ScanCodeMask.Value,
		KpClearEntry = Scancode.KpClearEntry | ScanCodeMask.Value,
		KpBinary = Scancode.KpBinary | ScanCodeMask.Value,
		KpOctal = Scancode.KpOctal | ScanCodeMask.Value,
		KpDecimal = Scancode.KpDecimal | ScanCodeMask.Value,
		KpHexadecimal =
			Scancode.KpHexadecimal | ScanCodeMask.Value,
	
		LCtrl = Scancode.LCtrl | ScanCodeMask.Value,
		LShift = Scancode.LShift | ScanCodeMask.Value,
		LAlt = Scancode.LAlt | ScanCodeMask.Value,
		LGui = Scancode.LGui | ScanCodeMask.Value,
		RCtrl = Scancode.RCtrl | ScanCodeMask.Value,
		RShift = Scancode.RShift | ScanCodeMask.Value,
		RAlt = Scancode.RAlt | ScanCodeMask.Value,
		RGui = Scancode.RGui | ScanCodeMask.Value,
	
		Mode = Scancode.Mode | ScanCodeMask.Value,
	
		AudioNext = Scancode.AudioNext | ScanCodeMask.Value,
		AudioPrev = Scancode.AudioPrev | ScanCodeMask.Value,
		AudioStop = Scancode.AudioStop | ScanCodeMask.Value,
		AudioPlay = Scancode.AudioPlay | ScanCodeMask.Value,
		AudioMute = Scancode.AudioMute | ScanCodeMask.Value,
		MediaSelect = Scancode.MediaSelect | ScanCodeMask.Value,
		Www = Scancode.Www | ScanCodeMask.Value,
		Mail = Scancode.Mail | ScanCodeMask.Value,
		Calculator = Scancode.Calculator | ScanCodeMask.Value,
		Computer = Scancode.Computer | ScanCodeMask.Value,
		AcSearch = Scancode.AcSearch | ScanCodeMask.Value,
		AcHome = Scancode.AcHome | ScanCodeMask.Value,
		AcBack = Scancode.AcBack | ScanCodeMask.Value,
		AcForward = Scancode.AcForward | ScanCodeMask.Value,
		AcStop = Scancode.AcStop | ScanCodeMask.Value,
		AcRefresh = Scancode.AcRefresh | ScanCodeMask.Value,
		AcBookmarks = Scancode.AcBookmarks | ScanCodeMask.Value,
	
		BrightnessDown =
			Scancode.BrightnessDown | ScanCodeMask.Value,
		BrightnessUp = Scancode.BrightnessUp | ScanCodeMask.Value,
		DisplaySwitch = Scancode.Displayswitch | ScanCodeMask.Value,
		KbdIllumToggle =
			Scancode.KbdIllumToggle | ScanCodeMask.Value,
		KbdIllumDown = Scancode.KbdIllumDown | ScanCodeMask.Value,
		KbdIllumUp = Scancode.KbdIllumUp | ScanCodeMask.Value,
		Eject = Scancode.Eject | ScanCodeMask.Value,
		Sleep = Scancode.Sleep | ScanCodeMask.Value,
		App1 = Scancode.App1 | ScanCodeMask.Value,
		App2 = Scancode.App2 | ScanCodeMask.Value,
	
		AudioRewind = Scancode.AudioRewind | ScanCodeMask.Value,
		AudioFastForward = Scancode.AudioFastForward | ScanCodeMask.Value
	}
}