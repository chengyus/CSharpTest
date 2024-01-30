using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ProjectTransformToNewParent
{
    // StructProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:Child
    static readonly int Child_Offset;
    public UnrealSharp.ControlRig.RigElementKey Child;
    
    // BoolProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:bChildInitial
    static readonly int bChildInitial_Offset;
    public bool ChildInitial;
    
    // StructProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:OldParent
    static readonly int OldParent_Offset;
    public UnrealSharp.ControlRig.RigElementKey OldParent;
    
    // BoolProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:bOldParentInitial
    static readonly int bOldParentInitial_Offset;
    public bool OldParentInitial;
    
    // StructProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:NewParent
    static readonly int NewParent_Offset;
    public UnrealSharp.ControlRig.RigElementKey NewParent;
    
    // BoolProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:bNewParentInitial
    static readonly int bNewParentInitial_Offset;
    public bool NewParentInitial;
    
    // StructProperty /Script/ControlRig.RigUnit_ProjectTransformToNewParent:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ProjectTransformToNewParent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ProjectTransformToNewParent");
        
        Child_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Child");
        bChildInitial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bChildInitial");
        OldParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OldParent");
        bOldParentInitial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOldParentInitial");
        NewParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NewParent");
        bNewParentInitial_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNewParentInitial");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ProjectTransformToNewParent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Child = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Child_Offset), 0, null);
            ChildInitial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bChildInitial_Offset), 0, null);
            OldParent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, OldParent_Offset), 0, null);
            OldParentInitial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOldParentInitial_Offset), 0, null);
            NewParent = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, NewParent_Offset), 0, null);
            NewParentInitial = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNewParentInitial_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Child_Offset), 0, null, Child);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bChildInitial_Offset), 0, null, ChildInitial);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, OldParent_Offset), 0, null, OldParent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOldParentInitial_Offset), 0, null, OldParentInitial);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, NewParent_Offset), 0, null, NewParent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNewParentInitial_Offset), 0, null, NewParentInitial);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
        }
    }
}

public static class RigUnit_ProjectTransformToNewParentMarshaler
{
    public static RigUnit_ProjectTransformToNewParent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ProjectTransformToNewParent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ProjectTransformToNewParent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ProjectTransformToNewParent.NativeDataSize;
    }
}