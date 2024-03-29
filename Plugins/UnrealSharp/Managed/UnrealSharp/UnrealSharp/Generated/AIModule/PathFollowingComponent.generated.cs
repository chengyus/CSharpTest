// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AIModule;

[UClass]
public partial class PathFollowingComponent : UnrealSharp.Engine.ActorComponent
{
    
    static PathFollowingComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PathFollowingComponent");
        
        
        GetPathDestination_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPathDestination");
        GetPathDestination_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPathDestination_NativeFunction);
        GetPathDestination_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPathDestination_NativeFunction, "ReturnValue");
        GetPathActionType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPathActionType");
        GetPathActionType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPathActionType_NativeFunction);
        GetPathActionType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPathActionType_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PathFollowingComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/AIModule.PathFollowingComponent:GetPathDestination
    static readonly IntPtr GetPathDestination_NativeFunction;
    static readonly int GetPathDestination_ParamsSize;
    static readonly int GetPathDestination_ReturnValue_Offset;
    
    [Obsolete("This function is now deprecated, please use AIController.GetImmediateMoveDestination instead")]
    public System.DoubleNumerics.Vector3 GetPathDestination()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPathDestination_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPathDestination_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetPathDestination_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/AIModule.PathFollowingComponent:GetPathActionType
    static readonly IntPtr GetPathActionType_NativeFunction;
    static readonly int GetPathActionType_ParamsSize;
    static readonly int GetPathActionType_ReturnValue_Offset;
    
    [Obsolete("This function is now deprecated, please use AIController.GetMoveStatus instead")]
    public UnrealSharp.AIModule.EPathFollowingAction GetPathActionType()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPathActionType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPathActionType_NativeFunction, ParamsBuffer);
            
            UnrealSharp.AIModule.EPathFollowingAction returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.AIModule.EPathFollowingAction>.FromNative(IntPtr.Add(ParamsBuffer, GetPathActionType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}