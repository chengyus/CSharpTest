using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerCore;

[UStruct]
public partial struct SequencerViewModelScriptingStruct
{
    // NameProperty /Script/SequencerCore.SequencerViewModelScriptingStruct:Type
    static readonly int Type_Offset;
    public Name Type;
    
    
    public static readonly int NativeDataSize;
    static SequencerViewModelScriptingStruct()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SequencerViewModelScriptingStruct");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SequencerViewModelScriptingStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class SequencerViewModelScriptingStructMarshaler
{
    public static SequencerViewModelScriptingStruct FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SequencerViewModelScriptingStruct(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SequencerViewModelScriptingStruct obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SequencerViewModelScriptingStruct.NativeDataSize;
    }
}