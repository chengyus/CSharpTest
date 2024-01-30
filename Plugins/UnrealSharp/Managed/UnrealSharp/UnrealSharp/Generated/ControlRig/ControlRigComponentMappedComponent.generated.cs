using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct ControlRigComponentMappedComponent
{
    // ObjectProperty /Script/ControlRig.ControlRigComponentMappedComponent:Component
    static readonly int Component_Offset;
    public UnrealSharp.Engine.SceneComponent Component;
    
    // NameProperty /Script/ControlRig.ControlRigComponentMappedComponent:ElementName
    static readonly int ElementName_Offset;
    public Name ElementName;
    
    // EnumProperty /Script/ControlRig.ControlRigComponentMappedComponent:ElementType
    static readonly int ElementType_Offset;
    public UnrealSharp.ControlRig.ERigElementType ElementType;
    
    // EnumProperty /Script/ControlRig.ControlRigComponentMappedComponent:Direction
    static readonly int Direction_Offset;
    public UnrealSharp.ControlRig.EControlRigComponentMapDirection Direction;
    
    
    public static readonly int NativeDataSize;
    static ControlRigComponentMappedComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigComponentMappedComponent");
        
        Component_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Component");
        ElementName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementName");
        ElementType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ElementType");
        Direction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Direction");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigComponentMappedComponent(IntPtr InNativeStruct)
    {
        unsafe
        {
            Component = ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.FromNative(IntPtr.Add(InNativeStruct, Component_Offset), 0, null);
            ElementName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ElementName_Offset), 0, null);
            ElementType = BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.FromNative(IntPtr.Add(InNativeStruct, ElementType_Offset), 0, null);
            Direction = BlittableMarshaller<UnrealSharp.ControlRig.EControlRigComponentMapDirection>.FromNative(IntPtr.Add(InNativeStruct, Direction_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.ToNative(IntPtr.Add(Buffer, Component_Offset), 0, null, Component);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ElementName_Offset), 0, null, ElementName);
            BlittableMarshaller<UnrealSharp.ControlRig.ERigElementType>.ToNative(IntPtr.Add(Buffer, ElementType_Offset), 0, null, ElementType);
            BlittableMarshaller<UnrealSharp.ControlRig.EControlRigComponentMapDirection>.ToNative(IntPtr.Add(Buffer, Direction_Offset), 0, null, Direction);
        }
    }
}

public static class ControlRigComponentMappedComponentMarshaler
{
    public static ControlRigComponentMappedComponent FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigComponentMappedComponent(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigComponentMappedComponent obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigComponentMappedComponent.NativeDataSize;
    }
}