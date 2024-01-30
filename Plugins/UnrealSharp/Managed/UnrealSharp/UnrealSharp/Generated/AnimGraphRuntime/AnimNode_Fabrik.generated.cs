using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_Fabrik
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_Fabrik:EffectorTransform
    static readonly int EffectorTransform_Offset;
    public UnrealSharp.Transform EffectorTransform;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_Fabrik()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_Fabrik");
        
        EffectorTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EffectorTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_Fabrik(IntPtr InNativeStruct)
    {
        unsafe
        {
            EffectorTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, EffectorTransform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, EffectorTransform_Offset), 0, null, EffectorTransform);
        }
    }
}

public static class AnimNode_FabrikMarshaler
{
    public static AnimNode_Fabrik FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_Fabrik(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_Fabrik obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_Fabrik.NativeDataSize;
    }
}