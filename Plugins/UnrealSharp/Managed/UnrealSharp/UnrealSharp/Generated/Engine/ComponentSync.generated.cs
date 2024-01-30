using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ComponentSync
{
    // NameProperty /Script/Engine.ComponentSync:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // EnumProperty /Script/Engine.ComponentSync:SyncOption
    static readonly int SyncOption_Offset;
    public UnrealSharp.Engine.ESyncOption SyncOption;
    
    
    public static readonly int NativeDataSize;
    static ComponentSync()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ComponentSync");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        SyncOption_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SyncOption");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ComponentSync(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            SyncOption = BlittableMarshaller<UnrealSharp.Engine.ESyncOption>.FromNative(IntPtr.Add(InNativeStruct, SyncOption_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<UnrealSharp.Engine.ESyncOption>.ToNative(IntPtr.Add(Buffer, SyncOption_Offset), 0, null, SyncOption);
        }
    }
}

public static class ComponentSyncMarshaler
{
    public static ComponentSync FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ComponentSync(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ComponentSync obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ComponentSync.NativeDataSize;
    }
}