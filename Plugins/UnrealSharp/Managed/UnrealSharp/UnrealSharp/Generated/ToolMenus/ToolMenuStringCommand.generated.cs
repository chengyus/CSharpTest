using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct]
public partial struct ToolMenuStringCommand
{
    // EnumProperty /Script/ToolMenus.ToolMenuStringCommand:Type
    static readonly int Type_Offset;
    public UnrealSharp.ToolMenus.EToolMenuStringCommandType Type;
    
    // NameProperty /Script/ToolMenus.ToolMenuStringCommand:CustomType
    static readonly int CustomType_Offset;
    public Name CustomType;
    
    
    public static readonly int NativeDataSize;
    static ToolMenuStringCommand()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolMenuStringCommand");
        
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        CustomType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolMenuStringCommand(IntPtr InNativeStruct)
    {
        unsafe
        {
            Type = BlittableMarshaller<UnrealSharp.ToolMenus.EToolMenuStringCommandType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
            CustomType = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, CustomType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ToolMenus.EToolMenuStringCommandType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, CustomType_Offset), 0, null, CustomType);
        }
    }
}

public static class ToolMenuStringCommandMarshaler
{
    public static ToolMenuStringCommand FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolMenuStringCommand(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolMenuStringCommand obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolMenuStringCommand.NativeDataSize;
    }
}