using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakesCore;

[UStruct]
public partial struct ActorRecordedProperty
{
    // NameProperty /Script/TakesCore.ActorRecordedProperty:PropertyName
    static readonly int PropertyName_Offset;
    public Name PropertyName;
    
    // BoolProperty /Script/TakesCore.ActorRecordedProperty:bEnabled
    static readonly int bEnabled_Offset;
    public bool Enabled;
    
    
    public static readonly int NativeDataSize;
    static ActorRecordedProperty()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ActorRecordedProperty");
        
        PropertyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PropertyName");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ActorRecordedProperty(IntPtr InNativeStruct)
    {
        unsafe
        {
            PropertyName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PropertyName_Offset), 0, null);
            Enabled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnabled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PropertyName_Offset), 0, null, PropertyName);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnabled_Offset), 0, null, Enabled);
        }
    }
}

public static class ActorRecordedPropertyMarshaler
{
    public static ActorRecordedProperty FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ActorRecordedProperty(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ActorRecordedProperty obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ActorRecordedProperty.NativeDataSize;
    }
}