using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TypedElementRuntime;

[UStruct]
public partial struct TypedElementSelectionOptions
{
    // BoolProperty /Script/TypedElementRuntime.TypedElementSelectionOptions:bAllowHidden
    static readonly int bAllowHidden_Offset;
    public bool AllowHidden;
    
    // BoolProperty /Script/TypedElementRuntime.TypedElementSelectionOptions:bAllowGroups
    static readonly int bAllowGroups_Offset;
    public bool AllowGroups;
    
    // BoolProperty /Script/TypedElementRuntime.TypedElementSelectionOptions:bAllowLegacyNotifications
    static readonly int bAllowLegacyNotifications_Offset;
    public bool AllowLegacyNotifications;
    
    // BoolProperty /Script/TypedElementRuntime.TypedElementSelectionOptions:bWarnIfLocked
    static readonly int bWarnIfLocked_Offset;
    public bool WarnIfLocked;
    
    // EnumProperty /Script/TypedElementRuntime.TypedElementSelectionOptions:ChildElementInclusionMethod
    static readonly int ChildElementInclusionMethod_Offset;
    public UnrealSharp.TypedElementRuntime.ETypedElementChildInclusionMethod ChildElementInclusionMethod;
    
    
    public static readonly int NativeDataSize;
    static TypedElementSelectionOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TypedElementSelectionOptions");
        
        bAllowHidden_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowHidden");
        bAllowGroups_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowGroups");
        bAllowLegacyNotifications_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowLegacyNotifications");
        bWarnIfLocked_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWarnIfLocked");
        ChildElementInclusionMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChildElementInclusionMethod");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TypedElementSelectionOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            AllowHidden = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowHidden_Offset), 0, null);
            AllowGroups = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowGroups_Offset), 0, null);
            AllowLegacyNotifications = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowLegacyNotifications_Offset), 0, null);
            WarnIfLocked = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bWarnIfLocked_Offset), 0, null);
            ChildElementInclusionMethod = BlittableMarshaller<UnrealSharp.TypedElementRuntime.ETypedElementChildInclusionMethod>.FromNative(IntPtr.Add(InNativeStruct, ChildElementInclusionMethod_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowHidden_Offset), 0, null, AllowHidden);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowGroups_Offset), 0, null, AllowGroups);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowLegacyNotifications_Offset), 0, null, AllowLegacyNotifications);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bWarnIfLocked_Offset), 0, null, WarnIfLocked);
            BlittableMarshaller<UnrealSharp.TypedElementRuntime.ETypedElementChildInclusionMethod>.ToNative(IntPtr.Add(Buffer, ChildElementInclusionMethod_Offset), 0, null, ChildElementInclusionMethod);
        }
    }
}

public static class TypedElementSelectionOptionsMarshaler
{
    public static TypedElementSelectionOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TypedElementSelectionOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TypedElementSelectionOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TypedElementSelectionOptions.NativeDataSize;
    }
}