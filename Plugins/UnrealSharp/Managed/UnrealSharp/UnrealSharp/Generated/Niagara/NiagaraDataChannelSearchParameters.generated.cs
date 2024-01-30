using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Niagara;

[UStruct]
public partial struct NiagaraDataChannelSearchParameters
{
    // ObjectProperty /Script/Niagara.NiagaraDataChannelSearchParameters:OwningComponent
    static readonly int OwningComponent_Offset;
    public UnrealSharp.Engine.SceneComponent OwningComponent;
    
    // StructProperty /Script/Niagara.NiagaraDataChannelSearchParameters:Location
    static readonly int Location_Offset;
    public System.DoubleNumerics.Vector3 Location;
    
    
    public static readonly int NativeDataSize;
    static NiagaraDataChannelSearchParameters()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NiagaraDataChannelSearchParameters");
        
        OwningComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "OwningComponent");
        Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Location");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NiagaraDataChannelSearchParameters(IntPtr InNativeStruct)
    {
        unsafe
        {
            OwningComponent = ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.FromNative(IntPtr.Add(InNativeStruct, OwningComponent_Offset), 0, null);
            Location = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Location_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.SceneComponent>.ToNative(IntPtr.Add(Buffer, OwningComponent_Offset), 0, null, OwningComponent);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Location_Offset), 0, null, Location);
        }
    }
}

public static class NiagaraDataChannelSearchParametersMarshaler
{
    public static NiagaraDataChannelSearchParameters FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NiagaraDataChannelSearchParameters(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NiagaraDataChannelSearchParameters obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NiagaraDataChannelSearchParameters.NativeDataSize;
    }
}