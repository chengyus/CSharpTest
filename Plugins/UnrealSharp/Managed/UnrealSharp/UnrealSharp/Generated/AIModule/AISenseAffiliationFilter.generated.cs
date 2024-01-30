using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UStruct]
public partial struct AISenseAffiliationFilter
{
    // BoolProperty /Script/AIModule.AISenseAffiliationFilter:bDetectEnemies
    static readonly int bDetectEnemies_Offset;
    static readonly IntPtr bDetectEnemies_NativeProperty;
    public bool DetectEnemies;
    
    // BoolProperty /Script/AIModule.AISenseAffiliationFilter:bDetectNeutrals
    static readonly int bDetectNeutrals_Offset;
    static readonly IntPtr bDetectNeutrals_NativeProperty;
    public bool DetectNeutrals;
    
    // BoolProperty /Script/AIModule.AISenseAffiliationFilter:bDetectFriendlies
    static readonly int bDetectFriendlies_Offset;
    static readonly IntPtr bDetectFriendlies_NativeProperty;
    public bool DetectFriendlies;
    
    
    public static readonly int NativeDataSize;
    static AISenseAffiliationFilter()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AISenseAffiliationFilter");
        
        bDetectEnemies_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDetectEnemies");
        bDetectEnemies_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDetectEnemies");
        bDetectNeutrals_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDetectNeutrals");
        bDetectNeutrals_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDetectNeutrals");
        bDetectFriendlies_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bDetectFriendlies");
        bDetectFriendlies_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bDetectFriendlies");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AISenseAffiliationFilter(IntPtr InNativeStruct)
    {
        unsafe
        {
            DetectEnemies = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDetectEnemies_NativeProperty, bDetectEnemies_Offset);
            DetectNeutrals = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDetectNeutrals_NativeProperty, bDetectNeutrals_Offset);
            DetectFriendlies = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bDetectFriendlies_NativeProperty, bDetectFriendlies_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDetectEnemies_NativeProperty, bDetectEnemies_Offset, DetectEnemies);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDetectNeutrals_NativeProperty, bDetectNeutrals_Offset, DetectNeutrals);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bDetectFriendlies_NativeProperty, bDetectFriendlies_Offset, DetectFriendlies);
        }
    }
}

public static class AISenseAffiliationFilterMarshaler
{
    public static AISenseAffiliationFilter FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AISenseAffiliationFilter(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AISenseAffiliationFilter obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AISenseAffiliationFilter.NativeDataSize;
    }
}