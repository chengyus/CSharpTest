using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct TypedElementPasteOptions
{
    // ObjectProperty /Script/Engine.TypedElementPasteOptions:SelectionSetToModify
    static readonly int SelectionSetToModify_Offset;
    public UnrealSharp.TypedElementRuntime.TypedElementSelectionSet SelectionSetToModify;
    
    // BoolProperty /Script/Engine.TypedElementPasteOptions:bPasteAtLocation
    static readonly int bPasteAtLocation_Offset;
    public bool PasteAtLocation;
    
    // StructProperty /Script/Engine.TypedElementPasteOptions:PasteLocation
    static readonly int PasteLocation_Offset;
    public System.DoubleNumerics.Vector3 PasteLocation;
    
    
    public static readonly int NativeDataSize;
    static TypedElementPasteOptions()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("TypedElementPasteOptions");
        
        SelectionSetToModify_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SelectionSetToModify");
        bPasteAtLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bPasteAtLocation");
        PasteLocation_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PasteLocation");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public TypedElementPasteOptions(IntPtr InNativeStruct)
    {
        unsafe
        {
            SelectionSetToModify = ObjectMarshaller<UnrealSharp.TypedElementRuntime.TypedElementSelectionSet>.FromNative(IntPtr.Add(InNativeStruct, SelectionSetToModify_Offset), 0, null);
            PasteAtLocation = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bPasteAtLocation_Offset), 0, null);
            PasteLocation = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, PasteLocation_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            ObjectMarshaller<UnrealSharp.TypedElementRuntime.TypedElementSelectionSet>.ToNative(IntPtr.Add(Buffer, SelectionSetToModify_Offset), 0, null, SelectionSetToModify);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bPasteAtLocation_Offset), 0, null, PasteAtLocation);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, PasteLocation_Offset), 0, null, PasteLocation);
        }
    }
}

public static class TypedElementPasteOptionsMarshaler
{
    public static TypedElementPasteOptions FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new TypedElementPasteOptions(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, TypedElementPasteOptions obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return TypedElementPasteOptions.NativeDataSize;
    }
}