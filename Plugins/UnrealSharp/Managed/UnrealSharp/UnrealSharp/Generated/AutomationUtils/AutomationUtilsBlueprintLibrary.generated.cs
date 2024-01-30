// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AutomationUtils;

[UClass]
public partial class AutomationUtilsBlueprintLibrary : UnrealSharp.Engine.BlueprintFunctionLibrary
{
    
    static readonly IntPtr NativeClassPtr;
    static AutomationUtilsBlueprintLibrary()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AutomationUtilsBlueprintLibrary");
        
        
        TakeGameplayAutomationScreenshot_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "TakeGameplayAutomationScreenshot");
        TakeGameplayAutomationScreenshot_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(TakeGameplayAutomationScreenshot_NativeFunction);
        TakeGameplayAutomationScreenshot_ScreenshotName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TakeGameplayAutomationScreenshot_NativeFunction, "ScreenshotName");
        TakeGameplayAutomationScreenshot_MaxGlobalError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TakeGameplayAutomationScreenshot_NativeFunction, "MaxGlobalError");
        TakeGameplayAutomationScreenshot_MaxLocalError_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TakeGameplayAutomationScreenshot_NativeFunction, "MaxLocalError");
        TakeGameplayAutomationScreenshot_MapNameOverride_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(TakeGameplayAutomationScreenshot_NativeFunction, "MapNameOverride");
        
        
    }
    
    protected AutomationUtilsBlueprintLibrary(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/AutomationUtils.AutomationUtilsBlueprintLibrary:TakeGameplayAutomationScreenshot
    static readonly IntPtr TakeGameplayAutomationScreenshot_NativeFunction;
    static readonly int TakeGameplayAutomationScreenshot_ParamsSize;
    static readonly int TakeGameplayAutomationScreenshot_ScreenshotName_Offset;
    static readonly int TakeGameplayAutomationScreenshot_MaxGlobalError_Offset;
    static readonly int TakeGameplayAutomationScreenshot_MaxLocalError_Offset;
    static readonly int TakeGameplayAutomationScreenshot_MapNameOverride_Offset;
    
    public static void TakeGameplayAutomationScreenshot(string screenshotName, float maxGlobalError = 0.020000f, float maxLocalError = 0.120000f, string mapNameOverride = "")
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[TakeGameplayAutomationScreenshot_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr ScreenshotName_NativePtr = IntPtr.Add(ParamsBuffer,TakeGameplayAutomationScreenshot_ScreenshotName_Offset);
            StringMarshaller.ToNative(ScreenshotName_NativePtr,0,null,screenshotName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, TakeGameplayAutomationScreenshot_MaxGlobalError_Offset), 0, null, maxGlobalError);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(ParamsBuffer, TakeGameplayAutomationScreenshot_MaxLocalError_Offset), 0, null, maxLocalError);
            IntPtr MapNameOverride_NativePtr = IntPtr.Add(ParamsBuffer,TakeGameplayAutomationScreenshot_MapNameOverride_Offset);
            StringMarshaller.ToNative(MapNameOverride_NativePtr,0,null,mapNameOverride);
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, TakeGameplayAutomationScreenshot_NativeFunction, ParamsBuffer);
            
            StringMarshaller.DestructInstance(ScreenshotName_NativePtr, 0);
            StringMarshaller.DestructInstance(MapNameOverride_NativePtr, 0);
        }
    }
    
    
}