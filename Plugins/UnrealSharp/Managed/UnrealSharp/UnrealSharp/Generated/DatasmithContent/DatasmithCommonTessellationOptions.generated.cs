// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.DatasmithContent;

[UClass]
public partial class DatasmithCommonTessellationOptions : UnrealSharp.DatasmithContent.DatasmithOptionsBase
{
    
    static DatasmithCommonTessellationOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("DatasmithCommonTessellationOptions");
        
        Options_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Options");
        
        
        
    }
    
    protected DatasmithCommonTessellationOptions(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/DatasmithContent.DatasmithCommonTessellationOptions:Options
    static readonly int Options_Offset;
    
    public UnrealSharp.DatasmithContent.DatasmithTessellationOptions Options
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.DatasmithContent.DatasmithTessellationOptionsMarshaler.FromNative(IntPtr.Add(NativeObject, Options_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.DatasmithContent.DatasmithTessellationOptionsMarshaler.ToNative(IntPtr.Add(NativeObject, Options_Offset), 0, this, value);
        }
    }
    
    
}