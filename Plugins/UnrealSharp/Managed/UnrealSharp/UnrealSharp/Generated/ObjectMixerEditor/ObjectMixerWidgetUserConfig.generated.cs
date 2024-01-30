using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ObjectMixerEditor;

[UStruct]
public partial struct ObjectMixerWidgetUserConfig
{
    // ClassProperty /Script/ObjectMixerEditor.ObjectMixerWidgetUserConfig:DefaultFilterClass
    static readonly int DefaultFilterClass_Offset;
    public SubclassOf<UnrealSharp.ObjectMixerEditor.ObjectMixerObjectFilter> DefaultFilterClass;
    
    
    public static readonly int NativeDataSize;
    static ObjectMixerWidgetUserConfig()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ObjectMixerWidgetUserConfig");
        
        DefaultFilterClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultFilterClass");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ObjectMixerWidgetUserConfig(IntPtr InNativeStruct)
    {
        unsafe
        {
            DefaultFilterClass = SubclassOfMarshaller<UnrealSharp.ObjectMixerEditor.ObjectMixerObjectFilter>.FromNative(IntPtr.Add(InNativeStruct, DefaultFilterClass_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.ObjectMixerEditor.ObjectMixerObjectFilter>.ToNative(IntPtr.Add(Buffer, DefaultFilterClass_Offset), 0, null, DefaultFilterClass);
        }
    }
}

public static class ObjectMixerWidgetUserConfigMarshaler
{
    public static ObjectMixerWidgetUserConfig FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ObjectMixerWidgetUserConfig(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ObjectMixerWidgetUserConfig obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ObjectMixerWidgetUserConfig.NativeDataSize;
    }
}