// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UClass]
public partial class Note : UnrealSharp.Engine.Actor
{
    
    static Note()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("Note");
        
        Text_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Text");
        Text_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "Text");
        
        
        
    }
    
    protected Note(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StrProperty /Script/Engine.Note:Text
    static readonly int Text_Offset;
    static readonly IntPtr Text_NativeProperty;
    
    public string Text
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,Text_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,Text_Offset),0,this,value);
        }
    }
    
    
}