// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class UniformGridPanel : UnrealSharp.UMG.PanelWidget
{
    
    static UniformGridPanel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("UniformGridPanel");
        
        SlotPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SlotPadding");
        MinDesiredSlotWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinDesiredSlotWidth");
        MinDesiredSlotHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MinDesiredSlotHeight");
        
        SetSlotPadding_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSlotPadding");
        SetSlotPadding_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSlotPadding_NativeFunction);
        SetSlotPadding_InSlotPadding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSlotPadding_NativeFunction, "InSlotPadding");
        SetMinDesiredSlotWidth_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMinDesiredSlotWidth");
        SetMinDesiredSlotWidth_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMinDesiredSlotWidth_NativeFunction);
        SetMinDesiredSlotWidth_InMinDesiredSlotWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMinDesiredSlotWidth_NativeFunction, "InMinDesiredSlotWidth");
        SetMinDesiredSlotHeight_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetMinDesiredSlotHeight");
        SetMinDesiredSlotHeight_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetMinDesiredSlotHeight_NativeFunction);
        SetMinDesiredSlotHeight_InMinDesiredSlotHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetMinDesiredSlotHeight_NativeFunction, "InMinDesiredSlotHeight");
        AddChildToUniformGrid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddChildToUniformGrid");
        AddChildToUniformGrid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddChildToUniformGrid_NativeFunction);
        AddChildToUniformGrid_Content_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChildToUniformGrid_NativeFunction, "Content");
        AddChildToUniformGrid_InRow_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChildToUniformGrid_NativeFunction, "InRow");
        AddChildToUniformGrid_InColumn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChildToUniformGrid_NativeFunction, "InColumn");
        AddChildToUniformGrid_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChildToUniformGrid_NativeFunction, "ReturnValue");
        
        
    }
    
    protected UniformGridPanel(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.UniformGridPanel:SlotPadding
    static readonly int SlotPadding_Offset;
    
    public UnrealSharp.SlateCore.Margin SlotPadding
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, SlotPadding_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(NativeObject, SlotPadding_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.UniformGridPanel:MinDesiredSlotWidth
    static readonly int MinDesiredSlotWidth_Offset;
    
    public float MinDesiredSlotWidth
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinDesiredSlotWidth_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinDesiredSlotWidth_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.UniformGridPanel:MinDesiredSlotHeight
    static readonly int MinDesiredSlotHeight_Offset;
    
    public float MinDesiredSlotHeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, MinDesiredSlotHeight_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, MinDesiredSlotHeight_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.UniformGridPanel:SetSlotPadding
    static readonly IntPtr SetSlotPadding_NativeFunction;
    static readonly int SetSlotPadding_ParamsSize;
    static readonly int SetSlotPadding_InSlotPadding_Offset;
    
    public void SetSlotPadding(UnrealSharp.SlateCore.Margin inSlotPadding)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSlotPadding_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(ParamsBuffer, SetSlotPadding_InSlotPadding_Offset), 0, null, inSlotPadding);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSlotPadding_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.UniformGridPanel:SetMinDesiredSlotWidth
    static readonly IntPtr SetMinDesiredSlotWidth_NativeFunction;
    static readonly int SetMinDesiredSlotWidth_ParamsSize;
    static readonly int SetMinDesiredSlotWidth_InMinDesiredSlotWidth_Offset;
    
    public void SetMinDesiredSlotWidth(float inMinDesiredSlotWidth)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMinDesiredSlotWidth_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMinDesiredSlotWidth_InMinDesiredSlotWidth_Offset), 0, null, inMinDesiredSlotWidth);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMinDesiredSlotWidth_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.UniformGridPanel:SetMinDesiredSlotHeight
    static readonly IntPtr SetMinDesiredSlotHeight_NativeFunction;
    static readonly int SetMinDesiredSlotHeight_ParamsSize;
    static readonly int SetMinDesiredSlotHeight_InMinDesiredSlotHeight_Offset;
    
    public void SetMinDesiredSlotHeight(float inMinDesiredSlotHeight)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetMinDesiredSlotHeight_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, SetMinDesiredSlotHeight_InMinDesiredSlotHeight_Offset), 0, null, inMinDesiredSlotHeight);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetMinDesiredSlotHeight_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.UniformGridPanel:AddChildToUniformGrid
    static readonly IntPtr AddChildToUniformGrid_NativeFunction;
    static readonly int AddChildToUniformGrid_ParamsSize;
    static readonly int AddChildToUniformGrid_Content_Offset;
    static readonly int AddChildToUniformGrid_InRow_Offset;
    static readonly int AddChildToUniformGrid_InColumn_Offset;
    static readonly int AddChildToUniformGrid_ReturnValue_Offset;
    
    public UnrealSharp.UMG.UniformGridSlot AddChildToUniformGrid(UnrealSharp.UMG.Widget content, int inRow = 0, int inColumn = 0)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddChildToUniformGrid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.UMG.Widget>.ToNative(IntPtr.Add(ParamsBuffer, AddChildToUniformGrid_Content_Offset), 0, null, content);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, AddChildToUniformGrid_InRow_Offset), 0, null, inRow);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, AddChildToUniformGrid_InColumn_Offset), 0, null, inColumn);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddChildToUniformGrid_NativeFunction, ParamsBuffer);
            
            UnrealSharp.UMG.UniformGridSlot returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.UMG.UniformGridSlot>.FromNative(IntPtr.Add(ParamsBuffer, AddChildToUniformGrid_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}