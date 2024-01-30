using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathTransformMakeRelative
{
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMakeRelative:Global
    static readonly int Global_Offset;
    public UnrealSharp.Transform Global;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMakeRelative:Parent
    static readonly int Parent_Offset;
    public UnrealSharp.Transform Parent;
    
    // StructProperty /Script/RigVM.RigVMFunction_MathTransformMakeRelative:Local
    static readonly int Local_Offset;
    public UnrealSharp.Transform Local;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathTransformMakeRelative()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathTransformMakeRelative");
        
        Global_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Global");
        Parent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Parent");
        Local_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Local");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathTransformMakeRelative(IntPtr InNativeStruct)
    {
        unsafe
        {
            Global = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Global_Offset), 0, null);
            Parent = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Parent_Offset), 0, null);
            Local = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Local_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Global_Offset), 0, null, Global);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Parent_Offset), 0, null, Parent);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Local_Offset), 0, null, Local);
        }
    }
}

public static class RigVMFunction_MathTransformMakeRelativeMarshaler
{
    public static RigVMFunction_MathTransformMakeRelative FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathTransformMakeRelative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathTransformMakeRelative obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathTransformMakeRelative.NativeDataSize;
    }
}