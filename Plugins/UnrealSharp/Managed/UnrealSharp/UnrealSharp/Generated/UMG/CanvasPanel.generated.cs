// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class CanvasPanel : UnrealSharp.UMG.PanelWidget
{
    
    static CanvasPanel()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CanvasPanel");
        
        
        AddChildToCanvas_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddChildToCanvas");
        AddChildToCanvas_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddChildToCanvas_NativeFunction);
        AddChildToCanvas_Content_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChildToCanvas_NativeFunction, "Content");
        AddChildToCanvas_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddChildToCanvas_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CanvasPanel(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/UMG.CanvasPanel:AddChildToCanvas
    static readonly IntPtr AddChildToCanvas_NativeFunction;
    static readonly int AddChildToCanvas_ParamsSize;
    static readonly int AddChildToCanvas_Content_Offset;
    static readonly int AddChildToCanvas_ReturnValue_Offset;
    
    public UnrealSharp.UMG.CanvasPanelSlot AddChildToCanvas(UnrealSharp.UMG.Widget content)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddChildToCanvas_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.UMG.Widget>.ToNative(IntPtr.Add(ParamsBuffer, AddChildToCanvas_Content_Offset), 0, null, content);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddChildToCanvas_NativeFunction, ParamsBuffer);
            
            UnrealSharp.UMG.CanvasPanelSlot returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.UMG.CanvasPanelSlot>.FromNative(IntPtr.Add(ParamsBuffer, AddChildToCanvas_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}