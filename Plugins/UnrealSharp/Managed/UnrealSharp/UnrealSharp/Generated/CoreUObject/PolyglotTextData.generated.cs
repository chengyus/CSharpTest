using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct PolyglotTextData
{
    // EnumProperty /Script/CoreUObject.PolyglotTextData:Category
    static readonly int Category_Offset;
    public UnrealSharp.CoreUObject.ELocalizedTextSourceCategory Category;
    
    // BoolProperty /Script/CoreUObject.PolyglotTextData:bIsMinimalPatch
    static readonly int bIsMinimalPatch_Offset;
    public bool IsMinimalPatch;
    
    
    public static readonly int NativeDataSize;
    static PolyglotTextData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PolyglotTextData");
        
        Category_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Category");
        bIsMinimalPatch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsMinimalPatch");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PolyglotTextData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Category = BlittableMarshaller<UnrealSharp.CoreUObject.ELocalizedTextSourceCategory>.FromNative(IntPtr.Add(InNativeStruct, Category_Offset), 0, null);
            IsMinimalPatch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsMinimalPatch_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.ELocalizedTextSourceCategory>.ToNative(IntPtr.Add(Buffer, Category_Offset), 0, null, Category);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsMinimalPatch_Offset), 0, null, IsMinimalPatch);
        }
    }
}

public static class PolyglotTextDataMarshaler
{
    public static PolyglotTextData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PolyglotTextData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PolyglotTextData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PolyglotTextData.NativeDataSize;
    }
}