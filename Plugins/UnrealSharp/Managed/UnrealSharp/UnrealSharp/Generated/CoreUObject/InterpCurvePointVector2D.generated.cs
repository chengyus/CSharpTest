using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct InterpCurvePointVector2D
{
    // FloatProperty /Script/CoreUObject.InterpCurvePointVector2D:InVal
    static readonly int InVal_Offset;
    public float Val;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointVector2D:OutVal
    static readonly int OutVal_Offset;
    public System.DoubleNumerics.Vector2 OutVal;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointVector2D:ArriveTangent
    static readonly int ArriveTangent_Offset;
    public System.DoubleNumerics.Vector2 ArriveTangent;
    
    // StructProperty /Script/CoreUObject.InterpCurvePointVector2D:LeaveTangent
    static readonly int LeaveTangent_Offset;
    public System.DoubleNumerics.Vector2 LeaveTangent;
    
    // ByteProperty /Script/CoreUObject.InterpCurvePointVector2D:InterpMode
    static readonly int InterpMode_Offset;
    public UnrealSharp.CoreUObject.EInterpCurveMode InterpMode;
    
    
    public static readonly int NativeDataSize;
    static InterpCurvePointVector2D()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InterpCurvePointVector2D");
        
        InVal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InVal");
        OutVal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OutVal");
        ArriveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ArriveTangent");
        LeaveTangent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LeaveTangent");
        InterpMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InterpMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InterpCurvePointVector2D(IntPtr InNativeStruct)
    {
        unsafe
        {
            Val = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, InVal_Offset), 0, null);
            OutVal = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, OutVal_Offset), 0, null);
            ArriveTangent = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, ArriveTangent_Offset), 0, null);
            LeaveTangent = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, LeaveTangent_Offset), 0, null);
            InterpMode = BlittableMarshaller<UnrealSharp.CoreUObject.EInterpCurveMode>.FromNative(IntPtr.Add(InNativeStruct, InterpMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, InVal_Offset), 0, null, Val);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, OutVal_Offset), 0, null, OutVal);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, ArriveTangent_Offset), 0, null, ArriveTangent);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, LeaveTangent_Offset), 0, null, LeaveTangent);
            BlittableMarshaller<UnrealSharp.CoreUObject.EInterpCurveMode>.ToNative(IntPtr.Add(Buffer, InterpMode_Offset), 0, null, InterpMode);
        }
    }
}

public static class InterpCurvePointVector2DMarshaler
{
    public static InterpCurvePointVector2D FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InterpCurvePointVector2D(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InterpCurvePointVector2D obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InterpCurvePointVector2D.NativeDataSize;
    }
}