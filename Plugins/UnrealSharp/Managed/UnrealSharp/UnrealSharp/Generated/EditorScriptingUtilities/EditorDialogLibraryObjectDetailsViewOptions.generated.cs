using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EditorScriptingUtilities;

[UStruct]
public partial struct EditorDialogLibraryObjectDetailsViewOptions
{
    // BoolProperty /Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:bShowObjectName
    static readonly int bShowObjectName_Offset;
    public bool ShowObjectName;
    
    // BoolProperty /Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:bAllowSearch
    static readonly int bAllowSearch_Offset;
    public bool AllowSearch;
    
    // IntProperty /Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:MinWidth
    static readonly int MinWidth_Offset;
    public int MinWidth;
    
    // IntProperty /Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:MinHeight
    static readonly int MinHeight_Offset;
    public int MinHeight;
    
    // FloatProperty /Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:ValueColumnWidthRatio
    static readonly int ValueColumnWidthRatio_Offset;
    public float ValueColumnWidthRatio;
    
    
    public static readonly int NativeDataSize;
    static EditorDialogLibraryObjectDetailsViewOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EditorDialogLibraryObjectDetailsViewOptions");
        
        bShowObjectName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowObjectName");
        bAllowSearch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAllowSearch");
        MinWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinWidth");
        MinHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinHeight");
        ValueColumnWidthRatio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ValueColumnWidthRatio");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EditorDialogLibraryObjectDetailsViewOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            ShowObjectName = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bShowObjectName_Offset), 0, null);
            AllowSearch = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAllowSearch_Offset), 0, null);
            MinWidth = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MinWidth_Offset), 0, null);
            MinHeight = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, MinHeight_Offset), 0, null);
            ValueColumnWidthRatio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ValueColumnWidthRatio_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bShowObjectName_Offset), 0, null, ShowObjectName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAllowSearch_Offset), 0, null, AllowSearch);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MinWidth_Offset), 0, null, MinWidth);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, MinHeight_Offset), 0, null, MinHeight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ValueColumnWidthRatio_Offset), 0, null, ValueColumnWidthRatio);
        }
    }
}

public static class EditorDialogLibraryObjectDetailsViewOptionsMarshaler
{
    public static EditorDialogLibraryObjectDetailsViewOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EditorDialogLibraryObjectDetailsViewOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EditorDialogLibraryObjectDetailsViewOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EditorDialogLibraryObjectDetailsViewOptions.NativeDataSize;
    }
}