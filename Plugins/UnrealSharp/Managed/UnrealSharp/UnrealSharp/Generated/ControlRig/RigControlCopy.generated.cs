using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigControlCopy
{
    // NameProperty /Script/ControlRig.RigControlCopy:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // EnumProperty /Script/ControlRig.RigControlCopy:ControlType
    static readonly int ControlType_Offset;
    public UnrealSharp.ControlRig.ERigControlType ControlType;
    
    // StructProperty /Script/ControlRig.RigControlCopy:ParentKey
    static readonly int ParentKey_Offset;
    public UnrealSharp.ControlRig.RigElementKey ParentKey;
    
    // StructProperty /Script/ControlRig.RigControlCopy:OffsetTransform
    static readonly int OffsetTransform_Offset;
    public UnrealSharp.Transform OffsetTransform;
    
    // StructProperty /Script/ControlRig.RigControlCopy:ParentTransform
    static readonly int ParentTransform_Offset;
    public UnrealSharp.Transform ParentTransform;
    
    // StructProperty /Script/ControlRig.RigControlCopy:LocalTransform
    static readonly int LocalTransform_Offset;
    public UnrealSharp.Transform LocalTransform;
    
    // StructProperty /Script/ControlRig.RigControlCopy:GlobalTransform
    static readonly int GlobalTransform_Offset;
    public UnrealSharp.Transform GlobalTransform;
    
    
    public static readonly int NativeDataSize;
    static RigControlCopy()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigControlCopy");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        ControlType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControlType");
        ParentKey_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentKey");
        OffsetTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OffsetTransform");
        ParentTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentTransform");
        LocalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LocalTransform");
        GlobalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GlobalTransform");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigControlCopy(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            ControlType = BlittableMarshaller<UnrealSharp.ControlRig.ERigControlType>.FromNative(IntPtr.Add(InNativeStruct, ControlType_Offset), 0, null);
            ParentKey = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParentKey_Offset), 0, null);
            OffsetTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, OffsetTransform_Offset), 0, null);
            ParentTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, ParentTransform_Offset), 0, null);
            LocalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, LocalTransform_Offset), 0, null);
            GlobalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, GlobalTransform_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigControlType>.ToNative(IntPtr.Add(Buffer, ControlType_Offset), 0, null, ControlType);
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, ParentKey_Offset), 0, null, ParentKey);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, OffsetTransform_Offset), 0, null, OffsetTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, ParentTransform_Offset), 0, null, ParentTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, LocalTransform_Offset), 0, null, LocalTransform);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, GlobalTransform_Offset), 0, null, GlobalTransform);
        }
    }
}

public static class RigControlCopyMarshaler
{
    public static RigControlCopy FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigControlCopy(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigControlCopy obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigControlCopy.NativeDataSize;
    }
}