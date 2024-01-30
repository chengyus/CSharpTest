using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigBone
{
    // NameProperty /Script/ControlRig.RigBone:ParentName
    static readonly int ParentName_Offset;
    public Name ParentName;
    
    // StructProperty /Script/ControlRig.RigBone:InitialTransform
    static readonly int InitialTransform_Offset;
    public UnrealSharp.Transform InitialTransform;
    
    // StructProperty /Script/ControlRig.RigBone:GlobalTransform
    static readonly int GlobalTransform_Offset;
    public UnrealSharp.Transform GlobalTransform;
    
    // StructProperty /Script/ControlRig.RigBone:LocalTransform
    static readonly int LocalTransform_Offset;
    public UnrealSharp.Transform LocalTransform;
    
    // EnumProperty /Script/ControlRig.RigBone:Type
    static readonly int Type_Offset;
    public UnrealSharp.ControlRig.ERigBoneType Type;
    
    
    public static readonly int NativeDataSize;
    static RigBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigBone");
        
        ParentName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentName");
        InitialTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialTransform");
        GlobalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlobalTransform");
        LocalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalTransform");
        Type_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Type");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParentName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParentName_Offset), 0, null);
            InitialTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InitialTransform_Offset), 0, null);
            GlobalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, GlobalTransform_Offset), 0, null);
            LocalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, LocalTransform_Offset), 0, null);
            Type = BlittableMarshaller<UnrealSharp.ControlRig.ERigBoneType>.FromNative(IntPtr.Add(InNativeStruct, Type_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ParentName_Offset), 0, null, ParentName);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InitialTransform_Offset), 0, null, InitialTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, GlobalTransform_Offset), 0, null, GlobalTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, LocalTransform_Offset), 0, null, LocalTransform);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigBoneType>.ToNative(IntPtr.Add(Buffer, Type_Offset), 0, null, Type);
        }
    }
}

public static class RigBoneMarshaler
{
    public static RigBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigBone.NativeDataSize;
    }
}