using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DataTableRowHandle
{
    // ObjectProperty /Script/Engine.DataTableRowHandle:DataTable
    static readonly int DataTable_Offset;
    public UnrealSharp.Engine.DataTable DataTable;
    
    // NameProperty /Script/Engine.DataTableRowHandle:RowName
    static readonly int RowName_Offset;
    public Name RowName;
    
    
    public static readonly int NativeDataSize;
    static DataTableRowHandle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DataTableRowHandle");
        
        DataTable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DataTable");
        RowName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RowName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DataTableRowHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            DataTable = ObjectMarshaller<UnrealSharp.Engine.DataTable>.FromNative(IntPtr.Add(InNativeStruct, DataTable_Offset), 0, null);
            RowName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, RowName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.DataTable>.ToNative(IntPtr.Add(Buffer, DataTable_Offset), 0, null, DataTable);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, RowName_Offset), 0, null, RowName);
        }
    }
}

public static class DataTableRowHandleMarshaler
{
    public static DataTableRowHandle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DataTableRowHandle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DataTableRowHandle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DataTableRowHandle.NativeDataSize;
    }
}