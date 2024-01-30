using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct TViewTarget
{
    // ObjectProperty /Script/Engine.TViewTarget:Target
    static readonly int Target_Offset;
    public UnrealSharp.Engine.Actor Target;
    
    // StructProperty /Script/Engine.TViewTarget:POV
    static readonly int POV_Offset;
    public UnrealSharp.Engine.MinimalViewInfo POV;
    
    // ObjectProperty /Script/Engine.TViewTarget:PlayerState
    static readonly int PlayerState_Offset;
    public UnrealSharp.Engine.PlayerState PlayerState;
    
    
    public static readonly int NativeDataSize;
    static TViewTarget()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TViewTarget");
        
        Target_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Target");
        POV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "POV");
        PlayerState_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayerState");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TViewTarget(IntPtr InNativeStruct)
    {
        unsafe
        {
            Target = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, Target_Offset), 0, null);
            POV = UnrealSharp.Engine.MinimalViewInfoMarshaler.FromNative(IntPtr.Add(InNativeStruct, POV_Offset), 0, null);
            PlayerState = ObjectMarshaller<UnrealSharp.Engine.PlayerState>.FromNative(IntPtr.Add(InNativeStruct, PlayerState_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, Target_Offset), 0, null, Target);
            UnrealSharp.Engine.MinimalViewInfoMarshaler.ToNative(IntPtr.Add(Buffer, POV_Offset), 0, null, POV);
            ObjectMarshaller<UnrealSharp.Engine.PlayerState>.ToNative(IntPtr.Add(Buffer, PlayerState_Offset), 0, null, PlayerState);
        }
    }
}

public static class TViewTargetMarshaler
{
    public static TViewTarget FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TViewTarget(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TViewTarget obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TViewTarget.NativeDataSize;
    }
}