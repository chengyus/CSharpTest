// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PhysicsSettings : UnrealSharp.PhysicsCore.PhysicsSettingsCore
{
    
    static PhysicsSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PhysicsSettings");
        
        
        GetPhysicsHistoryCount_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPhysicsHistoryCount");
        GetPhysicsHistoryCount_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPhysicsHistoryCount_NativeFunction);
        GetPhysicsHistoryCount_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPhysicsHistoryCount_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PhysicsSettings(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.PhysicsSettings:GetPhysicsHistoryCount
    static readonly IntPtr GetPhysicsHistoryCount_NativeFunction;
    static readonly int GetPhysicsHistoryCount_ParamsSize;
    static readonly int GetPhysicsHistoryCount_ReturnValue_Offset;
    
    public int GetPhysicsHistoryCount()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPhysicsHistoryCount_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPhysicsHistoryCount_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetPhysicsHistoryCount_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}