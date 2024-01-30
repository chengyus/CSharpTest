// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class PawnMovementComponent : UnrealSharp.Engine.NavMovementComponent
{
    
    static PawnMovementComponent()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PawnMovementComponent");
        
        
        IsMoveInputIgnored_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsMoveInputIgnored");
        IsMoveInputIgnored_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsMoveInputIgnored_NativeFunction);
        IsMoveInputIgnored_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsMoveInputIgnored_NativeFunction, "ReturnValue");
        GetPendingInputVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPendingInputVector");
        GetPendingInputVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPendingInputVector_NativeFunction);
        GetPendingInputVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPendingInputVector_NativeFunction, "ReturnValue");
        GetPawnOwner_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPawnOwner");
        GetPawnOwner_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPawnOwner_NativeFunction);
        GetPawnOwner_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPawnOwner_NativeFunction, "ReturnValue");
        GetLastInputVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLastInputVector");
        GetLastInputVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLastInputVector_NativeFunction);
        GetLastInputVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLastInputVector_NativeFunction, "ReturnValue");
        ConsumeInputVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ConsumeInputVector");
        ConsumeInputVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ConsumeInputVector_NativeFunction);
        ConsumeInputVector_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ConsumeInputVector_NativeFunction, "ReturnValue");
        AddInputVector_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddInputVector");
        AddInputVector_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddInputVector_NativeFunction);
        AddInputVector_WorldVector_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddInputVector_NativeFunction, "WorldVector");
        AddInputVector_bForce_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddInputVector_NativeFunction, "bForce");
        
        
    }
    
    protected PawnMovementComponent(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.PawnMovementComponent:IsMoveInputIgnored
    static readonly IntPtr IsMoveInputIgnored_NativeFunction;
    static readonly int IsMoveInputIgnored_ParamsSize;
    static readonly int IsMoveInputIgnored_ReturnValue_Offset;
    
    public bool IsMoveInputIgnored()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsMoveInputIgnored_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsMoveInputIgnored_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsMoveInputIgnored_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PawnMovementComponent:GetPendingInputVector
    static readonly IntPtr GetPendingInputVector_NativeFunction;
    static readonly int GetPendingInputVector_ParamsSize;
    static readonly int GetPendingInputVector_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector3 GetPendingInputVector()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPendingInputVector_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPendingInputVector_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetPendingInputVector_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PawnMovementComponent:GetPawnOwner
    static readonly IntPtr GetPawnOwner_NativeFunction;
    static readonly int GetPawnOwner_ParamsSize;
    static readonly int GetPawnOwner_ReturnValue_Offset;
    
    public UnrealSharp.Engine.Pawn GetPawnOwner()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPawnOwner_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPawnOwner_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.Pawn returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(ParamsBuffer, GetPawnOwner_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PawnMovementComponent:GetLastInputVector
    static readonly IntPtr GetLastInputVector_NativeFunction;
    static readonly int GetLastInputVector_ParamsSize;
    static readonly int GetLastInputVector_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector3 GetLastInputVector()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLastInputVector_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLastInputVector_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetLastInputVector_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PawnMovementComponent:ConsumeInputVector
    static readonly IntPtr ConsumeInputVector_NativeFunction;
    static readonly int ConsumeInputVector_ParamsSize;
    static readonly int ConsumeInputVector_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector3 ConsumeInputVector()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ConsumeInputVector_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ConsumeInputVector_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, ConsumeInputVector_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.PawnMovementComponent:AddInputVector
    static readonly IntPtr AddInputVector_NativeFunction;
    static readonly int AddInputVector_ParamsSize;
    static readonly int AddInputVector_WorldVector_Offset;
    static readonly int AddInputVector_bForce_Offset;
    
    public void AddInputVector(System.DoubleNumerics.Vector3 worldVector, bool bForce = false)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddInputVector_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, AddInputVector_WorldVector_Offset), 0, null, worldVector);
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, AddInputVector_bForce_Offset), 0, null, bForce);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddInputVector_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}