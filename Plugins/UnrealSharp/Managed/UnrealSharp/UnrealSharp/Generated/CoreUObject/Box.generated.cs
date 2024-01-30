using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UStruct]
public partial struct Box
{
    // StructProperty /Script/CoreUObject.Box:Min
    static readonly int Min_Offset;
    public System.DoubleNumerics.Vector3 Min;
    
    // StructProperty /Script/CoreUObject.Box:Max
    static readonly int Max_Offset;
    public System.DoubleNumerics.Vector3 Max;
    
    // BoolProperty /Script/CoreUObject.Box:IsValid
    static readonly int IsValid_Offset;
    public bool IsValid;
    
    
    public static readonly int NativeDataSize;
    static Box()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("Box");
        
        Min_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Min");
        Max_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Max");
        IsValid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IsValid");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public Box(IntPtr InNativeStruct)
    {
        unsafe
        {
            Min = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Min_Offset), 0, null);
            Max = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Max_Offset), 0, null);
            IsValid = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, IsValid_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Min_Offset), 0, null, Min);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Max_Offset), 0, null, Max);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, IsValid_Offset), 0, null, IsValid);
        }
    }
}

public static class BoxMarshaler
{
    public static Box FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new Box(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, Box obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return Box.NativeDataSize;
    }
}