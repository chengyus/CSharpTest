using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct SphericalPoseReaderDebugSettings
{
    // BoolProperty /Script/ControlRig.SphericalPoseReaderDebugSettings:bDrawDebug
    static readonly int bDrawDebug_Offset;
    public bool DrawDebug;
    
    // BoolProperty /Script/ControlRig.SphericalPoseReaderDebugSettings:bDraw2D
    static readonly int bDraw2D_Offset;
    public bool Draw2D;
    
    // BoolProperty /Script/ControlRig.SphericalPoseReaderDebugSettings:bDrawLocalAxes
    static readonly int bDrawLocalAxes_Offset;
    public bool DrawLocalAxes;
    
    // FloatProperty /Script/ControlRig.SphericalPoseReaderDebugSettings:DebugScale
    static readonly int DebugScale_Offset;
    public float DebugScale;
    
    // IntProperty /Script/ControlRig.SphericalPoseReaderDebugSettings:DebugSegments
    static readonly int DebugSegments_Offset;
    public int DebugSegments;
    
    // FloatProperty /Script/ControlRig.SphericalPoseReaderDebugSettings:DebugThickness
    static readonly int DebugThickness_Offset;
    public float DebugThickness;
    
    
    public static readonly int NativeDataSize;
    static SphericalPoseReaderDebugSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SphericalPoseReaderDebugSettings");
        
        bDrawDebug_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawDebug");
        bDraw2D_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDraw2D");
        bDrawLocalAxes_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDrawLocalAxes");
        DebugScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugScale");
        DebugSegments_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSegments");
        DebugThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugThickness");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SphericalPoseReaderDebugSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            DrawDebug = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawDebug_Offset), 0, null);
            Draw2D = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDraw2D_Offset), 0, null);
            DrawLocalAxes = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bDrawLocalAxes_Offset), 0, null);
            DebugScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DebugScale_Offset), 0, null);
            DebugSegments = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, DebugSegments_Offset), 0, null);
            DebugThickness = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, DebugThickness_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawDebug_Offset), 0, null, DrawDebug);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDraw2D_Offset), 0, null, Draw2D);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bDrawLocalAxes_Offset), 0, null, DrawLocalAxes);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DebugScale_Offset), 0, null, DebugScale);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, DebugSegments_Offset), 0, null, DebugSegments);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, DebugThickness_Offset), 0, null, DebugThickness);
        }
    }
}

public static class SphericalPoseReaderDebugSettingsMarshaler
{
    public static SphericalPoseReaderDebugSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SphericalPoseReaderDebugSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SphericalPoseReaderDebugSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SphericalPoseReaderDebugSettings.NativeDataSize;
    }
}