using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct ActorDesc
{
    // StructProperty /Script/Engine.ActorDesc:Guid
    static readonly int Guid_Offset;
    public UnrealSharp.CoreUObject.Guid Guid;
    
    // StructProperty /Script/Engine.ActorDesc:Class
    static readonly int Class_Offset;
    public UnrealSharp.CoreUObject.SoftObjectPath Class;
    
    // NameProperty /Script/Engine.ActorDesc:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // NameProperty /Script/Engine.ActorDesc:Label
    static readonly int Label_Offset;
    public Name Label;
    
    // StructProperty /Script/Engine.ActorDesc:Bounds
    static readonly int Bounds_Offset;
    public UnrealSharp.CoreUObject.Box Bounds;
    
    // NameProperty /Script/Engine.ActorDesc:RuntimeGrid
    static readonly int RuntimeGrid_Offset;
    public Name RuntimeGrid;
    
    // BoolProperty /Script/Engine.ActorDesc:bIsSpatiallyLoaded
    static readonly int bIsSpatiallyLoaded_Offset;
    public bool IsSpatiallyLoaded;
    
    // BoolProperty /Script/Engine.ActorDesc:bActorIsEditorOnly
    static readonly int bActorIsEditorOnly_Offset;
    public bool ActorIsEditorOnly;
    
    // NameProperty /Script/Engine.ActorDesc:ActorPackage
    static readonly int ActorPackage_Offset;
    public Name ActorPackage;
    
    // NameProperty /Script/Engine.ActorDesc:ActorPath
    static readonly int ActorPath_Offset;
    public Name ActorPath;
    
    
    public static readonly int NativeDataSize;
    static ActorDesc()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ActorDesc");
        
        Guid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Guid");
        Class_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Class");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Label_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Label");
        Bounds_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bounds");
        RuntimeGrid_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RuntimeGrid");
        bIsSpatiallyLoaded_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsSpatiallyLoaded");
        bActorIsEditorOnly_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bActorIsEditorOnly");
        ActorPackage_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActorPackage");
        ActorPath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ActorPath");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ActorDesc(IntPtr InNativeStruct)
    {
        unsafe
        {
            Guid = UnrealSharp.CoreUObject.GuidMarshaler.FromNative(IntPtr.Add(InNativeStruct, Guid_Offset), 0, null);
            Class = UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, Class_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Label = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Label_Offset), 0, null);
            Bounds = UnrealSharp.CoreUObject.BoxMarshaler.FromNative(IntPtr.Add(InNativeStruct, Bounds_Offset), 0, null);
            RuntimeGrid = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, RuntimeGrid_Offset), 0, null);
            IsSpatiallyLoaded = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bIsSpatiallyLoaded_Offset), 0, null);
            ActorIsEditorOnly = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bActorIsEditorOnly_Offset), 0, null);
            ActorPackage = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ActorPackage_Offset), 0, null);
            ActorPath = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ActorPath_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            UnrealSharp.CoreUObject.GuidMarshaler.ToNative(IntPtr.Add(Buffer, Guid_Offset), 0, null, Guid);
            UnrealSharp.CoreUObject.SoftObjectPathMarshaler.ToNative(IntPtr.Add(Buffer, Class_Offset), 0, null, Class);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Label_Offset), 0, null, Label);
            UnrealSharp.CoreUObject.BoxMarshaler.ToNative(IntPtr.Add(Buffer, Bounds_Offset), 0, null, Bounds);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, RuntimeGrid_Offset), 0, null, RuntimeGrid);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bIsSpatiallyLoaded_Offset), 0, null, IsSpatiallyLoaded);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bActorIsEditorOnly_Offset), 0, null, ActorIsEditorOnly);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ActorPackage_Offset), 0, null, ActorPackage);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ActorPath_Offset), 0, null, ActorPath);
        }
    }
}

public static class ActorDescMarshaler
{
    public static ActorDesc FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ActorDesc(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ActorDesc obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ActorDesc.NativeDataSize;
    }
}