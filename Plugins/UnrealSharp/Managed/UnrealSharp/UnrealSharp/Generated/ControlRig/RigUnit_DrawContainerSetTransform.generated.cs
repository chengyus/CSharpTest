using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DrawContainerSetTransform
{
    // NameProperty /Script/ControlRig.RigUnit_DrawContainerSetTransform:InstructionName
    static readonly int InstructionName_Offset;
    public Name InstructionName;
    
    // StructProperty /Script/ControlRig.RigUnit_DrawContainerSetTransform:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DrawContainerSetTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DrawContainerSetTransform");
        
        InstructionName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InstructionName");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DrawContainerSetTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            InstructionName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, InstructionName_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, InstructionName_Offset), 0, null, InstructionName);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class RigUnit_DrawContainerSetTransformMarshaler
{
    public static RigUnit_DrawContainerSetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DrawContainerSetTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DrawContainerSetTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DrawContainerSetTransform.NativeDataSize;
    }
}