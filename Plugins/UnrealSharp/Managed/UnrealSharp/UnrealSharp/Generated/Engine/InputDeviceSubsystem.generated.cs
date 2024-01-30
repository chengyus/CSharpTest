// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class InputDeviceSubsystem : UnrealSharp.Engine.EngineSubsystem
{
    
    static InputDeviceSubsystem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InputDeviceSubsystem");
        
        
        RemoveDevicePropertyByHandle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveDevicePropertyByHandle");
        RemoveDevicePropertyByHandle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveDevicePropertyByHandle_NativeFunction);
        RemoveDevicePropertyByHandle_HandleToRemove_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveDevicePropertyByHandle_NativeFunction, "HandleToRemove");
        RemoveAllDeviceProperties_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveAllDeviceProperties");
        IsPropertyActive_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsPropertyActive");
        IsPropertyActive_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsPropertyActive_NativeFunction);
        IsPropertyActive_Handle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsPropertyActive_NativeFunction, "Handle");
        IsPropertyActive_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsPropertyActive_NativeFunction, "ReturnValue");
        GetMostRecentlyUsedHardwareDevice_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetMostRecentlyUsedHardwareDevice");
        GetMostRecentlyUsedHardwareDevice_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetMostRecentlyUsedHardwareDevice_NativeFunction);
        GetMostRecentlyUsedHardwareDevice_InUserId_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMostRecentlyUsedHardwareDevice_NativeFunction, "InUserId");
        GetMostRecentlyUsedHardwareDevice_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetMostRecentlyUsedHardwareDevice_NativeFunction, "ReturnValue");
        GetInputDeviceHardwareIdentifier_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInputDeviceHardwareIdentifier");
        GetInputDeviceHardwareIdentifier_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInputDeviceHardwareIdentifier_NativeFunction);
        GetInputDeviceHardwareIdentifier_InputDevice_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInputDeviceHardwareIdentifier_NativeFunction, "InputDevice");
        GetInputDeviceHardwareIdentifier_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInputDeviceHardwareIdentifier_NativeFunction, "ReturnValue");
        GetActiveDeviceProperty_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetActiveDeviceProperty");
        GetActiveDeviceProperty_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetActiveDeviceProperty_NativeFunction);
        GetActiveDeviceProperty_Handle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetActiveDeviceProperty_NativeFunction, "Handle");
        GetActiveDeviceProperty_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetActiveDeviceProperty_NativeFunction, "ReturnValue");
        ActivateDevicePropertyOfClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ActivateDevicePropertyOfClass");
        ActivateDevicePropertyOfClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ActivateDevicePropertyOfClass_NativeFunction);
        ActivateDevicePropertyOfClass_PropertyClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ActivateDevicePropertyOfClass_NativeFunction, "PropertyClass");
        ActivateDevicePropertyOfClass_Params_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ActivateDevicePropertyOfClass_NativeFunction, "Params");
        ActivateDevicePropertyOfClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ActivateDevicePropertyOfClass_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InputDeviceSubsystem(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.InputDeviceSubsystem:RemoveDevicePropertyByHandle
    static readonly IntPtr RemoveDevicePropertyByHandle_NativeFunction;
    static readonly int RemoveDevicePropertyByHandle_ParamsSize;
    static readonly int RemoveDevicePropertyByHandle_HandleToRemove_Offset;
    
    public void RemoveDevicePropertyByHandle(UnrealSharp.Engine.InputDevicePropertyHandle handleToRemove)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveDevicePropertyByHandle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.InputDevicePropertyHandleMarshaler.ToNative(IntPtr.Add(ParamsBuffer, RemoveDevicePropertyByHandle_HandleToRemove_Offset), 0, null, handleToRemove);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveDevicePropertyByHandle_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.InputDeviceSubsystem:RemoveAllDeviceProperties
    static readonly IntPtr RemoveAllDeviceProperties_NativeFunction;
    
    public void RemoveAllDeviceProperties()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveAllDeviceProperties_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.InputDeviceSubsystem:IsPropertyActive
    static readonly IntPtr IsPropertyActive_NativeFunction;
    static readonly int IsPropertyActive_ParamsSize;
    static readonly int IsPropertyActive_Handle_Offset;
    static readonly int IsPropertyActive_ReturnValue_Offset;
    
    public bool IsPropertyActive(UnrealSharp.Engine.InputDevicePropertyHandle handle)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsPropertyActive_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.InputDevicePropertyHandleMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsPropertyActive_Handle_Offset), 0, null, handle);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsPropertyActive_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsPropertyActive_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.InputDeviceSubsystem:GetMostRecentlyUsedHardwareDevice
    static readonly IntPtr GetMostRecentlyUsedHardwareDevice_NativeFunction;
    static readonly int GetMostRecentlyUsedHardwareDevice_ParamsSize;
    static readonly int GetMostRecentlyUsedHardwareDevice_InUserId_Offset;
    static readonly int GetMostRecentlyUsedHardwareDevice_ReturnValue_Offset;
    
    public UnrealSharp.Engine.HardwareDeviceIdentifier GetMostRecentlyUsedHardwareDevice(UnrealSharp.CoreUObject.PlatformUserId inUserId)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetMostRecentlyUsedHardwareDevice_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.CoreUObject.PlatformUserIdMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetMostRecentlyUsedHardwareDevice_InUserId_Offset), 0, null, inUserId);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetMostRecentlyUsedHardwareDevice_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.HardwareDeviceIdentifier returnValue;
            returnValue = UnrealSharp.Engine.HardwareDeviceIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetMostRecentlyUsedHardwareDevice_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.InputDeviceSubsystem:GetInputDeviceHardwareIdentifier
    static readonly IntPtr GetInputDeviceHardwareIdentifier_NativeFunction;
    static readonly int GetInputDeviceHardwareIdentifier_ParamsSize;
    static readonly int GetInputDeviceHardwareIdentifier_InputDevice_Offset;
    static readonly int GetInputDeviceHardwareIdentifier_ReturnValue_Offset;
    
    public UnrealSharp.Engine.HardwareDeviceIdentifier GetInputDeviceHardwareIdentifier(UnrealSharp.CoreUObject.InputDeviceId inputDevice)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetInputDeviceHardwareIdentifier_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.CoreUObject.InputDeviceIdMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetInputDeviceHardwareIdentifier_InputDevice_Offset), 0, null, inputDevice);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetInputDeviceHardwareIdentifier_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.HardwareDeviceIdentifier returnValue;
            returnValue = UnrealSharp.Engine.HardwareDeviceIdentifierMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetInputDeviceHardwareIdentifier_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.InputDeviceSubsystem:GetActiveDeviceProperty
    static readonly IntPtr GetActiveDeviceProperty_NativeFunction;
    static readonly int GetActiveDeviceProperty_ParamsSize;
    static readonly int GetActiveDeviceProperty_Handle_Offset;
    static readonly int GetActiveDeviceProperty_ReturnValue_Offset;
    
    public UnrealSharp.Engine.InputDeviceProperty GetActiveDeviceProperty(UnrealSharp.Engine.InputDevicePropertyHandle handle)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetActiveDeviceProperty_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.InputDevicePropertyHandleMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetActiveDeviceProperty_Handle_Offset), 0, null, handle);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetActiveDeviceProperty_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.InputDeviceProperty returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.InputDeviceProperty>.FromNative(IntPtr.Add(ParamsBuffer, GetActiveDeviceProperty_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.InputDeviceSubsystem:ActivateDevicePropertyOfClass
    static readonly IntPtr ActivateDevicePropertyOfClass_NativeFunction;
    static readonly int ActivateDevicePropertyOfClass_ParamsSize;
    static readonly int ActivateDevicePropertyOfClass_PropertyClass_Offset;
    static readonly int ActivateDevicePropertyOfClass_Params_Offset;
    static readonly int ActivateDevicePropertyOfClass_ReturnValue_Offset;
    
    public UnrealSharp.Engine.InputDevicePropertyHandle ActivateDevicePropertyOfClass(SubclassOf<UnrealSharp.Engine.InputDeviceProperty> propertyClass, UnrealSharp.Engine.ActivateDevicePropertyParams @params)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ActivateDevicePropertyOfClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            SubclassOfMarshaller<UnrealSharp.Engine.InputDeviceProperty>.ToNative(IntPtr.Add(ParamsBuffer, ActivateDevicePropertyOfClass_PropertyClass_Offset), 0, null, propertyClass);
            UnrealSharp.Engine.ActivateDevicePropertyParamsMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ActivateDevicePropertyOfClass_Params_Offset), 0, null, @params);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ActivateDevicePropertyOfClass_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.InputDevicePropertyHandle returnValue;
            returnValue = UnrealSharp.Engine.InputDevicePropertyHandleMarshaler.FromNative(IntPtr.Add(ParamsBuffer, ActivateDevicePropertyOfClass_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}