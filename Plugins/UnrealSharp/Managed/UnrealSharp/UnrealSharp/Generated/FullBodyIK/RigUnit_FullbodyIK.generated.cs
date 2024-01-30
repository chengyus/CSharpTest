using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FullBodyIK;

[UStruct]
public partial struct RigUnit_FullbodyIK
{
    // StructProperty /Script/FullBodyIK.RigUnit_FullbodyIK:Root
    static readonly int Root_Offset;
    public UnrealSharp.ControlRig.RigElementKey Root;
    
    // StructProperty /Script/FullBodyIK.RigUnit_FullbodyIK:SolverProperty
    static readonly int SolverProperty_Offset;
    public UnrealSharp.FullBodyIK.SolverInput SolverProperty;
    
    // StructProperty /Script/FullBodyIK.RigUnit_FullbodyIK:MotionProperty
    static readonly int MotionProperty_Offset;
    public UnrealSharp.FullBodyIK.MotionProcessInput MotionProperty;
    
    // BoolProperty /Script/FullBodyIK.RigUnit_FullbodyIK:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    // StructProperty /Script/FullBodyIK.RigUnit_FullbodyIK:DebugOption
    static readonly int DebugOption_Offset;
    public UnrealSharp.FullBodyIK.FBIKDebugOption DebugOption;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_FullbodyIK()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_FullbodyIK");
        
        Root_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Root");
        SolverProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SolverProperty");
        MotionProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MotionProperty");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        DebugOption_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugOption");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_FullbodyIK(IntPtr InNativeStruct)
    {
        unsafe
        {
            Root = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Root_Offset), 0, null);
            SolverProperty = UnrealSharp.FullBodyIK.SolverInputMarshaler.FromNative(IntPtr.Add(InNativeStruct, SolverProperty_Offset), 0, null);
            MotionProperty = UnrealSharp.FullBodyIK.MotionProcessInputMarshaler.FromNative(IntPtr.Add(InNativeStruct, MotionProperty_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
            DebugOption = UnrealSharp.FullBodyIK.FBIKDebugOptionMarshaler.FromNative(IntPtr.Add(InNativeStruct, DebugOption_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Root_Offset), 0, null, Root);
            UnrealSharp.FullBodyIK.SolverInputMarshaler.ToNative(IntPtr.Add(Buffer, SolverProperty_Offset), 0, null, SolverProperty);
            UnrealSharp.FullBodyIK.MotionProcessInputMarshaler.ToNative(IntPtr.Add(Buffer, MotionProperty_Offset), 0, null, MotionProperty);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
            UnrealSharp.FullBodyIK.FBIKDebugOptionMarshaler.ToNative(IntPtr.Add(Buffer, DebugOption_Offset), 0, null, DebugOption);
        }
    }
}

public static class RigUnit_FullbodyIKMarshaler
{
    public static RigUnit_FullbodyIK FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_FullbodyIK(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_FullbodyIK obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_FullbodyIK.NativeDataSize;
    }
}