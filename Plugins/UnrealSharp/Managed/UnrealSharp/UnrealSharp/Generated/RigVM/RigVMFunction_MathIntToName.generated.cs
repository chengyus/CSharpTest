using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathIntToName
{
    // IntProperty /Script/RigVM.RigVMFunction_MathIntToName:Number
    static readonly int Number_Offset;
    public int Number;
    
    // IntProperty /Script/RigVM.RigVMFunction_MathIntToName:PaddedSize
    static readonly int PaddedSize_Offset;
    public int PaddedSize;
    
    // NameProperty /Script/RigVM.RigVMFunction_MathIntToName:Result
    static readonly int Result_Offset;
    public Name Result;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathIntToName()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathIntToName");
        
        Number_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Number");
        PaddedSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PaddedSize");
        Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Result");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathIntToName(IntPtr InNativeStruct)
    {
        unsafe
        {
            Number = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Number_Offset), 0, null);
            PaddedSize = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, PaddedSize_Offset), 0, null);
            Result = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Result_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Number_Offset), 0, null, Number);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, PaddedSize_Offset), 0, null, PaddedSize);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Result_Offset), 0, null, Result);
        }
    }
}

public static class RigVMFunction_MathIntToNameMarshaler
{
    public static RigVMFunction_MathIntToName FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathIntToName(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathIntToName obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathIntToName.NativeDataSize;
    }
}