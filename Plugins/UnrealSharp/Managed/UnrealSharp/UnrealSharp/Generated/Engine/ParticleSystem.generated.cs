// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class ParticleSystem : UnrealSharp.Engine.FXSystemAsset
{
    
    static ParticleSystem()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ParticleSystem");
        
        
        ContainsEmitterType_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ContainsEmitterType");
        ContainsEmitterType_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ContainsEmitterType_NativeFunction);
        ContainsEmitterType_TypeData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ContainsEmitterType_NativeFunction, "TypeData");
        ContainsEmitterType_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ContainsEmitterType_NativeFunction, "ReturnValue");
        
        
    }
    
    protected ParticleSystem(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.ParticleSystem:ContainsEmitterType
    static readonly IntPtr ContainsEmitterType_NativeFunction;
    static readonly int ContainsEmitterType_ParamsSize;
    static readonly int ContainsEmitterType_TypeData_Offset;
    static readonly int ContainsEmitterType_ReturnValue_Offset;
    
    public bool ContainsEmitterType(SubclassOf<UnrealSharp.CoreUObject.Object> typeData)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ContainsEmitterType_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            SubclassOfMarshaller<UnrealSharp.CoreUObject.Object>.ToNative(IntPtr.Add(ParamsBuffer, ContainsEmitterType_TypeData_Offset), 0, null, typeData);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ContainsEmitterType_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ContainsEmitterType_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}