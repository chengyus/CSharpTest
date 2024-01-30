using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct InputAxisKeyMapping
{
    // NameProperty /Script/Engine.InputAxisKeyMapping:AxisName
    static readonly int AxisName_Offset;
    public Name AxisName;
    
    // FloatProperty /Script/Engine.InputAxisKeyMapping:Scale
    static readonly int Scale_Offset;
    public float Scale;
    
    // StructProperty /Script/Engine.InputAxisKeyMapping:Key
    static readonly int Key_Offset;
    public UnrealSharp.InputCore.Key Key;
    
    
    public static readonly int NativeDataSize;
    static InputAxisKeyMapping()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputAxisKeyMapping");
        
        AxisName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AxisName");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Key");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputAxisKeyMapping(IntPtr InNativeStruct)
    {
        unsafe
        {
            AxisName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, AxisName_Offset), 0, null);
            Scale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Key = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Key_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, AxisName_Offset), 0, null, AxisName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, Key_Offset), 0, null, Key);
        }
    }
}

public static class InputAxisKeyMappingMarshaler
{
    public static InputAxisKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputAxisKeyMapping(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputAxisKeyMapping obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputAxisKeyMapping.NativeDataSize;
    }
}