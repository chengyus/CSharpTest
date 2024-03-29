// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GeometryCollectionEngine;

[UClass]
public partial class GeometryCollectionActor : UnrealSharp.Engine.Actor
{
    
    static GeometryCollectionActor()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("GeometryCollectionActor");
        
        GeometryCollectionComponent_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GeometryCollectionComponent");
        
        RaycastSingle_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RaycastSingle");
        RaycastSingle_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RaycastSingle_NativeFunction);
        RaycastSingle_Start_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RaycastSingle_NativeFunction, "Start");
        RaycastSingle_End_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RaycastSingle_NativeFunction, "End");
        RaycastSingle_OutHit_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RaycastSingle_NativeFunction, "OutHit");
        RaycastSingle_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RaycastSingle_NativeFunction, "ReturnValue");
        
        
    }
    
    protected GeometryCollectionActor(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/GeometryCollectionEngine.GeometryCollectionActor:GeometryCollectionComponent
    static readonly int GeometryCollectionComponent_Offset;
    
    public UnrealSharp.GeometryCollectionEngine.GeometryCollectionComponent GeometryCollectionComponent
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.GeometryCollectionEngine.GeometryCollectionComponent>.FromNative(IntPtr.Add(NativeObject, GeometryCollectionComponent_Offset), 0, this);
        }
    }
    
    // Function /Script/GeometryCollectionEngine.GeometryCollectionActor:RaycastSingle
    static readonly IntPtr RaycastSingle_NativeFunction;
    static readonly int RaycastSingle_ParamsSize;
    static readonly int RaycastSingle_Start_Offset;
    static readonly int RaycastSingle_End_Offset;
    static readonly int RaycastSingle_OutHit_Offset;
    static readonly int RaycastSingle_ReturnValue_Offset;
    
    public bool RaycastSingle(System.DoubleNumerics.Vector3 start, System.DoubleNumerics.Vector3 end, out UnrealSharp.Engine.HitResult outHit)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RaycastSingle_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, RaycastSingle_Start_Offset), 0, null, start);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, RaycastSingle_End_Offset), 0, null, end);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RaycastSingle_NativeFunction, ParamsBuffer);
            
            outHit = UnrealSharp.Engine.HitResultMarshaler.FromNative(IntPtr.Add(ParamsBuffer, RaycastSingle_OutHit_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, RaycastSingle_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}