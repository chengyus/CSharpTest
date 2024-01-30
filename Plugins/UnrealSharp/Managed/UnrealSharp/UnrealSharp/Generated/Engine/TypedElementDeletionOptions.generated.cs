using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct TypedElementDeletionOptions
{
    // BoolProperty /Script/Engine.TypedElementDeletionOptions:bVerifyDeletionCanHappen
    static readonly int bVerifyDeletionCanHappen_Offset;
    public bool VerifyDeletionCanHappen;
    
    // BoolProperty /Script/Engine.TypedElementDeletionOptions:bWarnAboutReferences
    static readonly int bWarnAboutReferences_Offset;
    public bool WarnAboutReferences;
    
    // BoolProperty /Script/Engine.TypedElementDeletionOptions:bWarnAboutSoftReferences
    static readonly int bWarnAboutSoftReferences_Offset;
    public bool WarnAboutSoftReferences;
    
    
    public static readonly int NativeDataSize;
    static TypedElementDeletionOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TypedElementDeletionOptions");
        
        bVerifyDeletionCanHappen_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bVerifyDeletionCanHappen");
        bWarnAboutReferences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWarnAboutReferences");
        bWarnAboutSoftReferences_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWarnAboutSoftReferences");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TypedElementDeletionOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            VerifyDeletionCanHappen = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bVerifyDeletionCanHappen_Offset), 0, null);
            WarnAboutReferences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bWarnAboutReferences_Offset), 0, null);
            WarnAboutSoftReferences = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bWarnAboutSoftReferences_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bVerifyDeletionCanHappen_Offset), 0, null, VerifyDeletionCanHappen);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bWarnAboutReferences_Offset), 0, null, WarnAboutReferences);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bWarnAboutSoftReferences_Offset), 0, null, WarnAboutSoftReferences);
        }
    }
}

public static class TypedElementDeletionOptionsMarshaler
{
    public static TypedElementDeletionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TypedElementDeletionOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TypedElementDeletionOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TypedElementDeletionOptions.NativeDataSize;
    }
}