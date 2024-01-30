using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct MovementProperties
{
    // BoolProperty /Script/Engine.MovementProperties:bCanCrouch
    static readonly int bCanCrouch_Offset;
    static readonly IntPtr bCanCrouch_NativeProperty;
    public bool CanCrouch;
    
    // BoolProperty /Script/Engine.MovementProperties:bCanJump
    static readonly int bCanJump_Offset;
    static readonly IntPtr bCanJump_NativeProperty;
    public bool CanJump;
    
    // BoolProperty /Script/Engine.MovementProperties:bCanWalk
    static readonly int bCanWalk_Offset;
    static readonly IntPtr bCanWalk_NativeProperty;
    public bool CanWalk;
    
    // BoolProperty /Script/Engine.MovementProperties:bCanSwim
    static readonly int bCanSwim_Offset;
    static readonly IntPtr bCanSwim_NativeProperty;
    public bool CanSwim;
    
    // BoolProperty /Script/Engine.MovementProperties:bCanFly
    static readonly int bCanFly_Offset;
    static readonly IntPtr bCanFly_NativeProperty;
    public bool CanFly;
    
    
    public static readonly int NativeDataSize;
    static MovementProperties()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MovementProperties");
        
        bCanCrouch_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanCrouch");
        bCanCrouch_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCanCrouch");
        bCanJump_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanJump");
        bCanJump_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCanJump");
        bCanWalk_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanWalk");
        bCanWalk_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCanWalk");
        bCanSwim_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanSwim");
        bCanSwim_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCanSwim");
        bCanFly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCanFly");
        bCanFly_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCanFly");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MovementProperties(IntPtr InNativeStruct)
    {
        unsafe
        {
            CanCrouch = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCanCrouch_NativeProperty, bCanCrouch_Offset);
            CanJump = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCanJump_NativeProperty, bCanJump_Offset);
            CanWalk = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCanWalk_NativeProperty, bCanWalk_Offset);
            CanSwim = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCanSwim_NativeProperty, bCanSwim_Offset);
            CanFly = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCanFly_NativeProperty, bCanFly_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCanCrouch_NativeProperty, bCanCrouch_Offset, CanCrouch);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCanJump_NativeProperty, bCanJump_Offset, CanJump);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCanWalk_NativeProperty, bCanWalk_Offset, CanWalk);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCanSwim_NativeProperty, bCanSwim_Offset, CanSwim);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCanFly_NativeProperty, bCanFly_Offset, CanFly);
        }
    }
}

public static class MovementPropertiesMarshaler
{
    public static MovementProperties FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MovementProperties(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MovementProperties obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MovementProperties.NativeDataSize;
    }
}