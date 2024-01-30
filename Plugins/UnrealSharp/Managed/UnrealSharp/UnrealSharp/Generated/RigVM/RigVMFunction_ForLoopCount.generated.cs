using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_ForLoopCount
{
    // IntProperty /Script/RigVM.RigVMFunction_ForLoopCount:Count
    static readonly int Count_Offset;
    public int Count;
    
    // IntProperty /Script/RigVM.RigVMFunction_ForLoopCount:Index
    static readonly int Index_Offset;
    public int Index;
    
    // FloatProperty /Script/RigVM.RigVMFunction_ForLoopCount:Ratio
    static readonly int Ratio_Offset;
    public float Ratio;
    
    // StructProperty /Script/RigVM.RigVMFunction_ForLoopCount:Completed
    static readonly int Completed_Offset;
    public UnrealSharp.RigVM.RigVMExecuteContext Completed;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_ForLoopCount()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_ForLoopCount");
        
        Count_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Count");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        Ratio_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Ratio");
        Completed_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Completed");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_ForLoopCount(IntPtr InNativeStruct)
    {
        unsafe
        {
            Count = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Count_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
            Ratio = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Ratio_Offset), 0, null);
            Completed = UnrealSharp.RigVM.RigVMExecuteContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, Completed_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Count_Offset), 0, null, Count);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Ratio_Offset), 0, null, Ratio);
            UnrealSharp.RigVM.RigVMExecuteContextMarshaler.ToNative(IntPtr.Add(Buffer, Completed_Offset), 0, null, Completed);
        }
    }
}

public static class RigVMFunction_ForLoopCountMarshaler
{
    public static RigVMFunction_ForLoopCount FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_ForLoopCount(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_ForLoopCount obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_ForLoopCount.NativeDataSize;
    }
}