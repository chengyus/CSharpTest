using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct BlackboardKeySelector
{
    // NameProperty /Script/AIModule.BlackboardKeySelector:SelectedKeyName
    static readonly int SelectedKeyName_Offset;
    public Name SelectedKeyName;
    
    // ClassProperty /Script/AIModule.BlackboardKeySelector:SelectedKeyType
    static readonly int SelectedKeyType_Offset;
    public SubclassOf<UnrealSharp.AIModule.BlackboardKeyType> SelectedKeyType;
    
    // IntProperty /Script/AIModule.BlackboardKeySelector:SelectedKeyID
    static readonly int SelectedKeyID_Offset;
    public int SelectedKeyID;
    
    // BoolProperty /Script/AIModule.BlackboardKeySelector:bNoneIsAllowedValue
    static readonly int bNoneIsAllowedValue_Offset;
    static readonly IntPtr bNoneIsAllowedValue_NativeProperty;
    public bool NoneIsAllowedValue;
    
    
    public static readonly int NativeDataSize;
    static BlackboardKeySelector()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BlackboardKeySelector");
        
        SelectedKeyName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectedKeyName");
        SelectedKeyType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectedKeyType");
        SelectedKeyID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectedKeyID");
        bNoneIsAllowedValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNoneIsAllowedValue");
        bNoneIsAllowedValue_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bNoneIsAllowedValue");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BlackboardKeySelector(IntPtr InNativeStruct)
    {
        unsafe
        {
            SelectedKeyName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, SelectedKeyName_Offset), 0, null);
            SelectedKeyType = SubclassOfMarshaller<UnrealSharp.AIModule.BlackboardKeyType>.FromNative(IntPtr.Add(InNativeStruct, SelectedKeyType_Offset), 0, null);
            SelectedKeyID = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, SelectedKeyID_Offset), 0, null);
            NoneIsAllowedValue = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bNoneIsAllowedValue_NativeProperty, bNoneIsAllowedValue_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, SelectedKeyName_Offset), 0, null, SelectedKeyName);
            SubclassOfMarshaller<UnrealSharp.AIModule.BlackboardKeyType>.ToNative(IntPtr.Add(Buffer, SelectedKeyType_Offset), 0, null, SelectedKeyType);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, SelectedKeyID_Offset), 0, null, SelectedKeyID);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bNoneIsAllowedValue_NativeProperty, bNoneIsAllowedValue_Offset, NoneIsAllowedValue);
        }
    }
}

public static class BlackboardKeySelectorMarshaler
{
    public static BlackboardKeySelector FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BlackboardKeySelector(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BlackboardKeySelector obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BlackboardKeySelector.NativeDataSize;
    }
}