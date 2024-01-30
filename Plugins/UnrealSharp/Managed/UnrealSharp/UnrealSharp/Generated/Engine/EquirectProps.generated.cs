using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct EquirectProps
{
    // StructProperty /Script/Engine.EquirectProps:LeftUVRect
    static readonly int LeftUVRect_Offset;
    public UnrealSharp.CoreUObject.Box2D LeftUVRect;
    
    // StructProperty /Script/Engine.EquirectProps:RightUVRect
    static readonly int RightUVRect_Offset;
    public UnrealSharp.CoreUObject.Box2D RightUVRect;
    
    // StructProperty /Script/Engine.EquirectProps:LeftScale
    static readonly int LeftScale_Offset;
    public System.DoubleNumerics.Vector2 LeftScale;
    
    // StructProperty /Script/Engine.EquirectProps:RightScale
    static readonly int RightScale_Offset;
    public System.DoubleNumerics.Vector2 RightScale;
    
    // StructProperty /Script/Engine.EquirectProps:LeftBias
    static readonly int LeftBias_Offset;
    public System.DoubleNumerics.Vector2 LeftBias;
    
    // StructProperty /Script/Engine.EquirectProps:RightBias
    static readonly int RightBias_Offset;
    public System.DoubleNumerics.Vector2 RightBias;
    
    // FloatProperty /Script/Engine.EquirectProps:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    
    public static readonly int NativeDataSize;
    static EquirectProps()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("EquirectProps");
        
        LeftUVRect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeftUVRect");
        RightUVRect_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RightUVRect");
        LeftScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeftScale");
        RightScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RightScale");
        LeftBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeftBias");
        RightBias_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RightBias");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public EquirectProps(IntPtr InNativeStruct)
    {
        unsafe
        {
            LeftUVRect = UnrealSharp.CoreUObject.Box2DMarshaler.FromNative(IntPtr.Add(InNativeStruct, LeftUVRect_Offset), 0, null);
            RightUVRect = UnrealSharp.CoreUObject.Box2DMarshaler.FromNative(IntPtr.Add(InNativeStruct, RightUVRect_Offset), 0, null);
            LeftScale = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, LeftScale_Offset), 0, null);
            RightScale = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, RightScale_Offset), 0, null);
            LeftBias = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, LeftBias_Offset), 0, null);
            RightBias = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, RightBias_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.Box2DMarshaler.ToNative(IntPtr.Add(Buffer, LeftUVRect_Offset), 0, null, LeftUVRect);
            UnrealSharp.CoreUObject.Box2DMarshaler.ToNative(IntPtr.Add(Buffer, RightUVRect_Offset), 0, null, RightUVRect);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, LeftScale_Offset), 0, null, LeftScale);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, RightScale_Offset), 0, null, RightScale);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, LeftBias_Offset), 0, null, LeftBias);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, RightBias_Offset), 0, null, RightBias);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
        }
    }
}

public static class EquirectPropsMarshaler
{
    public static EquirectProps FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new EquirectProps(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, EquirectProps obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return EquirectProps.NativeDataSize;
    }
}