// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class GameStateBase : UnrealSharp.Engine.Info
{
    
    static GameStateBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("GameStateBase");
        
        GameModeClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "GameModeClass");
        AuthorityGameMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AuthorityGameMode");
        SpectatorClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpectatorClass");
        PlayerArray_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PlayerArray");
        PlayerArray_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "PlayerArray");
        
        HasMatchStarted_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "HasMatchStarted");
        HasMatchStarted_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(HasMatchStarted_NativeFunction);
        HasMatchStarted_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(HasMatchStarted_NativeFunction, "ReturnValue");
        HasMatchEnded_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "HasMatchEnded");
        HasMatchEnded_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(HasMatchEnded_NativeFunction);
        HasMatchEnded_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(HasMatchEnded_NativeFunction, "ReturnValue");
        HasBegunPlay_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "HasBegunPlay");
        HasBegunPlay_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(HasBegunPlay_NativeFunction);
        HasBegunPlay_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(HasBegunPlay_NativeFunction, "ReturnValue");
        GetServerWorldTimeSeconds_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetServerWorldTimeSeconds");
        GetServerWorldTimeSeconds_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetServerWorldTimeSeconds_NativeFunction);
        GetServerWorldTimeSeconds_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetServerWorldTimeSeconds_NativeFunction, "ReturnValue");
        GetPlayerStartTime_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlayerStartTime");
        GetPlayerStartTime_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlayerStartTime_NativeFunction);
        GetPlayerStartTime_Controller_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlayerStartTime_NativeFunction, "Controller");
        GetPlayerStartTime_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlayerStartTime_NativeFunction, "ReturnValue");
        GetPlayerRespawnDelay_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPlayerRespawnDelay");
        GetPlayerRespawnDelay_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPlayerRespawnDelay_NativeFunction);
        GetPlayerRespawnDelay_Controller_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlayerRespawnDelay_NativeFunction, "Controller");
        GetPlayerRespawnDelay_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPlayerRespawnDelay_NativeFunction, "ReturnValue");
        
        
    }
    
    protected GameStateBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ClassProperty /Script/Engine.GameStateBase:GameModeClass
    static readonly int GameModeClass_Offset;
    
    public SubclassOf<UnrealSharp.Engine.GameModeBase> GameModeClass
    {
        get
        {
            CheckObjectForValidity();
            return SubclassOfMarshaller<UnrealSharp.Engine.GameModeBase>.FromNative(IntPtr.Add(NativeObject, GameModeClass_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Engine.GameStateBase:AuthorityGameMode
    static readonly int AuthorityGameMode_Offset;
    
    public UnrealSharp.Engine.GameModeBase AuthorityGameMode
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.GameModeBase>.FromNative(IntPtr.Add(NativeObject, AuthorityGameMode_Offset), 0, this);
        }
    }
    
    // ClassProperty /Script/Engine.GameStateBase:SpectatorClass
    static readonly int SpectatorClass_Offset;
    
    public SubclassOf<UnrealSharp.Engine.SpectatorPawn> SpectatorClass
    {
        get
        {
            CheckObjectForValidity();
            return SubclassOfMarshaller<UnrealSharp.Engine.SpectatorPawn>.FromNative(IntPtr.Add(NativeObject, SpectatorClass_Offset), 0, this);
        }
    }
    
    // ArrayProperty /Script/Engine.GameStateBase:PlayerArray
    static readonly int PlayerArray_Offset;
    static readonly IntPtr PlayerArray_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.PlayerState> PlayerArray_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Engine.PlayerState> PlayerArray
    {
        get
        {
            if(PlayerArray_Wrapper == null)
            {
                PlayerArray_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Engine.PlayerState>(1, PlayerArray_NativeProperty, ObjectMarshaller<UnrealSharp.Engine.PlayerState>.ToNative, ObjectMarshaller<UnrealSharp.Engine.PlayerState>.FromNative);
            }
            
            return PlayerArray_Wrapper.FromNative(IntPtr.Add(NativeObject,PlayerArray_Offset),0,this);
        }
    }
    
    // Function /Script/Engine.GameStateBase:HasMatchStarted
    static readonly IntPtr HasMatchStarted_NativeFunction;
    static readonly int HasMatchStarted_ParamsSize;
    static readonly int HasMatchStarted_ReturnValue_Offset;
    
    public bool HasMatchStarted()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[HasMatchStarted_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, HasMatchStarted_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, HasMatchStarted_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.GameStateBase:HasMatchEnded
    static readonly IntPtr HasMatchEnded_NativeFunction;
    static readonly int HasMatchEnded_ParamsSize;
    static readonly int HasMatchEnded_ReturnValue_Offset;
    
    public bool HasMatchEnded()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[HasMatchEnded_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, HasMatchEnded_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, HasMatchEnded_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.GameStateBase:HasBegunPlay
    static readonly IntPtr HasBegunPlay_NativeFunction;
    static readonly int HasBegunPlay_ParamsSize;
    static readonly int HasBegunPlay_ReturnValue_Offset;
    
    public bool HasBegunPlay()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[HasBegunPlay_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, HasBegunPlay_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, HasBegunPlay_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.GameStateBase:GetServerWorldTimeSeconds
    static readonly IntPtr GetServerWorldTimeSeconds_NativeFunction;
    static readonly int GetServerWorldTimeSeconds_ParamsSize;
    static readonly int GetServerWorldTimeSeconds_ReturnValue_Offset;
    
    public double GetServerWorldTimeSeconds()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetServerWorldTimeSeconds_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetServerWorldTimeSeconds_NativeFunction, ParamsBuffer);
            
            double returnValue;
            returnValue = BlittableMarshaller<double>.FromNative(IntPtr.Add(ParamsBuffer, GetServerWorldTimeSeconds_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.GameStateBase:GetPlayerStartTime
    static readonly IntPtr GetPlayerStartTime_NativeFunction;
    static readonly int GetPlayerStartTime_ParamsSize;
    static readonly int GetPlayerStartTime_Controller_Offset;
    static readonly int GetPlayerStartTime_ReturnValue_Offset;
    
    public float GetPlayerStartTime(UnrealSharp.Engine.Controller controller)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlayerStartTime_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Controller>.ToNative(IntPtr.Add(ParamsBuffer, GetPlayerStartTime_Controller_Offset), 0, null, controller);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlayerStartTime_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetPlayerStartTime_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/Engine.GameStateBase:GetPlayerRespawnDelay
    static readonly IntPtr GetPlayerRespawnDelay_NativeFunction;
    static readonly int GetPlayerRespawnDelay_ParamsSize;
    static readonly int GetPlayerRespawnDelay_Controller_Offset;
    static readonly int GetPlayerRespawnDelay_ReturnValue_Offset;
    
    public float GetPlayerRespawnDelay(UnrealSharp.Engine.Controller controller)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPlayerRespawnDelay_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.Engine.Controller>.ToNative(IntPtr.Add(ParamsBuffer, GetPlayerRespawnDelay_Controller_Offset), 0, null, controller);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPlayerRespawnDelay_NativeFunction, ParamsBuffer);
            
            float returnValue;
            returnValue = BlittableMarshaller<float>.FromNative(IntPtr.Add(ParamsBuffer, GetPlayerRespawnDelay_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}