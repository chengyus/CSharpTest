using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct DialogueContext
{
    // ObjectProperty /Script/Engine.DialogueContext:Speaker
    static readonly int Speaker_Offset;
    public UnrealSharp.Engine.DialogueVoice Speaker;
    
    
    public static readonly int NativeDataSize;
    static DialogueContext()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("DialogueContext");
        
        Speaker_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Speaker");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public DialogueContext(IntPtr InNativeStruct)
    {
        unsafe
        {
            Speaker = ObjectMarshaller<UnrealSharp.Engine.DialogueVoice>.FromNative(IntPtr.Add(InNativeStruct, Speaker_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.Engine.DialogueVoice>.ToNative(IntPtr.Add(Buffer, Speaker_Offset), 0, null, Speaker);
        }
    }
}

public static class DialogueContextMarshaler
{
    public static DialogueContext FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new DialogueContext(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, DialogueContext obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return DialogueContext.NativeDataSize;
    }
}