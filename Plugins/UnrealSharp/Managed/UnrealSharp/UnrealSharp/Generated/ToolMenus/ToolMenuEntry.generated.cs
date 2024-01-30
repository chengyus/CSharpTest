using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct]
public partial struct ToolMenuEntry
{
    // NameProperty /Script/ToolMenus.ToolMenuEntry:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // StructProperty /Script/ToolMenus.ToolMenuEntry:Owner
    static readonly int Owner_Offset;
    public UnrealSharp.ToolMenus.ToolMenuOwner Owner;
    
    // EnumProperty /Script/ToolMenus.ToolMenuEntry:Type
    static readonly int Type_Offset;
    public UnrealSharp.Slate.EMultiBlockType Type;
    
    // EnumProperty /Script/ToolMenus.ToolMenuEntry:UserInterfaceActionType
    static readonly int UserInterfaceActionType_Offset;
    public UnrealSharp.Slate.EUserInterfaceActionType UserInterfaceActionType;
    
    // NameProperty /Script/ToolMenus.ToolMenuEntry:TutorialHighlightName
    static readonly int TutorialHighlightName_Offset;
    public Name TutorialHighlightName;
    
    // StructProperty /Script/ToolMenus.ToolMenuEntry:InsertPosition
    static readonly int InsertPosition_Offset;
    public UnrealSharp.ToolMenus.ToolMenuInsert InsertPosition;
    
    // BoolProperty /Script/ToolMenus.ToolMenuEntry:bShouldCloseWindowAfterMenuSelection
    static readonly int bShouldCloseWindowAfterMenuSelection_Offset;
    public bool ShouldCloseWindowAfterMenuSelection;
    
    // ObjectProperty /Script/ToolMenus.ToolMenuEntry:ScriptObject
    static readonly int ScriptObject_Offset;
    public UnrealSharp.ToolMenus.ToolMenuEntryScript ScriptObject;
    
    // NameProperty /Script/ToolMenus.ToolMenuEntry:StyleNameOverride
    static readonly int StyleNameOverride_Offset;
    public Name StyleNameOverride;
    
    
    public static readonly int NativeDataSize;
    static ToolMenuEntry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolMenuEntry");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Owner");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        UserInterfaceActionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserInterfaceActionType");
        TutorialHighlightName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TutorialHighlightName");
        InsertPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InsertPosition");
        bShouldCloseWindowAfterMenuSelection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShouldCloseWindowAfterMenuSelection");
        ScriptObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScriptObject");
        StyleNameOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StyleNameOverride");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolMenuEntry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Owner = UnrealSharp.ToolMenus.ToolMenuOwnerMarshaler.FromNative(IntPtr.Add(InNativeStruct, Owner_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.Slate.EMultiBlockType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            UserInterfaceActionType = BlittableMarshaller<UnrealSharp.Slate.EUserInterfaceActionType>.FromNative(IntPtr.Add(InNativeStruct, UserInterfaceActionType_Offset), 0, null);
            TutorialHighlightName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, TutorialHighlightName_Offset), 0, null);
            InsertPosition = UnrealSharp.ToolMenus.ToolMenuInsertMarshaler.FromNative(IntPtr.Add(InNativeStruct, InsertPosition_Offset), 0, null);
            ShouldCloseWindowAfterMenuSelection = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShouldCloseWindowAfterMenuSelection_Offset), 0, null);
            ScriptObject = ObjectMarshaller<UnrealSharp.ToolMenus.ToolMenuEntryScript>.FromNative(IntPtr.Add(InNativeStruct, ScriptObject_Offset), 0, null);
            StyleNameOverride = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StyleNameOverride_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            UnrealSharp.ToolMenus.ToolMenuOwnerMarshaler.ToNative(IntPtr.Add(Buffer, Owner_Offset), 0, null, Owner);
            BlittableMarshaller<UnrealSharp.Slate.EMultiBlockType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<UnrealSharp.Slate.EUserInterfaceActionType>.ToNative(IntPtr.Add(Buffer, UserInterfaceActionType_Offset), 0, null, UserInterfaceActionType);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, TutorialHighlightName_Offset), 0, null, TutorialHighlightName);
            UnrealSharp.ToolMenus.ToolMenuInsertMarshaler.ToNative(IntPtr.Add(Buffer, InsertPosition_Offset), 0, null, InsertPosition);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShouldCloseWindowAfterMenuSelection_Offset), 0, null, ShouldCloseWindowAfterMenuSelection);
            ObjectMarshaller<UnrealSharp.ToolMenus.ToolMenuEntryScript>.ToNative(IntPtr.Add(Buffer, ScriptObject_Offset), 0, null, ScriptObject);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StyleNameOverride_Offset), 0, null, StyleNameOverride);
        }
    }
}

public static class ToolMenuEntryMarshaler
{
    public static ToolMenuEntry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolMenuEntry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolMenuEntry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolMenuEntry.NativeDataSize;
    }
}