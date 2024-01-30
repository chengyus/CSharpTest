using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InteractiveToolsFramework;

[UStruct]
public partial struct InputRayHit
{
    // BoolProperty /Script/InteractiveToolsFramework.InputRayHit:bHit
    static readonly int bHit_Offset;
    public bool Hit;
    
    // DoubleProperty /Script/InteractiveToolsFramework.InputRayHit:HitDepth
    static readonly int HitDepth_Offset;
    public double HitDepth;
    
    // StructProperty /Script/InteractiveToolsFramework.InputRayHit:HitNormal
    static readonly int HitNormal_Offset;
    public System.DoubleNumerics.Vector3 HitNormal;
    
    // BoolProperty /Script/InteractiveToolsFramework.InputRayHit:bHasHitNormal
    static readonly int bHasHitNormal_Offset;
    public bool HasHitNormal;
    
    // IntProperty /Script/InteractiveToolsFramework.InputRayHit:HitIdentifier
    static readonly int HitIdentifier_Offset;
    public int HitIdentifier;
    
    // WeakObjectProperty /Script/InteractiveToolsFramework.InputRayHit:HitObject
    static readonly int HitObject_Offset;
    public WeakObject<UnrealSharp.CoreUObject.Object> HitObject;
    
    
    public static readonly int NativeDataSize;
    static InputRayHit()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputRayHit");
        
        bHit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHit");
        HitDepth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitDepth");
        HitNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitNormal");
        bHasHitNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHasHitNormal");
        HitIdentifier_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitIdentifier");
        HitObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HitObject");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputRayHit(IntPtr InNativeStruct)
    {
        unsafe
        {
            Hit = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHit_Offset), 0, null);
            HitDepth = BlittableMarshaller<double>.FromNative(IntPtr.Add(InNativeStruct, HitDepth_Offset), 0, null);
            HitNormal = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, HitNormal_Offset), 0, null);
            HasHitNormal = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHasHitNormal_Offset), 0, null);
            HitIdentifier = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, HitIdentifier_Offset), 0, null);
            HitObject = BlittableMarshaller<WeakObject<UnrealSharp.CoreUObject.Object>>.FromNative(IntPtr.Add(InNativeStruct, HitObject_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHit_Offset), 0, null, Hit);
            BlittableMarshaller<double>.ToNative(IntPtr.Add(Buffer, HitDepth_Offset), 0, null, HitDepth);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, HitNormal_Offset), 0, null, HitNormal);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHasHitNormal_Offset), 0, null, HasHitNormal);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, HitIdentifier_Offset), 0, null, HitIdentifier);
            BlittableMarshaller<WeakObject<UnrealSharp.CoreUObject.Object>>.ToNative(IntPtr.Add(Buffer, HitObject_Offset), 0, null, HitObject);
        }
    }
}

public static class InputRayHitMarshaler
{
    public static InputRayHit FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputRayHit(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputRayHit obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputRayHit.NativeDataSize;
    }
}