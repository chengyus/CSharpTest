using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformMakeAbsolute
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMakeAbsolute:Local
    static readonly int Local_Offset;
    public UnrealSharp.Transform Local;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMakeAbsolute:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.Transform Parent;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMakeAbsolute:Global
    static readonly int Global_Offset;
    public UnrealSharp.Transform Global;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformMakeAbsolute()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformMakeAbsolute");
        
        Local_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Local");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformMakeAbsolute(IntPtr InNativeStruct)
    {
        unsafe
        {
            Local = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Local_Offset), 0, null);
            Parent = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            Global = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Local_Offset), 0, null, Local);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
        }
    }
}

public static class RigVMFunction_MathTransformMakeAbsoluteMarshaler
{
    public static RigVMFunction_MathTransformMakeAbsolute FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformMakeAbsolute(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformMakeAbsolute obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformMakeAbsolute.NativeDataSize;
    }
}