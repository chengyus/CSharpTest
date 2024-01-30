using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UStruct]
public partial struct ToolMenuSection
{
    // NameProperty /Script/ToolMenus.ToolMenuSection:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // StructProperty /Script/ToolMenus.ToolMenuSection:Owner
    static readonly int Owner_Offset;
    public UnrealSharp.ToolMenus.ToolMenuOwner Owner;
    
    // StructProperty /Script/ToolMenus.ToolMenuSection:InsertPosition
    static readonly int InsertPosition_Offset;
    public UnrealSharp.ToolMenus.ToolMenuInsert InsertPosition;
    
    // StructProperty /Script/ToolMenus.ToolMenuSection:Context
    static readonly int Context_Offset;
    public UnrealSharp.ToolMenus.ToolMenuContext Context;
    
    // ObjectProperty /Script/ToolMenus.ToolMenuSection:ToolMenuSectionDynamic
    static readonly int ToolMenuSectionDynamic_Offset;
    public UnrealSharp.ToolMenus.ToolMenuSectionDynamic ToolMenuSectionDynamic;
    
    
    public static readonly int NativeDataSize;
    static ToolMenuSection()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("ToolMenuSection");
        
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        Owner_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Owner");
        InsertPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InsertPosition");
        Context_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Context");
        ToolMenuSectionDynamic_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ToolMenuSectionDynamic");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public ToolMenuSection(IntPtr InNativeStruct)
    {
        unsafe
        {
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            Owner = UnrealSharp.ToolMenus.ToolMenuOwnerMarshaler.FromNative(IntPtr.Add(InNativeStruct, Owner_Offset), 0, null);
            InsertPosition = UnrealSharp.ToolMenus.ToolMenuInsertMarshaler.FromNative(IntPtr.Add(InNativeStruct, InsertPosition_Offset), 0, null);
            Context = UnrealSharp.ToolMenus.ToolMenuContextMarshaler.FromNative(IntPtr.Add(InNativeStruct, Context_Offset), 0, null);
            ToolMenuSectionDynamic = ObjectMarshaller<UnrealSharp.ToolMenus.ToolMenuSectionDynamic>.FromNative(IntPtr.Add(InNativeStruct, ToolMenuSectionDynamic_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            UnrealSharp.ToolMenus.ToolMenuOwnerMarshaler.ToNative(IntPtr.Add(Buffer, Owner_Offset), 0, null, Owner);
            UnrealSharp.ToolMenus.ToolMenuInsertMarshaler.ToNative(IntPtr.Add(Buffer, InsertPosition_Offset), 0, null, InsertPosition);
            UnrealSharp.ToolMenus.ToolMenuContextMarshaler.ToNative(IntPtr.Add(Buffer, Context_Offset), 0, null, Context);
            ObjectMarshaller<UnrealSharp.ToolMenus.ToolMenuSectionDynamic>.ToNative(IntPtr.Add(Buffer, ToolMenuSectionDynamic_Offset), 0, null, ToolMenuSectionDynamic);
        }
    }
}

public static class ToolMenuSectionMarshaler
{
    public static ToolMenuSection FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new ToolMenuSection(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, ToolMenuSection obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return ToolMenuSection.NativeDataSize;
    }
}