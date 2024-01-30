using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigSpace
{
    // EnumProperty /Script/ControlRig.RigSpace:SpaceType
    static readonly int SpaceType_Offset;
    public UnrealSharp.ControlRig.ERigSpaceType SpaceType;
    
    // NameProperty /Script/ControlRig.RigSpace:ParentName
    static readonly int ParentName_Offset;
    public Name ParentName;
    
    // IntProperty /Script/ControlRig.RigSpace:ParentIndex
    static readonly int ParentIndex_Offset;
    public int ParentIndex;
    
    // StructProperty /Script/ControlRig.RigSpace:InitialTransform
    static readonly int InitialTransform_Offset;
    public UnrealSharp.Transform InitialTransform;
    
    // StructProperty /Script/ControlRig.RigSpace:LocalTransform
    static readonly int LocalTransform_Offset;
    public UnrealSharp.Transform LocalTransform;
    
    
    public static readonly int NativeDataSize;
    static RigSpace()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigSpace");
        
        SpaceType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpaceType");
        ParentName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentName");
        ParentIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentIndex");
        InitialTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialTransform");
        LocalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigSpace(IntPtr InNativeStruct)
    {
        unsafe
        {
            SpaceType = BlittableMarshaller<UnrealSharp.ControlRig.ERigSpaceType>.FromNative(IntPtr.Add(InNativeStruct, SpaceType_Offset), 0, null);
            ParentName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParentName_Offset), 0, null);
            ParentIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ParentIndex_Offset), 0, null);
            InitialTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InitialTransform_Offset), 0, null);
            LocalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, LocalTransform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.ControlRig.ERigSpaceType>.ToNative(IntPtr.Add(Buffer, SpaceType_Offset), 0, null, SpaceType);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ParentName_Offset), 0, null, ParentName);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ParentIndex_Offset), 0, null, ParentIndex);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InitialTransform_Offset), 0, null, InitialTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, LocalTransform_Offset), 0, null, LocalTransform);
        }
    }
}

public static class RigSpaceMarshaler
{
    public static RigSpace FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigSpace(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigSpace obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigSpace.NativeDataSize;
    }
}