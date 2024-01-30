using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InteractiveToolsFramework;

[UStruct]
public partial struct InputDeviceRay
{
    // StructProperty /Script/InteractiveToolsFramework.InputDeviceRay:WorldRay
    static readonly int WorldRay_Offset;
    public UnrealSharp.CoreUObject.Ray WorldRay;
    
    // BoolProperty /Script/InteractiveToolsFramework.InputDeviceRay:bHas2D
    static readonly int bHas2D_Offset;
    public bool Has2D;
    
    // StructProperty /Script/InteractiveToolsFramework.InputDeviceRay:ScreenPosition
    static readonly int ScreenPosition_Offset;
    public System.DoubleNumerics.Vector2 ScreenPosition;
    
    
    public static readonly int NativeDataSize;
    static InputDeviceRay()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputDeviceRay");
        
        WorldRay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WorldRay");
        bHas2D_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHas2D");
        ScreenPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScreenPosition");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputDeviceRay(IntPtr InNativeStruct)
    {
        unsafe
        {
            WorldRay = BlittableMarshaller<UnrealSharp.CoreUObject.Ray>.FromNative(IntPtr.Add(InNativeStruct, WorldRay_Offset), 0, null);
            Has2D = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHas2D_Offset), 0, null);
            ScreenPosition = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, ScreenPosition_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.Ray>.ToNative(IntPtr.Add(Buffer, WorldRay_Offset), 0, null, WorldRay);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHas2D_Offset), 0, null, Has2D);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, ScreenPosition_Offset), 0, null, ScreenPosition);
        }
    }
}

public static class InputDeviceRayMarshaler
{
    public static InputDeviceRay FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputDeviceRay(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputDeviceRay obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputDeviceRay.NativeDataSize;
    }
}