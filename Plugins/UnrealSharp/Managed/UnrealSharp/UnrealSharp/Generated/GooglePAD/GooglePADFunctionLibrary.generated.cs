// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GooglePAD;

[UClass]
public partial class GooglePADFunctionLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static GooglePADFunctionLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("GooglePADFunctionLibrary");
        
        
        ShowCellularDataConfirmation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ShowCellularDataConfirmation");
        ShowCellularDataConfirmation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ShowCellularDataConfirmation_NativeFunction);
        ShowCellularDataConfirmation_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ShowCellularDataConfirmation_NativeFunction, "ReturnValue");
        RequestRemoval_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RequestRemoval");
        RequestRemoval_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RequestRemoval_NativeFunction);
        RequestRemoval_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RequestRemoval_NativeFunction, "Name");
        RequestRemoval_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RequestRemoval_NativeFunction, "ReturnValue");
        ReleaseDownloadState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReleaseDownloadState");
        ReleaseDownloadState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReleaseDownloadState_NativeFunction);
        ReleaseDownloadState_State_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReleaseDownloadState_NativeFunction, "State");
        ReleaseAssetPackLocation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ReleaseAssetPackLocation");
        ReleaseAssetPackLocation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ReleaseAssetPackLocation_NativeFunction);
        ReleaseAssetPackLocation_Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ReleaseAssetPackLocation_NativeFunction, "Location");
        GetTotalBytesToDownload_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetTotalBytesToDownload");
        GetTotalBytesToDownload_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetTotalBytesToDownload_NativeFunction);
        GetTotalBytesToDownload_State_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTotalBytesToDownload_NativeFunction, "State");
        GetTotalBytesToDownload_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetTotalBytesToDownload_NativeFunction, "ReturnValue");
        GetStorageMethod_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetStorageMethod");
        GetStorageMethod_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetStorageMethod_NativeFunction);
        GetStorageMethod_Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStorageMethod_NativeFunction, "Location");
        GetStorageMethod_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetStorageMethod_NativeFunction, "ReturnValue");
        GetShowCellularDataConfirmationStatus_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetShowCellularDataConfirmationStatus");
        GetShowCellularDataConfirmationStatus_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetShowCellularDataConfirmationStatus_NativeFunction);
        GetShowCellularDataConfirmationStatus_Status_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetShowCellularDataConfirmationStatus_NativeFunction, "Status");
        GetShowCellularDataConfirmationStatus_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetShowCellularDataConfirmationStatus_NativeFunction, "ReturnValue");
        GetDownloadStatus_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDownloadStatus");
        GetDownloadStatus_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDownloadStatus_NativeFunction);
        GetDownloadStatus_State_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDownloadStatus_NativeFunction, "State");
        GetDownloadStatus_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDownloadStatus_NativeFunction, "ReturnValue");
        GetDownloadState_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetDownloadState");
        GetDownloadState_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetDownloadState_NativeFunction);
        GetDownloadState_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDownloadState_NativeFunction, "Name");
        GetDownloadState_State_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDownloadState_NativeFunction, "State");
        GetDownloadState_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetDownloadState_NativeFunction, "ReturnValue");
        GetBytesDownloaded_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetBytesDownloaded");
        GetBytesDownloaded_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetBytesDownloaded_NativeFunction);
        GetBytesDownloaded_State_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBytesDownloaded_NativeFunction, "State");
        GetBytesDownloaded_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetBytesDownloaded_NativeFunction, "ReturnValue");
        GetAssetsPath_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAssetsPath");
        GetAssetsPath_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAssetsPath_NativeFunction);
        GetAssetsPath_Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAssetsPath_NativeFunction, "Location");
        GetAssetsPath_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAssetsPath_NativeFunction, "ReturnValue");
        GetAssetPackLocation_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetAssetPackLocation");
        GetAssetPackLocation_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetAssetPackLocation_NativeFunction);
        GetAssetPackLocation_Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAssetPackLocation_NativeFunction, "Name");
        GetAssetPackLocation_Location_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAssetPackLocation_NativeFunction, "Location");
        GetAssetPackLocation_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetAssetPackLocation_NativeFunction, "ReturnValue");
        
        
    }
    
    protected GooglePADFunctionLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:ShowCellularDataConfirmation
    static readonly IntPtr ShowCellularDataConfirmation_NativeFunction;
    static readonly int ShowCellularDataConfirmation_ParamsSize;
    static readonly int ShowCellularDataConfirmation_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADErrorCode ShowCellularDataConfirmation()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ShowCellularDataConfirmation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ShowCellularDataConfirmation_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GooglePAD.EGooglePADErrorCode returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADErrorCode>.FromNative(IntPtr.Add(ParamsBuffer, ShowCellularDataConfirmation_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:RequestRemoval
    static readonly IntPtr RequestRemoval_NativeFunction;
    static readonly int RequestRemoval_ParamsSize;
    static readonly int RequestRemoval_Name_Offset;
    static readonly int RequestRemoval_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADErrorCode RequestRemoval(string name)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RequestRemoval_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Name_NativePtr = IntPtr.Add(ParamsBuffer,RequestRemoval_Name_Offset);
            StringMarshaller.ToNative(Name_NativePtr,0,null,name);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, RequestRemoval_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GooglePAD.EGooglePADErrorCode returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADErrorCode>.FromNative(IntPtr.Add(ParamsBuffer, RequestRemoval_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Name_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:ReleaseDownloadState
    static readonly IntPtr ReleaseDownloadState_NativeFunction;
    static readonly int ReleaseDownloadState_ParamsSize;
    static readonly int ReleaseDownloadState_State_Offset;
    
    public static void ReleaseDownloadState(int state)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ReleaseDownloadState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, ReleaseDownloadState_State_Offset), 0, null, state);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ReleaseDownloadState_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:ReleaseAssetPackLocation
    static readonly IntPtr ReleaseAssetPackLocation_NativeFunction;
    static readonly int ReleaseAssetPackLocation_ParamsSize;
    static readonly int ReleaseAssetPackLocation_Location_Offset;
    
    public static void ReleaseAssetPackLocation(int location)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ReleaseAssetPackLocation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, ReleaseAssetPackLocation_Location_Offset), 0, null, location);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ReleaseAssetPackLocation_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetTotalBytesToDownload
    static readonly IntPtr GetTotalBytesToDownload_NativeFunction;
    static readonly int GetTotalBytesToDownload_ParamsSize;
    static readonly int GetTotalBytesToDownload_State_Offset;
    static readonly int GetTotalBytesToDownload_ReturnValue_Offset;
    
    public static int GetTotalBytesToDownload(int state)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetTotalBytesToDownload_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetTotalBytesToDownload_State_Offset), 0, null, state);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetTotalBytesToDownload_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetTotalBytesToDownload_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetStorageMethod
    static readonly IntPtr GetStorageMethod_NativeFunction;
    static readonly int GetStorageMethod_ParamsSize;
    static readonly int GetStorageMethod_Location_Offset;
    static readonly int GetStorageMethod_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADStorageMethod GetStorageMethod(int location)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetStorageMethod_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetStorageMethod_Location_Offset), 0, null, location);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetStorageMethod_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GooglePAD.EGooglePADStorageMethod returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADStorageMethod>.FromNative(IntPtr.Add(ParamsBuffer, GetStorageMethod_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetShowCellularDataConfirmationStatus
    static readonly IntPtr GetShowCellularDataConfirmationStatus_NativeFunction;
    static readonly int GetShowCellularDataConfirmationStatus_ParamsSize;
    static readonly int GetShowCellularDataConfirmationStatus_Status_Offset;
    static readonly int GetShowCellularDataConfirmationStatus_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADErrorCode GetShowCellularDataConfirmationStatus(out UnrealSharp.GooglePAD.EGooglePADCellularDataConfirmStatus status)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetShowCellularDataConfirmationStatus_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetShowCellularDataConfirmationStatus_NativeFunction, ParamsBuffer);
            
            status = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADCellularDataConfirmStatus>.FromNative(IntPtr.Add(ParamsBuffer, GetShowCellularDataConfirmationStatus_Status_Offset), 0, null);
            UnrealSharp.GooglePAD.EGooglePADErrorCode returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADErrorCode>.FromNative(IntPtr.Add(ParamsBuffer, GetShowCellularDataConfirmationStatus_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadStatus
    static readonly IntPtr GetDownloadStatus_NativeFunction;
    static readonly int GetDownloadStatus_ParamsSize;
    static readonly int GetDownloadStatus_State_Offset;
    static readonly int GetDownloadStatus_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADDownloadStatus GetDownloadStatus(int state)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDownloadStatus_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetDownloadStatus_State_Offset), 0, null, state);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetDownloadStatus_NativeFunction, ParamsBuffer);
            
            UnrealSharp.GooglePAD.EGooglePADDownloadStatus returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADDownloadStatus>.FromNative(IntPtr.Add(ParamsBuffer, GetDownloadStatus_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadState
    static readonly IntPtr GetDownloadState_NativeFunction;
    static readonly int GetDownloadState_ParamsSize;
    static readonly int GetDownloadState_Name_Offset;
    static readonly int GetDownloadState_State_Offset;
    static readonly int GetDownloadState_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADErrorCode GetDownloadState(string name, out int state)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetDownloadState_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Name_NativePtr = IntPtr.Add(ParamsBuffer,GetDownloadState_Name_Offset);
            StringMarshaller.ToNative(Name_NativePtr,0,null,name);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetDownloadState_NativeFunction, ParamsBuffer);
            
            state = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetDownloadState_State_Offset), 0, null);
            UnrealSharp.GooglePAD.EGooglePADErrorCode returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADErrorCode>.FromNative(IntPtr.Add(ParamsBuffer, GetDownloadState_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Name_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetBytesDownloaded
    static readonly IntPtr GetBytesDownloaded_NativeFunction;
    static readonly int GetBytesDownloaded_ParamsSize;
    static readonly int GetBytesDownloaded_State_Offset;
    static readonly int GetBytesDownloaded_ReturnValue_Offset;
    
    public static int GetBytesDownloaded(int state)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetBytesDownloaded_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetBytesDownloaded_State_Offset), 0, null, state);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetBytesDownloaded_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetBytesDownloaded_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetAssetsPath
    static readonly IntPtr GetAssetsPath_NativeFunction;
    static readonly int GetAssetsPath_ParamsSize;
    static readonly int GetAssetsPath_Location_Offset;
    static readonly int GetAssetsPath_ReturnValue_Offset;
    
    public static string GetAssetsPath(int location)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAssetsPath_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, GetAssetsPath_Location_Offset), 0, null, location);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetAssetsPath_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetAssetsPath_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/GooglePAD.GooglePADFunctionLibrary:GetAssetPackLocation
    static readonly IntPtr GetAssetPackLocation_NativeFunction;
    static readonly int GetAssetPackLocation_ParamsSize;
    static readonly int GetAssetPackLocation_Name_Offset;
    static readonly int GetAssetPackLocation_Location_Offset;
    static readonly int GetAssetPackLocation_ReturnValue_Offset;
    
    public static UnrealSharp.GooglePAD.EGooglePADErrorCode GetAssetPackLocation(string name, out int location)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetAssetPackLocation_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Name_NativePtr = IntPtr.Add(ParamsBuffer,GetAssetPackLocation_Name_Offset);
            StringMarshaller.ToNative(Name_NativePtr,0,null,name);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetAssetPackLocation_NativeFunction, ParamsBuffer);
            
            location = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetAssetPackLocation_Location_Offset), 0, null);
            UnrealSharp.GooglePAD.EGooglePADErrorCode returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.GooglePAD.EGooglePADErrorCode>.FromNative(IntPtr.Add(ParamsBuffer, GetAssetPackLocation_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Name_NativePtr, 0);
            return returnValue;
        }
    }
    
    
}