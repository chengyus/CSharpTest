// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class SkeletalMeshSocket : UnrealSharp.CoreUObject.Object
{
    
    static SkeletalMeshSocket()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SkeletalMeshSocket");
        
        SocketName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SocketName");
        BoneName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoneName");
        RelativeLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelativeLocation");
        RelativeRotation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelativeRotation");
        RelativeScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "RelativeScale");
        bForceAlwaysAnimated_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bForceAlwaysAnimated");
        
        InitializeSocketFromLocation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "InitializeSocketFromLocation");
        InitializeSocketFromLocation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(InitializeSocketFromLocation_NativeFunction);
        InitializeSocketFromLocation_SkelComp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(InitializeSocketFromLocation_NativeFunction, "SkelComp");
        InitializeSocketFromLocation_WorldLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(InitializeSocketFromLocation_NativeFunction, "WorldLocation");
        InitializeSocketFromLocation_WorldNormal_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(InitializeSocketFromLocation_NativeFunction, "WorldNormal");
        GetSocketLocation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSocketLocation");
        GetSocketLocation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSocketLocation_NativeFunction);
        GetSocketLocation_SkelComp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSocketLocation_NativeFunction, "SkelComp");
        GetSocketLocation_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSocketLocation_NativeFunction, "ReturnValue");
        
        
    }
    
    protected SkeletalMeshSocket(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // NameProperty /Script/Engine.SkeletalMeshSocket:SocketName
    static readonly int SocketName_Offset;
    
    public Name SocketName
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<Name>.FromNative(IntPtr.Add(NativeObject, SocketName_Offset), 0, this);
        }
    }
    
    // NameProperty /Script/Engine.SkeletalMeshSocket:BoneName
    static readonly int BoneName_Offset;
    
    public Name BoneName
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<Name>.FromNative(IntPtr.Add(NativeObject, BoneName_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.SkeletalMeshSocket:RelativeLocation
    static readonly int RelativeLocation_Offset;
    
    public System.DoubleNumerics.Vector3 RelativeLocation
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(NativeObject, RelativeLocation_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.SkeletalMeshSocket:RelativeRotation
    static readonly int RelativeRotation_Offset;
    
    public UnrealSharp.Rotator RelativeRotation
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Rotator>.FromNative(IntPtr.Add(NativeObject, RelativeRotation_Offset), 0, this);
        }
    }
    
    // StructProperty /Script/Engine.SkeletalMeshSocket:RelativeScale
    static readonly int RelativeScale_Offset;
    
    public System.DoubleNumerics.Vector3 RelativeScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(NativeObject, RelativeScale_Offset), 0, this);
        }
    }
    
    // BoolProperty /Script/Engine.SkeletalMeshSocket:bForceAlwaysAnimated
    static readonly int bForceAlwaysAnimated_Offset;
    
    public bool bForceAlwaysAnimated
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bForceAlwaysAnimated_Offset), 0, this);
        }
    }
    
    // Function /Script/Engine.SkeletalMeshSocket:InitializeSocketFromLocation
    static readonly IntPtr InitializeSocketFromLocation_NativeFunction;
    static readonly int InitializeSocketFromLocation_ParamsSize;
    static readonly int InitializeSocketFromLocation_SkelComp_Offset;
    static readonly int InitializeSocketFromLocation_WorldLocation_Offset;
    static readonly int InitializeSocketFromLocation_WorldNormal_Offset;
    
    public void InitializeSocketFromLocation(UnrealSharp.Engine.SkeletalMeshComponent skelComp, System.DoubleNumerics.Vector3 worldLocation, System.DoubleNumerics.Vector3 worldNormal)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[InitializeSocketFromLocation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.SkeletalMeshComponent>.ToNative(IntPtr.Add(ParamsBuffer, InitializeSocketFromLocation_SkelComp_Offset), 0, null, skelComp);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, InitializeSocketFromLocation_WorldLocation_Offset), 0, null, worldLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, InitializeSocketFromLocation_WorldNormal_Offset), 0, null, worldNormal);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, InitializeSocketFromLocation_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/Engine.SkeletalMeshSocket:GetSocketLocation
    static readonly IntPtr GetSocketLocation_NativeFunction;
    static readonly int GetSocketLocation_ParamsSize;
    static readonly int GetSocketLocation_SkelComp_Offset;
    static readonly int GetSocketLocation_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector3 GetSocketLocation(UnrealSharp.Engine.SkeletalMeshComponent skelComp)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSocketLocation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.SkeletalMeshComponent>.ToNative(IntPtr.Add(ParamsBuffer, GetSocketLocation_SkelComp_Offset), 0, null, skelComp);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSocketLocation_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector3 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(ParamsBuffer, GetSocketLocation_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}