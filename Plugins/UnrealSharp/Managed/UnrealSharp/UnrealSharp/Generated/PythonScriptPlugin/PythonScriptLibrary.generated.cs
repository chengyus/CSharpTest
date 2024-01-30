// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UClass]
public partial class PythonScriptLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static PythonScriptLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PythonScriptLibrary");
        
        
        IsPythonAvailable_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "IsPythonAvailable");
        IsPythonAvailable_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(IsPythonAvailable_NativeFunction);
        IsPythonAvailable_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(IsPythonAvailable_NativeFunction, "ReturnValue");
        ExecutePythonCommandEx_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ExecutePythonCommandEx");
        ExecutePythonCommandEx_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ExecutePythonCommandEx_NativeFunction);
        ExecutePythonCommandEx_PythonCommand_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommandEx_NativeFunction, "PythonCommand");
        ExecutePythonCommandEx_CommandResult_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommandEx_NativeFunction, "CommandResult");
        ExecutePythonCommandEx_LogOutput_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommandEx_NativeFunction, "LogOutput");
        ExecutePythonCommandEx_LogOutput_ElementSize = FArrayPropertyExporter.CallGetArrayElementSize(ExecutePythonCommandEx_NativeFunction, "LogOutput");
        ExecutePythonCommandEx_ExecutionMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommandEx_NativeFunction, "ExecutionMode");
        ExecutePythonCommandEx_FileExecutionScope_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommandEx_NativeFunction, "FileExecutionScope");
        ExecutePythonCommandEx_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommandEx_NativeFunction, "ReturnValue");
        ExecutePythonCommand_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ExecutePythonCommand");
        ExecutePythonCommand_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ExecutePythonCommand_NativeFunction);
        ExecutePythonCommand_PythonCommand_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommand_NativeFunction, "PythonCommand");
        ExecutePythonCommand_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ExecutePythonCommand_NativeFunction, "ReturnValue");
        
        
    }
    
    protected PythonScriptLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/PythonScriptPlugin.PythonScriptLibrary:IsPythonAvailable
    static readonly IntPtr IsPythonAvailable_NativeFunction;
    static readonly int IsPythonAvailable_ParamsSize;
    static readonly int IsPythonAvailable_ReturnValue_Offset;
    
    public static bool IsPythonAvailable()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[IsPythonAvailable_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, IsPythonAvailable_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, IsPythonAvailable_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PythonScriptLibrary:ExecutePythonCommandEx
    static readonly IntPtr ExecutePythonCommandEx_NativeFunction;
    static readonly int ExecutePythonCommandEx_ParamsSize;
    static readonly int ExecutePythonCommandEx_PythonCommand_Offset;
    static readonly int ExecutePythonCommandEx_CommandResult_Offset;
    static readonly int ExecutePythonCommandEx_LogOutput_Offset;
    static readonly int ExecutePythonCommandEx_LogOutput_ElementSize;
    static readonly int ExecutePythonCommandEx_ExecutionMode_Offset;
    static readonly int ExecutePythonCommandEx_FileExecutionScope_Offset;
    static readonly int ExecutePythonCommandEx_ReturnValue_Offset;
    
    public static bool ExecutePythonCommandEx(string pythonCommand, out string commandResult, out System.Collections.Generic.IList<UnrealSharp.PythonScriptPlugin.PythonLogOutputEntry> logOutput, UnrealSharp.PythonScriptPlugin.EPythonCommandExecutionMode executionMode = UnrealSharp.PythonScriptPlugin.EPythonCommandExecutionMode.ExecuteFile, UnrealSharp.PythonScriptPlugin.EPythonFileExecutionScope fileExecutionScope = UnrealSharp.PythonScriptPlugin.EPythonFileExecutionScope.Private)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ExecutePythonCommandEx_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr PythonCommand_NativePtr = IntPtr.Add(ParamsBuffer,ExecutePythonCommandEx_PythonCommand_Offset);
            StringMarshaller.ToNative(PythonCommand_NativePtr,0,null,pythonCommand);
            BlittableMarshaller<UnrealSharp.PythonScriptPlugin.EPythonCommandExecutionMode>.ToNative(IntPtr.Add(ParamsBuffer, ExecutePythonCommandEx_ExecutionMode_Offset), 0, null, executionMode);
            BlittableMarshaller<UnrealSharp.PythonScriptPlugin.EPythonFileExecutionScope>.ToNative(IntPtr.Add(ParamsBuffer, ExecutePythonCommandEx_FileExecutionScope_Offset), 0, null, fileExecutionScope);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ExecutePythonCommandEx_NativeFunction, ParamsBuffer);
            
            IntPtr CommandResult_NativePtr = IntPtr.Add(ParamsBuffer,ExecutePythonCommandEx_CommandResult_Offset);
            commandResult = StringMarshaller.FromNative(CommandResult_NativePtr,0,null);
            StringMarshaller.DestructInstance(CommandResult_NativePtr, 0);
            IntPtr LogOutput_NativeBuffer = IntPtr.Add(ParamsBuffer, ExecutePythonCommandEx_LogOutput_Offset);
            UnrealArrayCopyMarshaler<UnrealSharp.PythonScriptPlugin.PythonLogOutputEntry> LogOutput_Marshaler = new UnrealArrayCopyMarshaler<UnrealSharp.PythonScriptPlugin.PythonLogOutputEntry> (1, UnrealSharp.PythonScriptPlugin.PythonLogOutputEntryMarshaler.ToNative, UnrealSharp.PythonScriptPlugin.PythonLogOutputEntryMarshaler.FromNative, ExecutePythonCommandEx_LogOutput_ElementSize);
            logOutput = LogOutput_Marshaler.FromNative(LogOutput_NativeBuffer, 0, null);
            UnrealArrayCopyMarshaler<UnrealSharp.PythonScriptPlugin.PythonLogOutputEntry>.DestructInstance(LogOutput_NativeBuffer, 0);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ExecutePythonCommandEx_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(PythonCommand_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/PythonScriptPlugin.PythonScriptLibrary:ExecutePythonCommand
    static readonly IntPtr ExecutePythonCommand_NativeFunction;
    static readonly int ExecutePythonCommand_ParamsSize;
    static readonly int ExecutePythonCommand_PythonCommand_Offset;
    static readonly int ExecutePythonCommand_ReturnValue_Offset;
    
    public static bool ExecutePythonCommand(string pythonCommand)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[ExecutePythonCommand_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr PythonCommand_NativePtr = IntPtr.Add(ParamsBuffer,ExecutePythonCommand_PythonCommand_Offset);
            StringMarshaller.ToNative(PythonCommand_NativePtr,0,null,pythonCommand);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, ExecutePythonCommand_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, ExecutePythonCommand_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(PythonCommand_NativePtr, 0);
            return returnValue;
        }
    }
    
    
}