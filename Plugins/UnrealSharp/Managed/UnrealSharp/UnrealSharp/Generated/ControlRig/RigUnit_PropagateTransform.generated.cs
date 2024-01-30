using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_PropagateTransform
{
    // StructProperty /Script/ControlRig.RigUnit_PropagateTransform:Item
    static readonly int Item_Offset;
    public UnrealSharp.ControlRig.RigElementKey Item;
    
    // BoolProperty /Script/ControlRig.RigUnit_PropagateTransform:bRecomputeGlobal
    static readonly int bRecomputeGlobal_Offset;
    public bool RecomputeGlobal;
    
    // BoolProperty /Script/ControlRig.RigUnit_PropagateTransform:bApplyToChildren
    static readonly int bApplyToChildren_Offset;
    public bool ApplyToChildren;
    
    // BoolProperty /Script/ControlRig.RigUnit_PropagateTransform:bRecursive
    static readonly int bRecursive_Offset;
    public bool Recursive;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_PropagateTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_PropagateTransform");
        
        Item_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Item");
        bRecomputeGlobal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecomputeGlobal");
        bApplyToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bApplyToChildren");
        bRecursive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bRecursive");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_PropagateTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Item = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Item_Offset), 0, null);
            RecomputeGlobal = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecomputeGlobal_Offset), 0, null);
            ApplyToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bApplyToChildren_Offset), 0, null);
            Recursive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bRecursive_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Item_Offset), 0, null, Item);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecomputeGlobal_Offset), 0, null, RecomputeGlobal);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bApplyToChildren_Offset), 0, null, ApplyToChildren);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bRecursive_Offset), 0, null, Recursive);
        }
    }
}

public static class RigUnit_PropagateTransformMarshaler
{
    public static RigUnit_PropagateTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_PropagateTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_PropagateTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_PropagateTransform.NativeDataSize;
    }
}