using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UStruct]
public partial struct DatasmithRetessellationOptions
{
    // EnumProperty /Script/DatasmithContent.DatasmithRetessellationOptions:RetessellationRule
    static readonly int RetessellationRule_Offset;
    public UnrealSharp.DatasmithContent.EDatasmithCADRetessellationRule RetessellationRule;
    
    
    public static readonly int NativeDataSize;
    static DatasmithRetessellationOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DatasmithRetessellationOptions");
        
        RetessellationRule_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RetessellationRule");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DatasmithRetessellationOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            RetessellationRule = BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithCADRetessellationRule>.FromNative(IntPtr.Add(InNativeStruct, RetessellationRule_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.DatasmithContent.EDatasmithCADRetessellationRule>.ToNative(IntPtr.Add(Buffer, RetessellationRule_Offset), 0, null, RetessellationRule);
        }
    }
}

public static class DatasmithRetessellationOptionsMarshaler
{
    public static DatasmithRetessellationOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DatasmithRetessellationOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DatasmithRetessellationOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DatasmithRetessellationOptions.NativeDataSize;
    }
}