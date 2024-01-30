using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UStruct]
public partial struct WidgetTransform
{
    // StructProperty /Script/UMG.WidgetTransform:Translation
    static readonly int Translation_Offset;
    public System.DoubleNumerics.Vector2 Translation;
    
    // StructProperty /Script/UMG.WidgetTransform:Scale
    static readonly int Scale_Offset;
    public System.DoubleNumerics.Vector2 Scale;
    
    // StructProperty /Script/UMG.WidgetTransform:Shear
    static readonly int Shear_Offset;
    public System.DoubleNumerics.Vector2 Shear;
    
    // FloatProperty /Script/UMG.WidgetTransform:Angle
    static readonly int Angle_Offset;
    public float Angle;
    
    
    public static readonly int NativeDataSize;
    static WidgetTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WidgetTransform");
        
        Translation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Translation");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        Shear_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Shear");
        Angle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Angle");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WidgetTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Translation = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Translation_Offset), 0, null);
            Scale = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
            Shear = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, Shear_Offset), 0, null);
            Angle = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Angle_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Translation_Offset), 0, null, Translation);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, Shear_Offset), 0, null, Shear);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Angle_Offset), 0, null, Angle);
        }
    }
}

public static class WidgetTransformMarshaler
{
    public static WidgetTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WidgetTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WidgetTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WidgetTransform.NativeDataSize;
    }
}