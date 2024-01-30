using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct NavDataConfig
{
    // NameProperty /Script/Engine.NavDataConfig:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // StructProperty /Script/Engine.NavDataConfig:Color
    static readonly int Color_Offset;
    public UnrealSharp.CoreUObject.Color Color;
    
    // StructProperty /Script/Engine.NavDataConfig:DefaultQueryExtent
    static readonly int DefaultQueryExtent_Offset;
    public System.DoubleNumerics.Vector3 DefaultQueryExtent;
    
    
    public static readonly int NativeDataSize;
    static NavDataConfig()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NavDataConfig");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Color_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Color");
        DefaultQueryExtent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultQueryExtent");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NavDataConfig(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Color = BlittableMarshaller<UnrealSharp.CoreUObject.Color>.FromNative(IntPtr.Add(InNativeStruct, Color_Offset), 0, null);
            DefaultQueryExtent = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, DefaultQueryExtent_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.CoreUObject.Color>.ToNative(IntPtr.Add(Buffer, Color_Offset), 0, null, Color);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, DefaultQueryExtent_Offset), 0, null, DefaultQueryExtent);
        }
    }
}

public static class NavDataConfigMarshaler
{
    public static NavDataConfig FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NavDataConfig(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NavDataConfig obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NavDataConfig.NativeDataSize;
    }
}