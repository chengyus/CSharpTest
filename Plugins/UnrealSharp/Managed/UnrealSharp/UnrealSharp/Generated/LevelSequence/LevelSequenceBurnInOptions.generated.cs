// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequence;

[UClass]
public partial class LevelSequenceBurnInOptions : UnrealSharp.CoreUObject.Object
{
    
    static LevelSequenceBurnInOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("LevelSequenceBurnInOptions");
        
        bUseBurnIn_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseBurnIn");
        BurnInClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BurnInClass");
        Settings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Settings");
        
        SetBurnIn_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "SetBurnIn");
        SetBurnIn_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(SetBurnIn_NativeFunction);
        SetBurnIn_InBurnInClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(SetBurnIn_NativeFunction, "InBurnInClass");
        
        
    }
    
    protected LevelSequenceBurnInOptions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/LevelSequence.LevelSequenceBurnInOptions:bUseBurnIn
    static readonly int bUseBurnIn_Offset;
    
    public bool bUseBurnIn
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseBurnIn_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseBurnIn_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/LevelSequence.LevelSequenceBurnInOptions:BurnInClass
    static readonly int BurnInClass_Offset;
    
    public UnrealSharp.CoreUObject.SoftClassPath BurnInClass
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.CoreUObject.SoftClassPathMarshaler.FromNative(IntPtr.Add(NativeObject, BurnInClass_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.CoreUObject.SoftClassPathMarshaler.ToNative(IntPtr.Add(NativeObject, BurnInClass_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/LevelSequence.LevelSequenceBurnInOptions:Settings
    static readonly int Settings_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequenceBurnInInitSettings Settings
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequenceBurnInInitSettings>.FromNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequenceBurnInInitSettings>.ToNative(IntPtr.Add(NativeObject, Settings_Offset), 0, this, value);
        }
    }
    
    // Function /Script/LevelSequence.LevelSequenceBurnInOptions:SetBurnIn
    static readonly IntPtr SetBurnIn_NativeFunction;
    static readonly int SetBurnIn_ParamsSize;
    static readonly int SetBurnIn_InBurnInClass_Offset;
    
    public void SetBurnIn(UnrealSharp.CoreUObject.SoftClassPath inBurnInClass)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[SetBurnIn_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            UnrealSharp.CoreUObject.SoftClassPathMarshaler.ToNative(IntPtr.Add(ParamsBuffer, SetBurnIn_InBurnInClass_Offset), 0, null, inBurnInClass);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, SetBurnIn_NativeFunction, ParamsBuffer);
            
        }
    }
    
    
}