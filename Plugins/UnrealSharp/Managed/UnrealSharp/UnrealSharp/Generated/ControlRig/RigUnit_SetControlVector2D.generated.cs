using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SetControlVector2D
{
    // NameProperty /Script/ControlRig.RigUnit_SetControlVector2D:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // FloatProperty /Script/ControlRig.RigUnit_SetControlVector2D:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // StructProperty /Script/ControlRig.RigUnit_SetControlVector2D:Vector
    static readonly int Vector_Offset;
    public System.DoubleNumerics.Vector2 Vector;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SetControlVector2D()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SetControlVector2D");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        Vector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Vector");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SetControlVector2D(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            Vector = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Vector_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Vector_Offset), 0, null, Vector);
        }
    }
}

public static class RigUnit_SetControlVector2DMarshaler
{
    public static RigUnit_SetControlVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SetControlVector2D(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SetControlVector2D obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SetControlVector2D.NativeDataSize;
    }
}