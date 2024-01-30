using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AlphaBlendArgs
{
    // ObjectProperty /Script/Engine.AlphaBlendArgs:CustomCurve
    static readonly int CustomCurve_Offset;
    public UnrealSharp.Engine.CurveFloat CustomCurve;
    
    // FloatProperty /Script/Engine.AlphaBlendArgs:BlendTime
    static readonly int BlendTime_Offset;
    public float BlendTime;
    
    // EnumProperty /Script/Engine.AlphaBlendArgs:BlendOption
    static readonly int BlendOption_Offset;
    public UnrealSharp.Engine.EAlphaBlendOption BlendOption;
    
    
    public static readonly int NativeDataSize;
    static AlphaBlendArgs()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AlphaBlendArgs");
        
        CustomCurve_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomCurve");
        BlendTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendTime");
        BlendOption_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendOption");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AlphaBlendArgs(IntPtr InNativeStruct)
    {
        unsafe
        {
            CustomCurve = ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.FromNative(IntPtr.Add(InNativeStruct, CustomCurve_Offset), 0, null);
            BlendTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendTime_Offset), 0, null);
            BlendOption = BlittableMarshaller<UnrealSharp.Engine.EAlphaBlendOption>.FromNative(IntPtr.Add(InNativeStruct, BlendOption_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.CurveFloat>.ToNative(IntPtr.Add(Buffer, CustomCurve_Offset), 0, null, CustomCurve);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendTime_Offset), 0, null, BlendTime);
            BlittableMarshaller<UnrealSharp.Engine.EAlphaBlendOption>.ToNative(IntPtr.Add(Buffer, BlendOption_Offset), 0, null, BlendOption);
        }
    }
}

public static class AlphaBlendArgsMarshaler
{
    public static AlphaBlendArgs FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AlphaBlendArgs(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AlphaBlendArgs obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AlphaBlendArgs.NativeDataSize;
    }
}