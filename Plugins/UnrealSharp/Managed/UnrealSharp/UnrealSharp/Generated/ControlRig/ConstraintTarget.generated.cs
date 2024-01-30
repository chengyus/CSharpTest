using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct ConstraintTarget
{
    // StructProperty /Script/ControlRig.ConstraintTarget:Filter
    static readonly int Filter_Offset;
    public UnrealSharp.AnimationCore.TransformFilter Filter;
    
    
    public static readonly int NativeDataSize;
    static ConstraintTarget()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ConstraintTarget");
        
        Filter_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Filter");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ConstraintTarget(IntPtr InNativeStruct)
    {
        unsafe
        {
            Filter = UnrealSharp.AnimationCore.TransformFilterMarshaler.FromNative(IntPtr.Add(InNativeStruct, Filter_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.AnimationCore.TransformFilterMarshaler.ToNative(IntPtr.Add(Buffer, Filter_Offset), 0, null, Filter);
        }
    }
}

public static class ConstraintTargetMarshaler
{
    public static ConstraintTarget FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ConstraintTarget(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ConstraintTarget obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ConstraintTarget.NativeDataSize;
    }
}