using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_ModifyBone
{
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ModifyBone:Translation
    static readonly int Translation_Offset;
    public System.DoubleNumerics.Vector3 Translation;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ModifyBone:Rotation
    static readonly int Rotation_Offset;
    public UnrealSharp.Rotator Rotation;
    
    // StructProperty /Script/AnimGraphRuntime.AnimNode_ModifyBone:Scale
    static readonly int Scale_Offset;
    public System.DoubleNumerics.Vector3 Scale;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_ModifyBone()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_ModifyBone");
        
        Translation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Translation");
        Rotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rotation");
        Scale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Scale");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_ModifyBone(IntPtr InNativeStruct)
    {
        unsafe
        {
            Translation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Translation_Offset), 0, null);
            Rotation = BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(InNativeStruct, Rotation_Offset), 0, null);
            Scale = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Scale_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Translation_Offset), 0, null, Translation);
            BlittableMarshaller<UnrealSharp.Rotator>.ToNative(IntPtr.Add(Buffer, Rotation_Offset), 0, null, Rotation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Scale_Offset), 0, null, Scale);
        }
    }
}

public static class AnimNode_ModifyBoneMarshaler
{
    public static AnimNode_ModifyBone FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_ModifyBone(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_ModifyBone obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_ModifyBone.NativeDataSize;
    }
}