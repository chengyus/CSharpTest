using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_SlideChain
{
    // NameProperty /Script/ControlRig.RigUnit_SlideChain:StartBone
    static readonly int StartBone_Offset;
    public Name StartBone;
    
    // NameProperty /Script/ControlRig.RigUnit_SlideChain:EndBone
    static readonly int EndBone_Offset;
    public Name EndBone;
    
    // FloatProperty /Script/ControlRig.RigUnit_SlideChain:SlideAmount
    static readonly int SlideAmount_Offset;
    public float SlideAmount;
    
    // BoolProperty /Script/ControlRig.RigUnit_SlideChain:bPropagateToChildren
    static readonly int bPropagateToChildren_Offset;
    public bool PropagateToChildren;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_SlideChain()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_SlideChain");
        
        StartBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StartBone");
        EndBone_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EndBone");
        SlideAmount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SlideAmount");
        bPropagateToChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPropagateToChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_SlideChain(IntPtr InNativeStruct)
    {
        unsafe
        {
            StartBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StartBone_Offset), 0, null);
            EndBone = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, EndBone_Offset), 0, null);
            SlideAmount = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SlideAmount_Offset), 0, null);
            PropagateToChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPropagateToChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StartBone_Offset), 0, null, StartBone);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, EndBone_Offset), 0, null, EndBone);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SlideAmount_Offset), 0, null, SlideAmount);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPropagateToChildren_Offset), 0, null, PropagateToChildren);
        }
    }
}

public static class RigUnit_SlideChainMarshaler
{
    public static RigUnit_SlideChain FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_SlideChain(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_SlideChain obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_SlideChain.NativeDataSize;
    }
}