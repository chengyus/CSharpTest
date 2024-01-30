using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct InterpCurvePointQuat
{
    // FloatProperty /Script/CoreUObject.InterpCurvePointQuat:InVal
    static readonly int InVal_Offset;
    public float Val;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointQuat:OutVal
    static readonly int OutVal_Offset;
    public System.DoubleNumerics.Quaternion OutVal;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointQuat:ArriveTangent
    static readonly int ArriveTangent_Offset;
    public System.DoubleNumerics.Quaternion ArriveTangent;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointQuat:LeaveTangent
    static readonly int LeaveTangent_Offset;
    public System.DoubleNumerics.Quaternion LeaveTangent;
    
    // ByteProperty /Script/CoreUObject.InterpCurvePointQuat:InterpMode
    static readonly int InterpMode_Offset;
    public UnrealSharp.CoreUObject.EInterpCurveMode InterpMode;
    
    
    public static readonly int NativeDataSize;
    static InterpCurvePointQuat()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpCurvePointQuat");
        
        InVal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InVal");
        OutVal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutVal");
        ArriveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArriveTangent");
        LeaveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeaveTangent");
        InterpMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpCurvePointQuat(IntPtr InNativeStruct)
    {
        unsafe
        {
            Val = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InVal_Offset), 0, null);
            OutVal = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, OutVal_Offset), 0, null);
            ArriveTangent = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, ArriveTangent_Offset), 0, null);
            LeaveTangent = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, LeaveTangent_Offset), 0, null);
            InterpMode = BlittableMarshaller<UnrealSharp.CoreUObject.EInterpCurveMode>.FromNative(IntPtr.Add(InNativeStruct, InterpMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InVal_Offset), 0, null, Val);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, OutVal_Offset), 0, null, OutVal);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, ArriveTangent_Offset), 0, null, ArriveTangent);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, LeaveTangent_Offset), 0, null, LeaveTangent);
            BlittableMarshaller<UnrealSharp.CoreUObject.EInterpCurveMode>.ToNative(IntPtr.Add(Buffer, InterpMode_Offset), 0, null, InterpMode);
        }
    }
}

public static class InterpCurvePointQuatMarshaler
{
    public static InterpCurvePointQuat FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpCurvePointQuat(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpCurvePointQuat obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpCurvePointQuat.NativeDataSize;
    }
}