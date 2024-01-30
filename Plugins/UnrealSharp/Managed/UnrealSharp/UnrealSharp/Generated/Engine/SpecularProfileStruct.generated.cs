using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct SpecularProfileStruct
{
    // EnumProperty /Script/Engine.SpecularProfileStruct:Format
    static readonly int Format_Offset;
    public UnrealSharp.Engine.ESpecularProfileFormat Format;
    
    // ObjectProperty /Script/Engine.SpecularProfileStruct:Texture
    static readonly int Texture_Offset;
    public UnrealSharp.Engine.Texture2D Texture;
    
    
    public static readonly int NativeDataSize;
    static SpecularProfileStruct()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("SpecularProfileStruct");
        
        Format_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Format");
        Texture_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Texture");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public SpecularProfileStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
            Format = BlittableMarshaller<UnrealSharp.Engine.ESpecularProfileFormat>.FromNative(IntPtr.Add(InNativeStruct, Format_Offset), 0, null);
            Texture = ObjectMarshaller<UnrealSharp.Engine.Texture2D>.FromNative(IntPtr.Add(InNativeStruct, Texture_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.Engine.ESpecularProfileFormat>.ToNative(IntPtr.Add(Buffer, Format_Offset), 0, null, Format);
            ObjectMarshaller<UnrealSharp.Engine.Texture2D>.ToNative(IntPtr.Add(Buffer, Texture_Offset), 0, null, Texture);
        }
    }
}

public static class SpecularProfileStructMarshaler
{
    public static SpecularProfileStruct FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new SpecularProfileStruct(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, SpecularProfileStruct obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return SpecularProfileStruct.NativeDataSize;
    }
}