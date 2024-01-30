// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PlayerInput : UnrealSharp.CoreUObject.Object
{
    
    static PlayerInput()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PlayerInput");
        
        
        GetOuterAPlayerController_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetOuterAPlayerController");
        GetOuterAPlayerController_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetOuterAPlayerController_NativeFunction);
        GetOuterAPlayerController_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetOuterAPlayerController_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PlayerInput(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.PlayerInput:GetOuterAPlayerController
    static readonly IntPtr GetOuterAPlayerController_NativeFunction;
    static readonly int GetOuterAPlayerController_ParamsSize;
    static readonly int GetOuterAPlayerController_ReturnValue_Offset;
    
    public UnrealSharp.Engine.PlayerController GetOuterAPlayerController()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetOuterAPlayerController_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetOuterAPlayerController_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.PlayerController returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.PlayerController>.FromNative(IntPtr.Add(ParamsBuffer, GetOuterAPlayerController_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}