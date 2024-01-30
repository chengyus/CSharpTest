using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UStruct]
public partial struct PythonLogOutputEntry
{
    // EnumProperty /Script/PythonScriptPlugin.PythonLogOutputEntry:Type
    static readonly int Type_Offset;
    public UnrealSharp.PythonScriptPlugin.EPythonLogOutputType Type;
    
    
    public static readonly int NativeDataSize;
    static PythonLogOutputEntry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PythonLogOutputEntry");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PythonLogOutputEntry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.PythonScriptPlugin.EPythonLogOutputType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.PythonScriptPlugin.EPythonLogOutputType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class PythonLogOutputEntryMarshaler
{
    public static PythonLogOutputEntry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PythonLogOutputEntry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PythonLogOutputEntry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PythonLogOutputEntry.NativeDataSize;
    }
}