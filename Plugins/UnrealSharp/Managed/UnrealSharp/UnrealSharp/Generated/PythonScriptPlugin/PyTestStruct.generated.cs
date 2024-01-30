using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.PythonScriptPlugin;

[UStruct]
public partial struct PyTestStruct
{
    // BoolProperty /Script/PythonScriptPlugin.PyTestStruct:Bool
    static readonly int Bool_Offset;
    public bool Bool;
    
    // IntProperty /Script/PythonScriptPlugin.PyTestStruct:Int
    static readonly int Int_Offset;
    public int Int;
    
    // FloatProperty /Script/PythonScriptPlugin.PyTestStruct:Float
    static readonly int Float_Offset;
    public float Float;
    
    // EnumProperty /Script/PythonScriptPlugin.PyTestStruct:Enum
    static readonly int Enum_Offset;
    public UnrealSharp.PythonScriptPlugin.EPyTestEnum Enum;
    
    // NameProperty /Script/PythonScriptPlugin.PyTestStruct:Name
    static readonly int Name_Offset;
    public Name Name;
    
    // BoolProperty /Script/PythonScriptPlugin.PyTestStruct:BoolMutable
    static readonly int BoolMutable_Offset;
    public bool BoolMutable;
    
    
    public static readonly int NativeDataSize;
    static PyTestStruct()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("PyTestStruct");
        
        Bool_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Bool");
        Int_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Int");
        Float_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Float");
        Enum_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Enum");
        Name_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Name");
        BoolMutable_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BoolMutable");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public PyTestStruct(IntPtr InNativeStruct)
    {
        unsafe
        {
            Bool = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, Bool_Offset), 0, null);
            Int = BlittableMarshaller<int>.FromNative(IntPtr.Add(InNativeStruct, Int_Offset), 0, null);
            Float = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Float_Offset), 0, null);
            Enum = BlittableMarshaller<UnrealSharp.PythonScriptPlugin.EPyTestEnum>.FromNative(IntPtr.Add(InNativeStruct, Enum_Offset), 0, null);
            Name = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, Name_Offset), 0, null);
            BoolMutable = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, BoolMutable_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, Bool_Offset), 0, null, Bool);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(Buffer, Int_Offset), 0, null, Int);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Float_Offset), 0, null, Float);
            BlittableMarshaller<UnrealSharp.PythonScriptPlugin.EPyTestEnum>.ToNative(IntPtr.Add(Buffer, Enum_Offset), 0, null, Enum);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, Name_Offset), 0, null, Name);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, BoolMutable_Offset), 0, null, BoolMutable);
        }
    }
}

public static class PyTestStructMarshaler
{
    public static PyTestStruct FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new PyTestStruct(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, PyTestStruct obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return PyTestStruct.NativeDataSize;
    }
}