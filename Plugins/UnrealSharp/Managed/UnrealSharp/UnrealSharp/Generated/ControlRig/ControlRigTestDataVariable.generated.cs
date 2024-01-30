using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UStruct]
public partial struct ControlRigTestDataVariable
{
    // NameProperty /Script/ControlRig.ControlRigTestDataVariable:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // NameProperty /Script/ControlRig.ControlRigTestDataVariable:CPPType
    static readonly int CPPType_Offset;
    public Name CPPType;
    
    
    public static readonly int NativeDataSize;
    static ControlRigTestDataVariable()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ControlRigTestDataVariable");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        CPPType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CPPType");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ControlRigTestDataVariable(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            CPPType = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, CPPType_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, CPPType_Offset), 0, null, CPPType);
        }
    }
}

public static class ControlRigTestDataVariableMarshaler
{
    public static ControlRigTestDataVariable FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ControlRigTestDataVariable(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ControlRigTestDataVariable obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ControlRigTestDataVariable.NativeDataSize;
    }
}