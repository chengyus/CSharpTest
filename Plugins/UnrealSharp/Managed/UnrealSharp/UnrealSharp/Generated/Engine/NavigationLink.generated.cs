using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct NavigationLink
{
    // StructProperty /Script/Engine.NavigationLink:Left
    static readonly int Left_Offset;
    public System.DoubleNumerics.Vector3 Left;
    
    // StructProperty /Script/Engine.NavigationLink:Right
    static readonly int Right_Offset;
    public System.DoubleNumerics.Vector3 Right;
    
    
    public static readonly int NativeDataSize;
    static NavigationLink()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NavigationLink");
        
        Left_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Left");
        Right_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Right");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NavigationLink(IntPtr InNativeStruct)
    {
        unsafe
        {
            Left = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Left_Offset), 0, null);
            Right = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, Right_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Left_Offset), 0, null, Left);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, Right_Offset), 0, null, Right);
        }
    }
}

public static class NavigationLinkMarshaler
{
    public static NavigationLink FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NavigationLink(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NavigationLink obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NavigationLink.NativeDataSize;
    }
}