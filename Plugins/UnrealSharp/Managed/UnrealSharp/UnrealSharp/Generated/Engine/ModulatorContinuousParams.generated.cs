using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ModulatorContinuousParams
{
    // NameProperty /Script/Engine.ModulatorContinuousParams:ParameterName
    static readonly int ParameterName_Offset;
    public Name ParameterName;
    
    
    public static readonly int NativeDataSize;
    static ModulatorContinuousParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ModulatorContinuousParams");
        
        ParameterName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParameterName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ModulatorContinuousParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParameterName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ParameterName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ParameterName_Offset), 0, null, ParameterName);
        }
    }
}

public static class ModulatorContinuousParamsMarshaler
{
    public static ModulatorContinuousParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ModulatorContinuousParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ModulatorContinuousParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ModulatorContinuousParams.NativeDataSize;
    }
}