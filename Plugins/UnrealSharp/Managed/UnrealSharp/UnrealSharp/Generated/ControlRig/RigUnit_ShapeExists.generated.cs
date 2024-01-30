using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ShapeExists
{
    // NameProperty /Script/ControlRig.RigUnit_ShapeExists:ShapeName
    static readonly int ShapeName_Offset;
    public Name ShapeName;
    
    // BoolProperty /Script/ControlRig.RigUnit_ShapeExists:Result
    static readonly int Result_Offset;
    public bool Result;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ShapeExists()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ShapeExists");
        
        ShapeName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeName");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ShapeExists(IntPtr InNativeStruct)
    {
        unsafe
        {
            ShapeName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ShapeName_Offset), 0, null);
            Result = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ShapeName_Offset), 0, null, ShapeName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigUnit_ShapeExistsMarshaler
{
    public static RigUnit_ShapeExists FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ShapeExists(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ShapeExists obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ShapeExists.NativeDataSize;
    }
}