using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathVectorMakeAbsolute
{
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorMakeAbsolute:Local
    static readonly int Local_Offset;
    public System.DoubleNumerics.Vector3 Local;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorMakeAbsolute:Parent
    static readonly int Parent_Offset;
    public System.DoubleNumerics.Vector3 Parent;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathVectorMakeAbsolute:Global
    static readonly int Global_Offset;
    public System.DoubleNumerics.Vector3 Global;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathVectorMakeAbsolute()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathVectorMakeAbsolute");
        
        Local_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Local");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathVectorMakeAbsolute(IntPtr InNativeStruct)
    {
        unsafe
        {
            Local = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Local_Offset), 0, null);
            Parent = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            Global = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Local_Offset), 0, null, Local);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
        }
    }
}

public static class RigVMFunction_MathVectorMakeAbsoluteMarshaler
{
    public static RigVMFunction_MathVectorMakeAbsolute FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathVectorMakeAbsolute(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathVectorMakeAbsolute obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathVectorMakeAbsolute.NativeDataSize;
    }
}