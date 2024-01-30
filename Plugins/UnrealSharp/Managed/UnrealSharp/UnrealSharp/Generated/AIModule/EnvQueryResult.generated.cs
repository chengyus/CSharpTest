using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct EnvQueryResult
{
    // ClassProperty /Script/AIModule.EnvQueryResult:ItemType
    static readonly int ItemType_Offset;
    public SubclassOf<UnrealSharp.AIModule.EnvQueryItemType> ItemType;
    
    // IntProperty /Script/AIModule.EnvQueryResult:OptionIndex
    static readonly int OptionIndex_Offset;
    public int OptionIndex;
    
    // IntProperty /Script/AIModule.EnvQueryResult:QueryID
    static readonly int QueryID_Offset;
    public int QueryID;
    
    
    public static readonly int NativeDataSize;
    static EnvQueryResult()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EnvQueryResult");
        
        ItemType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ItemType");
        OptionIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OptionIndex");
        QueryID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "QueryID");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EnvQueryResult(IntPtr InNativeStruct)
    {
        unsafe
        {
            ItemType = SubclassOfMarshaller<UnrealSharp.AIModule.EnvQueryItemType>.FromNative(IntPtr.Add(InNativeStruct, ItemType_Offset), 0, null);
            OptionIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, OptionIndex_Offset), 0, null);
            QueryID = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, QueryID_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.AIModule.EnvQueryItemType>.ToNative(IntPtr.Add(Buffer, ItemType_Offset), 0, null, ItemType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, OptionIndex_Offset), 0, null, OptionIndex);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, QueryID_Offset), 0, null, QueryID);
        }
    }
}

public static class EnvQueryResultMarshaler
{
    public static EnvQueryResult FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EnvQueryResult(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EnvQueryResult obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EnvQueryResult.NativeDataSize;
    }
}