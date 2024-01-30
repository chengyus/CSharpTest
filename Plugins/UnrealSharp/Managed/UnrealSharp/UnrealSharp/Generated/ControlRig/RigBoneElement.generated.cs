using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigBoneElement
{
    // EnumProperty /Script/ControlRig.RigBoneElement:BoneType
    static readonly int BoneType_Offset;
    public UnrealSharp.ControlRig.ERigBoneType BoneType;
    
    
    public static readonly int NativeDataSize;
    static RigBoneElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigBoneElement");
        
        BoneType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigBoneElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            BoneType = BlittableMarshaller<UnrealSharp.ControlRig.ERigBoneType>.FromNative(IntPtr.Add(InNativeStruct, BoneType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigBoneType>.ToNative(IntPtr.Add(Buffer, BoneType_Offset), 0, null, BoneType);
        }
    }
}

public static class RigBoneElementMarshaler
{
    public static RigBoneElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigBoneElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigBoneElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigBoneElement.NativeDataSize;
    }
}