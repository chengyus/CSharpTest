using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CachedAnimRelevancyData
{
    // NameProperty /Script/Engine.CachedAnimRelevancyData:StateMachineName
    static readonly int StateMachineName_Offset;
    public Name StateMachineName;
    
    // NameProperty /Script/Engine.CachedAnimRelevancyData:StateName
    static readonly int StateName_Offset;
    public Name StateName;
    
    
    public static readonly int NativeDataSize;
    static CachedAnimRelevancyData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CachedAnimRelevancyData");
        
        StateMachineName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StateMachineName");
        StateName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StateName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CachedAnimRelevancyData(IntPtr InNativeStruct)
    {
        unsafe
        {
            StateMachineName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StateMachineName_Offset), 0, null);
            StateName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StateName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StateMachineName_Offset), 0, null, StateMachineName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StateName_Offset), 0, null, StateName);
        }
    }
}

public static class CachedAnimRelevancyDataMarshaler
{
    public static CachedAnimRelevancyData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CachedAnimRelevancyData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CachedAnimRelevancyData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CachedAnimRelevancyData.NativeDataSize;
    }
}