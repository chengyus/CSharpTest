using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct ControlRigComponentMappedElement
{
    // StructProperty /Script/ControlRig.ControlRigComponentMappedElement:ComponentReference
    static readonly int ComponentReference_Offset;
    public UnrealSharp.Engine.SoftComponentReference ComponentReference;
    
    // IntProperty /Script/ControlRig.ControlRigComponentMappedElement:TransformIndex
    static readonly int TransformIndex_Offset;
    public int TransformIndex;
    
    // NameProperty /Script/ControlRig.ControlRigComponentMappedElement:TransformName
    static readonly int TransformName_Offset;
    public Name TransformName;
    
    // EnumProperty /Script/ControlRig.ControlRigComponentMappedElement:ElementType
    static readonly int ElementType_Offset;
    public UnrealSharp.ControlRig.ERigElementType ElementType;
    
    // NameProperty /Script/ControlRig.ControlRigComponentMappedElement:ElementName
    static readonly int ElementName_Offset;
    public Name ElementName;
    
    // EnumProperty /Script/ControlRig.ControlRigComponentMappedElement:Direction
    static readonly int Direction_Offset;
    public UnrealSharp.ControlRig.EControlRigComponentMapDirection Direction;
    
    // StructProperty /Script/ControlRig.ControlRigComponentMappedElement:Offset
    static readonly int Offset_Offset;
    public UnrealSharp.Transform Offset;
    
    // FloatProperty /Script/ControlRig.ControlRigComponentMappedElement:Weight
    static readonly int Weight_Offset;
    public float Weight;
    
    // EnumProperty /Script/ControlRig.ControlRigComponentMappedElement:Space
    static readonly int Space_Offset;
    public UnrealSharp.ControlRig.EControlRigComponentSpace Space;
    
    
    public static readonly int NativeDataSize;
    static ControlRigComponentMappedElement()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigComponentMappedElement");
        
        ComponentReference_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComponentReference");
        TransformIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TransformIndex");
        TransformName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TransformName");
        ElementType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementType");
        ElementName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementName");
        Direction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Direction");
        Offset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Offset");
        Weight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Weight");
        Space_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Space");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigComponentMappedElement(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentReference = UnrealSharp.Engine.SoftComponentReferenceMarshaler.FromNative(IntPtr.Add(InNativeStruct, ComponentReference_Offset), 0, null);
            TransformIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, TransformIndex_Offset), 0, null);
            TransformName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, TransformName_Offset), 0, null);
            ElementType = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, ElementType_Offset), 0, null);
            ElementName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ElementName_Offset), 0, null);
            Direction = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigComponentMapDirection>.FromNative(IntPtr.Add(InNativeStruct, Direction_Offset), 0, null);
            Offset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, Offset_Offset), 0, null);
            Weight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Weight_Offset), 0, null);
            Space = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigComponentSpace>.FromNative(IntPtr.Add(InNativeStruct, Space_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.Engine.SoftComponentReferenceMarshaler.ToNative(IntPtr.Add(Buffer, ComponentReference_Offset), 0, null, ComponentReference);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, TransformIndex_Offset), 0, null, TransformIndex);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, TransformName_Offset), 0, null, TransformName);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, ElementType_Offset), 0, null, ElementType);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ElementName_Offset), 0, null, ElementName);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigComponentMapDirection>.ToNative(IntPtr.Add(Buffer, Direction_Offset), 0, null, Direction);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, Offset_Offset), 0, null, Offset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Weight_Offset), 0, null, Weight);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigComponentSpace>.ToNative(IntPtr.Add(Buffer, Space_Offset), 0, null, Space);
        }
    }
}

public static class ControlRigComponentMappedElementMarshaler
{
    public static ControlRigComponentMappedElement FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigComponentMappedElement(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigComponentMappedElement obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigComponentMappedElement.NativeDataSize;
    }
}