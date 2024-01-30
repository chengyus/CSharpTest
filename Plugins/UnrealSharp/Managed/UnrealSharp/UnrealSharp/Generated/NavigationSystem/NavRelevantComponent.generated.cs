// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.NavigationSystem;

[UClass]
public partial class NavRelevantComponent : UnrealSharp.Engine.ActorComponent
{
    
    static NavRelevantComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("NavRelevantComponent");
        
        
        SetNavigationRelevancy_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetNavigationRelevancy");
        SetNavigationRelevancy_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetNavigationRelevancy_NativeFunction);
        SetNavigationRelevancy_bRelevant_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetNavigationRelevancy_NativeFunction, "bRelevant");
        
        
    }
    
    protected NavRelevantComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/NavigationSystem.NavRelevantComponent:SetNavigationRelevancy
    static readonly IntPtr SetNavigationRelevancy_NativeFunction;
    static readonly int SetNavigationRelevancy_ParamsSize;
    static readonly int SetNavigationRelevancy_bRelevant_Offset;
    
    public void SetNavigationRelevancy(bool bRelevant)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetNavigationRelevancy_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, SetNavigationRelevancy_bRelevant_Offset), 0, null, bRelevant);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetNavigationRelevancy_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}