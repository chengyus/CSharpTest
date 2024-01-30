using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UStruct]
public partial struct WidgetNavigationData
{
    // EnumProperty /Script/UMG.WidgetNavigationData:Rule
    static readonly int Rule_Offset;
    public UnrealSharp.SlateCore.EUINavigationRule Rule;
    
    // NameProperty /Script/UMG.WidgetNavigationData:WidgetToFocus
    static readonly int WidgetToFocus_Offset;
    public Name WidgetToFocus;
    
    
    public static readonly int NativeDataSize;
    static WidgetNavigationData()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("WidgetNavigationData");
        
        Rule_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Rule");
        WidgetToFocus_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidgetToFocus");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public WidgetNavigationData(IntPtr InNativeStruct)
    {
        unsafe
        {
            Rule = BlittableMarshaller<UnrealSharp.SlateCore.EUINavigationRule>.FromNative(IntPtr.Add(InNativeStruct, Rule_Offset), 0, null);
            WidgetToFocus = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, WidgetToFocus_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.SlateCore.EUINavigationRule>.ToNative(IntPtr.Add(Buffer, Rule_Offset), 0, null, Rule);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, WidgetToFocus_Offset), 0, null, WidgetToFocus);
        }
    }
}

public static class WidgetNavigationDataMarshaler
{
    public static WidgetNavigationData FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new WidgetNavigationData(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, WidgetNavigationData obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return WidgetNavigationData.NativeDataSize;
    }
}