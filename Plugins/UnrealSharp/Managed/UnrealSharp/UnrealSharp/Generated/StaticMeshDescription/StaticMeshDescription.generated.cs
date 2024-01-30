// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.StaticMeshDescription;

[UClass]
public partial class StaticMeshDescription : UnrealSharp.MeshDescription.MeshDescriptionBase
{
    
    static StaticMeshDescription()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("StaticMeshDescription");
        
        
        SetVertexInstanceUV_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetVertexInstanceUV");
        SetVertexInstanceUV_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetVertexInstanceUV_NativeFunction);
        SetVertexInstanceUV_VertexInstanceID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVertexInstanceUV_NativeFunction, "VertexInstanceID");
        SetVertexInstanceUV_UV_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVertexInstanceUV_NativeFunction, "UV");
        SetVertexInstanceUV_UVIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetVertexInstanceUV_NativeFunction, "UVIndex");
        SetPolygonGroupMaterialSlotName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetPolygonGroupMaterialSlotName");
        SetPolygonGroupMaterialSlotName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetPolygonGroupMaterialSlotName_NativeFunction);
        SetPolygonGroupMaterialSlotName_PolygonGroupID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPolygonGroupMaterialSlotName_NativeFunction, "PolygonGroupID");
        SetPolygonGroupMaterialSlotName_SlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetPolygonGroupMaterialSlotName_NativeFunction, "SlotName");
        GetVertexInstanceUV_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetVertexInstanceUV");
        GetVertexInstanceUV_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetVertexInstanceUV_NativeFunction);
        GetVertexInstanceUV_VertexInstanceID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVertexInstanceUV_NativeFunction, "VertexInstanceID");
        GetVertexInstanceUV_UVIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVertexInstanceUV_NativeFunction, "UVIndex");
        GetVertexInstanceUV_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetVertexInstanceUV_NativeFunction, "ReturnValue");
        CreateCube_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "CreateCube");
        CreateCube_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(CreateCube_NativeFunction);
        CreateCube_Center_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "Center");
        CreateCube_HalfExtents_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "HalfExtents");
        CreateCube_PolygonGroup_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonGroup");
        CreateCube_PolygonID_PlusX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonID_PlusX");
        CreateCube_PolygonID_MinusX_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonID_MinusX");
        CreateCube_PolygonID_PlusY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonID_PlusY");
        CreateCube_PolygonID_MinusY_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonID_MinusY");
        CreateCube_PolygonID_PlusZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonID_PlusZ");
        CreateCube_PolygonID_MinusZ_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(CreateCube_NativeFunction, "PolygonID_MinusZ");
        
        
    }
    
    protected StaticMeshDescription(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/StaticMeshDescription.StaticMeshDescription:SetVertexInstanceUV
    static readonly IntPtr SetVertexInstanceUV_NativeFunction;
    static readonly int SetVertexInstanceUV_ParamsSize;
    static readonly int SetVertexInstanceUV_VertexInstanceID_Offset;
    static readonly int SetVertexInstanceUV_UV_Offset;
    static readonly int SetVertexInstanceUV_UVIndex_Offset;
    
    public void SetVertexInstanceUV(UnrealSharp.MeshDescription.VertexInstanceID vertexInstanceID, System.DoubleNumerics.Vector2 uV, int uVIndex = 0)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetVertexInstanceUV_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.MeshDescription.VertexInstanceID>.ToNative(IntPtr.Add(ParamsBuffer, SetVertexInstanceUV_VertexInstanceID_Offset), 0, null, vertexInstanceID);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(ParamsBuffer, SetVertexInstanceUV_UV_Offset), 0, null, uV);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, SetVertexInstanceUV_UVIndex_Offset), 0, null, uVIndex);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetVertexInstanceUV_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/StaticMeshDescription.StaticMeshDescription:SetPolygonGroupMaterialSlotName
    static readonly IntPtr SetPolygonGroupMaterialSlotName_NativeFunction;
    static readonly int SetPolygonGroupMaterialSlotName_ParamsSize;
    static readonly int SetPolygonGroupMaterialSlotName_PolygonGroupID_Offset;
    static readonly int SetPolygonGroupMaterialSlotName_SlotName_Offset;
    
    public void SetPolygonGroupMaterialSlotName(UnrealSharp.MeshDescription.PolygonGroupID polygonGroupID, Name slotName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetPolygonGroupMaterialSlotName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.MeshDescription.PolygonGroupID>.ToNative(IntPtr.Add(ParamsBuffer, SetPolygonGroupMaterialSlotName_PolygonGroupID_Offset), 0, null, polygonGroupID);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(ParamsBuffer, SetPolygonGroupMaterialSlotName_SlotName_Offset), 0, null, slotName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetPolygonGroupMaterialSlotName_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    // Function /Script/StaticMeshDescription.StaticMeshDescription:GetVertexInstanceUV
    static readonly IntPtr GetVertexInstanceUV_NativeFunction;
    static readonly int GetVertexInstanceUV_ParamsSize;
    static readonly int GetVertexInstanceUV_VertexInstanceID_Offset;
    static readonly int GetVertexInstanceUV_UVIndex_Offset;
    static readonly int GetVertexInstanceUV_ReturnValue_Offset;
    
    public System.DoubleNumerics.Vector2 GetVertexInstanceUV(UnrealSharp.MeshDescription.VertexInstanceID vertexInstanceID, int uVIndex = 0)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetVertexInstanceUV_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<UnrealSharp.MeshDescription.VertexInstanceID>.ToNative(IntPtr.Add(ParamsBuffer, GetVertexInstanceUV_VertexInstanceID_Offset), 0, null, vertexInstanceID);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetVertexInstanceUV_UVIndex_Offset), 0, null, uVIndex);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetVertexInstanceUV_NativeFunction, ParamsBuffer);
            
            System.DoubleNumerics.Vector2 returnValue;
            returnValue = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(ParamsBuffer, GetVertexInstanceUV_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/StaticMeshDescription.StaticMeshDescription:CreateCube
    static readonly IntPtr CreateCube_NativeFunction;
    static readonly int CreateCube_ParamsSize;
    static readonly int CreateCube_Center_Offset;
    static readonly int CreateCube_HalfExtents_Offset;
    static readonly int CreateCube_PolygonGroup_Offset;
    static readonly int CreateCube_PolygonID_PlusX_Offset;
    static readonly int CreateCube_PolygonID_MinusX_Offset;
    static readonly int CreateCube_PolygonID_PlusY_Offset;
    static readonly int CreateCube_PolygonID_MinusY_Offset;
    static readonly int CreateCube_PolygonID_PlusZ_Offset;
    static readonly int CreateCube_PolygonID_MinusZ_Offset;
    
    public void CreateCube(System.DoubleNumerics.Vector3 center, System.DoubleNumerics.Vector3 halfExtents, UnrealSharp.MeshDescription.PolygonGroupID polygonGroup, out UnrealSharp.MeshDescription.PolygonID polygonID_PlusX, out UnrealSharp.MeshDescription.PolygonID polygonID_MinusX, out UnrealSharp.MeshDescription.PolygonID polygonID_PlusY, out UnrealSharp.MeshDescription.PolygonID polygonID_MinusY, out UnrealSharp.MeshDescription.PolygonID polygonID_PlusZ, out UnrealSharp.MeshDescription.PolygonID polygonID_MinusZ)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[CreateCube_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, CreateCube_Center_Offset), 0, null, center);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(ParamsBuffer, CreateCube_HalfExtents_Offset), 0, null, halfExtents);
            BlittableMarshaller<UnrealSharp.MeshDescription.PolygonGroupID>.ToNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonGroup_Offset), 0, null, polygonGroup);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, CreateCube_NativeFunction, ParamsBuffer);
            
            polygonID_PlusX = BlittableMarshaller<UnrealSharp.MeshDescription.PolygonID>.FromNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonID_PlusX_Offset), 0, null);
            polygonID_MinusX = BlittableMarshaller<UnrealSharp.MeshDescription.PolygonID>.FromNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonID_MinusX_Offset), 0, null);
            polygonID_PlusY = BlittableMarshaller<UnrealSharp.MeshDescription.PolygonID>.FromNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonID_PlusY_Offset), 0, null);
            polygonID_MinusY = BlittableMarshaller<UnrealSharp.MeshDescription.PolygonID>.FromNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonID_MinusY_Offset), 0, null);
            polygonID_PlusZ = BlittableMarshaller<UnrealSharp.MeshDescription.PolygonID>.FromNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonID_PlusZ_Offset), 0, null);
            polygonID_MinusZ = BlittableMarshaller<UnrealSharp.MeshDescription.PolygonID>.FromNative(IntPtr.Add(ParamsBuffer, CreateCube_PolygonID_MinusZ_Offset), 0, null);
            
        }
    }
    
    
}