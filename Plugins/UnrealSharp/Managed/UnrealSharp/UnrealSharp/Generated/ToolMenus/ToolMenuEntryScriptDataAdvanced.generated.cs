using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct]
public partial struct ToolMenuEntryScriptDataAdvanced
{
    // NameProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:TutorialHighlight
    static readonly int TutorialHighlight_Offset;
    public Name TutorialHighlight;
    
    // EnumProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:EntryType
    static readonly int EntryType_Offset;
    public UnrealSharp.Slate.EMultiBlockType EntryType;
    
    // EnumProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:UserInterfaceActionType
    static readonly int UserInterfaceActionType_Offset;
    public UnrealSharp.Slate.EUserInterfaceActionType UserInterfaceActionType;
    
    // NameProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:StyleNameOverride
    static readonly int StyleNameOverride_Offset;
    public Name StyleNameOverride;
    
    // BoolProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bIsSubMenu
    static readonly int bIsSubMenu_Offset;
    public bool IsSubMenu;
    
    // BoolProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bOpenSubMenuOnClick
    static readonly int bOpenSubMenuOnClick_Offset;
    public bool OpenSubMenuOnClick;
    
    // BoolProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bShouldCloseWindowAfterMenuSelection
    static readonly int bShouldCloseWindowAfterMenuSelection_Offset;
    public bool ShouldCloseWindowAfterMenuSelection;
    
    // BoolProperty /Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bSimpleComboBox
    static readonly int bSimpleComboBox_Offset;
    public bool SimpleComboBox;
    
    
    public static readonly int NativeDataSize;
    static ToolMenuEntryScriptDataAdvanced()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolMenuEntryScriptDataAdvanced");
        
        TutorialHighlight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TutorialHighlight");
        EntryType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EntryType");
        UserInterfaceActionType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UserInterfaceActionType");
        StyleNameOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "StyleNameOverride");
        bIsSubMenu_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSubMenu");
        bOpenSubMenuOnClick_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOpenSubMenuOnClick");
        bShouldCloseWindowAfterMenuSelection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShouldCloseWindowAfterMenuSelection");
        bSimpleComboBox_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSimpleComboBox");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolMenuEntryScriptDataAdvanced(IntPtr InNativeStruct)
    {
        unsafe
        {
            TutorialHighlight = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, TutorialHighlight_Offset), 0, null);
            EntryType = BlittableMarshaller<UnrealSharp.Slate.EMultiBlockType>.FromNative(IntPtr.Add(InNativeStruct, EntryType_Offset), 0, null);
            UserInterfaceActionType = BlittableMarshaller<UnrealSharp.Slate.EUserInterfaceActionType>.FromNative(IntPtr.Add(InNativeStruct, UserInterfaceActionType_Offset), 0, null);
            StyleNameOverride = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, StyleNameOverride_Offset), 0, null);
            IsSubMenu = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSubMenu_Offset), 0, null);
            OpenSubMenuOnClick = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOpenSubMenuOnClick_Offset), 0, null);
            ShouldCloseWindowAfterMenuSelection = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShouldCloseWindowAfterMenuSelection_Offset), 0, null);
            SimpleComboBox = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSimpleComboBox_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, TutorialHighlight_Offset), 0, null, TutorialHighlight);
            BlittableMarshaller<UnrealSharp.Slate.EMultiBlockType>.ToNative(IntPtr.Add(Buffer, EntryType_Offset), 0, null, EntryType);
            BlittableMarshaller<UnrealSharp.Slate.EUserInterfaceActionType>.ToNative(IntPtr.Add(Buffer, UserInterfaceActionType_Offset), 0, null, UserInterfaceActionType);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, StyleNameOverride_Offset), 0, null, StyleNameOverride);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSubMenu_Offset), 0, null, IsSubMenu);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOpenSubMenuOnClick_Offset), 0, null, OpenSubMenuOnClick);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShouldCloseWindowAfterMenuSelection_Offset), 0, null, ShouldCloseWindowAfterMenuSelection);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSimpleComboBox_Offset), 0, null, SimpleComboBox);
        }
    }
}

public static class ToolMenuEntryScriptDataAdvancedMarshaler
{
    public static ToolMenuEntryScriptDataAdvanced FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolMenuEntryScriptDataAdvanced(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolMenuEntryScriptDataAdvanced obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolMenuEntryScriptDataAdvanced.NativeDataSize;
    }
}