using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_MakeDynamicAdditive
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive:Base
    static readonly int Base_Offset;
    public UnrealSharp.Engine.PoseLink Base;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive:Additive
    static readonly int Additive_Offset;
    public UnrealSharp.Engine.PoseLink Additive;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_MakeDynamicAdditive:bMeshSpaceAdditive
    static readonly int bMeshSpaceAdditive_Offset;
    public bool MeshSpaceAdditive;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_MakeDynamicAdditive()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_MakeDynamicAdditive");
        
        Base_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Base");
        Additive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Additive");
        bMeshSpaceAdditive_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMeshSpaceAdditive");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_MakeDynamicAdditive(IntPtr InNativeStruct)
    {
        unsafe
        {
            Base = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Base_Offset), 0, null);
            Additive = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Additive_Offset), 0, null);
            MeshSpaceAdditive = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMeshSpaceAdditive_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Base_Offset), 0, null, Base);
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Additive_Offset), 0, null, Additive);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMeshSpaceAdditive_Offset), 0, null, MeshSpaceAdditive);
        }
    }
}

public static class AnimNode_MakeDynamicAdditiveMarshaler
{
    public static AnimNode_MakeDynamicAdditive FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_MakeDynamicAdditive(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_MakeDynamicAdditive obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_MakeDynamicAdditive.NativeDataSize;
    }
}