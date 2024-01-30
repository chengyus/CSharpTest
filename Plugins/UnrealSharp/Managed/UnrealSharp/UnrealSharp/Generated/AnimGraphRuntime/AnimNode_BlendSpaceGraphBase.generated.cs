using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_BlendSpaceGraphBase
{
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:X
    static readonly int X_Offset;
    public float X;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:Y
    static readonly int Y_Offset;
    public float Y;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:GroupName
    static readonly int GroupName_Offset;
    public Name GroupName;
    
    // ByteProperty /Script/AnimGraphRuntime.AnimNode_BlendSpaceGraphBase:GroupRole
    static readonly int GroupRole_Offset;
    public UnrealSharp.Engine.EAnimGroupRole GroupRole;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_BlendSpaceGraphBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_BlendSpaceGraphBase");
        
        X_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "X");
        Y_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Y");
        GroupName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GroupName");
        GroupRole_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GroupRole");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_BlendSpaceGraphBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            X = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, X_Offset), 0, null);
            Y = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Y_Offset), 0, null);
            GroupName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, GroupName_Offset), 0, null);
            GroupRole = BlittableMarshaller<UnrealSharp.Engine.EAnimGroupRole>.FromNative(IntPtr.Add(InNativeStruct, GroupRole_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, X_Offset), 0, null, X);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Y_Offset), 0, null, Y);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, GroupName_Offset), 0, null, GroupName);
            BlittableMarshaller<UnrealSharp.Engine.EAnimGroupRole>.ToNative(IntPtr.Add(Buffer, GroupRole_Offset), 0, null, GroupRole);
        }
    }
}

public static class AnimNode_BlendSpaceGraphBaseMarshaler
{
    public static AnimNode_BlendSpaceGraphBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_BlendSpaceGraphBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_BlendSpaceGraphBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_BlendSpaceGraphBase.NativeDataSize;
    }
}