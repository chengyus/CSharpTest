using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct InputAlphaBoolBlend
{
    // FloatProperty /Script/Engine.InputAlphaBoolBlend:BlendInTime
    static readonly int BlendInTime_Offset;
    public float BlendInTime;
    
    // FloatProperty /Script/Engine.InputAlphaBoolBlend:BlendOutTime
    static readonly int BlendOutTime_Offset;
    public float BlendOutTime;
    
    // EnumProperty /Script/Engine.InputAlphaBoolBlend:BlendOption
    static readonly int BlendOption_Offset;
    public UnrealSharp.Engine.EAlphaBlendOption BlendOption;
    
    // ObjectProperty /Script/Engine.InputAlphaBoolBlend:CustomCurve
    static readonly int CustomCurve_Offset;
    public UnrealSharp.Engine.CurveFloat CustomCurve;
    
    
    public static readonly int NativeDataSize;
    static InputAlphaBoolBlend()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputAlphaBoolBlend");
        
        BlendInTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendInTime");
        BlendOutTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendOutTime");
        BlendOption_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendOption");
        CustomCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomCurve");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputAlphaBoolBlend(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlendInTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendInTime_Offset), 0, null);
            BlendOutTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendOutTime_Offset), 0, null);
            BlendOption = BlittableMarshaller<UnrealSharp.Engine.EAlphaBlendOption>.FromNative(IntPtr.Add(InNativeStruct, BlendOption_Offset), 0, null);
            CustomCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, CustomCurve_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendInTime_Offset), 0, null, BlendInTime);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendOutTime_Offset), 0, null, BlendOutTime);
            BlittableMarshaller<UnrealSharp.Engine.EAlphaBlendOption>.ToNative(IntPtr.Add(Buffer, BlendOption_Offset), 0, null, BlendOption);
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, CustomCurve_Offset), 0, null, CustomCurve);
        }
    }
}

public static class InputAlphaBoolBlendMarshaler
{
    public static InputAlphaBoolBlend FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputAlphaBoolBlend(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputAlphaBoolBlend obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputAlphaBoolBlend.NativeDataSize;
    }
}