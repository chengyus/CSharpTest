using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SourceControl;

[UStruct]
public partial struct SourceControlState
{
    // BoolProperty /Script/SourceControl.SourceControlState:bIsValid
    static readonly int bIsValid_Offset;
    public bool IsValid;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsUnknown
    static readonly int bIsUnknown_Offset;
    public bool IsUnknown;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bCanCheckIn
    static readonly int bCanCheckIn_Offset;
    public bool CanCheckIn;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bCanCheckOut
    static readonly int bCanCheckOut_Offset;
    public bool CanCheckOut;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsCheckedOut
    static readonly int bIsCheckedOut_Offset;
    public bool IsCheckedOut;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsCurrent
    static readonly int bIsCurrent_Offset;
    public bool IsCurrent;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsSourceControlled
    static readonly int bIsSourceControlled_Offset;
    public bool IsSourceControlled;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsAdded
    static readonly int bIsAdded_Offset;
    public bool IsAdded;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsDeleted
    static readonly int bIsDeleted_Offset;
    public bool IsDeleted;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsIgnored
    static readonly int bIsIgnored_Offset;
    public bool IsIgnored;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bCanEdit
    static readonly int bCanEdit_Offset;
    public bool CanEdit;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bCanDelete
    static readonly int bCanDelete_Offset;
    public bool CanDelete;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsModified
    static readonly int bIsModified_Offset;
    public bool IsModified;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bCanAdd
    static readonly int bCanAdd_Offset;
    public bool CanAdd;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsConflicted
    static readonly int bIsConflicted_Offset;
    public bool IsConflicted;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bCanRevert
    static readonly int bCanRevert_Offset;
    public bool CanRevert;
    
    // BoolProperty /Script/SourceControl.SourceControlState:bIsCheckedOutOther
    static readonly int bIsCheckedOutOther_Offset;
    public bool IsCheckedOutOther;
    
    
    public static readonly int NativeDataSize;
    static SourceControlState()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SourceControlState");
        
        bIsValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsValid");
        bIsUnknown_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsUnknown");
        bCanCheckIn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanCheckIn");
        bCanCheckOut_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanCheckOut");
        bIsCheckedOut_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsCheckedOut");
        bIsCurrent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsCurrent");
        bIsSourceControlled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSourceControlled");
        bIsAdded_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsAdded");
        bIsDeleted_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsDeleted");
        bIsIgnored_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsIgnored");
        bCanEdit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanEdit");
        bCanDelete_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanDelete");
        bIsModified_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsModified");
        bCanAdd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanAdd");
        bIsConflicted_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsConflicted");
        bCanRevert_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanRevert");
        bIsCheckedOutOther_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsCheckedOutOther");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SourceControlState(IntPtr InNativeStruct)
    {
        unsafe
        {
            IsValid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsValid_Offset), 0, null);
            IsUnknown = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsUnknown_Offset), 0, null);
            CanCheckIn = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanCheckIn_Offset), 0, null);
            CanCheckOut = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanCheckOut_Offset), 0, null);
            IsCheckedOut = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsCheckedOut_Offset), 0, null);
            IsCurrent = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsCurrent_Offset), 0, null);
            IsSourceControlled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSourceControlled_Offset), 0, null);
            IsAdded = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsAdded_Offset), 0, null);
            IsDeleted = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsDeleted_Offset), 0, null);
            IsIgnored = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsIgnored_Offset), 0, null);
            CanEdit = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanEdit_Offset), 0, null);
            CanDelete = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanDelete_Offset), 0, null);
            IsModified = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsModified_Offset), 0, null);
            CanAdd = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanAdd_Offset), 0, null);
            IsConflicted = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsConflicted_Offset), 0, null);
            CanRevert = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bCanRevert_Offset), 0, null);
            IsCheckedOutOther = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsCheckedOutOther_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsValid_Offset), 0, null, IsValid);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsUnknown_Offset), 0, null, IsUnknown);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanCheckIn_Offset), 0, null, CanCheckIn);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanCheckOut_Offset), 0, null, CanCheckOut);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsCheckedOut_Offset), 0, null, IsCheckedOut);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsCurrent_Offset), 0, null, IsCurrent);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSourceControlled_Offset), 0, null, IsSourceControlled);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsAdded_Offset), 0, null, IsAdded);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsDeleted_Offset), 0, null, IsDeleted);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsIgnored_Offset), 0, null, IsIgnored);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanEdit_Offset), 0, null, CanEdit);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanDelete_Offset), 0, null, CanDelete);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsModified_Offset), 0, null, IsModified);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanAdd_Offset), 0, null, CanAdd);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsConflicted_Offset), 0, null, IsConflicted);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bCanRevert_Offset), 0, null, CanRevert);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsCheckedOutOther_Offset), 0, null, IsCheckedOutOther);
        }
    }
}

public static class SourceControlStateMarshaler
{
    public static SourceControlState FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SourceControlState(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SourceControlState obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SourceControlState.NativeDataSize;
    }
}