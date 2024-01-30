using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CurveTableRowHandle
{
    // ObjectProperty /Script/Engine.CurveTableRowHandle:CurveTable
    static readonly int CurveTable_Offset;
    public UnrealSharp.Engine.CurveTable CurveTable;
    
    // NameProperty /Script/Engine.CurveTableRowHandle:RowName
    static readonly int RowName_Offset;
    public Name RowName;
    
    
    public static readonly int NativeDataSize;
    static CurveTableRowHandle()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CurveTableRowHandle");
        
        CurveTable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CurveTable");
        RowName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RowName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CurveTableRowHandle(IntPtr InNativeStruct)
    {
        unsafe
        {
            CurveTable = ObjectMarshaller<UnrealSharp.Engine.CurveTable>.FromNative(IntPtr.Add(InNativeStruct, CurveTable_Offset), 0, null);
            RowName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, RowName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.CurveTable>.ToNative(IntPtr.Add(Buffer, CurveTable_Offset), 0, null, CurveTable);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, RowName_Offset), 0, null, RowName);
        }
    }
}

public static class CurveTableRowHandleMarshaler
{
    public static CurveTableRowHandle FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CurveTableRowHandle(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CurveTableRowHandle obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CurveTableRowHandle.NativeDataSize;
    }
}