// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class CameraLensEffectInterfaceClassSupportLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static CameraLensEffectInterfaceClassSupportLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CameraLensEffectInterfaceClassSupportLibrary");
        
        
        SetInterfaceClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetInterfaceClass");
        SetInterfaceClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetInterfaceClass_NativeFunction);
        SetInterfaceClass_Class_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInterfaceClass_NativeFunction, "Class");
        SetInterfaceClass_Var_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInterfaceClass_NativeFunction, "Var");
        SetInterfaceClass_Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetInterfaceClass_NativeFunction, "Result");
        IsInterfaceClassValid_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsInterfaceClassValid");
        IsInterfaceClassValid_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsInterfaceClassValid_NativeFunction);
        IsInterfaceClassValid_CameraLens_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInterfaceClassValid_NativeFunction, "CameraLens");
        IsInterfaceClassValid_Result_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsInterfaceClassValid_NativeFunction, "Result");
        GetInterfaceClass_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInterfaceClass");
        GetInterfaceClass_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInterfaceClass_NativeFunction);
        GetInterfaceClass_CameraLens_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInterfaceClass_NativeFunction, "CameraLens");
        GetInterfaceClass_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInterfaceClass_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CameraLensEffectInterfaceClassSupportLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:SetInterfaceClass
    static readonly IntPtr SetInterfaceClass_NativeFunction;
    static readonly int SetInterfaceClass_ParamsSize;
    static readonly int SetInterfaceClass_Class_Offset;
    static readonly int SetInterfaceClass_Var_Offset;
    static readonly int SetInterfaceClass_Result_Offset;
    
    public static void SetInterfaceClass(SubclassOf<UnrealSharp.Engine.Actor> @class, ref UnrealSharp.Engine.CameraLensInterfaceClassSupport var, out UnrealSharp.Engine.EInterfaceValidResult result)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetInterfaceClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            SubclassOfMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(ParamsBuffer, SetInterfaceClass_Class_Offset), 0, null, @class);
            UnrealSharp.Engine.CameraLensInterfaceClassSupportMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetInterfaceClass_Var_Offset), 0, null, var);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, SetInterfaceClass_NativeFunction, ParamsBuffer);
            
            var = UnrealSharp.Engine.CameraLensInterfaceClassSupportMarshaler.FromNative(IntPtr.Add(ParamsBuffer, SetInterfaceClass_Var_Offset), 0, null);
            result = BlittableMarshaller<UnrealSharp.Engine.EInterfaceValidResult>.FromNative(IntPtr.Add(ParamsBuffer, SetInterfaceClass_Result_Offset), 0, null);
            
        }
    }
    
    // Function /Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:IsInterfaceClassValid
    static readonly IntPtr IsInterfaceClassValid_NativeFunction;
    static readonly int IsInterfaceClassValid_ParamsSize;
    static readonly int IsInterfaceClassValid_CameraLens_Offset;
    static readonly int IsInterfaceClassValid_Result_Offset;
    
    public static void IsInterfaceClassValid(UnrealSharp.Engine.CameraLensInterfaceClassSupport cameraLens, out UnrealSharp.Engine.EInterfaceValidResult result)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsInterfaceClassValid_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.CameraLensInterfaceClassSupportMarshaler.ToNative(IntPtr.Add(ParamsBuffer, IsInterfaceClassValid_CameraLens_Offset), 0, null, cameraLens);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsInterfaceClassValid_NativeFunction, ParamsBuffer);
            
            result = BlittableMarshaller<UnrealSharp.Engine.EInterfaceValidResult>.FromNative(IntPtr.Add(ParamsBuffer, IsInterfaceClassValid_Result_Offset), 0, null);
            
        }
    }
    
    // Function /Script/Engine.CameraLensEffectInterfaceClassSupportLibrary:GetInterfaceClass
    static readonly IntPtr GetInterfaceClass_NativeFunction;
    static readonly int GetInterfaceClass_ParamsSize;
    static readonly int GetInterfaceClass_CameraLens_Offset;
    static readonly int GetInterfaceClass_ReturnValue_Offset;
    
    public static SubclassOf<UnrealSharp.Engine.Actor> GetInterfaceClass(UnrealSharp.Engine.CameraLensInterfaceClassSupport cameraLens)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetInterfaceClass_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.CameraLensInterfaceClassSupportMarshaler.ToNative(IntPtr.Add(ParamsBuffer, GetInterfaceClass_CameraLens_Offset), 0, null, cameraLens);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetInterfaceClass_NativeFunction, ParamsBuffer);
            
            SubclassOf<UnrealSharp.Engine.Actor> returnValue;
            returnValue = SubclassOfMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(ParamsBuffer, GetInterfaceClass_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}