using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct FormatArgumentData
{
    // ByteProperty /Script/Engine.FormatArgumentData:ArgumentValueType
    static readonly int ArgumentValueType_Offset;
    public UnrealSharp.Engine.EFormatArgumentType ArgumentValueType;
    
    // Int64Property /Script/Engine.FormatArgumentData:ArgumentValueInt
    static readonly int ArgumentValueInt_Offset;
    public long ArgumentValueInt;
    
    // FloatProperty /Script/Engine.FormatArgumentData:ArgumentValueFloat
    static readonly int ArgumentValueFloat_Offset;
    public float ArgumentValueFloat;
    
    // DoubleProperty /Script/Engine.FormatArgumentData:ArgumentValueDouble
    static readonly int ArgumentValueDouble_Offset;
    public double ArgumentValueDouble;
    
    // EnumProperty /Script/Engine.FormatArgumentData:ArgumentValueGender
    static readonly int ArgumentValueGender_Offset;
    public UnrealSharp.Engine.ETextGender ArgumentValueGender;
    
    
    public static readonly int NativeDataSize;
    static FormatArgumentData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("FormatArgumentData");
        
        ArgumentValueType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArgumentValueType");
        ArgumentValueInt_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArgumentValueInt");
        ArgumentValueFloat_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArgumentValueFloat");
        ArgumentValueDouble_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArgumentValueDouble");
        ArgumentValueGender_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArgumentValueGender");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public FormatArgumentData(IntPtr InNativeStruct)
    {
        unsafe
        {
            ArgumentValueType = BlittableMarshaller<UnrealSharp.Engine.EFormatArgumentType>.FromNative(IntPtr.Add(InNativeStruct, ArgumentValueType_Offset), 0, null);
            ArgumentValueInt = BlittableMarshaller<long>.FromNative(IntPtr.Add(InNativeStruct, ArgumentValueInt_Offset), 0, null);
            ArgumentValueFloat = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ArgumentValueFloat_Offset), 0, null);
            ArgumentValueDouble = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, ArgumentValueDouble_Offset), 0, null);
            ArgumentValueGender = BlittableMarshaller<UnrealSharp.Engine.ETextGender>.FromNative(IntPtr.Add(InNativeStruct, ArgumentValueGender_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EFormatArgumentType>.ToNative(IntPtr.Add(Buffer, ArgumentValueType_Offset), 0, null, ArgumentValueType);
            BlittableMarshaller<long>.ToNative(IntPtr.Add(Buffer, ArgumentValueInt_Offset), 0, null, ArgumentValueInt);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ArgumentValueFloat_Offset), 0, null, ArgumentValueFloat);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, ArgumentValueDouble_Offset), 0, null, ArgumentValueDouble);
            BlittableMarshaller<UnrealSharp.Engine.ETextGender>.ToNative(IntPtr.Add(Buffer, ArgumentValueGender_Offset), 0, null, ArgumentValueGender);
        }
    }
}

public static class FormatArgumentDataMarshaler
{
    public static FormatArgumentData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new FormatArgumentData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, FormatArgumentData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return FormatArgumentData.NativeDataSize;
    }
}