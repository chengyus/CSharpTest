// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
abstract public partial class DynamicEntryBoxBase : UnrealSharp.UMG.Widget
{
    
    static DynamicEntryBoxBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DynamicEntryBoxBase");
        
        EntrySpacing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EntrySpacing");
        SpacingPattern_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpacingPattern");
        SpacingPattern_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "SpacingPattern");
        EntryBoxType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EntryBoxType");
        EntrySizeRule_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EntrySizeRule");
        EntryHorizontalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EntryHorizontalAlignment");
        EntryVerticalAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EntryVerticalAlignment");
        MaxElementSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MaxElementSize");
        RadialBoxSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RadialBoxSettings");
        
        SetRadialSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetRadialSettings");
        SetRadialSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetRadialSettings_NativeFunction);
        SetRadialSettings_InSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetRadialSettings_NativeFunction, "InSettings");
        SetEntrySpacing_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetEntrySpacing");
        SetEntrySpacing_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetEntrySpacing_NativeFunction);
        SetEntrySpacing_InEntrySpacing_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetEntrySpacing_NativeFunction, "InEntrySpacing");
        GetNumEntries_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNumEntries");
        GetNumEntries_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNumEntries_NativeFunction);
        GetNumEntries_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNumEntries_NativeFunction, "ReturnValue");
        GetAllEntries_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAllEntries");
        GetAllEntries_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAllEntries_NativeFunction);
        GetAllEntries_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAllEntries_NativeFunction, "ReturnValue");
        GetAllEntries_ReturnValue_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(GetAllEntries_NativeFunction, "ReturnValue");
        
        
    }
    
    protected DynamicEntryBoxBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.DynamicEntryBoxBase:EntrySpacing
    static readonly int EntrySpacing_Offset;
    
    public System.DoubleNumerics.Vector2 EntrySpacing
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(NativeObject, EntrySpacing_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(NativeObject, EntrySpacing_Offset), 0, this, value);
        }
    }
    
    // ArrayProperty /Script/UMG.DynamicEntryBoxBase:SpacingPattern
    static readonly int SpacingPattern_Offset;
    static readonly IntPtr SpacingPattern_NativeProperty;
    UnrealArrayReadOnlyMarshaler<System.DoubleNumerics.Vector2> SpacingPattern_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<System.DoubleNumerics.Vector2> SpacingPattern
    {
        get
        {
            if(SpacingPattern_Wrapper == null)
            {
                SpacingPattern_Wrapper = new UnrealArrayReadOnlyMarshaler<System.DoubleNumerics.Vector2>(1, SpacingPattern_NativeProperty, BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative, BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative);
            }
            
            return SpacingPattern_Wrapper.FromNative(IntPtr.Add(NativeObject,SpacingPattern_Offset),0,this);
        }
    }
    
    // EnumProperty /Script/UMG.DynamicEntryBoxBase:EntryBoxType
    static readonly int EntryBoxType_Offset;
    
    public UnrealSharp.UMG.EDynamicBoxType EntryBoxType
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.UMG.EDynamicBoxType>.FromNative(IntPtr.Add(NativeObject, EntryBoxType_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/UMG.DynamicEntryBoxBase:EntrySizeRule
    static readonly int EntrySizeRule_Offset;
    
    public UnrealSharp.UMG.SlateChildSize EntrySizeRule
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.UMG.SlateChildSizeMarshaler.FromNative(IntPtr.Add(NativeObject, EntrySizeRule_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/UMG.DynamicEntryBoxBase:EntryHorizontalAlignment
    static readonly int EntryHorizontalAlignment_Offset;
    
    public UnrealSharp.SlateCore.EHorizontalAlignment EntryHorizontalAlignment
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.FromNative(IntPtr.Add(NativeObject, EntryHorizontalAlignment_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/UMG.DynamicEntryBoxBase:EntryVerticalAlignment
    static readonly int EntryVerticalAlignment_Offset;
    
    public UnrealSharp.SlateCore.EVerticalAlignment EntryVerticalAlignment
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.FromNative(IntPtr.Add(NativeObject, EntryVerticalAlignment_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/UMG.DynamicEntryBoxBase:MaxElementSize
    static readonly int MaxElementSize_Offset;
    
    public int MaxElementSize
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MaxElementSize_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/UMG.DynamicEntryBoxBase:RadialBoxSettings
    static readonly int RadialBoxSettings_Offset;
    
    public UnrealSharp.UMG.RadialBoxSettings RadialBoxSettings
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.UMG.RadialBoxSettingsMarshaler.FromNative(IntPtr.Add(NativeObject, RadialBoxSettings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.UMG.RadialBoxSettingsMarshaler.ToNative(IntPtr.Add(NativeObject, RadialBoxSettings_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.DynamicEntryBoxBase:SetRadialSettings
    static readonly IntPtr SetRadialSettings_NativeFunction;
    static readonly int SetRadialSettings_ParamsSize;
    static readonly int SetRadialSettings_InSettings_Offset;
    
    public void SetRadialSettings(UnrealSharp.UMG.RadialBoxSettings inSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetRadialSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.UMG.RadialBoxSettingsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetRadialSettings_InSettings_Offset), 0, null, inSettings);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetRadialSettings_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.DynamicEntryBoxBase:SetEntrySpacing
    static readonly IntPtr SetEntrySpacing_NativeFunction;
    static readonly int SetEntrySpacing_ParamsSize;
    static readonly int SetEntrySpacing_InEntrySpacing_Offset;
    
    public void SetEntrySpacing(System.DoubleNumerics.Vector2 inEntrySpacing)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetEntrySpacing_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(ParamsBuffer, SetEntrySpacing_InEntrySpacing_Offset), 0, null, inEntrySpacing);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetEntrySpacing_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.DynamicEntryBoxBase:GetNumEntries
    static readonly IntPtr GetNumEntries_NativeFunction;
    static readonly int GetNumEntries_ParamsSize;
    static readonly int GetNumEntries_ReturnValue_Offset;
    
    public int GetNumEntries()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNumEntries_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNumEntries_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNumEntries_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.DynamicEntryBoxBase:GetAllEntries
    static readonly IntPtr GetAllEntries_NativeFunction;
    static readonly int GetAllEntries_ParamsSize;
    static readonly int GetAllEntries_ReturnValue_Offset;
    static readonly int GetAllEntries_ReturnValue_ElementSize;
    
    public System.Collections.Generic.IList<UnrealSharp.UMG.UserWidget> GetAllEntries()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAllEntries_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetAllEntries_NativeFunction, ParamsBuffer);
            
            System.Collections.Generic.IList<UnrealSharp.UMG.UserWidget> returnValue;
            IntPtr ReturnValue_NativeBuffer = IntPtr.Add(ParamsBuffer, GetAllEntries_ReturnValue_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.UMG.UserWidget> ReturnValue_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.UMG.UserWidget> (1, ObjectMarshaller<UnrealSharp.UMG.UserWidget>.ToNative, ObjectMarshaller<UnrealSharp.UMG.UserWidget>.FromNative, GetAllEntries_ReturnValue_ElementSize);
            returnValue = ReturnValue_Marshaler.FromNative(ReturnValue_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.UMG.UserWidget>.DestructInstance(ReturnValue_NativeBuffer, 0);
            
            return returnValue;
        }
    }
    
    
}