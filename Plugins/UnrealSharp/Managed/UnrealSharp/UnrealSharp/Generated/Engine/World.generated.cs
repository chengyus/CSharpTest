// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class World : UnrealSharp.CoreUObject.Object
{
    
    static World()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("World");
        
        
        K2_GetWorldSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "K2_GetWorldSettings");
        K2_GetWorldSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(K2_GetWorldSettings_NativeFunction);
        K2_GetWorldSettings_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(K2_GetWorldSettings_NativeFunction, "ReturnValue");
        GetDataLayerManager_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDataLayerManager");
        GetDataLayerManager_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDataLayerManager_NativeFunction);
        GetDataLayerManager_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDataLayerManager_NativeFunction, "ReturnValue");
        
        
    }
    
    protected World(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.World:K2_GetWorldSettings
    static readonly IntPtr K2_GetWorldSettings_NativeFunction;
    static readonly int K2_GetWorldSettings_ParamsSize;
    static readonly int K2_GetWorldSettings_ReturnValue_Offset;
    
    public UnrealSharp.Engine.WorldSettings GetWorldSettings()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[K2_GetWorldSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, K2_GetWorldSettings_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.WorldSettings returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.WorldSettings>.FromNative(IntPtr.Add(ParamsBuffer, K2_GetWorldSettings_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.World:GetDataLayerManager
    static readonly IntPtr GetDataLayerManager_NativeFunction;
    static readonly int GetDataLayerManager_ParamsSize;
    static readonly int GetDataLayerManager_ReturnValue_Offset;
    
    public UnrealSharp.Engine.DataLayerManager GetDataLayerManager()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDataLayerManager_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetDataLayerManager_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.DataLayerManager returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.DataLayerManager>.FromNative(IntPtr.Add(ParamsBuffer, GetDataLayerManager_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}