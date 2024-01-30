using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.VREditor;

[UStruct]
public partial struct VREditorFloatingUICreationContext
{
    // ClassProperty /Script/VREditor.VREditorFloatingUICreationContext:WidgetClass
    static readonly int WidgetClass_Offset;
    public SubclassOf<UnrealSharp.UMG.UserWidget> WidgetClass;
    
    // NameProperty /Script/VREditor.VREditorFloatingUICreationContext:PanelID
    static readonly int PanelID_Offset;
    public Name PanelID;
    
    // ObjectProperty /Script/VREditor.VREditorFloatingUICreationContext:ParentActor
    static readonly int ParentActor_Offset;
    public UnrealSharp.Engine.Actor ParentActor;
    
    // StructProperty /Script/VREditor.VREditorFloatingUICreationContext:PanelSpawnOffset
    static readonly int PanelSpawnOffset_Offset;
    public UnrealSharp.Transform PanelSpawnOffset;
    
    // StructProperty /Script/VREditor.VREditorFloatingUICreationContext:PanelSize
    static readonly int PanelSize_Offset;
    public System.DoubleNumerics.Vector2 PanelSize;
    
    // ObjectProperty /Script/VREditor.VREditorFloatingUICreationContext:PanelMesh
    static readonly int PanelMesh_Offset;
    public UnrealSharp.Engine.StaticMesh PanelMesh;
    
    // FloatProperty /Script/VREditor.VREditorFloatingUICreationContext:EditorUISize
    static readonly int EditorUISize_Offset;
    public float EditorUISize;
    
    // BoolProperty /Script/VREditor.VREditorFloatingUICreationContext:bHideWindowHandles
    static readonly int bHideWindowHandles_Offset;
    public bool HideWindowHandles;
    
    // BoolProperty /Script/VREditor.VREditorFloatingUICreationContext:bMaskOutWidgetBackground
    static readonly int bMaskOutWidgetBackground_Offset;
    public bool MaskOutWidgetBackground;
    
    // BoolProperty /Script/VREditor.VREditorFloatingUICreationContext:bNoCloseButton
    static readonly int bNoCloseButton_Offset;
    public bool NoCloseButton;
    
    
    public static readonly int NativeDataSize;
    static VREditorFloatingUICreationContext()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("VREditorFloatingUICreationContext");
        
        WidgetClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WidgetClass");
        PanelID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PanelID");
        ParentActor_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ParentActor");
        PanelSpawnOffset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PanelSpawnOffset");
        PanelSize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PanelSize");
        PanelMesh_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PanelMesh");
        EditorUISize_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "EditorUISize");
        bHideWindowHandles_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bHideWindowHandles");
        bMaskOutWidgetBackground_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bMaskOutWidgetBackground");
        bNoCloseButton_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bNoCloseButton");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public VREditorFloatingUICreationContext(IntPtr InNativeStruct)
    {
        unsafe
        {
            WidgetClass = SubclassOfMarshaller<UnrealSharp.UMG.UserWidget>.FromNative(IntPtr.Add(InNativeStruct, WidgetClass_Offset), 0, null);
            PanelID = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PanelID_Offset), 0, null);
            ParentActor = ObjectMarshaller<UnrealSharp.Engine.Actor>.FromNative(IntPtr.Add(InNativeStruct, ParentActor_Offset), 0, null);
            PanelSpawnOffset = BlittableMarshaller<UnrealSharp.Transform>.FromNative(IntPtr.Add(InNativeStruct, PanelSpawnOffset_Offset), 0, null);
            PanelSize = BlittableMarshaller<System.DoubleNumerics.Vector2>.FromNative(IntPtr.Add(InNativeStruct, PanelSize_Offset), 0, null);
            PanelMesh = ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.FromNative(IntPtr.Add(InNativeStruct, PanelMesh_Offset), 0, null);
            EditorUISize = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, EditorUISize_Offset), 0, null);
            HideWindowHandles = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bHideWindowHandles_Offset), 0, null);
            MaskOutWidgetBackground = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bMaskOutWidgetBackground_Offset), 0, null);
            NoCloseButton = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bNoCloseButton_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.UMG.UserWidget>.ToNative(IntPtr.Add(Buffer, WidgetClass_Offset), 0, null, WidgetClass);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PanelID_Offset), 0, null, PanelID);
            ObjectMarshaller<UnrealSharp.Engine.Actor>.ToNative(IntPtr.Add(Buffer, ParentActor_Offset), 0, null, ParentActor);
            BlittableMarshaller<UnrealSharp.Transform>.ToNative(IntPtr.Add(Buffer, PanelSpawnOffset_Offset), 0, null, PanelSpawnOffset);
            BlittableMarshaller<System.DoubleNumerics.Vector2>.ToNative(IntPtr.Add(Buffer, PanelSize_Offset), 0, null, PanelSize);
            ObjectMarshaller<UnrealSharp.Engine.StaticMesh>.ToNative(IntPtr.Add(Buffer, PanelMesh_Offset), 0, null, PanelMesh);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, EditorUISize_Offset), 0, null, EditorUISize);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bHideWindowHandles_Offset), 0, null, HideWindowHandles);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bMaskOutWidgetBackground_Offset), 0, null, MaskOutWidgetBackground);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bNoCloseButton_Offset), 0, null, NoCloseButton);
        }
    }
}

public static class VREditorFloatingUICreationContextMarshaler
{
    public static VREditorFloatingUICreationContext FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new VREditorFloatingUICreationContext(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, VREditorFloatingUICreationContext obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return VREditorFloatingUICreationContext.NativeDataSize;
    }
}