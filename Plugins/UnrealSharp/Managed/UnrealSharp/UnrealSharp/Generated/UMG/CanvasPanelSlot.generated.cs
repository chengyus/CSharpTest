// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class CanvasPanelSlot : UnrealSharp.UMG.PanelSlot
{
    
    static CanvasPanelSlot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CanvasPanelSlot");
        
        LayoutData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LayoutData");
        bAutoSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutoSize");
        ZOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ZOrder");
        
        SetZOrder_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetZOrder");
        SetZOrder_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetZOrder_NativeFunction);
        SetZOrder_InZOrder_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetZOrder_NativeFunction, "InZOrder");
        SetSize_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetSize");
        SetSize_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetSize_NativeFunction);
        SetSize_InSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetSize_NativeFunction, "InSize");
        SetPosition_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPosition");
        SetPosition_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPosition_NativeFunction);
        SetPosition_InPosition_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPosition_NativeFunction, "InPosition");
        SetOffsets_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetOffsets");
        SetOffsets_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetOffsets_NativeFunction);
        SetOffsets_InOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetOffsets_NativeFunction, "InOffset");
        SetLayout_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetLayout");
        SetLayout_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetLayout_NativeFunction);
        SetLayout_InLayoutData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetLayout_NativeFunction, "InLayoutData");
        SetAutoSize_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAutoSize");
        SetAutoSize_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAutoSize_NativeFunction);
        SetAutoSize_InbAutoSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAutoSize_NativeFunction, "InbAutoSize");
        SetAnchors_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAnchors");
        SetAnchors_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAnchors_NativeFunction);
        SetAnchors_InAnchors_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAnchors_NativeFunction, "InAnchors");
        SetAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetAlignment");
        SetAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetAlignment_NativeFunction);
        SetAlignment_InAlignment_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetAlignment_NativeFunction, "InAlignment");
        GetZOrder_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetZOrder");
        GetZOrder_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetZOrder_NativeFunction);
        GetZOrder_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetZOrder_NativeFunction, "ReturnValue");
        GetSize_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSize");
        GetSize_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSize_NativeFunction);
        GetSize_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSize_NativeFunction, "ReturnValue");
        GetPosition_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPosition");
        GetPosition_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPosition_NativeFunction);
        GetPosition_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPosition_NativeFunction, "ReturnValue");
        GetOffsets_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOffsets");
        GetOffsets_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOffsets_NativeFunction);
        GetOffsets_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOffsets_NativeFunction, "ReturnValue");
        GetLayout_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLayout");
        GetLayout_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLayout_NativeFunction);
        GetLayout_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLayout_NativeFunction, "ReturnValue");
        GetAutoSize_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAutoSize");
        GetAutoSize_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAutoSize_NativeFunction);
        GetAutoSize_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAutoSize_NativeFunction, "ReturnValue");
        GetAnchors_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAnchors");
        GetAnchors_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAnchors_NativeFunction);
        GetAnchors_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAnchors_NativeFunction, "ReturnValue");
        GetAlignment_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAlignment");
        GetAlignment_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAlignment_NativeFunction);
        GetAlignment_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAlignment_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CanvasPanelSlot(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/UMG.CanvasPanelSlot:LayoutData
    static readonly int LayoutData_Offset;
    
    public UnrealSharp.UMG.AnchorData LayoutData
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.UMG.AnchorData>.FromNative(IntPtr.Add(NativeObject, LayoutData_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.UMG.AnchorData>.ToNative(IntPtr.Add(NativeObject, LayoutData_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.CanvasPanelSlot:bAutoSize
    static readonly int bAutoSize_Offset;
    
    public bool bAutoSize
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bAutoSize_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bAutoSize_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/UMG.CanvasPanelSlot:ZOrder
    static readonly int ZOrder_Offset;
    
    public int ZOrder
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, ZOrder_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, ZOrder_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetZOrder
    static readonly IntPtr SetZOrder_NativeFunction;
    static readonly int SetZOrder_ParamsSize;
    static readonly int SetZOrder_InZOrder_Offset;
    
    public void SetZOrder(int inZOrder)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetZOrder_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetZOrder_InZOrder_Offset), 0, null, inZOrder);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetZOrder_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetSize
    static readonly IntPtr SetSize_NativeFunction;
    static readonly int SetSize_ParamsSize;
    static readonly int SetSize_InSize_Offset;
    
    public void SetSize(System.DoubleNumerics.Vector2 inSize)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetSize_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(ParamsBuffer, SetSize_InSize_Offset), 0, null, inSize);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetSize_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetPosition
    static readonly IntPtr SetPosition_NativeFunction;
    static readonly int SetPosition_ParamsSize;
    static readonly int SetPosition_InPosition_Offset;
    
    public void SetPosition(System.DoubleNumerics.Vector2 inPosition)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPosition_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(ParamsBuffer, SetPosition_InPosition_Offset), 0, null, inPosition);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPosition_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetOffsets
    static readonly IntPtr SetOffsets_NativeFunction;
    static readonly int SetOffsets_ParamsSize;
    static readonly int SetOffsets_InOffset_Offset;
    
    public void SetOffsets(UnrealSharp.SlateCore.Margin inOffset)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetOffsets_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(ParamsBuffer, SetOffsets_InOffset_Offset), 0, null, inOffset);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetOffsets_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetLayout
    static readonly IntPtr SetLayout_NativeFunction;
    static readonly int SetLayout_ParamsSize;
    static readonly int SetLayout_InLayoutData_Offset;
    
    public void SetLayout(UnrealSharp.UMG.AnchorData inLayoutData)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetLayout_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.UMG.AnchorData>.ToNative(IntPtr.Add(ParamsBuffer, SetLayout_InLayoutData_Offset), 0, null, inLayoutData);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetLayout_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetAutoSize
    static readonly IntPtr SetAutoSize_NativeFunction;
    static readonly int SetAutoSize_ParamsSize;
    static readonly int SetAutoSize_InbAutoSize_Offset;
    
    public void SetAutoSize(bool inbAutoSize)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAutoSize_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetAutoSize_InbAutoSize_Offset), 0, null, inbAutoSize);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAutoSize_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetAnchors
    static readonly IntPtr SetAnchors_NativeFunction;
    static readonly int SetAnchors_ParamsSize;
    static readonly int SetAnchors_InAnchors_Offset;
    
    public void SetAnchors(UnrealSharp.Slate.Anchors inAnchors)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAnchors_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.Slate.Anchors>.ToNative(IntPtr.Add(ParamsBuffer, SetAnchors_InAnchors_Offset), 0, null, inAnchors);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAnchors_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:SetAlignment
    static readonly IntPtr SetAlignment_NativeFunction;
    static readonly int SetAlignment_ParamsSize;
    static readonly int SetAlignment_InAlignment_Offset;
    
    public void SetAlignment(System.DoubleNumerics.Vector2 inAlignment)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetAlignment_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(ParamsBuffer, SetAlignment_InAlignment_Offset), 0, null, inAlignment);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetAlignment_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetZOrder
    static readonly IntPtr GetZOrder_NativeFunction;
    static readonly int GetZOrder_ParamsSize;
    static readonly int GetZOrder_ReturnValue_Offset;
    
    public int GetZOrder()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetZOrder_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetZOrder_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetZOrder_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetSize
    static readonly IntPtr GetSize_NativeFunction;
    static readonly int GetSize_ParamsSize;
    static readonly int GetSize_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector2 GetSize()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSize_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSize_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector2 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(ParamsBuffer, GetSize_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetPosition
    static readonly IntPtr GetPosition_NativeFunction;
    static readonly int GetPosition_ParamsSize;
    static readonly int GetPosition_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector2 GetPosition()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPosition_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPosition_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector2 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(ParamsBuffer, GetPosition_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetOffsets
    static readonly IntPtr GetOffsets_NativeFunction;
    static readonly int GetOffsets_ParamsSize;
    static readonly int GetOffsets_ReturnValue_Offset;
    
    public UnrealSharp.SlateCore.Margin GetOffsets()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOffsets_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOffsets_NativeFunction, ParamsBuffer);
            
            UnrealSharp.SlateCore.Margin returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(ParamsBuffer, GetOffsets_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetLayout
    static readonly IntPtr GetLayout_NativeFunction;
    static readonly int GetLayout_ParamsSize;
    static readonly int GetLayout_ReturnValue_Offset;
    
    public UnrealSharp.UMG.AnchorData GetLayout()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLayout_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLayout_NativeFunction, ParamsBuffer);
            
            UnrealSharp.UMG.AnchorData returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.UMG.AnchorData>.FromNative(IntPtr.Add(ParamsBuffer, GetLayout_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetAutoSize
    static readonly IntPtr GetAutoSize_NativeFunction;
    static readonly int GetAutoSize_ParamsSize;
    static readonly int GetAutoSize_ReturnValue_Offset;
    
    public bool GetAutoSize()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAutoSize_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetAutoSize_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetAutoSize_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetAnchors
    static readonly IntPtr GetAnchors_NativeFunction;
    static readonly int GetAnchors_ParamsSize;
    static readonly int GetAnchors_ReturnValue_Offset;
    
    public UnrealSharp.Slate.Anchors GetAnchors()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAnchors_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetAnchors_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Slate.Anchors returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.Slate.Anchors>.FromNative(IntPtr.Add(ParamsBuffer, GetAnchors_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.CanvasPanelSlot:GetAlignment
    static readonly IntPtr GetAlignment_NativeFunction;
    static readonly int GetAlignment_ParamsSize;
    static readonly int GetAlignment_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector2 GetAlignment()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAlignment_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetAlignment_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector2 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(ParamsBuffer, GetAlignment_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}