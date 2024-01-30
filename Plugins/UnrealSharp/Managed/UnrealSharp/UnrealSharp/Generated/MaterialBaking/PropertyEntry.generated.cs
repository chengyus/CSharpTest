using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MaterialBaking;

[UStruct]
public partial struct PropertyEntry
{
    // ByteProperty /Script/MaterialBaking.PropertyEntry:Property
    static readonly int Property_Offset;
    public UnrealSharp.Engine.EMaterialProperty Property;
    
    // BoolProperty /Script/MaterialBaking.PropertyEntry:bUseCustomSize
    static readonly int bUseCustomSize_Offset;
    public bool UseCustomSize;
    
    // StructProperty /Script/MaterialBaking.PropertyEntry:CustomSize
    static readonly int CustomSize_Offset;
    public UnrealSharp.CoreUObject.IntPoint CustomSize;
    
    // BoolProperty /Script/MaterialBaking.PropertyEntry:bUseConstantValue
    static readonly int bUseConstantValue_Offset;
    public bool UseConstantValue;
    
    // FloatProperty /Script/MaterialBaking.PropertyEntry:ConstantValue
    static readonly int ConstantValue_Offset;
    public float ConstantValue;
    
    
    public static readonly int NativeDataSize;
    static PropertyEntry()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PropertyEntry");
        
        Property_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Property");
        bUseCustomSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCustomSize");
        CustomSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomSize");
        bUseConstantValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseConstantValue");
        ConstantValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ConstantValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PropertyEntry(IntPtr InNativeStruct)
    {
        unsafe
        {
            Property = BlittableMarshaller<UnrealSharp.Engine.EMaterialProperty>.FromNative(IntPtr.Add(InNativeStruct, Property_Offset), 0, null);
            UseCustomSize = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseCustomSize_Offset), 0, null);
            CustomSize = BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.FromNative(IntPtr.Add(InNativeStruct, CustomSize_Offset), 0, null);
            UseConstantValue = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUseConstantValue_Offset), 0, null);
            ConstantValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, ConstantValue_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.EMaterialProperty>.ToNative(IntPtr.Add(Buffer, Property_Offset), 0, null, Property);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseCustomSize_Offset), 0, null, UseCustomSize);
            BlittableMarshaller<UnrealSharp.CoreUObject.IntPoint>.ToNative(IntPtr.Add(Buffer, CustomSize_Offset), 0, null, CustomSize);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUseConstantValue_Offset), 0, null, UseConstantValue);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, ConstantValue_Offset), 0, null, ConstantValue);
        }
    }
}

public static class PropertyEntryMarshaler
{
    public static PropertyEntry FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PropertyEntry(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PropertyEntry obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PropertyEntry.NativeDataSize;
    }
}