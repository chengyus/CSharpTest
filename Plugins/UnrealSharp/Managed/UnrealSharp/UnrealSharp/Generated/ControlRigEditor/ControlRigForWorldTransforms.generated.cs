using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRigEditor;

[UStruct]
public partial struct ControlRigForWorldTransforms
{
    // WeakObjectProperty /Script/ControlRigEditor.ControlRigForWorldTransforms:ControlRig
    static readonly int ControlRig_Offset;
    public WeakObject<UnrealSharp.ControlRig.ControlRig> ControlRig;
    
    
    public static readonly int NativeDataSize;
    static ControlRigForWorldTransforms()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigForWorldTransforms");
        
        ControlRig_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlRig");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigForWorldTransforms(IntPtr InNativeStruct)
    {
        unsafe
        {
            ControlRig = BlittableMarshaller<WeakObject<UnrealSharp.ControlRig.ControlRig>>.FromNative(IntPtr.Add(InNativeStruct, ControlRig_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<WeakObject<UnrealSharp.ControlRig.ControlRig>>.ToNative(IntPtr.Add(Buffer, ControlRig_Offset), 0, null, ControlRig);
        }
    }
}

public static class ControlRigForWorldTransformsMarshaler
{
    public static ControlRigForWorldTransforms FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigForWorldTransforms(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigForWorldTransforms obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigForWorldTransforms.NativeDataSize;
    }
}