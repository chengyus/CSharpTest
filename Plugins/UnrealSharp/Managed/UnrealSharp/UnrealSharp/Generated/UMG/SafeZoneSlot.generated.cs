// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

[UClass]
public partial class SafeZoneSlot : UnrealSharp.UMG.PanelSlot
{
    
    static SafeZoneSlot()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("SafeZoneSlot");
        
        bIsTitleSafe_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bIsTitleSafe");
        SafeAreaScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SafeAreaScale");
        HAlign_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "HAlign");
        VAlign_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "VAlign");
        Padding_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Padding");
        
        
        
    }
    
    protected SafeZoneSlot(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // BoolProperty /Script/UMG.SafeZoneSlot:bIsTitleSafe
    static readonly int bIsTitleSafe_Offset;
    
    public bool bIsTitleSafe
    {
        get
        {
            CheckObjectForValidity();
            return BoolMarshaller.FromNative(IntPtr.Add(NativeObject, bIsTitleSafe_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BoolMarshaller.ToNative(IntPtr.Add(NativeObject, bIsTitleSafe_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.SafeZoneSlot:SafeAreaScale
    static readonly int SafeAreaScale_Offset;
    
    public UnrealSharp.SlateCore.Margin SafeAreaScale
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, SafeAreaScale_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(NativeObject, SafeAreaScale_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/UMG.SafeZoneSlot:HAlign
    static readonly int HAlign_Offset;
    
    public UnrealSharp.SlateCore.EHorizontalAlignment HAlign
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.FromNative(IntPtr.Add(NativeObject, HAlign_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.EHorizontalAlignment>.ToNative(IntPtr.Add(NativeObject, HAlign_Offset), 0, this, value);
        }
    }
    
    // ByteProperty /Script/UMG.SafeZoneSlot:VAlign
    static readonly int VAlign_Offset;
    
    public UnrealSharp.SlateCore.EVerticalAlignment VAlign
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.FromNative(IntPtr.Add(NativeObject, VAlign_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.EVerticalAlignment>.ToNative(IntPtr.Add(NativeObject, VAlign_Offset), 0, this, value);
        }
    }
    
    // StructProperty /Script/UMG.SafeZoneSlot:Padding
    static readonly int Padding_Offset;
    
    public UnrealSharp.SlateCore.Margin Padding
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.SlateCore.Margin>.FromNative(IntPtr.Add(NativeObject, Padding_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<UnrealSharp.SlateCore.Margin>.ToNative(IntPtr.Add(NativeObject, Padding_Offset), 0, this, value);
        }
    }
    
    
}