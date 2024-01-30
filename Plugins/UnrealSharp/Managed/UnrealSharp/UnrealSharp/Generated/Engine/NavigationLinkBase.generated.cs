using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct NavigationLinkBase
{
    // ByteProperty /Script/Engine.NavigationLinkBase:Direction
    static readonly int Direction_Offset;
    public UnrealSharp.Engine.ENavLinkDirection Direction;
    
    
    public static readonly int NativeDataSize;
    static NavigationLinkBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NavigationLinkBase");
        
        Direction_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Direction");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NavigationLinkBase(IntPtr InNativeStruct)
    {
        unsafe
        {
            Direction = BlittableMarshaller<UnrealSharp.Engine.ENavLinkDirection>.FromNative(IntPtr.Add(InNativeStruct, Direction_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.ENavLinkDirection>.ToNative(IntPtr.Add(Buffer, Direction_Offset), 0, null, Direction);
        }
    }
}

public static class NavigationLinkBaseMarshaler
{
    public static NavigationLinkBase FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NavigationLinkBase(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NavigationLinkBase obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NavigationLinkBase.NativeDataSize;
    }
}