// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ToolMenus;

[UClass]
public partial class ToolMenuSectionDynamic : UnrealSharp.CoreUObject.Object
{
    
    static ToolMenuSectionDynamic()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ToolMenuSectionDynamic");
        
        
        
        IntPtr ConstructSections_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "ConstructSections");
        ConstructSections_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(ConstructSections_NativeFunction);
        ConstructSections_Menu_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ConstructSections_NativeFunction, "Menu");
        ConstructSections_Context_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(ConstructSections_NativeFunction, "Context");
        
        
    }
    
    protected ToolMenuSectionDynamic(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/ToolMenus.ToolMenuSectionDynamic:ConstructSections
    IntPtr ConstructSections_NativeFunction;
    static readonly int ConstructSections_ParamsSize;
    static readonly int ConstructSections_Menu_Offset;
    static readonly int ConstructSections_Context_Offset;
    
    [UFunction(FunctionFlags.BlueprintEvent)]
    public virtual void ConstructSections(UnrealSharp.ToolMenus.ToolMenu menu, UnrealSharp.ToolMenus.ToolMenuContext context)
    {
        unsafe
        {
            if (ConstructSections_NativeFunction == IntPtr.Zero)
            {
                ConstructSections_NativeFunction = UClassExporter.CallGetNativeFunctionFromInstanceAndName(NativeObject, "ConstructSections");
            }
            byte* ParamsBufferAllocation = stackalloc byte[ConstructSections_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.ToolMenus.ToolMenu>.ToNative(IntPtr.Add(ParamsBuffer, ConstructSections_Menu_Offset), 0, null, menu);
            UnrealSharp.ToolMenus.ToolMenuContextMarshaler.ToNative(IntPtr.Add(ParamsBuffer, ConstructSections_Context_Offset), 0, null, context);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, ConstructSections_NativeFunction, ParamsBuffer);
            
            
        }
    }
    
    //Hide implementation function from Intellisense/ReSharper
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    protected virtual void ConstructSections_Implementation(UnrealSharp.ToolMenus.ToolMenu menu, UnrealSharp.ToolMenus.ToolMenuContext context)
    {
    }
    void Invoke_ConstructSections(IntPtr buffer, IntPtr returnBuffer)
    {
        unsafe
        {
            UnrealSharp.ToolMenus.ToolMenu menu = ObjectMarshaller<UnrealSharp.ToolMenus.ToolMenu>.FromNative(IntPtr.Add(buffer, ConstructSections_Menu_Offset), 0, null);
            UnrealSharp.ToolMenus.ToolMenuContext context = UnrealSharp.ToolMenus.ToolMenuContextMarshaler.FromNative(IntPtr.Add(buffer, ConstructSections_Context_Offset), 0, null);
            ConstructSections_Implementation(menu, context);
        }
    }
    
    
}