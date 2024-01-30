using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct HardwareDeviceIdentifier
{
    // NameProperty /Script/Engine.HardwareDeviceIdentifier:InputClassName
    static readonly int InputClassName_Offset;
    public Name InputClassName;
    
    // NameProperty /Script/Engine.HardwareDeviceIdentifier:HardwareDeviceIdentifier
    static readonly int HardwareDeviceIdentifier_Offset;
    public Name K2_HardwareDeviceIdentifier;
    
    // EnumProperty /Script/Engine.HardwareDeviceIdentifier:PrimaryDeviceType
    static readonly int PrimaryDeviceType_Offset;
    public UnrealSharp.Engine.EHardwareDevicePrimaryType PrimaryDeviceType;
    
    // IntProperty /Script/Engine.HardwareDeviceIdentifier:SupportedFeaturesMask
    static readonly int SupportedFeaturesMask_Offset;
    public int SupportedFeaturesMask;
    
    
    public static readonly int NativeDataSize;
    static HardwareDeviceIdentifier()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("HardwareDeviceIdentifier");
        
        InputClassName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InputClassName");
        HardwareDeviceIdentifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HardwareDeviceIdentifier");
        PrimaryDeviceType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PrimaryDeviceType");
        SupportedFeaturesMask_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SupportedFeaturesMask");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public HardwareDeviceIdentifier(IntPtr InNativeStruct)
    {
        unsafe
        {
            InputClassName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, InputClassName_Offset), 0, null);
            K2_HardwareDeviceIdentifier = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, HardwareDeviceIdentifier_Offset), 0, null);
            PrimaryDeviceType = BlittableMarshaller<UnrealSharp.Engine.EHardwareDevicePrimaryType>.FromNative(IntPtr.Add(InNativeStruct, PrimaryDeviceType_Offset), 0, null);
            SupportedFeaturesMask = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SupportedFeaturesMask_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, InputClassName_Offset), 0, null, InputClassName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, HardwareDeviceIdentifier_Offset), 0, null, K2_HardwareDeviceIdentifier);
            BlittableMarshaller<UnrealSharp.Engine.EHardwareDevicePrimaryType>.ToNative(IntPtr.Add(Buffer, PrimaryDeviceType_Offset), 0, null, PrimaryDeviceType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SupportedFeaturesMask_Offset), 0, null, SupportedFeaturesMask);
        }
    }
}

public static class HardwareDeviceIdentifierMarshaler
{
    public static HardwareDeviceIdentifier FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new HardwareDeviceIdentifier(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, HardwareDeviceIdentifier obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return HardwareDeviceIdentifier.NativeDataSize;
    }
}