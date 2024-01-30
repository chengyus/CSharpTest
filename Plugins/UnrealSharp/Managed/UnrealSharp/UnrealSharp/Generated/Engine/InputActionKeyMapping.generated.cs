using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct InputActionKeyMapping
{
    // NameProperty /Script/Engine.InputActionKeyMapping:ActionName
    static readonly int ActionName_Offset;
    public Name ActionName;
    
    // BoolProperty /Script/Engine.InputActionKeyMapping:bShift
    static readonly int bShift_Offset;
    static readonly IntPtr bShift_NativeProperty;
    public bool Shift;
    
    // BoolProperty /Script/Engine.InputActionKeyMapping:bCtrl
    static readonly int bCtrl_Offset;
    static readonly IntPtr bCtrl_NativeProperty;
    public bool Ctrl;
    
    // BoolProperty /Script/Engine.InputActionKeyMapping:bAlt
    static readonly int bAlt_Offset;
    static readonly IntPtr bAlt_NativeProperty;
    public bool Alt;
    
    // BoolProperty /Script/Engine.InputActionKeyMapping:bCmd
    static readonly int bCmd_Offset;
    static readonly IntPtr bCmd_NativeProperty;
    public bool Cmd;
    
    // StructProperty /Script/Engine.InputActionKeyMapping:Key
    static readonly int Key_Offset;
    public UnrealSharp.InputCore.Key Key;
    
    
    public static readonly int NativeDataSize;
    static InputActionKeyMapping()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("InputActionKeyMapping");
        
        ActionName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActionName");
        bShift_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShift");
        bShift_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bShift");
        bCtrl_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCtrl");
        bCtrl_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCtrl");
        bAlt_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAlt");
        bAlt_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bAlt");
        bCmd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bCmd");
        bCmd_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bCmd");
        Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Key");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public InputActionKeyMapping(IntPtr InNativeStruct)
    {
        unsafe
        {
            ActionName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ActionName_Offset), 0, null);
            Shift = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bShift_NativeProperty, bShift_Offset);
            Ctrl = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCtrl_NativeProperty, bCtrl_Offset);
            Alt = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bAlt_NativeProperty, bAlt_Offset);
            Cmd = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bCmd_NativeProperty, bCmd_Offset);
            Key = UnrealSharp.InputCore.KeyMarshaler.FromNative(IntPtr.Add(InNativeStruct, Key_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ActionName_Offset), 0, null, ActionName);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bShift_NativeProperty, bShift_Offset, Shift);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCtrl_NativeProperty, bCtrl_Offset, Ctrl);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bAlt_NativeProperty, bAlt_Offset, Alt);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bCmd_NativeProperty, bCmd_Offset, Cmd);
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(Buffer, Key_Offset), 0, null, Key);
        }
    }
}

public static class InputActionKeyMappingMarshaler
{
    public static InputActionKeyMapping FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new InputActionKeyMapping(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, InputActionKeyMapping obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return InputActionKeyMapping.NativeDataSize;
    }
}