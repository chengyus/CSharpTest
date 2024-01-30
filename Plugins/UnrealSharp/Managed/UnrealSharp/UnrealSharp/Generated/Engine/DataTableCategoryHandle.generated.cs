using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DataTableCategoryHandle
{
    // ObjectProperty /Script/Engine.DataTableCategoryHandle:DataTable
    static readonly int DataTable_Offset;
    public UnrealSharp.Engine.DataTable DataTable;
    
    // NameProperty /Script/Engine.DataTableCategoryHandle:ColumnName
    static readonly int ColumnName_Offset;
    public Name ColumnName;
    
    // NameProperty /Script/Engine.DataTableCategoryHandle:RowContents
    static readonly int RowContents_Offset;
    public Name RowContents;
    
    
    public static readonly int NativeDataSize;
    static DataTableCategoryHandle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DataTableCategoryHandle");
        
        DataTable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DataTable");
        ColumnName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ColumnName");
        RowContents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RowContents");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DataTableCategoryHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            DataTable = ObjectMarshaller<UnrealSharp.Engine.DataTable>.FromNative(IntPtr.Add(InNativeStruct, DataTable_Offset), 0, null);
            ColumnName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ColumnName_Offset), 0, null);
            RowContents = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, RowContents_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.DataTable>.ToNative(IntPtr.Add(Buffer, DataTable_Offset), 0, null, DataTable);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ColumnName_Offset), 0, null, ColumnName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, RowContents_Offset), 0, null, RowContents);
        }
    }
}

public static class DataTableCategoryHandleMarshaler
{
    public static DataTableCategoryHandle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DataTableCategoryHandle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DataTableCategoryHandle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DataTableCategoryHandle.NativeDataSize;
    }
}