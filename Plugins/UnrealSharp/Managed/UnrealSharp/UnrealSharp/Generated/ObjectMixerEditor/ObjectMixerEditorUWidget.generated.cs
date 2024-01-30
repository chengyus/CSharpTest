// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ObjectMixerEditor;

[UClass]
public partial class ObjectMixerEditorUWidget : UnrealSharp.UMG.Widget
{
    
    static ObjectMixerEditorUWidget()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ObjectMixerEditorUWidget");
        
        ObjectMixerWidgetUserConfig_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ObjectMixerWidgetUserConfig");
        
        
        
    }
    
    protected ObjectMixerEditorUWidget(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/ObjectMixerEditor.ObjectMixerEditorUWidget:ObjectMixerWidgetUserConfig
    static readonly int ObjectMixerWidgetUserConfig_Offset;
    
    public UnrealSharp.ObjectMixerEditor.ObjectMixerWidgetUserConfig ObjectMixerWidgetUserConfig
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.ObjectMixerEditor.ObjectMixerWidgetUserConfigMarshaler.FromNative(IntPtr.Add(NativeObject, ObjectMixerWidgetUserConfig_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.ObjectMixerEditor.ObjectMixerWidgetUserConfigMarshaler.ToNative(IntPtr.Add(NativeObject, ObjectMixerWidgetUserConfig_Offset), 0, this, value);
        }
    }
    
    
}