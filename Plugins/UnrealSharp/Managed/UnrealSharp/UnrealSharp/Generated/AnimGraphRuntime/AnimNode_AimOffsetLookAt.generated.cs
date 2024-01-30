using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_AimOffsetLookAt
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:BasePose
    static readonly int BasePose_Offset;
    public UnrealSharp.Engine.PoseLink BasePose;
    
    // IntProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:LODThreshold
    static readonly int LODThreshold_Offset;
    public int LODThreshold;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:SourceSocketName
    static readonly int SourceSocketName_Offset;
    public Name SourceSocketName;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:PivotSocketName
    static readonly int PivotSocketName_Offset;
    public Name PivotSocketName;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:LookAtLocation
    static readonly int LookAtLocation_Offset;
    public System.DoubleNumerics.Vector3 LookAtLocation;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:SocketAxis
    static readonly int SocketAxis_Offset;
    public System.DoubleNumerics.Vector3 SocketAxis;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_AimOffsetLookAt:Alpha
    static readonly int Alpha_Offset;
    public float Alpha;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_AimOffsetLookAt()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_AimOffsetLookAt");
        
        BasePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BasePose");
        LODThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LODThreshold");
        SourceSocketName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SourceSocketName");
        PivotSocketName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PivotSocketName");
        LookAtLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LookAtLocation");
        SocketAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SocketAxis");
        Alpha_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Alpha");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_AimOffsetLookAt(IntPtr InNativeStruct)
    {
        unsafe
        {
            BasePose = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, BasePose_Offset), 0, null);
            LODThreshold = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, LODThreshold_Offset), 0, null);
            SourceSocketName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SourceSocketName_Offset), 0, null);
            PivotSocketName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PivotSocketName_Offset), 0, null);
            LookAtLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, LookAtLocation_Offset), 0, null);
            SocketAxis = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SocketAxis_Offset), 0, null);
            Alpha = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Alpha_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, BasePose_Offset), 0, null, BasePose);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, LODThreshold_Offset), 0, null, LODThreshold);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SourceSocketName_Offset), 0, null, SourceSocketName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PivotSocketName_Offset), 0, null, PivotSocketName);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, LookAtLocation_Offset), 0, null, LookAtLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SocketAxis_Offset), 0, null, SocketAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Alpha_Offset), 0, null, Alpha);
        }
    }
}

public static class AnimNode_AimOffsetLookAtMarshaler
{
    public static AnimNode_AimOffsetLookAt FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_AimOffsetLookAt(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_AimOffsetLookAt obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_AimOffsetLookAt.NativeDataSize;
    }
}