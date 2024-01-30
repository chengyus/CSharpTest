using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GameplayTags;

[UStruct]
public partial struct GameplayTagTableRow
{
    // NameProperty /Script/GameplayTags.GameplayTagTableRow:Tag
    static readonly int Tag_Offset;
    public Name Tag;
    
    
    public static readonly int NativeDataSize;
    static GameplayTagTableRow()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("GameplayTagTableRow");
        
        Tag_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Tag");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public GameplayTagTableRow(IntPtr InNativeStruct)
    {
        unsafe
        {
            Tag = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Tag_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Tag_Offset), 0, null, Tag);
        }
    }
}

public static class GameplayTagTableRowMarshaler
{
    public static GameplayTagTableRow FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new GameplayTagTableRow(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, GameplayTagTableRow obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return GameplayTagTableRow.NativeDataSize;
    }
}