// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class PhysicsThreadLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static PhysicsThreadLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PhysicsThreadLibrary");
        
        
        AddForce_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddForce");
        AddForce_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddForce_NativeFunction);
        AddForce_Handle_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddForce_NativeFunction, "Handle");
        AddForce_Force_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddForce_NativeFunction, "Force");
        AddForce_bAccelChange_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddForce_NativeFunction, "bAccelChange");
        
        
    }
    
    protected PhysicsThreadLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.PhysicsThreadLibrary:AddForce
    static readonly IntPtr AddForce_NativeFunction;
    static readonly int AddForce_ParamsSize;
    static readonly int AddForce_Handle_Offset;
    static readonly int AddForce_Force_Offset;
    static readonly int AddForce_bAccelChange_Offset;
    
    public static void AddForce(UnrealSharp.Engine.BodyInstanceAsyncPhysicsTickHandle handle, System.DoubleNumerics.Vector3 force, bool bAccelChange = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddForce_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.Engine.BodyInstanceAsyncPhysicsTickHandleMarshaler.ToNative(IntPtr.Add(ParamsBuffer, AddForce_Handle_Offset), 0, null, handle);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, AddForce_Force_Offset), 0, null, force);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddForce_bAccelChange_Offset), 0, null, bAccelChange);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, AddForce_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}