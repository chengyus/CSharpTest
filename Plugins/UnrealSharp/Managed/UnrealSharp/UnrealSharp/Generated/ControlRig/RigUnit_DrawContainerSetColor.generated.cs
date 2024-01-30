using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_DrawContainerSetColor
{
    // NameProperty /Script/ControlRig.RigUnit_DrawContainerSetColor:InstructionName
    static readonly int InstructionName_Offset;
    public Name InstructionName;
    
    // StructProperty /Script/ControlRig.RigUnit_DrawContainerSetColor:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.LinearColor Color;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_DrawContainerSetColor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_DrawContainerSetColor");
        
        InstructionName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InstructionName");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_DrawContainerSetColor(IntPtr InNativeStruct)
    {
        unsafe
        {
            InstructionName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, InstructionName_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, InstructionName_Offset), 0, null, InstructionName);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
        }
    }
}

public static class RigUnit_DrawContainerSetColorMarshaler
{
    public static RigUnit_DrawContainerSetColor FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_DrawContainerSetColor(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_DrawContainerSetColor obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_DrawContainerSetColor.NativeDataSize;
    }
}