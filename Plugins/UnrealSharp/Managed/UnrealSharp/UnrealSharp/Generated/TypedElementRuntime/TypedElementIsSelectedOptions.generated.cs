using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TypedElementRuntime;

[UStruct]
public partial struct TypedElementIsSelectedOptions
{
    // BoolProperty /Script/TypedElementRuntime.TypedElementIsSelectedOptions:bAllowIndirect
    static readonly int bAllowIndirect_Offset;
    public bool AllowIndirect;
    
    
    public static readonly int NativeDataSize;
    static TypedElementIsSelectedOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TypedElementIsSelectedOptions");
        
        bAllowIndirect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowIndirect");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TypedElementIsSelectedOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            AllowIndirect = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowIndirect_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowIndirect_Offset), 0, null, AllowIndirect);
        }
    }
}

public static class TypedElementIsSelectedOptionsMarshaler
{
    public static TypedElementIsSelectedOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TypedElementIsSelectedOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TypedElementIsSelectedOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TypedElementIsSelectedOptions.NativeDataSize;
    }
}