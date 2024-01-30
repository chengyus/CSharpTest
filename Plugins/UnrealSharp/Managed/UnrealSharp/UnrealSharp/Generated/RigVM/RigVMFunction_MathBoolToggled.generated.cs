using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UStruct]
public partial struct RigVMFunction_MathBoolToggled
{
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolToggled:Value
    static readonly int Value_Offset;
    public bool Value;
    
    // BoolProperty /Script/RigVM.RigVMFunction_MathBoolToggled:Toggled
    static readonly int Toggled_Offset;
    public bool Toggled;
    
    
    public static readonly int NativeDataSize;
    static RigVMFunction_MathBoolToggled()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMFunction_MathBoolToggled");
        
        Value_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Value");
        Toggled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Toggled");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMFunction_MathBoolToggled(IntPtr InNativeStruct)
    {
        unsafe
        {
            Value = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Value_Offset), 0, null);
            Toggled = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Toggled_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Value_Offset), 0, null, Value);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Toggled_Offset), 0, null, Toggled);
        }
    }
}

public static class RigVMFunction_MathBoolToggledMarshaler
{
    public static RigVMFunction_MathBoolToggled FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMFunction_MathBoolToggled(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMFunction_MathBoolToggled obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMFunction_MathBoolToggled.NativeDataSize;
    }
}