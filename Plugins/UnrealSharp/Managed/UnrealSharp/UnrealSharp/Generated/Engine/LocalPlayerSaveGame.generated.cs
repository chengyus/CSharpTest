// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
abstract public partial class LocalPlayerSaveGame : UnrealSharp.Engine.SaveGame
{
    
    static readonly IntPtr NativeClassPtr;
    static LocalPlayerSaveGame()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("LocalPlayerSaveGame");
        
        
        WasSaveRequested_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "WasSaveRequested");
        WasSaveRequested_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(WasSaveRequested_NativeFunction);
        WasSaveRequested_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(WasSaveRequested_NativeFunction, "ReturnValue");
        WasLoaded_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "WasLoaded");
        WasLoaded_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(WasLoaded_NativeFunction);
        WasLoaded_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(WasLoaded_NativeFunction, "ReturnValue");
        WasLastSaveSuccessful_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "WasLastSaveSuccessful");
        WasLastSaveSuccessful_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(WasLastSaveSuccessful_NativeFunction);
        WasLastSaveSuccessful_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(WasLastSaveSuccessful_NativeFunction, "ReturnValue");
        SaveGameToSlotForLocalPlayer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SaveGameToSlotForLocalPlayer");
        SaveGameToSlotForLocalPlayer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SaveGameToSlotForLocalPlayer_NativeFunction);
        SaveGameToSlotForLocalPlayer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SaveGameToSlotForLocalPlayer_NativeFunction, "ReturnValue");
        ResetToDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ResetToDefault");
        LoadOrCreateSaveGameForLocalPlayer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "LoadOrCreateSaveGameForLocalPlayer");
        LoadOrCreateSaveGameForLocalPlayer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(LoadOrCreateSaveGameForLocalPlayer_NativeFunction);
        LoadOrCreateSaveGameForLocalPlayer_SaveGameClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadOrCreateSaveGameForLocalPlayer_NativeFunction, "SaveGameClass");
        LoadOrCreateSaveGameForLocalPlayer_LocalPlayerController_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadOrCreateSaveGameForLocalPlayer_NativeFunction, "LocalPlayerController");
        LoadOrCreateSaveGameForLocalPlayer_SlotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadOrCreateSaveGameForLocalPlayer_NativeFunction, "SlotName");
        LoadOrCreateSaveGameForLocalPlayer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(LoadOrCreateSaveGameForLocalPlayer_NativeFunction, "ReturnValue");
        IsSaveInProgress_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsSaveInProgress");
        IsSaveInProgress_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsSaveInProgress_NativeFunction);
        IsSaveInProgress_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsSaveInProgress_NativeFunction, "ReturnValue");
        GetSaveSlotName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSaveSlotName");
        GetSaveSlotName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSaveSlotName_NativeFunction);
        GetSaveSlotName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSaveSlotName_NativeFunction, "ReturnValue");
        GetSavedDataVersion_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetSavedDataVersion");
        GetSavedDataVersion_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetSavedDataVersion_NativeFunction);
        GetSavedDataVersion_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetSavedDataVersion_NativeFunction, "ReturnValue");
        GetPlatformUserIndex_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlatformUserIndex");
        GetPlatformUserIndex_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlatformUserIndex_NativeFunction);
        GetPlatformUserIndex_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlatformUserIndex_NativeFunction, "ReturnValue");
        GetPlatformUserId_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlatformUserId");
        GetPlatformUserId_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlatformUserId_NativeFunction);
        GetPlatformUserId_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlatformUserId_NativeFunction, "ReturnValue");
        GetLocalPlayerController_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLocalPlayerController");
        GetLocalPlayerController_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLocalPlayerController_NativeFunction);
        GetLocalPlayerController_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLocalPlayerController_NativeFunction, "ReturnValue");
        GetLatestDataVersion_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLatestDataVersion");
        GetLatestDataVersion_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLatestDataVersion_NativeFunction);
        GetLatestDataVersion_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLatestDataVersion_NativeFunction, "ReturnValue");
        GetInvalidDataVersion_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetInvalidDataVersion");
        GetInvalidDataVersion_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetInvalidDataVersion_NativeFunction);
        GetInvalidDataVersion_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetInvalidDataVersion_NativeFunction, "ReturnValue");
        AsyncSaveGameToSlotForLocalPlayer_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AsyncSaveGameToSlotForLocalPlayer");
        AsyncSaveGameToSlotForLocalPlayer_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AsyncSaveGameToSlotForLocalPlayer_NativeFunction);
        AsyncSaveGameToSlotForLocalPlayer_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AsyncSaveGameToSlotForLocalPlayer_NativeFunction, "ReturnValue");
        
        IntPtr OnPostSave_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "OnPostSave");
        OnPostSave_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(OnPostSave_NativeFunction);
        OnPostSave_bSuccess_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(OnPostSave_NativeFunction, "bSuccess");
        
        
    }
    
    protected LocalPlayerSaveGame(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/Engine.LocalPlayerSaveGame:WasSaveRequested
    static readonly IntPtr WasSaveRequested_NativeFunction;
    static readonly int WasSaveRequested_ParamsSize;
    static readonly int WasSaveRequested_ReturnValue_Offset;
    
    public bool WasSaveRequested()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[WasSaveRequested_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, WasSaveRequested_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, WasSaveRequested_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:WasLoaded
    static readonly IntPtr WasLoaded_NativeFunction;
    static readonly int WasLoaded_ParamsSize;
    static readonly int WasLoaded_ReturnValue_Offset;
    
    public bool WasLoaded()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[WasLoaded_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, WasLoaded_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, WasLoaded_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:WasLastSaveSuccessful
    static readonly IntPtr WasLastSaveSuccessful_NativeFunction;
    static readonly int WasLastSaveSuccessful_ParamsSize;
    static readonly int WasLastSaveSuccessful_ReturnValue_Offset;
    
    public bool WasLastSaveSuccessful()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[WasLastSaveSuccessful_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, WasLastSaveSuccessful_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, WasLastSaveSuccessful_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:SaveGameToSlotForLocalPlayer
    static readonly IntPtr SaveGameToSlotForLocalPlayer_NativeFunction;
    static readonly int SaveGameToSlotForLocalPlayer_ParamsSize;
    static readonly int SaveGameToSlotForLocalPlayer_ReturnValue_Offset;
    
    public bool SaveGameToSlotForLocalPlayer()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SaveGameToSlotForLocalPlayer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SaveGameToSlotForLocalPlayer_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, SaveGameToSlotForLocalPlayer_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:ResetToDefault
    static readonly IntPtr ResetToDefault_NativeFunction;
    
    public void ResetToDefault()
    {
        unsafe
        {
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ResetToDefault_NativeFunction, IntPtr.Zero);
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:LoadOrCreateSaveGameForLocalPlayer
    static readonly IntPtr LoadOrCreateSaveGameForLocalPlayer_NativeFunction;
    static readonly int LoadOrCreateSaveGameForLocalPlayer_ParamsSize;
    static readonly int LoadOrCreateSaveGameForLocalPlayer_SaveGameClass_Offset;
    static readonly int LoadOrCreateSaveGameForLocalPlayer_LocalPlayerController_Offset;
    static readonly int LoadOrCreateSaveGameForLocalPlayer_SlotName_Offset;
    static readonly int LoadOrCreateSaveGameForLocalPlayer_ReturnValue_Offset;
    
    public static UnrealSharp.Engine.LocalPlayerSaveGame LoadOrCreateSaveGameForLocalPlayer(SubclassOf<UnrealSharp.Engine.LocalPlayerSaveGame> saveGameClass, UnrealSharp.Engine.PlayerController localPlayerController, string slotName)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[LoadOrCreateSaveGameForLocalPlayer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            SubclassOfMarshaller<UnrealSharp.Engine.LocalPlayerSaveGame>.ToNative(IntPtr.Add(ParamsBuffer, LoadOrCreateSaveGameForLocalPlayer_SaveGameClass_Offset), 0, null, saveGameClass);
            ObjectMarshaller<UnrealSharp.Engine.PlayerController>.ToNative(IntPtr.Add(ParamsBuffer, LoadOrCreateSaveGameForLocalPlayer_LocalPlayerController_Offset), 0, null, localPlayerController);
            IntPtr SlotName_NativePtr = IntPtr.Add(ParamsBuffer,LoadOrCreateSaveGameForLocalPlayer_SlotName_Offset);
            StringMarshaller.ToNative(SlotName_NativePtr,0,null,slotName);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, LoadOrCreateSaveGameForLocalPlayer_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.LocalPlayerSaveGame returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.LocalPlayerSaveGame>.FromNative(IntPtr.Add(ParamsBuffer, LoadOrCreateSaveGameForLocalPlayer_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(SlotName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:IsSaveInProgress
    static readonly IntPtr IsSaveInProgress_NativeFunction;
    static readonly int IsSaveInProgress_ParamsSize;
    static readonly int IsSaveInProgress_ReturnValue_Offset;
    
    public bool IsSaveInProgress()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsSaveInProgress_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, IsSaveInProgress_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsSaveInProgress_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetSaveSlotName
    static readonly IntPtr GetSaveSlotName_NativeFunction;
    static readonly int GetSaveSlotName_ParamsSize;
    static readonly int GetSaveSlotName_ReturnValue_Offset;
    
    public string GetSaveSlotName()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSaveSlotName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSaveSlotName_NativeFunction, ParamsBuffer);
            
            string returnValue;
            IntPtr ReturnValue_NativePtr = IntPtr.Add(ParamsBuffer,GetSaveSlotName_ReturnValue_Offset);
            returnValue = StringMarshaller.FromNative(ReturnValue_NativePtr,0,null);
            StringMarshaller.DestructInstance(ReturnValue_NativePtr, 0);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetSavedDataVersion
    static readonly IntPtr GetSavedDataVersion_NativeFunction;
    static readonly int GetSavedDataVersion_ParamsSize;
    static readonly int GetSavedDataVersion_ReturnValue_Offset;
    
    public int GetSavedDataVersion()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetSavedDataVersion_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetSavedDataVersion_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetSavedDataVersion_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetPlatformUserIndex
    static readonly IntPtr GetPlatformUserIndex_NativeFunction;
    static readonly int GetPlatformUserIndex_ParamsSize;
    static readonly int GetPlatformUserIndex_ReturnValue_Offset;
    
    public int GetPlatformUserIndex()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlatformUserIndex_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlatformUserIndex_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetPlatformUserIndex_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetPlatformUserId
    static readonly IntPtr GetPlatformUserId_NativeFunction;
    static readonly int GetPlatformUserId_ParamsSize;
    static readonly int GetPlatformUserId_ReturnValue_Offset;
    
    public UnrealSharp.CoreUObject.PlatformUserId GetPlatformUserId()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlatformUserId_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlatformUserId_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CoreUObject.PlatformUserId returnValue;
            returnValue = UnrealSharp.CoreUObject.PlatformUserIdMarshaler.FromNative(IntPtr.Add(ParamsBuffer, GetPlatformUserId_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetLocalPlayerController
    static readonly IntPtr GetLocalPlayerController_NativeFunction;
    static readonly int GetLocalPlayerController_ParamsSize;
    static readonly int GetLocalPlayerController_ReturnValue_Offset;
    
    public UnrealSharp.Engine.PlayerController GetLocalPlayerController()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLocalPlayerController_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLocalPlayerController_NativeFunction, ParamsBuffer);
            
            UnrealSharp.Engine.PlayerController returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.Engine.PlayerController>.FromNative(IntPtr.Add(ParamsBuffer, GetLocalPlayerController_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetLatestDataVersion
    static readonly IntPtr GetLatestDataVersion_NativeFunction;
    static readonly int GetLatestDataVersion_ParamsSize;
    static readonly int GetLatestDataVersion_ReturnValue_Offset;
    
    public int GetLatestDataVersion()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLatestDataVersion_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLatestDataVersion_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetLatestDataVersion_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:GetInvalidDataVersion
    static readonly IntPtr GetInvalidDataVersion_NativeFunction;
    static readonly int GetInvalidDataVersion_ParamsSize;
    static readonly int GetInvalidDataVersion_ReturnValue_Offset;
    
    public int GetInvalidDataVersion()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetInvalidDataVersion_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetInvalidDataVersion_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetInvalidDataVersion_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:AsyncSaveGameToSlotForLocalPlayer
    static readonly IntPtr AsyncSaveGameToSlotForLocalPlayer_NativeFunction;
    static readonly int AsyncSaveGameToSlotForLocalPlayer_ParamsSize;
    static readonly int AsyncSaveGameToSlotForLocalPlayer_ReturnValue_Offset;
    
    public bool AsyncSaveGameToSlotForLocalPlayer()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AsyncSaveGameToSlotForLocalPlayer_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AsyncSaveGameToSlotForLocalPlayer_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AsyncSaveGameToSlotForLocalPlayer_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:OnResetToDefault
    IntPtr OnResetToDefault_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void OnResetToDefault()
    {
        unsafe
        {
            if (OnResetToDefault_NativeFunction == IntPtr.Zero)
            {
                OnResetToDefault_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnResetToDefault");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnResetToDefault_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnResetToDefault_Implementation()
    {
    }
    void Invoke_OnResetToDefault(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnResetToDefault_Implementation();
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:OnPreSave
    IntPtr OnPreSave_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void OnPreSave()
    {
        unsafe
        {
            if (OnPreSave_NativeFunction == IntPtr.Zero)
            {
                OnPreSave_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPreSave");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPreSave_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPreSave_Implementation()
    {
    }
    void Invoke_OnPreSave(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnPreSave_Implementation();
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:OnPostSave
    IntPtr OnPostSave_NativeFunction;
    static readonly int OnPostSave_ParamsSize;
    static readonly int OnPostSave_bSuccess_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void OnPostSave(bool bSuccess)
    {
        unsafe
        {
            if (OnPostSave_NativeFunction == IntPtr.Zero)
            {
                OnPostSave_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPostSave");
            }
            byte* ParamsBufferAllocation = stackalloc byte[OnPostSave_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BoolMarshaller.ToNative(IntPtr.Add(ParamsBuffer, OnPostSave_bSuccess_Offset), 0, null, bSuccess);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPostSave_NativeFunction, ParamsBuffer);
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPostSave_Implementation(bool bSuccess)
    {
    }
    void Invoke_OnPostSave(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            bool bSuccess = BoolMarshaller.FromNative(IntPtr.Add(buffer, OnPostSave_bSuccess_Offset), 0, null);
            OnPostSave_Implementation(bSuccess);
        }
    }
    
    // Function /Script/Engine.LocalPlayerSaveGame:OnPostLoad
    IntPtr OnPostLoad_NativeFunction;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void OnPostLoad()
    {
        unsafe
        {
            if (OnPostLoad_NativeFunction == IntPtr.Zero)
            {
                OnPostLoad_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "OnPostLoad");
            }
            UObjectExporter.CallInvokeNativeFunction(NativeObject, OnPostLoad_NativeFunction, IntPtr.Zero);
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void OnPostLoad_Implementation()
    {
    }
    void Invoke_OnPostLoad(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            OnPostLoad_Implementation();
        }
    }
    
    
}