using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_GetControlVector2D
{
    // NameProperty /Script/ControlRig.RigUnit_GetControlVector2D:Control
    static readonly int Control_Offset;
    public Name Control;
    
    // StructProperty /Script/ControlRig.RigUnit_GetControlVector2D:Vector
    static readonly int Vector_Offset;
    public System.DoubleNumerics.Vector2 Vector;
    
    // StructProperty /Script/ControlRig.RigUnit_GetControlVector2D:Minimum
    static readonly int Minimum_Offset;
    public System.DoubleNumerics.Vector2 Minimum;
    
    // StructProperty /Script/ControlRig.RigUnit_GetControlVector2D:Maximum
    static readonly int Maximum_Offset;
    public System.DoubleNumerics.Vector2 Maximum;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_GetControlVector2D()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_GetControlVector2D");
        
        Control_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Control");
        Vector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Vector");
        Minimum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Minimum");
        Maximum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Maximum");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_GetControlVector2D(IntPtr InNativeStruct)
    {
        unsafe
        {
            Control = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Control_Offset), 0, null);
            Vector = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Vector_Offset), 0, null);
            Minimum = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Minimum_Offset), 0, null);
            Maximum = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Maximum_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Control_Offset), 0, null, Control);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Vector_Offset), 0, null, Vector);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Minimum_Offset), 0, null, Minimum);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Maximum_Offset), 0, null, Maximum);
        }
    }
}

public static class RigUnit_GetControlVector2DMarshaler
{
    public static RigUnit_GetControlVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_GetControlVector2D(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_GetControlVector2D obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_GetControlVector2D.NativeDataSize;
    }
}