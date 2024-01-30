using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct LensImperfectionSettings
{
    // ObjectProperty /Script/Engine.LensImperfectionSettings:DirtMask
    static readonly int DirtMask_Offset;
    public UnrealSharp.Engine.Texture DirtMask;
    
    // FloatProperty /Script/Engine.LensImperfectionSettings:DirtMaskIntensity
    static readonly int DirtMaskIntensity_Offset;
    public float DirtMaskIntensity;
    
    // StructProperty /Script/Engine.LensImperfectionSettings:DirtMaskTint
    static readonly int DirtMaskTint_Offset;
    public UnrealSharp.CoreUObject.LinearColor DirtMaskTint;
    
    
    public static readonly int NativeDataSize;
    static LensImperfectionSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("LensImperfectionSettings");
        
        DirtMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DirtMask");
        DirtMaskIntensity_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DirtMaskIntensity");
        DirtMaskTint_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DirtMaskTint");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public LensImperfectionSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DirtMask = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, DirtMask_Offset), 0, null);
            DirtMaskIntensity = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DirtMaskIntensity_Offset), 0, null);
            DirtMaskTint = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, DirtMaskTint_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, DirtMask_Offset), 0, null, DirtMask);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DirtMaskIntensity_Offset), 0, null, DirtMaskIntensity);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, DirtMaskTint_Offset), 0, null, DirtMaskTint);
        }
    }
}

public static class LensImperfectionSettingsMarshaler
{
    public static LensImperfectionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new LensImperfectionSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, LensImperfectionSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return LensImperfectionSettings.NativeDataSize;
    }
}