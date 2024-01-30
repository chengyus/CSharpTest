using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct AssetManagerSearchRules
{
    // BoolProperty /Script/Engine.AssetManagerSearchRules:bHasBlueprintClasses
    static readonly int bHasBlueprintClasses_Offset;
    public bool HasBlueprintClasses;
    
    // BoolProperty /Script/Engine.AssetManagerSearchRules:bForceSynchronousScan
    static readonly int bForceSynchronousScan_Offset;
    public bool ForceSynchronousScan;
    
    // BoolProperty /Script/Engine.AssetManagerSearchRules:bSkipVirtualPathExpansion
    static readonly int bSkipVirtualPathExpansion_Offset;
    public bool SkipVirtualPathExpansion;
    
    // BoolProperty /Script/Engine.AssetManagerSearchRules:bSkipManagerIncludeCheck
    static readonly int bSkipManagerIncludeCheck_Offset;
    public bool SkipManagerIncludeCheck;
    
    
    public static readonly int NativeDataSize;
    static AssetManagerSearchRules()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AssetManagerSearchRules");
        
        bHasBlueprintClasses_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHasBlueprintClasses");
        bForceSynchronousScan_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceSynchronousScan");
        bSkipVirtualPathExpansion_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipVirtualPathExpansion");
        bSkipManagerIncludeCheck_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bSkipManagerIncludeCheck");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AssetManagerSearchRules(IntPtr InNativeStruct)
    {
        unsafe
        {
            HasBlueprintClasses = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHasBlueprintClasses_Offset), 0, null);
            ForceSynchronousScan = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bForceSynchronousScan_Offset), 0, null);
            SkipVirtualPathExpansion = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipVirtualPathExpansion_Offset), 0, null);
            SkipManagerIncludeCheck = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bSkipManagerIncludeCheck_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHasBlueprintClasses_Offset), 0, null, HasBlueprintClasses);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bForceSynchronousScan_Offset), 0, null, ForceSynchronousScan);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipVirtualPathExpansion_Offset), 0, null, SkipVirtualPathExpansion);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bSkipManagerIncludeCheck_Offset), 0, null, SkipManagerIncludeCheck);
        }
    }
}

public static class AssetManagerSearchRulesMarshaler
{
    public static AssetManagerSearchRules FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AssetManagerSearchRules(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AssetManagerSearchRules obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AssetManagerSearchRules.NativeDataSize;
    }
}