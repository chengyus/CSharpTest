using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UStruct]
public partial struct CSVImportSettings
{
    // ObjectProperty /Script/UnrealEd.CSVImportSettings:ImportRowStruct
    static readonly int ImportRowStruct_Offset;
    public UnrealSharp.CoreUObject.ScriptStruct ImportRowStruct;
    
    // EnumProperty /Script/UnrealEd.CSVImportSettings:ImportType
    static readonly int ImportType_Offset;
    public UnrealSharp.UnrealEd.ECSVImportType ImportType;
    
    // ByteProperty /Script/UnrealEd.CSVImportSettings:ImportCurveInterpMode
    static readonly int ImportCurveInterpMode_Offset;
    public UnrealSharp.Engine.ERichCurveInterpMode ImportCurveInterpMode;
    
    
    public static readonly int NativeDataSize;
    static CSVImportSettings()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("CSVImportSettings");
        
        ImportRowStruct_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImportRowStruct");
        ImportType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImportType");
        ImportCurveInterpMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ImportCurveInterpMode");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public CSVImportSettings(IntPtr InNativeStruct)
    {
        unsafe
        {
            ImportRowStruct = ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.FromNative(IntPtr.Add(InNativeStruct, ImportRowStruct_Offset), 0, null);
            ImportType = BlittableMarshaller<UnrealSharp.UnrealEd.ECSVImportType>.FromNative(IntPtr.Add(InNativeStruct, ImportType_Offset), 0, null);
            ImportCurveInterpMode = BlittableMarshaller<UnrealSharp.Engine.ERichCurveInterpMode>.FromNative(IntPtr.Add(InNativeStruct, ImportCurveInterpMode_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.CoreUObject.ScriptStruct>.ToNative(IntPtr.Add(Buffer, ImportRowStruct_Offset), 0, null, ImportRowStruct);
            BlittableMarshaller<UnrealSharp.UnrealEd.ECSVImportType>.ToNative(IntPtr.Add(Buffer, ImportType_Offset), 0, null, ImportType);
            BlittableMarshaller<UnrealSharp.Engine.ERichCurveInterpMode>.ToNative(IntPtr.Add(Buffer, ImportCurveInterpMode_Offset), 0, null, ImportCurveInterpMode);
        }
    }
}

public static class CSVImportSettingsMarshaler
{
    public static CSVImportSettings FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new CSVImportSettings(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, CSVImportSettings obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return CSVImportSettings.NativeDataSize;
    }
}