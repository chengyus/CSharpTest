using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.EnhancedInput;

[UStruct]
public partial struct MappingQueryIssue
{
    // EnumProperty /Script/EnhancedInput.MappingQueryIssue:Issue
    static readonly int Issue_Offset;
    public UnrealSharp.EnhancedInput.EMappingQueryIssue Issue;
    
    // ObjectProperty /Script/EnhancedInput.MappingQueryIssue:BlockingContext
    static readonly int BlockingContext_Offset;
    public UnrealSharp.EnhancedInput.InputMappingContext BlockingContext;
    
    // ObjectProperty /Script/EnhancedInput.MappingQueryIssue:BlockingAction
    static readonly int BlockingAction_Offset;
    public UnrealSharp.EnhancedInput.InputAction BlockingAction;
    
    
    public static readonly int NativeDataSize;
    static MappingQueryIssue()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("MappingQueryIssue");
        
        Issue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Issue");
        BlockingContext_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlockingContext");
        BlockingAction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BlockingAction");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public MappingQueryIssue(IntPtr InNativeStruct)
    {
        unsafe
        {
            Issue = BlittableMarshaller<UnrealSharp.EnhancedInput.EMappingQueryIssue>.FromNative(IntPtr.Add(InNativeStruct, Issue_Offset), 0, null);
            BlockingContext = ObjectMarshaller<UnrealSharp.EnhancedInput.InputMappingContext>.FromNative(IntPtr.Add(InNativeStruct, BlockingContext_Offset), 0, null);
            BlockingAction = ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.FromNative(IntPtr.Add(InNativeStruct, BlockingAction_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.EnhancedInput.EMappingQueryIssue>.ToNative(IntPtr.Add(Buffer, Issue_Offset), 0, null, Issue);
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputMappingContext>.ToNative(IntPtr.Add(Buffer, BlockingContext_Offset), 0, null, BlockingContext);
            ObjectMarshaller<UnrealSharp.EnhancedInput.InputAction>.ToNative(IntPtr.Add(Buffer, BlockingAction_Offset), 0, null, BlockingAction);
        }
    }
}

public static class MappingQueryIssueMarshaler
{
    public static MappingQueryIssue FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new MappingQueryIssue(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, MappingQueryIssue obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return MappingQueryIssue.NativeDataSize;
    }
}