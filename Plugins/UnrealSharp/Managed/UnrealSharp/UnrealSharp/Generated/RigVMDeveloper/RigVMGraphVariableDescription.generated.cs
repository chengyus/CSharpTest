using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVMDeveloper;

[UStruct]
public partial struct RigVMGraphVariableDescription
{
    // NameProperty /Script/RigVMDeveloper.RigVMGraphVariableDescription:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // ObjectProperty /Script/RigVMDeveloper.RigVMGraphVariableDescription:CPPTypeObject
    static readonly int CPPTypeObject_Offset;
    public UnrealSharp.CoreUObject.Object CPPTypeObject;
    
    
    public static readonly int NativeDataSize;
    static RigVMGraphVariableDescription()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RigVMGraphVariableDescription");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        CPPTypeObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CPPTypeObject");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RigVMGraphVariableDescription(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            CPPTypeObject = ObjectMarshaller<UnrealSharp.CoreUObject.Object>.FromNative(IntPtr.Add(InNativeStruct, CPPTypeObject_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(Buffer, CPPTypeObject_Offset), 0, null, CPPTypeObject);
        }
    }
}

public static class RigVMGraphVariableDescriptionMarshaler
{
    public static RigVMGraphVariableDescription FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RigVMGraphVariableDescription(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RigVMGraphVariableDescription obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RigVMGraphVariableDescription.NativeDataSize;
    }
}