using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Slate;

[UStruct]
public partial struct InputChord
{
    // StructProperty /Script/Slate.InputChord:Key
    static readonly int Key_Offset;
    public UnrealSharp.InputCore.Key Key;
    
    // BoolProperty /Script/Slate.InputChord:bShift
    static readonly int bShift_Offset;
    static readonly IntPtr bShift_NativeProperty;
    public bool Shift;
    
    // BoolProperty /Script/Slate.InputChord:bCtrl
    static readonly int bCtrl_Offset;
    static readonly IntPtr bCtrl_NativeProperty;
    public bool Ctrl;
    
    // BoolProperty /Script/Slate.InputChord:bAlt
    static readonly int bAlt_Offset;
    static readonly IntPtr bAlt_NativeProperty;
    public bool Alt;
    
    // BoolProperty /Script/Slate.InputChord:bCmd
    static readonly int bCmd_Offset;
    static readonly IntPtr bCmd_NativeProperty;
    public bool Cmd;
    
    
    public static readonly int NativeDataSize;
    static InputChord()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputChord");
        
        Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Key");
        bShift_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShift");
        bShift_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShift");
        bCtrl_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCtrl");
        bCtrl_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCtrl");
        bAlt_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlt");
        bAlt_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAlt");
        bCmd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCmd");
        bCmd_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCmd");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputChord(IntPtr InNativeStruct)
    {
        unsafe
        {
            Key = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Key_Offset), 0, null);
            Shift = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bShift_NativeProperty, bShift_Offset);
            Ctrl = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCtrl_NativeProperty, bCtrl_Offset);
            Alt = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAlt_NativeProperty, bAlt_Offset);
            Cmd = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCmd_NativeProperty, bCmd_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, Key_Offset), 0, null, Key);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bShift_NativeProperty, bShift_Offset, Shift);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCtrl_NativeProperty, bCtrl_Offset, Ctrl);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAlt_NativeProperty, bAlt_Offset, Alt);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCmd_NativeProperty, bCmd_Offset, Cmd);
        }
    }
}

public static class InputChordMarshaler
{
    public static InputChord FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputChord(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputChord obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputChord.NativeDataSize;
    }
}