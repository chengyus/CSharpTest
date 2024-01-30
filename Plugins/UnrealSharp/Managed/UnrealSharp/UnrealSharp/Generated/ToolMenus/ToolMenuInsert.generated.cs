using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct]
public partial struct ToolMenuInsert
{
    // NameProperty /Script/ToolMenus.ToolMenuInsert:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // EnumProperty /Script/ToolMenus.ToolMenuInsert:Position
    static readonly int Position_Offset;
    public UnrealSharp.ToolMenus.EToolMenuInsertType Position;
    
    
    public static readonly int NativeDataSize;
    static ToolMenuInsert()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolMenuInsert");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Position_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Position");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolMenuInsert(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Position = BlittableMarshaller<UnrealSharp.ToolMenus.EToolMenuInsertType>.FromNative(IntPtr.Add(InNativeStruct, Position_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.ToolMenus.EToolMenuInsertType>.ToNative(IntPtr.Add(Buffer, Position_Offset), 0, null, Position);
        }
    }
}

public static class ToolMenuInsertMarshaler
{
    public static ToolMenuInsert FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolMenuInsert(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolMenuInsert obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolMenuInsert.NativeDataSize;
    }
}