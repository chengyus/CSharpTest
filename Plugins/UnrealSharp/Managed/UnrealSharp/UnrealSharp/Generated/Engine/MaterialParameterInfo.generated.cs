using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MaterialParameterInfo
{
    // NameProperty /Script/Engine.MaterialParameterInfo:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // ByteProperty /Script/Engine.MaterialParameterInfo:Association
    static readonly int Association_Offset;
    public UnrealSharp.Engine.EMaterialParameterAssociation Association;
    
    // IntProperty /Script/Engine.MaterialParameterInfo:Index
    static readonly int Index_Offset;
    public int Index;
    
    
    public static readonly int NativeDataSize;
    static MaterialParameterInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MaterialParameterInfo");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Association_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Association");
        Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Index");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MaterialParameterInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Association = BlittableMarshaller<UnrealSharp.Engine.EMaterialParameterAssociation>.FromNative(IntPtr.Add(InNativeStruct, Association_Offset), 0, null);
            Index = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Index_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.Engine.EMaterialParameterAssociation>.ToNative(IntPtr.Add(Buffer, Association_Offset), 0, null, Association);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Index_Offset), 0, null, Index);
        }
    }
}

public static class MaterialParameterInfoMarshaler
{
    public static MaterialParameterInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MaterialParameterInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MaterialParameterInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MaterialParameterInfo.NativeDataSize;
    }
}