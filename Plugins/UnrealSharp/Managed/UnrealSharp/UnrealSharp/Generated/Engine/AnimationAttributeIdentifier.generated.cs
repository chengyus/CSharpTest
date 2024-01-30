using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AnimationAttributeIdentifier
{
    // NameProperty /Script/Engine.AnimationAttributeIdentifier:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // NameProperty /Script/Engine.AnimationAttributeIdentifier:BoneName
    static readonly int BoneName_Offset;
    public Name BoneName;
    
    // IntProperty /Script/Engine.AnimationAttributeIdentifier:BoneIndex
    static readonly int BoneIndex_Offset;
    public int BoneIndex;
    
    // ObjectProperty /Script/Engine.AnimationAttributeIdentifier:ScriptStruct
    static readonly int ScriptStruct_Offset;
    public UnrealSharp.CoreUObject.ScriptStruct ScriptStruct;
    
    // StructProperty /Script/Engine.AnimationAttributeIdentifier:ScriptStructPath
    static readonly int ScriptStructPath_Offset;
    public UnrealSharp.CoreUObject.SoftObjectPath ScriptStructPath;
    
    
    public static readonly int NativeDataSize;
    static AnimationAttributeIdentifier()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimationAttributeIdentifier");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneName");
        BoneIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneIndex");
        ScriptStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScriptStruct");
        ScriptStructPath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ScriptStructPath");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimationAttributeIdentifier(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            BoneName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, BoneName_Offset), 0, null);
            BoneIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, BoneIndex_Offset), 0, null);
            ScriptStruct = ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.FromNative(IntPtr.Add(InNativeStruct, ScriptStruct_Offset), 0, null);
            ScriptStructPath = UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, ScriptStructPath_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, BoneName_Offset), 0, null, BoneName);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, BoneIndex_Offset), 0, null, BoneIndex);
            ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.ToNative(IntPtr.Add(Buffer, ScriptStruct_Offset), 0, null, ScriptStruct);
            UnrealSharp.CoreUObject.SoftObjectPathMarshaler.ToNative(IntPtr.Add(Buffer, ScriptStructPath_Offset), 0, null, ScriptStructPath);
        }
    }
}

public static class AnimationAttributeIdentifierMarshaler
{
    public static AnimationAttributeIdentifier FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimationAttributeIdentifier(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimationAttributeIdentifier obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimationAttributeIdentifier.NativeDataSize;
    }
}