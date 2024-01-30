using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathIntToString
{
    // IntProperty /Script/RigVM.RigVMFunction_MathIntToString:Number
    static readonly int Number_Offset;
    public int Number;
    
    // IntProperty /Script/RigVM.RigVMFunction_MathIntToString:PaddedSize
    static readonly int PaddedSize_Offset;
    public int PaddedSize;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathIntToString()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathIntToString");
        
        Number_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Number");
        PaddedSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PaddedSize");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathIntToString(IntPtr InNativeStruct)
    {
        unsafe
        {
            Number = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Number_Offset), 0, null);
            PaddedSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PaddedSize_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Number_Offset), 0, null, Number);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PaddedSize_Offset), 0, null, PaddedSize);
        }
    }
}

public static class RigVMFunction_MathIntToStringMarshaler
{
    public static RigVMFunction_MathIntToString FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathIntToString(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathIntToString obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathIntToString.NativeDataSize;
    }
}