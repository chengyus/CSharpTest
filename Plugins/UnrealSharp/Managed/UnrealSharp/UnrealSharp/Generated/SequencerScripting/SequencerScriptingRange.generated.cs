using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.SequencerScripting;

[UStruct]
public partial struct SequencerScriptingRange
{
    // BoolProperty /Script/SequencerScripting.SequencerScriptingRange:bHasStart
    static readonly int bHasStart_Offset;
    static readonly IntPtr bHasStart_NativeProperty;
    public bool HasStartValue;
    
    // BoolProperty /Script/SequencerScripting.SequencerScriptingRange:bHasEnd
    static readonly int bHasEnd_Offset;
    static readonly IntPtr bHasEnd_NativeProperty;
    public bool HasEndValue;
    
    // IntProperty /Script/SequencerScripting.SequencerScriptingRange:InclusiveStart
    static readonly int InclusiveStart_Offset;
    public int InclusiveStart;
    
    // IntProperty /Script/SequencerScripting.SequencerScriptingRange:ExclusiveEnd
    static readonly int ExclusiveEnd_Offset;
    public int ExclusiveEnd;
    
    
    public static readonly int NativeDataSize;
    static SequencerScriptingRange()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SequencerScriptingRange");
        
        bHasStart_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHasStart");
        bHasStart_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHasStart");
        bHasEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHasEnd");
        bHasEnd_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bHasEnd");
        InclusiveStart_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InclusiveStart");
        ExclusiveEnd_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ExclusiveEnd");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SequencerScriptingRange(IntPtr InNativeStruct)
    {
        unsafe
        {
            HasStartValue = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bHasStart_NativeProperty, bHasStart_Offset);
            HasEndValue = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bHasEnd_NativeProperty, bHasEnd_Offset);
            InclusiveStart = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, InclusiveStart_Offset), 0, null);
            ExclusiveEnd = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, ExclusiveEnd_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bHasStart_NativeProperty, bHasStart_Offset, HasStartValue);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bHasEnd_NativeProperty, bHasEnd_Offset, HasEndValue);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, InclusiveStart_Offset), 0, null, InclusiveStart);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, ExclusiveEnd_Offset), 0, null, ExclusiveEnd);
        }
    }
}

public static class SequencerScriptingRangeMarshaler
{
    public static SequencerScriptingRange FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SequencerScriptingRange(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SequencerScriptingRange obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SequencerScriptingRange.NativeDataSize;
    }
}