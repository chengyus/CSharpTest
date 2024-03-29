// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieSceneTools;

[UClass]
public partial class AutomatedLevelSequenceCapture : UnrealSharp.MovieSceneCapture.MovieSceneCapture
{
    
    static AutomatedLevelSequenceCapture()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AutomatedLevelSequenceCapture");
        
        LevelSequenceAsset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LevelSequenceAsset");
        ShotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShotName");
        ShotName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "ShotName");
        bUseCustomStartFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCustomStartFrame");
        CustomStartFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomStartFrame");
        bUseCustomEndFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bUseCustomEndFrame");
        CustomEndFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CustomEndFrame");
        WarmUpFrameCount_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WarmUpFrameCount");
        DelayBeforeWarmUp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayBeforeWarmUp");
        DelayBeforeShotWarmUp_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayBeforeShotWarmUp");
        DelayEveryFrame_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DelayEveryFrame");
        BurnInOptions_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BurnInOptions");
        bWriteEditDecisionList_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWriteEditDecisionList");
        bWriteFinalCutProXML_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bWriteFinalCutProXML");
        
        
        
    }
    
    protected AutomatedLevelSequenceCapture(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:LevelSequenceAsset
    static readonly int LevelSequenceAsset_Offset;
    
    public UnrealSharp.CoreUObject.SoftObjectPath LevelSequenceAsset
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.CoreUObject.SoftObjectPathMarshaler.FromNative(IntPtr.Add(NativeObject, LevelSequenceAsset_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.CoreUObject.SoftObjectPathMarshaler.ToNative(IntPtr.Add(NativeObject, LevelSequenceAsset_Offset), 0, this, value);
        }
    }
    
    // StrProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:ShotName
    static readonly int ShotName_Offset;
    static readonly IntPtr ShotName_NativeProperty;
    
    public string ShotName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,ShotName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,ShotName_Offset),0,this,value);
        }
    }
    
    // BoolProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomStartFrame
    static readonly int bUseCustomStartFrame_Offset;
    
    public bool bUseCustomStartFrame
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseCustomStartFrame_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseCustomStartFrame_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomStartFrame
    static readonly int CustomStartFrame_Offset;
    
    public UnrealSharp.CoreUObject.FrameNumber CustomStartFrame
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(NativeObject, CustomStartFrame_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(NativeObject, CustomStartFrame_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:bUseCustomEndFrame
    static readonly int bUseCustomEndFrame_Offset;
    
    public bool bUseCustomEndFrame
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bUseCustomEndFrame_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bUseCustomEndFrame_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:CustomEndFrame
    static readonly int CustomEndFrame_Offset;
    
    public UnrealSharp.CoreUObject.FrameNumber CustomEndFrame
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.FromNative(IntPtr.Add(NativeObject, CustomEndFrame_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.CoreUObject.FrameNumber>.ToNative(IntPtr.Add(NativeObject, CustomEndFrame_Offset), 0, this, value);
        }
    }
    
    // IntProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:WarmUpFrameCount
    static readonly int WarmUpFrameCount_Offset;
    
    public int WarmUpFrameCount
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, WarmUpFrameCount_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<int>.ToNative(IntPtr.Add(NativeObject, WarmUpFrameCount_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeWarmUp
    static readonly int DelayBeforeWarmUp_Offset;
    
    public float DelayBeforeWarmUp
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DelayBeforeWarmUp_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DelayBeforeWarmUp_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayBeforeShotWarmUp
    static readonly int DelayBeforeShotWarmUp_Offset;
    
    public float DelayBeforeShotWarmUp
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DelayBeforeShotWarmUp_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DelayBeforeShotWarmUp_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:DelayEveryFrame
    static readonly int DelayEveryFrame_Offset;
    
    public float DelayEveryFrame
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DelayEveryFrame_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DelayEveryFrame_Offset), 0, this, value);
        }
    }
    
    // ObjectProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:BurnInOptions
    static readonly int BurnInOptions_Offset;
    
    public UnrealSharp.LevelSequence.LevelSequenceBurnInOptions BurnInOptions
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequenceBurnInOptions>.FromNative(IntPtr.Add(NativeObject, BurnInOptions_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.LevelSequence.LevelSequenceBurnInOptions>.ToNative(IntPtr.Add(NativeObject, BurnInOptions_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteEditDecisionList
    static readonly int bWriteEditDecisionList_Offset;
    
    public bool bWriteEditDecisionList
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bWriteEditDecisionList_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bWriteEditDecisionList_Offset), 0, this, value);
        }
    }
    
    // BoolProperty /Script/MovieSceneTools.AutomatedLevelSequenceCapture:bWriteFinalCutProXML
    static readonly int bWriteFinalCutProXML_Offset;
    
    public bool bWriteFinalCutProXML
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bWriteFinalCutProXML_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bWriteFinalCutProXML_Offset), 0, this, value);
        }
    }
    
    
}