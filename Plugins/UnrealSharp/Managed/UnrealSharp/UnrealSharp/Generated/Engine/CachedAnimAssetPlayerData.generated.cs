using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CachedAnimAssetPlayerData
{
    // NameProperty /Script/Engine.CachedAnimAssetPlayerData:StateMachineName
    static readonly int StateMachineName_Offset;
    public Name StateMachineName;
    
    // NameProperty /Script/Engine.CachedAnimAssetPlayerData:StateName
    static readonly int StateName_Offset;
    public Name StateName;
    
    
    public static readonly int NativeDataSize;
    static CachedAnimAssetPlayerData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CachedAnimAssetPlayerData");
        
        StateMachineName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StateMachineName");
        StateName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StateName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CachedAnimAssetPlayerData(IntPtr InNativeStruct)
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

public static class CachedAnimAssetPlayerDataMarshaler
{
    public static CachedAnimAssetPlayerData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CachedAnimAssetPlayerData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CachedAnimAssetPlayerData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CachedAnimAssetPlayerData.NativeDataSize;
    }
}