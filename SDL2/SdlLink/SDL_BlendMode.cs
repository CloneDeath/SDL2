namespace SDL2.SdlLink {
	// ReSharper disable once InconsistentNaming
	public enum SDL_BlendMode
	{
		/// <summary>
		/// no blending
		/// dstRGBA = srcRGBA
		/// </summary>
		None = 0x00000000,
		
		/// <summary>
		/// alpha blending
		/// dstRGB = (srcRGB * srcA) + (dstRGB * (1-srcA))
		/// dstA = srcA + (dstA * (1-srcA))
		/// </summary>
		Alpha = 0x00000001,
		
		/// <summary>
		/// additive blending
		/// dstRGB = (srcRGB * srcA) + dstRGB
		/// dstA = dstA
		/// </summary>
		Additive = 0x00000002,
		
		/// <summary>
		/// color modulate
		/// dstRGB = srcRGB * dstRGB
		/// dstA = dstA
		/// </summary>
		ColorModulate = 0x00000004,
	}
}