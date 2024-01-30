using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct BaseComponentReference
{
    // NameProperty /Script/Engine.BaseComponentReference:ComponentProperty
    static readonly int ComponentProperty_Offset;
    public Name ComponentProperty;
    
    
    public static readonly int NativeDataSize;
    static BaseComponentReference()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BaseComponentReference");
        
        ComponentProperty_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ComponentProperty");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BaseComponentReference(IntPtr InNativeStruct)
    {
        unsafe
        {
            ComponentProperty = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ComponentProperty_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ComponentProperty_Offset), 0, null, ComponentProperty);
        }
    }
}

public static class BaseComponentReferenceMarshaler
{
    public static BaseComponentReference FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BaseComponentReference(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BaseComponentReference obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BaseComponentReference.NativeDataSize;
    }
}