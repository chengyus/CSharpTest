using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct]
public partial struct ToolMenuEntryScriptData
{
    // NameProperty /Script/ToolMenus.ToolMenuEntryScriptData:Menu
    static readonly int Menu_Offset;
    public Name Menu;
    
    // NameProperty /Script/ToolMenus.ToolMenuEntryScriptData:Section
    static readonly int Section_Offset;
    public Name Section;
    
    // NameProperty /Script/ToolMenus.ToolMenuEntryScriptData:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // StructProperty /Script/ToolMenus.ToolMenuEntryScriptData:Icon
    static readonly int Icon_Offset;
    public UnrealSharp.ToolMenus.ScriptSlateIcon Icon;
    
    // NameProperty /Script/ToolMenus.ToolMenuEntryScriptData:OwnerName
    static readonly int OwnerName_Offset;
    public Name OwnerName;
    
    // StructProperty /Script/ToolMenus.ToolMenuEntryScriptData:InsertPosition
    static readonly int InsertPosition_Offset;
    public UnrealSharp.ToolMenus.ToolMenuInsert InsertPosition;
    
    // StructProperty /Script/ToolMenus.ToolMenuEntryScriptData:Advanced
    static readonly int Advanced_Offset;
    public UnrealSharp.ToolMenus.ToolMenuEntryScriptDataAdvanced Advanced;
    
    
    public static readonly int NativeDataSize;
    static ToolMenuEntryScriptData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolMenuEntryScriptData");
        
        Menu_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Menu");
        Section_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Section");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Icon_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Icon");
        OwnerName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OwnerName");
        InsertPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InsertPosition");
        Advanced_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Advanced");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolMenuEntryScriptData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Menu = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Menu_Offset), 0, null);
            Section = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Section_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Icon = BlittableMarshaller<UnrealSharp.ToolMenus.ScriptSlateIcon>.FromNative(IntPtr.Add(InNativeStruct, Icon_Offset), 0, null);
            OwnerName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, OwnerName_Offset), 0, null);
            InsertPosition = UnrealSharp.ToolMenus.ToolMenuInsertMarshaler.FromNative(IntPtr.Add(InNativeStruct, InsertPosition_Offset), 0, null);
            Advanced = UnrealSharp.ToolMenus.ToolMenuEntryScriptDataAdvancedMarshaler.FromNative(IntPtr.Add(InNativeStruct, Advanced_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Menu_Offset), 0, null, Menu);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Section_Offset), 0, null, Section);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.ToolMenus.ScriptSlateIcon>.ToNative(IntPtr.Add(Buffer, Icon_Offset), 0, null, Icon);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, OwnerName_Offset), 0, null, OwnerName);
            UnrealSharp.ToolMenus.ToolMenuInsertMarshaler.ToNative(IntPtr.Add(Buffer, InsertPosition_Offset), 0, null, InsertPosition);
            UnrealSharp.ToolMenus.ToolMenuEntryScriptDataAdvancedMarshaler.ToNative(IntPtr.Add(Buffer, Advanced_Offset), 0, null, Advanced);
        }
    }
}

public static class ToolMenuEntryScriptDataMarshaler
{
    public static ToolMenuEntryScriptData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolMenuEntryScriptData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolMenuEntryScriptData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolMenuEntryScriptData.NativeDataSize;
    }
}