// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.InterchangeEngine;

[UClass]
public partial class InterchangePipelineConfigurationBase : UnrealSharp.CoreUObject.Object
{
    
    static InterchangePipelineConfigurationBase()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("InterchangePipelineConfigurationBase");
        
        
        
        IntPtr ScriptedShowScenePipelineConfigurationDialog_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptedShowScenePipelineConfigurationDialog");
        ScriptedShowScenePipelineConfigurationDialog_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptedShowScenePipelineConfigurationDialog_NativeFunction);
        ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowScenePipelineConfigurationDialog_NativeFunction, "PipelineStacks");
        ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ScriptedShowScenePipelineConfigurationDialog_NativeFunction, "PipelineStacks");
        ScriptedShowScenePipelineConfigurationDialog_OutPipelines_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowScenePipelineConfigurationDialog_NativeFunction, "OutPipelines");
        ScriptedShowScenePipelineConfigurationDialog_OutPipelines_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ScriptedShowScenePipelineConfigurationDialog_NativeFunction, "OutPipelines");
        ScriptedShowScenePipelineConfigurationDialog_SourceData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowScenePipelineConfigurationDialog_NativeFunction, "SourceData");
        ScriptedShowScenePipelineConfigurationDialog_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowScenePipelineConfigurationDialog_NativeFunction, "ReturnValue");
        
        IntPtr ScriptedShowReimportPipelineConfigurationDialog_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptedShowReimportPipelineConfigurationDialog");
        ScriptedShowReimportPipelineConfigurationDialog_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction);
        ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, "PipelineStacks");
        ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, "PipelineStacks");
        ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, "OutPipelines");
        ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, "OutPipelines");
        ScriptedShowReimportPipelineConfigurationDialog_SourceData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, "SourceData");
        ScriptedShowReimportPipelineConfigurationDialog_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, "ReturnValue");
        
        IntPtr ScriptedShowPipelineConfigurationDialog_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ScriptedShowPipelineConfigurationDialog");
        ScriptedShowPipelineConfigurationDialog_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ScriptedShowPipelineConfigurationDialog_NativeFunction);
        ScriptedShowPipelineConfigurationDialog_PipelineStacks_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowPipelineConfigurationDialog_NativeFunction, "PipelineStacks");
        ScriptedShowPipelineConfigurationDialog_PipelineStacks_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ScriptedShowPipelineConfigurationDialog_NativeFunction, "PipelineStacks");
        ScriptedShowPipelineConfigurationDialog_OutPipelines_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowPipelineConfigurationDialog_NativeFunction, "OutPipelines");
        ScriptedShowPipelineConfigurationDialog_OutPipelines_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ScriptedShowPipelineConfigurationDialog_NativeFunction, "OutPipelines");
        ScriptedShowPipelineConfigurationDialog_SourceData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowPipelineConfigurationDialog_NativeFunction, "SourceData");
        ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ScriptedShowPipelineConfigurationDialog_NativeFunction, "ReturnValue");
        
        
    }
    
    protected InterchangePipelineConfigurationBase(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowScenePipelineConfigurationDialog
    IntPtr ScriptedShowScenePipelineConfigurationDialog_NativeFunction;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_ParamsSize;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_Offset;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_ElementSize;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_OutPipelines_Offset;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_OutPipelines_ElementSize;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_SourceData_Offset;
    static readonly int ScriptedShowScenePipelineConfigurationDialog_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult ScriptedShowScenePipelineConfigurationDialog(out System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks, out System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines, UnrealSharp.InterchangeCore.InterchangeSourceData sourceData)
    {
        unsafe
        {
            if (ScriptedShowScenePipelineConfigurationDialog_NativeFunction == IntPtr.Zero)
            {
                ScriptedShowScenePipelineConfigurationDialog_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ScriptedShowScenePipelineConfigurationDialog");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ScriptedShowScenePipelineConfigurationDialog_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeSourceData>.ToNative(IntPtr.Add(ParamsBuffer, ScriptedShowScenePipelineConfigurationDialog_SourceData_Offset), 0, null, sourceData);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptedShowScenePipelineConfigurationDialog_NativeFunction, ParamsBuffer);
            
            IntPtr PipelineStacks_NativeBuffer = IntPtr.Add(ParamsBuffer, ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> PipelineStacks_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> (1, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.ToNative, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.FromNative, ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_ElementSize);
            pipelineStacks = PipelineStacks_Marshaler.FromNative(PipelineStacks_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo>.DestructInstance(PipelineStacks_NativeBuffer, 0);
            IntPtr OutPipelines_NativeBuffer = IntPtr.Add(ParamsBuffer, ScriptedShowScenePipelineConfigurationDialog_OutPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> OutPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> (1, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.ToNative, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.FromNative, ScriptedShowScenePipelineConfigurationDialog_OutPipelines_ElementSize);
            outPipelines = OutPipelines_Marshaler.FromNative(OutPipelines_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase>.DestructInstance(OutPipelines_NativeBuffer, 0);
            UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult>.FromNative(IntPtr.Add(ParamsBuffer, ScriptedShowScenePipelineConfigurationDialog_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult ScriptedShowScenePipelineConfigurationDialog_Implementation(out System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks, out System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines, UnrealSharp.InterchangeCore.InterchangeSourceData sourceData)
    {
        pipelineStacks = null;
        outPipelines = null;
        return default(UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult);
    }
    void Invoke_ScriptedShowScenePipelineConfigurationDialog(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks = default;
            System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines = default;
            UnrealSharp.InterchangeCore.InterchangeSourceData sourceData = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeSourceData>.FromNative(IntPtr.Add(buffer, ScriptedShowScenePipelineConfigurationDialog_SourceData_Offset), 0, null);
            UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult returnValue = ScriptedShowScenePipelineConfigurationDialog_Implementation(out pipelineStacks, out outPipelines, sourceData);
            BlittableMarshaller<UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult>.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
            IntPtr PipelineStacks_NativeBuffer = IntPtr.Add(buffer, ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> PipelineStacks_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo>(1, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.ToNative, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.FromNative, ScriptedShowScenePipelineConfigurationDialog_PipelineStacks_ElementSize);
            PipelineStacks_Marshaler.ToNative(PipelineStacks_NativeBuffer, 0, null, pipelineStacks);
            IntPtr OutPipelines_NativeBuffer = IntPtr.Add(buffer, ScriptedShowScenePipelineConfigurationDialog_OutPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> OutPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase>(1, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.ToNative, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.FromNative, ScriptedShowScenePipelineConfigurationDialog_OutPipelines_ElementSize);
            OutPipelines_Marshaler.ToNative(OutPipelines_NativeBuffer, 0, null, outPipelines);
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowReimportPipelineConfigurationDialog
    IntPtr ScriptedShowReimportPipelineConfigurationDialog_NativeFunction;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_ParamsSize;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_Offset;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_ElementSize;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_Offset;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_ElementSize;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_SourceData_Offset;
    static readonly int ScriptedShowReimportPipelineConfigurationDialog_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult ScriptedShowReimportPipelineConfigurationDialog(out System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks, out System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines, UnrealSharp.InterchangeCore.InterchangeSourceData sourceData)
    {
        unsafe
        {
            if (ScriptedShowReimportPipelineConfigurationDialog_NativeFunction == IntPtr.Zero)
            {
                ScriptedShowReimportPipelineConfigurationDialog_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ScriptedShowReimportPipelineConfigurationDialog");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ScriptedShowReimportPipelineConfigurationDialog_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeSourceData>.ToNative(IntPtr.Add(ParamsBuffer, ScriptedShowReimportPipelineConfigurationDialog_SourceData_Offset), 0, null, sourceData);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptedShowReimportPipelineConfigurationDialog_NativeFunction, ParamsBuffer);
            
            IntPtr PipelineStacks_NativeBuffer = IntPtr.Add(ParamsBuffer, ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> PipelineStacks_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> (1, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.ToNative, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.FromNative, ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_ElementSize);
            pipelineStacks = PipelineStacks_Marshaler.FromNative(PipelineStacks_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo>.DestructInstance(PipelineStacks_NativeBuffer, 0);
            IntPtr OutPipelines_NativeBuffer = IntPtr.Add(ParamsBuffer, ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> OutPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> (1, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.ToNative, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.FromNative, ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_ElementSize);
            outPipelines = OutPipelines_Marshaler.FromNative(OutPipelines_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase>.DestructInstance(OutPipelines_NativeBuffer, 0);
            UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult>.FromNative(IntPtr.Add(ParamsBuffer, ScriptedShowReimportPipelineConfigurationDialog_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult ScriptedShowReimportPipelineConfigurationDialog_Implementation(out System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks, out System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines, UnrealSharp.InterchangeCore.InterchangeSourceData sourceData)
    {
        pipelineStacks = null;
        outPipelines = null;
        return default(UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult);
    }
    void Invoke_ScriptedShowReimportPipelineConfigurationDialog(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks = default;
            System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines = default;
            UnrealSharp.InterchangeCore.InterchangeSourceData sourceData = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeSourceData>.FromNative(IntPtr.Add(buffer, ScriptedShowReimportPipelineConfigurationDialog_SourceData_Offset), 0, null);
            UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult returnValue = ScriptedShowReimportPipelineConfigurationDialog_Implementation(out pipelineStacks, out outPipelines, sourceData);
            BlittableMarshaller<UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult>.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
            IntPtr PipelineStacks_NativeBuffer = IntPtr.Add(buffer, ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> PipelineStacks_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo>(1, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.ToNative, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.FromNative, ScriptedShowReimportPipelineConfigurationDialog_PipelineStacks_ElementSize);
            PipelineStacks_Marshaler.ToNative(PipelineStacks_NativeBuffer, 0, null, pipelineStacks);
            IntPtr OutPipelines_NativeBuffer = IntPtr.Add(buffer, ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> OutPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase>(1, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.ToNative, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.FromNative, ScriptedShowReimportPipelineConfigurationDialog_OutPipelines_ElementSize);
            OutPipelines_Marshaler.ToNative(OutPipelines_NativeBuffer, 0, null, outPipelines);
        }
    }
    
    // Function /Script/InterchangeEngine.InterchangePipelineConfigurationBase:ScriptedShowPipelineConfigurationDialog
    IntPtr ScriptedShowPipelineConfigurationDialog_NativeFunction;
    static readonly int ScriptedShowPipelineConfigurationDialog_ParamsSize;
    static readonly int ScriptedShowPipelineConfigurationDialog_PipelineStacks_Offset;
    static readonly int ScriptedShowPipelineConfigurationDialog_PipelineStacks_ElementSize;
    static readonly int ScriptedShowPipelineConfigurationDialog_OutPipelines_Offset;
    static readonly int ScriptedShowPipelineConfigurationDialog_OutPipelines_ElementSize;
    static readonly int ScriptedShowPipelineConfigurationDialog_SourceData_Offset;
    static readonly int ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult ScriptedShowPipelineConfigurationDialog(out System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks, out System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines, UnrealSharp.InterchangeCore.InterchangeSourceData sourceData)
    {
        unsafe
        {
            if (ScriptedShowPipelineConfigurationDialog_NativeFunction == IntPtr.Zero)
            {
                ScriptedShowPipelineConfigurationDialog_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ScriptedShowPipelineConfigurationDialog");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ScriptedShowPipelineConfigurationDialog_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeSourceData>.ToNative(IntPtr.Add(ParamsBuffer, ScriptedShowPipelineConfigurationDialog_SourceData_Offset), 0, null, sourceData);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ScriptedShowPipelineConfigurationDialog_NativeFunction, ParamsBuffer);
            
            IntPtr PipelineStacks_NativeBuffer = IntPtr.Add(ParamsBuffer, ScriptedShowPipelineConfigurationDialog_PipelineStacks_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> PipelineStacks_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> (1, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.ToNative, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.FromNative, ScriptedShowPipelineConfigurationDialog_PipelineStacks_ElementSize);
            pipelineStacks = PipelineStacks_Marshaler.FromNative(PipelineStacks_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo>.DestructInstance(PipelineStacks_NativeBuffer, 0);
            IntPtr OutPipelines_NativeBuffer = IntPtr.Add(ParamsBuffer, ScriptedShowPipelineConfigurationDialog_OutPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> OutPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> (1, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.ToNative, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.FromNative, ScriptedShowPipelineConfigurationDialog_OutPipelines_ElementSize);
            outPipelines = OutPipelines_Marshaler.FromNative(OutPipelines_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase>.DestructInstance(OutPipelines_NativeBuffer, 0);
            UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult returnValue;
            returnValue = BlittableMarshaller<UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult>.FromNative(IntPtr.Add(ParamsBuffer, ScriptedShowPipelineConfigurationDialog_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult ScriptedShowPipelineConfigurationDialog_Implementation(out System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks, out System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines, UnrealSharp.InterchangeCore.InterchangeSourceData sourceData)
    {
        pipelineStacks = null;
        outPipelines = null;
        return default(UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult);
    }
    void Invoke_ScriptedShowPipelineConfigurationDialog(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            System.Collections.Generic.IList<UnrealSharp.InterchangeEngine.InterchangeStackInfo> pipelineStacks = default;
            System.Collections.Generic.IList<UnrealSharp.InterchangeCore.InterchangePipelineBase> outPipelines = default;
            UnrealSharp.InterchangeCore.InterchangeSourceData sourceData = ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangeSourceData>.FromNative(IntPtr.Add(buffer, ScriptedShowPipelineConfigurationDialog_SourceData_Offset), 0, null);
            UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult returnValue = ScriptedShowPipelineConfigurationDialog_Implementation(out pipelineStacks, out outPipelines, sourceData);
            BlittableMarshaller<UnrealSharp.InterchangeEngine.EInterchangePipelineConfigurationDialogResult>.ToNative(IntPtr.Add(returnBuffer, 0), 0, null, returnValue);
            IntPtr PipelineStacks_NativeBuffer = IntPtr.Add(buffer, ScriptedShowPipelineConfigurationDialog_PipelineStacks_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo> PipelineStacks_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeEngine.InterchangeStackInfo>(1, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.ToNative, UnrealSharp.InterchangeEngine.InterchangeStackInfoMarshaler.FromNative, ScriptedShowPipelineConfigurationDialog_PipelineStacks_ElementSize);
            PipelineStacks_Marshaler.ToNative(PipelineStacks_NativeBuffer, 0, null, pipelineStacks);
            IntPtr OutPipelines_NativeBuffer = IntPtr.Add(buffer, ScriptedShowPipelineConfigurationDialog_OutPipelines_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase> OutPipelines_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.InterchangeCore.InterchangePipelineBase>(1, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.ToNative, ObjectMarshaller<UnrealSharp.InterchangeCore.InterchangePipelineBase>.FromNative, ScriptedShowPipelineConfigurationDialog_OutPipelines_ElementSize);
            OutPipelines_Marshaler.ToNative(OutPipelines_NativeBuffer, 0, null, outPipelines);
        }
    }
    
    
}