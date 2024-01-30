using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_HierarchyImportFromSkeleton
{
    // NameProperty /Script/ControlRig.RigUnit_HierarchyImportFromSkeleton:NameSpace
    static readonly int NameSpace_Offset;
    public Name NameSpace;
    
    // BoolProperty /Script/ControlRig.RigUnit_HierarchyImportFromSkeleton:bIncludeCurves
    static readonly int bIncludeCurves_Offset;
    public bool IncludeCurves;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_HierarchyImportFromSkeleton()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_HierarchyImportFromSkeleton");
        
        NameSpace_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NameSpace");
        bIncludeCurves_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIncludeCurves");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_HierarchyImportFromSkeleton(IntPtr InNativeStruct)
    {
        unsafe
        {
            NameSpace = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, NameSpace_Offset), 0, null);
            IncludeCurves = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIncludeCurves_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, NameSpace_Offset), 0, null, NameSpace);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIncludeCurves_Offset), 0, null, IncludeCurves);
        }
    }
}

public static class RigUnit_HierarchyImportFromSkeletonMarshaler
{
    public static RigUnit_HierarchyImportFromSkeleton FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_HierarchyImportFromSkeleton(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_HierarchyImportFromSkeleton obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_HierarchyImportFromSkeleton.NativeDataSize;
    }
}