using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SubobjectDataInterface;

[UStruct]
public partial struct AddNewSubobjectParams
{
    // StructProperty /Script/SubobjectDataInterface.AddNewSubobjectParams:ParentHandle
    static readonly int ParentHandle_Offset;
    public UnrealSharp.SubobjectDataInterface.SubobjectDataHandle ParentHandle;
    
    // ObjectProperty /Script/SubobjectDataInterface.AddNewSubobjectParams:BlueprintContext
    static readonly int BlueprintContext_Offset;
    public UnrealSharp.Engine.Blueprint BlueprintContext;
    
    // BoolProperty /Script/SubobjectDataInterface.AddNewSubobjectParams:bSkipMarkBlueprintModified
    static readonly int bSkipMarkBlueprintModified_Offset;
    static readonly IntPtr bSkipMarkBlueprintModified_NativeProperty;
    public bool SkipMarkBlueprintModified;
    
    // BoolProperty /Script/SubobjectDataInterface.AddNewSubobjectParams:bConformTransformToParent
    static readonly int bConformTransformToParent_Offset;
    static readonly IntPtr bConformTransformToParent_NativeProperty;
    public bool ConformTransformToParent;
    
    
    public static readonly int NativeDataSize;
    static AddNewSubobjectParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AddNewSubobjectParams");
        
        ParentHandle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentHandle");
        BlueprintContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlueprintContext");
        bSkipMarkBlueprintModified_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipMarkBlueprintModified");
        bSkipMarkBlueprintModified_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bSkipMarkBlueprintModified");
        bConformTransformToParent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bConformTransformToParent");
        bConformTransformToParent_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bConformTransformToParent");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AddNewSubobjectParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            ParentHandle = UnrealSharp.SubobjectDataInterface.SubobjectDataHandleMarshaler.FromNative(IntPtr.Add(InNativeStruct, ParentHandle_Offset), 0, null);
            BlueprintContext = ObjectMarshaller<UnrealSharp.Engine.Blueprint>.FromNative(IntPtr.Add(InNativeStruct, BlueprintContext_Offset), 0, null);
            SkipMarkBlueprintModified = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bSkipMarkBlueprintModified_NativeProperty, bSkipMarkBlueprintModified_Offset);
            ConformTransformToParent = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bConformTransformToParent_NativeProperty, bConformTransformToParent_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.SubobjectDataInterface.SubobjectDataHandleMarshaler.ToNative(IntPtr.Add(Buffer, ParentHandle_Offset), 0, null, ParentHandle);
            ObjectMarshaller<UnrealSharp.Engine.Blueprint>.ToNative(IntPtr.Add(Buffer, BlueprintContext_Offset), 0, null, BlueprintContext);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bSkipMarkBlueprintModified_NativeProperty, bSkipMarkBlueprintModified_Offset, SkipMarkBlueprintModified);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bConformTransformToParent_NativeProperty, bConformTransformToParent_Offset, ConformTransformToParent);
        }
    }
}

public static class AddNewSubobjectParamsMarshaler
{
    public static AddNewSubobjectParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AddNewSubobjectParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AddNewSubobjectParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AddNewSubobjectParams.NativeDataSize;
    }
}