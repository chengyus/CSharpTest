using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathQuaternionMakeRelative
{
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMakeRelative:Global
    static readonly int Global_Offset;
    public System.DoubleNumerics.Quaternion Global;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMakeRelative:Parent
    static readonly int Parent_Offset;
    public System.DoubleNumerics.Quaternion Parent;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathQuaternionMakeRelative:Local
    static readonly int Local_Offset;
    public System.DoubleNumerics.Quaternion Local;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathQuaternionMakeRelative()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathQuaternionMakeRelative");
        
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        Local_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Local");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathQuaternionMakeRelative(IntPtr InNativeStruct)
    {
        unsafe
        {
            Global = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
            Parent = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            Local = BlittableMarshaller<System.DoubleNumerics.Quaternion>.FromNative(IntPtr.Add(InNativeStruct, Local_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BlittableMarshaller<System.DoubleNumerics.Quaternion>.ToNative(IntPtr.Add(Buffer, Local_Offset), 0, null, Local);
        }
    }
}

public static class RigVMFunction_MathQuaternionMakeRelativeMarshaler
{
    public static RigVMFunction_MathQuaternionMakeRelative FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathQuaternionMakeRelative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathQuaternionMakeRelative obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathQuaternionMakeRelative.NativeDataSize;
    }
}