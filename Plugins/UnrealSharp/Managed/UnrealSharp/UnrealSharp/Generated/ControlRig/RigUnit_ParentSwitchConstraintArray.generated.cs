using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct RigUnit_ParentSwitchConstraintArray
{
    // StructProperty /Script/ControlRig.RigUnit_ParentSwitchConstraintArray:Subject
    static readonly int Subject_Offset;
    public UnrealSharp.ControlRig.RigElementKey Subject;
    
    // IntProperty /Script/ControlRig.RigUnit_ParentSwitchConstraintArray:ParentIndex
    static readonly int ParentIndex_Offset;
    public int ParentIndex;
    
    // StructProperty /Script/ControlRig.RigUnit_ParentSwitchConstraintArray:InitialGlobalTransform
    static readonly int InitialGlobalTransform_Offset;
    public UnrealSharp.Transform InitialGlobalTransform;
    
    // FloatProperty /Script/ControlRig.RigUnit_ParentSwitchConstraintArray:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // StructProperty /Script/ControlRig.RigUnit_ParentSwitchConstraintArray:Transform
    static readonly int Transform_Offset;
    public UnrealSharp.Transform Transform;
    
    // BoolProperty /Script/ControlRig.RigUnit_ParentSwitchConstraintArray:Switched
    static readonly int Switched_Offset;
    public bool Switched;
    
    
    public static readonly int NativeDataSize;
    static RigUnit_ParentSwitchConstraintArray()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigUnit_ParentSwitchConstraintArray");
        
        Subject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Subject");
        ParentIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentIndex");
        InitialGlobalTransform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InitialGlobalTransform");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        Transform_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Transform");
        Switched_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Switched");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigUnit_ParentSwitchConstraintArray(IntPtr InNativeStruct)
    {
        unsafe
        {
            Subject = UnrealSharp.ControlRig.RigElementKeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Subject_Offset), 0, null);
            ParentIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ParentIndex_Offset), 0, null);
            InitialGlobalTransform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, InitialGlobalTransform_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            Transform = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Transform_Offset), 0, null);
            Switched = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Switched_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.ControlRig.RigElementKeyMarshaler.ToNative(IntPtr.Add(Buffer, Subject_Offset), 0, null, Subject);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ParentIndex_Offset), 0, null, ParentIndex);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, InitialGlobalTransform_Offset), 0, null, InitialGlobalTransform);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Transform_Offset), 0, null, Transform);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Switched_Offset), 0, null, Switched);
        }
    }
}

public static class RigUnit_ParentSwitchConstraintArrayMarshaler
{
    public static RigUnit_ParentSwitchConstraintArray FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigUnit_ParentSwitchConstraintArray(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigUnit_ParentSwitchConstraintArray obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigUnit_ParentSwitchConstraintArray.NativeDataSize;
    }
}