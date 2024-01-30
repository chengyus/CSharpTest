using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigLocalAndGlobalTransform
{
    // StructProperty /Script/ControlRig.RigLocalAndGlobalTransform:Local
    static readonly int Local_Offset;
    public UnrealSharp.ControlRig.RigComputedTransform Local;
    
    // StructProperty /Script/ControlRig.RigLocalAndGlobalTransform:Global
    static readonly int Global_Offset;
    public UnrealSharp.ControlRig.RigComputedTransform Global;
    
    
    public static readonly int NativeDataSize;
    static RigLocalAndGlobalTransform()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigLocalAndGlobalTransform");
        
        Local_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Local");
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigLocalAndGlobalTransform(IntPtr InNativeStruct)
    {
        unsafe
        {
            Local = BlittableMarshaller<UnrealSharp.ControlRig.RigComputedTransform>.FromNative(IntPtr.Add(InNativeStruct, Local_Offset), 0, null);
            Global = BlittableMarshaller<UnrealSharp.ControlRig.RigComputedTransform>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.RigComputedTransform>.ToNative(IntPtr.Add(Buffer, Local_Offset), 0, null, Local);
            BlittableMarshaller<UnrealSharp.ControlRig.RigComputedTransform>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
        }
    }
}

public static class RigLocalAndGlobalTransformMarshaler
{
    public static RigLocalAndGlobalTransform FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigLocalAndGlobalTransform(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigLocalAndGlobalTransform obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigLocalAndGlobalTransform.NativeDataSize;
    }
}