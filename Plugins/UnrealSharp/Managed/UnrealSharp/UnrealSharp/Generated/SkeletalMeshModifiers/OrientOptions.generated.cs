using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SkeletalMeshModifiers;

[UStruct]
public partial struct OrientOptions
{
    // ByteProperty /Script/SkeletalMeshModifiers.OrientOptions:Primary
    static readonly int Primary_Offset;
    public UnrealSharp.CoreUObject.EAxis Primary;
    
    // ByteProperty /Script/SkeletalMeshModifiers.OrientOptions:Secondary
    static readonly int Secondary_Offset;
    public UnrealSharp.CoreUObject.EAxis Secondary;
    
    // BoolProperty /Script/SkeletalMeshModifiers.OrientOptions:bUsePlaneAsSecondary
    static readonly int bUsePlaneAsSecondary_Offset;
    public bool UsePlaneAsSecondary;
    
    // StructProperty /Script/SkeletalMeshModifiers.OrientOptions:SecondaryTarget
    static readonly int SecondaryTarget_Offset;
    public System.DoubleNumerics.Vector3 SecondaryTarget;
    
    // BoolProperty /Script/SkeletalMeshModifiers.OrientOptions:bOrientChildren
    static readonly int bOrientChildren_Offset;
    public bool OrientChildren;
    
    
    public static readonly int NativeDataSize;
    static OrientOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("OrientOptions");
        
        Primary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Primary");
        Secondary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Secondary");
        bUsePlaneAsSecondary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUsePlaneAsSecondary");
        SecondaryTarget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SecondaryTarget");
        bOrientChildren_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bOrientChildren");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public OrientOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            Primary = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, Primary_Offset), 0, null);
            Secondary = BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.FromNative(IntPtr.Add(InNativeStruct, Secondary_Offset), 0, null);
            UsePlaneAsSecondary = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bUsePlaneAsSecondary_Offset), 0, null);
            SecondaryTarget = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, SecondaryTarget_Offset), 0, null);
            OrientChildren = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bOrientChildren_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, Primary_Offset), 0, null, Primary);
            BlittableMarshaller<UnrealSharp.CoreUObject.EAxis>.ToNative(IntPtr.Add(Buffer, Secondary_Offset), 0, null, Secondary);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bUsePlaneAsSecondary_Offset), 0, null, UsePlaneAsSecondary);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, SecondaryTarget_Offset), 0, null, SecondaryTarget);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bOrientChildren_Offset), 0, null, OrientChildren);
        }
    }
}

public static class OrientOptionsMarshaler
{
    public static OrientOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new OrientOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, OrientOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return OrientOptions.NativeDataSize;
    }
}