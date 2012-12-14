using System;

namespace Bardez.Projects.BasicStructures.Win32
{
    /// <summary>Enum that is a managed representation for HRESULT code common to Win32 API call</summary>
    /// <remarks>See http://msdn.microsoft.com/en-us/library/cc704587%28v=prot.10%29.aspx for more HRESULT codes</remarks>
    public enum ResultCode : uint /* UInt32 */
    {
        /// <summary>An API call or one of its arguments was illegal</summary>
		XAudio2_Error_INVALID_CALL							= 0x88960001,

        /// <summary>The XMA hardware suffered an unrecoverable error</summary>
		XAudio2_Error_XMA_DECODER_ERROR						= 0x88960002,

        /// <summary>XAudio2 failed to initialize an XAPO effect</summary>
		XAudio2_Error_XAPO_CREATION_FAILED					= 0x88960003,

        /// <summary>An audio device became unusable (unplugged, etc)</summary>
		XAudio2_Error_DEVICE_INVALIDATED					= 0x88960004,

        /// <summary>Already initialized</summary>
		XAudio2_Error_ALREADY_INITIALIZED					= 0xFFFFFFFE,	//not referenced?

        /// <summary>Operation successful</summary>
		Success_OK											= 0x00000000,

        /// <summary>Not implemented</summary>
		Error_NotImplemented								= 0x80004001,

        /// <summary>Class not registered</summary>
		Error_ClassNotRegistered							= 0x80040154,	//not installed

        /// <summary>Operation aborted</summary>
		Error_OperationAborted								= 0x80004004,

        /// <summary>General access denied error</summary>
		Error_AccessDenied									= 0x80070005,

        /// <summary>Unspecified failure</summary>
		Error_Failure										= 0x80004005,

        /// <summary>Handle that is not valid</summary>
		Error_InvalidHandle									= 0x80070006,

        /// <summary>One or more arguments are not valid</summary>
		Error_InvalidArgument								= 0x80070057,

        /// <summary>No such interface supported</summary>
		Error_NoSuchInterfaceSupported						= 0x80004002,

        /// <summary>Failed to allocate necessary memory</summary>
		Error_OutOfMemory									= 0x8007000E,

        /// <summary>Pointer that is not valid</summary>
		Error_InvalidPointer								= 0x80004003,

        /// <summary>Unexpected failure</summary>
		Error_UnexpectedFailure								= 0x8000FFFF,
        /// <summary>The data necessary to complete this operation is not yet available</summary>
		Error_Pending										= 0x8000000A,

        /// <summary>No such interface exists</summary>
		Error_NoSuchInterface								= 0x80000004,

        /// <summary>Invalid number.</summary>
		Direct2D_Error_BadNumber							= 0x88990011,

        /// <summary>The display format we need to render is not supported by the hardware device.</summary>
		Direct2D_Error_DisplayFormatNotSupported			= 0x88990009,

        /// <summary>A valid display state could not be determined.</summary>
		Direct2D_Error_DisplayStateInvalid					= 0x88990006,

        /// <summary>The requested size is larger than the guaranteed supported texture size.</summary>
		Direct2D_Error_ExceedsMaximumBitmapSize				= 0x8899001D,

        /// <summary>The brush types are incompatible for the call.</summary>
		Direct2D_Error_IncompatibleBrushTypes				= 0x88990018,

        /// <summary>The supplied buffer was too small to accomodate the data.</summary>
		Direct2D_Error_InsufficientBuffer					= 0x0000007A,	//ERROR_INSUFFICIENT_BUFFER (Windows error)

        /// <summary>The application should close this instance of D2D and should consider restarting its process.</summary>
		Direct2D_Error_InternalError						= 0x88990008,

        /// <summary>A call to this method is invalid.</summary>
		Direct2D_Error_InvalidCall							= 0x8899000A,

        /// <summary>A layer resource can only be in use once at any point in time.</summary>
		Direct2D_Error_LayerAlreadyInUse					= 0x88990013,

        /// <summary>Requested DX surface size exceeded maximum texture size.</summary>
		Direct2D_Error_MaximumTextureSizeExceeded			= 0x8899000F,

        /// <summary>No HW rendering device is available for this operation.</summary>
		Direct2D_Error_NoHardwareDevice						= 0x8899000B,

        /// <summary>The object has not yet been initialized.</summary>
		Direct2D_Error_NotInitialized						= 0x88990002,

        /// <summary>The pop call did not match the corresponding push call.</summary>
		Direct2D_Error_PopCallDidNotMatchPush				= 0x88990014,

        /// <summary>The push and pop calls were unbalanced.</summary>
		Direct2D_Error_PushPopUnbalanced					= 0x88990016,

        /// <summary>
        ///     There has been a presentation error that may be recoverable. The caller
        ///     needs to recreate, rerender the entire frame, and reattempt present.
        /// </summary>
        Direct2D_Error_RecreateTarget						= 0x8899000C,

        /// <summary>Attempt to copy from a render target while a layer or clip rect is applied.</summary>
		Direct2D_Error_RenderTagetHasLayerOrClipRectangle	= 0x88990017,

        /// <summary>The geomery scanner failed to process the data.</summary>
		Direct2D_Error_ScannerFailed						= 0x88990004,

        /// <summary>D2D could not access the screen.</summary>
		Direct2D_Error_ScreenAccessDenied					= 0x88990005,

        /// <summary>Shader compilation failed.</summary>
		Direct2D_Error_ShaderCompileFailed					= 0x8899000E,

        /// <summary>The render target is not compatible with GDI.</summary>
		Direct2D_Error_TargetNotGdiCompatible				= 0x8899001A,

        /// <summary>A text client drawing effect object is of the wrong type.</summary>
		Direct2D_Error_TextEffectIsWrongType				= 0x8899001B,

        /// <summary>
        ///     The application is holding a reference to the IDWriteTextRenderer interface
        ///     after the corresponding DrawText or DrawTextLayout call has returned. The
        ///     IDWriteTextRenderer instance will be zombied.
        /// </summary>
		Direct2D_Error_TextRendererNotReleased				= 0x8899001C,

        /// <summary>Shader construction failed because it was too complex.</summary>
		Direct2D_Error_TooManyShaderElements				= 0x8899000D,

        /// <summary>The requested opertion is not supported.</summary>
		Direct2D_Error_UnsupportedOperation					= 0x88990003,

        /// <summary>The pixel format is not supported.</summary>
		Direct2D_Error_UnsupportedPixelFormat				= 0x88982F80,	//WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT (error in wincodec.h); (1UL << 31) | (0x898 UL << 16) | (0x2000 UL + 0xf80 UL)

        /// <summary>The requested D2D version is not supported.</summary>
		Direct2D_Error_UnsuportedVersion					= 0x88990010,

        /// <summary>An unknown win32 failure occurred.</summary>
		Direct2D_Error_Win32Error							= 0x88990019,

        /// <summary>Objects used together must be created from the same factory instance.</summary>
		Direct2D_Error_WrongFactory							= 0x88990012,

        /// <summary>The resource was realized on the wrong render target.</summary>
		Direct2D_Error_WrongResourceDomain					= 0x88990015,

        /// <summary>The object was not in the correct state to process the method.</summary>
		Direct2D_Error_WrongState							= 0x88990001,

        /// <summary>The supplied vector is vero.</summary>
		Direct2D_Error_ZeroVector							= 0x88990007,
    }
}