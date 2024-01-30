using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_MultiFABRIK
{
    // NameProperty /Script/ControlRig.RigUnit_MultiFABRIK:RootBone
    static readonly int RootBone_Offset;
    public Name RootBone;
    
    // FloatProperty /Script/ControlRig.RigUnit_MultiFABRIK:Precision
    static readonly int Precision_Offset;
    public float Precision;
    
    // BoolProperty /Script/ControlRig.RigUnit_MultiFABRIK:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // IntProperty /Script/ControlRig.RigUnit_MultiFABRIK:MaxIterations
    static readonly int MaxIterations_Offset;
    public int MaxIterations;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_MultiFABRIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_MultiFABRIK");
        
        RootBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RootBone");
        Precision_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Precision");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        MaxIterations_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxIterations");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_MultiFABRIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            RootBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, RootBone_Offset), 0, null);
            Precision = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Precision_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            MaxIterations = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MaxIterations_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, RootBone_Offset), 0, null, RootBone);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Precision_Offset), 0, null, Precision);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MaxIterations_Offset), 0, null, MaxIterations);
        }
    }
}

public static class RigUnit_MultiFABRIKMarshaler
{
    public static RigUnit_MultiFABRIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_MultiFABRIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_MultiFABRIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_MultiFABRIK.NativeDataSize;
    }
}