using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetShapeTransform
{
    // NameProperty /Script/ControlRig.RigUnit_SetShapeTransform:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // StructProperty /Script/ControlRig.RigUnit_SetShapeTransform:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetShapeTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetShapeTransform");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetShapeTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class RigUnit_SetShapeTransformMarshaler
{
    public static RigUnit_SetShapeTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetShapeTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetShapeTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetShapeTransform.NativeDataSize;
    }
}