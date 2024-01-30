using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct RetargetGlobalSettings
{
    // BoolProperty /Script/IKRig.RetargetGlobalSettings:bEnableRoot
    static readonly int bEnableRoot_Offset;
    public bool EnableRoot;
    
    // BoolProperty /Script/IKRig.RetargetGlobalSettings:bEnableFK
    static readonly int bEnableFK_Offset;
    public bool EnableFK;
    
    // BoolProperty /Script/IKRig.RetargetGlobalSettings:bEnableIK
    static readonly int bEnableIK_Offset;
    public bool EnableIK;
    
    // BoolProperty /Script/IKRig.RetargetGlobalSettings:bWarping
    static readonly int bWarping_Offset;
    public bool Warping;
    
    // EnumProperty /Script/IKRig.RetargetGlobalSettings:DirectionSource
    static readonly int DirectionSource_Offset;
    public UnrealSharp.IKRig.EWarpingDirectionSource DirectionSource;
    
    // EnumProperty /Script/IKRig.RetargetGlobalSettings:ForwardDirection
    static readonly int ForwardDirection_Offset;
    public UnrealSharp.IKRig.EBasicAxis ForwardDirection;
    
    // NameProperty /Script/IKRig.RetargetGlobalSettings:DirectionChain
    static readonly int DirectionChain_Offset;
    public Name DirectionChain;
    
    // FloatProperty /Script/IKRig.RetargetGlobalSettings:WarpForwards
    static readonly int WarpForwards_Offset;
    public float WarpForwards;
    
    // FloatProperty /Script/IKRig.RetargetGlobalSettings:SidewaysOffset
    static readonly int SidewaysOffset_Offset;
    public float SidewaysOffset;
    
    // FloatProperty /Script/IKRig.RetargetGlobalSettings:WarpSplay
    static readonly int WarpSplay_Offset;
    public float WarpSplay;
    
    
    public static readonly int NativeDataSize;
    static RetargetGlobalSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RetargetGlobalSettings");
        
        bEnableRoot_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableRoot");
        bEnableFK_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableFK");
        bEnableIK_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableIK");
        bWarping_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWarping");
        DirectionSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DirectionSource");
        ForwardDirection_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ForwardDirection");
        DirectionChain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DirectionChain");
        WarpForwards_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WarpForwards");
        SidewaysOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SidewaysOffset");
        WarpSplay_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WarpSplay");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RetargetGlobalSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            EnableRoot = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableRoot_Offset), 0, null);
            EnableFK = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableFK_Offset), 0, null);
            EnableIK = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bEnableIK_Offset), 0, null);
            Warping = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bWarping_Offset), 0, null);
            DirectionSource = BlittableMarshaller<UnrealSharp.IKRig.EWarpingDirectionSource>.FromNative(IntPtr.Add(InNativeStruct, DirectionSource_Offset), 0, null);
            ForwardDirection = BlittableMarshaller<UnrealSharp.IKRig.EBasicAxis>.FromNative(IntPtr.Add(InNativeStruct, ForwardDirection_Offset), 0, null);
            DirectionChain = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, DirectionChain_Offset), 0, null);
            WarpForwards = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WarpForwards_Offset), 0, null);
            SidewaysOffset = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, SidewaysOffset_Offset), 0, null);
            WarpSplay = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WarpSplay_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableRoot_Offset), 0, null, EnableRoot);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableFK_Offset), 0, null, EnableFK);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bEnableIK_Offset), 0, null, EnableIK);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bWarping_Offset), 0, null, Warping);
            BlittableMarshaller<UnrealSharp.IKRig.EWarpingDirectionSource>.ToNative(IntPtr.Add(Buffer, DirectionSource_Offset), 0, null, DirectionSource);
            BlittableMarshaller<UnrealSharp.IKRig.EBasicAxis>.ToNative(IntPtr.Add(Buffer, ForwardDirection_Offset), 0, null, ForwardDirection);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, DirectionChain_Offset), 0, null, DirectionChain);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WarpForwards_Offset), 0, null, WarpForwards);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, SidewaysOffset_Offset), 0, null, SidewaysOffset);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WarpSplay_Offset), 0, null, WarpSplay);
        }
    }
}

public static class RetargetGlobalSettingsMarshaler
{
    public static RetargetGlobalSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RetargetGlobalSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RetargetGlobalSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RetargetGlobalSettings.NativeDataSize;
    }
}