using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DrawContainerSetThickness
{
    // NameProperty /Script/ControlRig.RigUnit_DrawContainerSetThickness:InstructionName
    static readonly int InstructionName_Offset;
    public Name InstructionName;
    
    // FloatProperty /Script/ControlRig.RigUnit_DrawContainerSetThickness:Thickness
    static readonly int Thickness_Offset;
    public float Thickness;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DrawContainerSetThickness()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DrawContainerSetThickness");
        
        InstructionName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InstructionName");
        Thickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Thickness");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DrawContainerSetThickness(IntPtr InNativeStruct)
    {
        unsafe
        {
            InstructionName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, InstructionName_Offset), 0, null);
            Thickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Thickness_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, InstructionName_Offset), 0, null, InstructionName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Thickness_Offset), 0, null, Thickness);
        }
    }
}

public static class RigUnit_DrawContainerSetThicknessMarshaler
{
    public static RigUnit_DrawContainerSetThickness FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DrawContainerSetThickness(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DrawContainerSetThickness obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DrawContainerSetThickness.NativeDataSize;
    }
}