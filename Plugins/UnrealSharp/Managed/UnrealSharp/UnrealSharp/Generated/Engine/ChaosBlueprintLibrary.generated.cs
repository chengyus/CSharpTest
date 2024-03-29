// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class ChaosBlueprintLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static ChaosBlueprintLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ChaosBlueprintLibrary");
        
        
        GetEventRelayFromContext_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetEventRelayFromContext");
        GetEventRelayFromContext_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetEventRelayFromContext_NativeFunction);
        GetEventRelayFromContext_ContextObject_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetEventRelayFromContext_NativeFunction, "ContextObject");
        GetEventRelayFromContext_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetEventRelayFromContext_NativeFunction, "ReturnValue");
        
        
    }
    
    protected ChaosBlueprintLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.ChaosBlueprintLibrary:GetEventRelayFromContext
    static readonly IntPtr GetEventRelayFromContext_NativeFunction;
    static readonly int GetEventRelayFromContext_ParamsSize;
    static readonly int GetEventRelayFromContext_ContextObject_Offset;
    static readonly int GetEventRelayFromContext_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.ChaosEventRelay GetEventRelayFromContext(UnrealSharp.CoreUObject.Object contextObject)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetEventRelayFromContext_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, GetEventRelayFromContext_ContextObject_Offset), 0, null, contextObject);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetEventRelayFromContext_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.ChaosEventRelay returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.ChaosEventRelay>.FromNative(IntPtr.Add(ParamsBuffer, GetEventRelayFromContext_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}