using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SubobjectDataInterface;

[UStruct]
public partial struct ReparentSubobjectParams
{
    // StructProperty /Script/SubobjectDataInterface.ReparentSubobjectParams:NewParentHandle
    static readonly int NewParentHandle_Offset;
    public UnrealSharp.SubobjectDataInterface.SubobjectDataHandle NewParentHandle;
    
    // ObjectProperty /Script/SubobjectDataInterface.ReparentSubobjectParams:BlueprintContext
    static readonly int BlueprintContext_Offset;
    public UnrealSharp.Engine.Blueprint BlueprintContext;
    
    // ObjectProperty /Script/SubobjectDataInterface.ReparentSubobjectParams:ActorPreviewContext
    static readonly int ActorPreviewContext_Offset;
    public UnrealSharp.Engine.Actor ActorPreviewContext;
    
    
    public static readonly int NativeDataSize;
    static ReparentSubobjectParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ReparentSubobjectParams");
        
        NewParentHandle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NewParentHandle");
        BlueprintContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlueprintContext");
        ActorPreviewContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActorPreviewContext");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ReparentSubobjectParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            NewParentHandle = UnrealSharp.SubobjectDataInterface.SubobjectDataHandleMarshaler.FromNative(IntPtr.Add(InNativeStruct, NewParentHandle_Offset), 0, null);
            BlueprintContext = ObjectMarshaller<UnrealSharp.Engine.Blueprint>.FromNative(IntPtr.Add(InNativeStruct, BlueprintContext_Offset), 0, null);
            ActorPreviewContext = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, ActorPreviewContext_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SubobjectDataInterface.SubobjectDataHandleMarshaler.ToNative(IntPtr.Add(Buffer, NewParentHandle_Offset), 0, null, NewParentHandle);
            ObjectMarshaller<UnrealSharp.Engine.Blueprint>.ToNative(IntPtr.Add(Buffer, BlueprintContext_Offset), 0, null, BlueprintContext);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, ActorPreviewContext_Offset), 0, null, ActorPreviewContext);
        }
    }
}

public static class ReparentSubobjectParamsMarshaler
{
    public static ReparentSubobjectParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ReparentSubobjectParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ReparentSubobjectParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ReparentSubobjectParams.NativeDataSize;
    }
}