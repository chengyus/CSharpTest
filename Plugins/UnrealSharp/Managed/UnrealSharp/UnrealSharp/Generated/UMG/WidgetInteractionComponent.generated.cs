// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class WidgetInteractionComponent : UnrealSharp.Engine.SceneComponent
{
    
    static WidgetInteractionComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("WidgetInteractionComponent");
        
        VirtualUserIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VirtualUserIndex");
        PointerIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PointerIndex");
        TraceChannel_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TraceChannel");
        InteractionDistance_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InteractionDistance");
        InteractionSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "InteractionSource");
        bEnableHitTesting_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bEnableHitTesting");
        bShowDebug_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bShowDebug");
        DebugSphereLineThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugSphereLineThickness");
        DebugLineThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugLineThickness");
        DebugColor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DebugColor");
        
        SetFocus_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetFocus");
        SetFocus_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetFocus_NativeFunction);
        SetFocus_FocusWidget_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetFocus_NativeFunction, "FocusWidget");
        SetCustomHitResult_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetCustomHitResult");
        SetCustomHitResult_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetCustomHitResult_NativeFunction);
        SetCustomHitResult_HitResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetCustomHitResult_NativeFunction, "HitResult");
        SendKeyChar_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SendKeyChar");
        SendKeyChar_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SendKeyChar_NativeFunction);
        SendKeyChar_Characters_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SendKeyChar_NativeFunction, "Characters");
        SendKeyChar_bRepeat_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SendKeyChar_NativeFunction, "bRepeat");
        SendKeyChar_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SendKeyChar_NativeFunction, "ReturnValue");
        ScrollWheel_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScrollWheel");
        ScrollWheel_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScrollWheel_NativeFunction);
        ScrollWheel_ScrollDelta_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScrollWheel_NativeFunction, "ScrollDelta");
        ReleasePointerKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReleasePointerKey");
        ReleasePointerKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReleasePointerKey_NativeFunction);
        ReleasePointerKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReleasePointerKey_NativeFunction, "Key");
        ReleaseKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReleaseKey");
        ReleaseKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReleaseKey_NativeFunction);
        ReleaseKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReleaseKey_NativeFunction, "Key");
        ReleaseKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReleaseKey_NativeFunction, "ReturnValue");
        PressPointerKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "PressPointerKey");
        PressPointerKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(PressPointerKey_NativeFunction);
        PressPointerKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PressPointerKey_NativeFunction, "Key");
        PressKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "PressKey");
        PressKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(PressKey_NativeFunction);
        PressKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PressKey_NativeFunction, "Key");
        PressKey_bRepeat_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PressKey_NativeFunction, "bRepeat");
        PressKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PressKey_NativeFunction, "ReturnValue");
        PressAndReleaseKey_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "PressAndReleaseKey");
        PressAndReleaseKey_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(PressAndReleaseKey_NativeFunction);
        PressAndReleaseKey_Key_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PressAndReleaseKey_NativeFunction, "Key");
        PressAndReleaseKey_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(PressAndReleaseKey_NativeFunction, "ReturnValue");
        IsOverInteractableWidget_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsOverInteractableWidget");
        IsOverInteractableWidget_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsOverInteractableWidget_NativeFunction);
        IsOverInteractableWidget_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOverInteractableWidget_NativeFunction, "ReturnValue");
        IsOverHitTestVisibleWidget_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsOverHitTestVisibleWidget");
        IsOverHitTestVisibleWidget_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsOverHitTestVisibleWidget_NativeFunction);
        IsOverHitTestVisibleWidget_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOverHitTestVisibleWidget_NativeFunction, "ReturnValue");
        IsOverFocusableWidget_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsOverFocusableWidget");
        IsOverFocusableWidget_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsOverFocusableWidget_NativeFunction);
        IsOverFocusableWidget_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsOverFocusableWidget_NativeFunction, "ReturnValue");
        GetLastHitResult_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLastHitResult");
        GetLastHitResult_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLastHitResult_NativeFunction);
        GetLastHitResult_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLastHitResult_NativeFunction, "ReturnValue");
        GetHoveredWidgetComponent_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetHoveredWidgetComponent");
        GetHoveredWidgetComponent_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetHoveredWidgetComponent_NativeFunction);
        GetHoveredWidgetComponent_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetHoveredWidgetComponent_NativeFunction, "ReturnValue");
        Get2DHitLocation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Get2DHitLocation");
        Get2DHitLocation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Get2DHitLocation_NativeFunction);
        Get2DHitLocation_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Get2DHitLocation_NativeFunction, "ReturnValue");
        
        
    }
    
    protected WidgetInteractionComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/UMG.WidgetInteractionComponent:VirtualUserIndex
    static readonly int VirtualUserIndex_Offset;
    
    public int VirtualUserIndex
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, VirtualUserIndex_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, VirtualUserIndex_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/UMG.WidgetInteractionComponent:PointerIndex
    static readonly int PointerIndex_Offset;
    
    public int PointerIndex
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, PointerIndex_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, PointerIndex_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/UMG.WidgetInteractionComponent:TraceChannel
    static readonly int TraceChannel_Offset;
    
    public UnrealSharp.Engine.ECollisionChannel TraceChannel
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Engine.ECollisionChannel>.FromNative(IntPtr.Add(NativeObject, TraceChannel_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.Engine.ECollisionChannel>.ToNative(IntPtr.Add(NativeObject, TraceChannel_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.WidgetInteractionComponent:InteractionDistance
    static readonly int InteractionDistance_Offset;
    
    public float InteractionDistance
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, InteractionDistance_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, InteractionDistance_Offset), 0, this, value);
        }
    }
    
    // EnumProperty /Script/UMG.WidgetInteractionComponent:InteractionSource
    static readonly int InteractionSource_Offset;
    
    public UnrealSharp.UMG.EWidgetInteractionSource InteractionSource
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.UMG.EWidgetInteractionSource>.FromNative(IntPtr.Add(NativeObject, InteractionSource_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.UMG.EWidgetInteractionSource>.ToNative(IntPtr.Add(NativeObject, InteractionSource_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.WidgetInteractionComponent:bEnableHitTesting
    static readonly int bEnableHitTesting_Offset;
    
    public bool bEnableHitTesting
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bEnableHitTesting_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bEnableHitTesting_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/UMG.WidgetInteractionComponent:bShowDebug
    static readonly int bShowDebug_Offset;
    
    public bool bShowDebug
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bShowDebug_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bShowDebug_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.WidgetInteractionComponent:DebugSphereLineThickness
    static readonly int DebugSphereLineThickness_Offset;
    
    public float DebugSphereLineThickness
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DebugSphereLineThickness_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DebugSphereLineThickness_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/UMG.WidgetInteractionComponent:DebugLineThickness
    static readonly int DebugLineThickness_Offset;
    
    public float DebugLineThickness
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DebugLineThickness_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DebugLineThickness_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.WidgetInteractionComponent:DebugColor
    static readonly int DebugColor_Offset;
    
    public UnrealSharp.CoreUObject.LinearColor DebugColor
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.FromNative(IntPtr.Add(NativeObject, DebugColor_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.LinearColor>.ToNative(IntPtr.Add(NativeObject, DebugColor_Offset), 0, this, value);
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:SetFocus
    static readonly IntPtr SetFocus_NativeFunction;
    static readonly int SetFocus_ParamsSize;
    static readonly int SetFocus_FocusWidget_Offset;
    
    public void SetFocus(UnrealSharp.UMG.Widget focusWidget)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetFocus_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.UMG.Widget>.ToNative(IntPtr.Add(ParamsBuffer, SetFocus_FocusWidget_Offset), 0, null, focusWidget);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetFocus_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:SetCustomHitResult
    static readonly IntPtr SetCustomHitResult_NativeFunction;
    static readonly int SetCustomHitResult_ParamsSize;
    static readonly int SetCustomHitResult_HitResult_Offset;
    
    public void SetCustomHitResult(UnrealSharp.Engine.HitResult hitResult)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetCustomHitResult_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.HitResultMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetCustomHitResult_HitResult_Offset), 0, null, hitResult);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetCustomHitResult_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:SendKeyChar
    static readonly IntPtr SendKeyChar_NativeFunction;
    static readonly int SendKeyChar_ParamsSize;
    static readonly int SendKeyChar_Characters_Offset;
    static readonly int SendKeyChar_bRepeat_Offset;
    static readonly int SendKeyChar_ReturnValue_Offset;
    
    public bool SendKeyChar(string characters, bool bRepeat = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SendKeyChar_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Characters_NativePtr = IntPtr.Add(ParamsBuffer,SendKeyChar_Characters_Offset);
            StringMarshaller.ToNative(Characters_NativePtr,0,null,characters);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SendKeyChar_bRepeat_Offset), 0, null, bRepeat);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SendKeyChar_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SendKeyChar_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Characters_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:ScrollWheel
    static readonly IntPtr ScrollWheel_NativeFunction;
    static readonly int ScrollWheel_ParamsSize;
    static readonly int ScrollWheel_ScrollDelta_Offset;
    
    public void ScrollWheel(float scrollDelta)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ScrollWheel_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, ScrollWheel_ScrollDelta_Offset), 0, null, scrollDelta);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScrollWheel_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:ReleasePointerKey
    static readonly IntPtr ReleasePointerKey_NativeFunction;
    static readonly int ReleasePointerKey_ParamsSize;
    static readonly int ReleasePointerKey_Key_Offset;
    
    public void ReleasePointerKey(UnrealSharp.InputCore.Key key)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ReleasePointerKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ReleasePointerKey_Key_Offset), 0, null, key);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReleasePointerKey_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:ReleaseKey
    static readonly IntPtr ReleaseKey_NativeFunction;
    static readonly int ReleaseKey_ParamsSize;
    static readonly int ReleaseKey_Key_Offset;
    static readonly int ReleaseKey_ReturnValue_Offset;
    
    public bool ReleaseKey(UnrealSharp.InputCore.Key key)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ReleaseKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ReleaseKey_Key_Offset), 0, null, key);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ReleaseKey_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ReleaseKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:PressPointerKey
    static readonly IntPtr PressPointerKey_NativeFunction;
    static readonly int PressPointerKey_ParamsSize;
    static readonly int PressPointerKey_Key_Offset;
    
    public void PressPointerKey(UnrealSharp.InputCore.Key key)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[PressPointerKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(ParamsBuffer, PressPointerKey_Key_Offset), 0, null, key);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, PressPointerKey_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:PressKey
    static readonly IntPtr PressKey_NativeFunction;
    static readonly int PressKey_ParamsSize;
    static readonly int PressKey_Key_Offset;
    static readonly int PressKey_bRepeat_Offset;
    static readonly int PressKey_ReturnValue_Offset;
    
    public bool PressKey(UnrealSharp.InputCore.Key key, bool bRepeat = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[PressKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(ParamsBuffer, PressKey_Key_Offset), 0, null, key);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, PressKey_bRepeat_Offset), 0, null, bRepeat);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, PressKey_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, PressKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:PressAndReleaseKey
    static readonly IntPtr PressAndReleaseKey_NativeFunction;
    static readonly int PressAndReleaseKey_ParamsSize;
    static readonly int PressAndReleaseKey_Key_Offset;
    static readonly int PressAndReleaseKey_ReturnValue_Offset;
    
    public bool PressAndReleaseKey(UnrealSharp.InputCore.Key key)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[PressAndReleaseKey_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.InputCore.KeyMarshaler.ToNative(IntPtr.Add(ParamsBuffer, PressAndReleaseKey_Key_Offset), 0, null, key);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, PressAndReleaseKey_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, PressAndReleaseKey_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:IsOverInteractableWidget
    static readonly IntPtr IsOverInteractableWidget_NativeFunction;
    static readonly int IsOverInteractableWidget_ParamsSize;
    static readonly int IsOverInteractableWidget_ReturnValue_Offset;
    
    public bool IsOverInteractableWidget()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsOverInteractableWidget_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsOverInteractableWidget_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsOverInteractableWidget_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:IsOverHitTestVisibleWidget
    static readonly IntPtr IsOverHitTestVisibleWidget_NativeFunction;
    static readonly int IsOverHitTestVisibleWidget_ParamsSize;
    static readonly int IsOverHitTestVisibleWidget_ReturnValue_Offset;
    
    public bool IsOverHitTestVisibleWidget()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsOverHitTestVisibleWidget_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsOverHitTestVisibleWidget_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsOverHitTestVisibleWidget_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:IsOverFocusableWidget
    static readonly IntPtr IsOverFocusableWidget_NativeFunction;
    static readonly int IsOverFocusableWidget_ParamsSize;
    static readonly int IsOverFocusableWidget_ReturnValue_Offset;
    
    public bool IsOverFocusableWidget()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsOverFocusableWidget_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsOverFocusableWidget_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsOverFocusableWidget_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:GetLastHitResult
    static readonly IntPtr GetLastHitResult_NativeFunction;
    static readonly int GetLastHitResult_ParamsSize;
    static readonly int GetLastHitResult_ReturnValue_Offset;
    
    public UnrealSharp.Engine.HitResult GetLastHitResult()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLastHitResult_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLastHitResult_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.HitResult returnValue;
            returnValue = UnrealSharp.Engine.HitResultMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetLastHitResult_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:GetHoveredWidgetComponent
    static readonly IntPtr GetHoveredWidgetComponent_NativeFunction;
    static readonly int GetHoveredWidgetComponent_ParamsSize;
    static readonly int GetHoveredWidgetComponent_ReturnValue_Offset;
    
    public UnrealSharp.UMG.WidgetComponent GetHoveredWidgetComponent()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetHoveredWidgetComponent_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetHoveredWidgetComponent_NativeFunction, ParamsBuffer);
            
            UnrealSharp.UMG.WidgetComponent returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.UMG.WidgetComponent>.FromNative(IntPtr.Add(ParamsBuffer, GetHoveredWidgetComponent_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/UMG.WidgetInteractionComponent:Get2DHitLocation
    static readonly IntPtr Get2DHitLocation_NativeFunction;
    static readonly int Get2DHitLocation_ParamsSize;
    static readonly int Get2DHitLocation_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector2 Get2DHitLocation()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Get2DHitLocation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Get2DHitLocation_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector2 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(ParamsBuffer, Get2DHitLocation_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}