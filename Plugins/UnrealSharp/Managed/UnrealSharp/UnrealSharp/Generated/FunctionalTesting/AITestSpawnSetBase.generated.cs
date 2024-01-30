using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct AITestSpawnSetBase
{
    // NameProperty /Script/FunctionalTesting.AITestSpawnSetBase:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // BoolProperty /Script/FunctionalTesting.AITestSpawnSetBase:bEnabled
    static readonly int bEnabled_Offset;
    static readonly IntPtr bEnabled_NativeProperty;
    public bool Enabled;
    
    // ObjectProperty /Script/FunctionalTesting.AITestSpawnSetBase:FallbackSpawnLocation
    static readonly int FallbackSpawnLocation_Offset;
    public UnrealSharp.Engine.Actor FallbackSpawnLocation;
    
    
    public static readonly int NativeDataSize;
    static AITestSpawnSetBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AITestSpawnSetBase");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        bEnabled_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnabled");
        bEnabled_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bEnabled");
        FallbackSpawnLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FallbackSpawnLocation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AITestSpawnSetBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Enabled = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bEnabled_NativeProperty, bEnabled_Offset);
            FallbackSpawnLocation = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, FallbackSpawnLocation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bEnabled_NativeProperty, bEnabled_Offset, Enabled);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, FallbackSpawnLocation_Offset), 0, null, FallbackSpawnLocation);
        }
    }
}

public static class AITestSpawnSetBaseMarshaler
{
    public static AITestSpawnSetBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AITestSpawnSetBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AITestSpawnSetBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AITestSpawnSetBase.NativeDataSize;
    }
}