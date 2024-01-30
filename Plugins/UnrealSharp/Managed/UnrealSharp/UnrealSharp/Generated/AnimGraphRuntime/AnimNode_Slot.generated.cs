using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_Slot
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_Slot:Source
    static readonly int Source_Offset;
    public UnrealSharp.Engine.PoseLink Source;
    
    // NameProperty /Script/AnimGraphRuntime.AnimNode_Slot:SlotName
    static readonly int SlotName_Offset;
    public Name SlotName;
    
    // BoolProperty /Script/AnimGraphRuntime.AnimNode_Slot:bAlwaysUpdateSourcePose
    static readonly int bAlwaysUpdateSourcePose_Offset;
    public bool AlwaysUpdateSourcePose;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_Slot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_Slot");
        
        Source_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Source");
        SlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SlotName");
        bAlwaysUpdateSourcePose_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlwaysUpdateSourcePose");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_Slot(IntPtr InNativeStruct)
    {
        unsafe
        {
            Source = UnrealSharp.Engine.PoseLinkMarshaler.FromNative(IntPtr.Add(InNativeStruct, Source_Offset), 0, null);
            SlotName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SlotName_Offset), 0, null);
            AlwaysUpdateSourcePose = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAlwaysUpdateSourcePose_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.PoseLinkMarshaler.ToNative(IntPtr.Add(Buffer, Source_Offset), 0, null, Source);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SlotName_Offset), 0, null, SlotName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAlwaysUpdateSourcePose_Offset), 0, null, AlwaysUpdateSourcePose);
        }
    }
}

public static class AnimNode_SlotMarshaler
{
    public static AnimNode_Slot FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_Slot(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_Slot obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_Slot.NativeDataSize;
    }
}