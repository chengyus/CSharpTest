using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct InterpCurvePointLinearColor
{
    // FloatProperty /Script/CoreUObject.InterpCurvePointLinearColor:InVal
    static readonly int InVal_Offset;
    public float Val;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointLinearColor:OutVal
    static readonly int OutVal_Offset;
    public UnrealSharp.CoreUObject.LinearColor OutVal;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointLinearColor:ArriveTangent
    static readonly int ArriveTangent_Offset;
    public UnrealSharp.CoreUObject.LinearColor ArriveTangent;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointLinearColor:LeaveTangent
    static readonly int LeaveTangent_Offset;
    public UnrealSharp.CoreUObject.LinearColor LeaveTangent;
    
    // ByteProperty /Script/CoreUObject.InterpCurvePointLinearColor:InterpMode
    static readonly int InterpMode_Offset;
    public UnrealSharp.CoreUObject.EInterpCurveMode InterpMode;
    
    
    public static readonly int NativeDataSize;
    static InterpCurvePointLinearColor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpCurvePointLinearColor");
        
        InVal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InVal");
        OutVal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutVal");
        ArriveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArriveTangent");
        LeaveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeaveTangent");
        InterpMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpCurvePointLinearColor(IntPtr InNativeStruct)
    {
        unsafe
        {
            Val = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InVal_Offset), 0, null);
            OutVal = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, OutVal_Offset), 0, null);
            ArriveTangent = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, ArriveTangent_Offset), 0, null);
            LeaveTangent = BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(InNativeStruct, LeaveTangent_Offset), 0, null);
            InterpMode = BlittableMarshaller<UnrealSharp.CoreUObject.EInterpCurveMode>.FromNative(IntPtr.Add(InNativeStruct, InterpMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InVal_Offset), 0, null, Val);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, OutVal_Offset), 0, null, OutVal);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, ArriveTangent_Offset), 0, null, ArriveTangent);
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(Buffer, LeaveTangent_Offset), 0, null, LeaveTangent);
            BlittableMarshaller<UnrealSharp.CoreUObject.EInterpCurveMode>.ToNative(IntPtr.Add(Buffer, InterpMode_Offset), 0, null, InterpMode);
        }
    }
}

public static class InterpCurvePointLinearColorMarshaler
{
    public static InterpCurvePointLinearColor FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpCurvePointLinearColor(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpCurvePointLinearColor obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpCurvePointLinearColor.NativeDataSize;
    }
}