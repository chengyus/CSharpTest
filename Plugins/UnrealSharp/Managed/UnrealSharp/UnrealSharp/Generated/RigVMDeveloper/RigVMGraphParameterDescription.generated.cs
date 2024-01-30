using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMDeveloper;

[UStruct]
public partial struct RigVMGraphParameterDescription
{
    // NameProperty /Script/RigVMDeveloper.RigVMGraphParameterDescription:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // BoolProperty /Script/RigVMDeveloper.RigVMGraphParameterDescription:bIsInput
    static readonly int bIsInput_Offset;
    public bool IsInput;
    
    // ObjectProperty /Script/RigVMDeveloper.RigVMGraphParameterDescription:CPPTypeObject
    static readonly int CPPTypeObject_Offset;
    public UnrealSharp.CoreUObject.Object CPPTypeObject;
    
    
    public static readonly int NativeDataSize;
    static RigVMGraphParameterDescription()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMGraphParameterDescription");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        bIsInput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsInput");
        CPPTypeObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CPPTypeObject");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMGraphParameterDescription(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            IsInput = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsInput_Offset), 0, null);
            CPPTypeObject = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, CPPTypeObject_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsInput_Offset), 0, null, IsInput);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, CPPTypeObject_Offset), 0, null, CPPTypeObject);
        }
    }
}

public static class RigVMGraphParameterDescriptionMarshaler
{
    public static RigVMGraphParameterDescription FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMGraphParameterDescription(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMGraphParameterDescription obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMGraphParameterDescription.NativeDataSize;
    }
}