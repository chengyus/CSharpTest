using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct CanvasIcon
{
    // ObjectProperty /Script/Engine.CanvasIcon:Texture
    static readonly int Texture_Offset;
    public UnrealSharp.Engine.Texture Texture;
    
    // FloatProperty /Script/Engine.CanvasIcon:U
    static readonly int U_Offset;
    public float U;
    
    // FloatProperty /Script/Engine.CanvasIcon:V
    static readonly int V_Offset;
    public float V;
    
    // FloatProperty /Script/Engine.CanvasIcon:UL
    static readonly int UL_Offset;
    public float UL;
    
    // FloatProperty /Script/Engine.CanvasIcon:VL
    static readonly int VL_Offset;
    public float VL;
    
    
    public static readonly int NativeDataSize;
    static CanvasIcon()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CanvasIcon");
        
        Texture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Texture");
        U_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "U");
        V_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "V");
        UL_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "UL");
        VL_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VL");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CanvasIcon(IntPtr InNativeStruct)
    {
        unsafe
        {
            Texture = ObjectMarshaller<UnrealSharp.Engine.Texture>.FromNative(IntPtr.Add(InNativeStruct, Texture_Offset), 0, null);
            U = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, U_Offset), 0, null);
            V = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, V_Offset), 0, null);
            UL = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, UL_Offset), 0, null);
            VL = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, VL_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Texture>.ToNative(IntPtr.Add(Buffer, Texture_Offset), 0, null, Texture);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, U_Offset), 0, null, U);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, V_Offset), 0, null, V);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, UL_Offset), 0, null, UL);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, VL_Offset), 0, null, VL);
        }
    }
}

public static class CanvasIconMarshaler
{
    public static CanvasIcon FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CanvasIcon(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CanvasIcon obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CanvasIcon.NativeDataSize;
    }
}