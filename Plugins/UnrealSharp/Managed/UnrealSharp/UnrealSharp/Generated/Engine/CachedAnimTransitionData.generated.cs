using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CachedAnimTransitionData
{
    // NameProperty /Script/Engine.CachedAnimTransitionData:StateMachineName
    static readonly int StateMachineName_Offset;
    public Name StateMachineName;
    
    // NameProperty /Script/Engine.CachedAnimTransitionData:FromStateName
    static readonly int FromStateName_Offset;
    public Name FromStateName;
    
    // NameProperty /Script/Engine.CachedAnimTransitionData:ToStateName
    static readonly int ToStateName_Offset;
    public Name ToStateName;
    
    
    public static readonly int NativeDataSize;
    static CachedAnimTransitionData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CachedAnimTransitionData");
        
        StateMachineName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StateMachineName");
        FromStateName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FromStateName");
        ToStateName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToStateName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CachedAnimTransitionData(IntPtr InNativeStruct)
    {
        unsafe
        {
            StateMachineName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StateMachineName_Offset), 0, null);
            FromStateName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, FromStateName_Offset), 0, null);
            ToStateName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ToStateName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StateMachineName_Offset), 0, null, StateMachineName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, FromStateName_Offset), 0, null, FromStateName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ToStateName_Offset), 0, null, ToStateName);
        }
    }
}

public static class CachedAnimTransitionDataMarshaler
{
    public static CachedAnimTransitionData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CachedAnimTransitionData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CachedAnimTransitionData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CachedAnimTransitionData.NativeDataSize;
    }
}