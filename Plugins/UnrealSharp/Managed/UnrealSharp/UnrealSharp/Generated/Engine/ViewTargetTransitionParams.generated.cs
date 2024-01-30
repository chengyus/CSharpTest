using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ViewTargetTransitionParams
{
    // FloatProperty /Script/Engine.ViewTargetTransitionParams:BlendTime
    static readonly int BlendTime_Offset;
    public float BlendTime;
    
    // ByteProperty /Script/Engine.ViewTargetTransitionParams:BlendFunction
    static readonly int BlendFunction_Offset;
    public UnrealSharp.Engine.EViewTargetBlendFunction BlendFunction;
    
    // FloatProperty /Script/Engine.ViewTargetTransitionParams:BlendExp
    static readonly int BlendExp_Offset;
    public float BlendExp;
    
    // BoolProperty /Script/Engine.ViewTargetTransitionParams:bLockOutgoing
    static readonly int bLockOutgoing_Offset;
    static readonly IntPtr bLockOutgoing_NativeProperty;
    public bool LockOutgoing;
    
    
    public static readonly int NativeDataSize;
    static ViewTargetTransitionParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ViewTargetTransitionParams");
        
        BlendTime_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendTime");
        BlendFunction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendFunction");
        BlendExp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlendExp");
        bLockOutgoing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bLockOutgoing");
        bLockOutgoing_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bLockOutgoing");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ViewTargetTransitionParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            BlendTime = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendTime_Offset), 0, null);
            BlendFunction = BlittableMarshaller<UnrealSharp.Engine.EViewTargetBlendFunction>.FromNative(IntPtr.Add(InNativeStruct, BlendFunction_Offset), 0, null);
            BlendExp = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, BlendExp_Offset), 0, null);
            LockOutgoing = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bLockOutgoing_NativeProperty, bLockOutgoing_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendTime_Offset), 0, null, BlendTime);
            BlittableMarshaller<UnrealSharp.Engine.EViewTargetBlendFunction>.ToNative(IntPtr.Add(Buffer, BlendFunction_Offset), 0, null, BlendFunction);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, BlendExp_Offset), 0, null, BlendExp);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bLockOutgoing_NativeProperty, bLockOutgoing_Offset, LockOutgoing);
        }
    }
}

public static class ViewTargetTransitionParamsMarshaler
{
    public static ViewTargetTransitionParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ViewTargetTransitionParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ViewTargetTransitionParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ViewTargetTransitionParams.NativeDataSize;
    }
}