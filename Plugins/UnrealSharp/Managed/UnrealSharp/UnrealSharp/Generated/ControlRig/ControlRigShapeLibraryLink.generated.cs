// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ControlRig;

[UClass]
public partial class ControlRigShapeLibraryLink : UnrealSharp.RigVM.NameSpacedUserData
{
    
    static ControlRigShapeLibraryLink()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("ControlRigShapeLibraryLink");
        
        ShapeLibrary_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ShapeLibrary");
        
        
        
    }
    
    protected ControlRigShapeLibraryLink(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // ObjectProperty /Script/ControlRig.ControlRigShapeLibraryLink:ShapeLibrary
    static readonly int ShapeLibrary_Offset;
    
    public UnrealSharp.ControlRig.ControlRigShapeLibrary ShapeLibrary
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.ControlRig.ControlRigShapeLibrary>.FromNative(IntPtr.Add(NativeObject, ShapeLibrary_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            ObjectMarshaller<UnrealSharp.ControlRig.ControlRigShapeLibrary>.ToNative(IntPtr.Add(NativeObject, ShapeLibrary_Offset), 0, this, value);
        }
    }
    
    
}