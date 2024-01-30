using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct AnimNode_PoseByName
{
    // NameProperty /Script/AnimGraphRuntime.AnimNode_PoseByName:PoseName
    static readonly int PoseName_Offset;
    public Name PoseName;
    
    // FloatProperty /Script/AnimGraphRuntime.AnimNode_PoseByName:PoseWeight
    static readonly int PoseWeight_Offset;
    public float PoseWeight;
    
    
    public static readonly int NativeDataSize;
    static AnimNode_PoseByName()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AnimNode_PoseByName");
        
        PoseName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoseName");
        PoseWeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PoseWeight");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AnimNode_PoseByName(IntPtr InNativeStruct)
    {
        unsafe
        {
            PoseName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, PoseName_Offset), 0, null);
            PoseWeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, PoseWeight_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, PoseName_Offset), 0, null, PoseName);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, PoseWeight_Offset), 0, null, PoseWeight);
        }
    }
}

public static class AnimNode_PoseByNameMarshaler
{
    public static AnimNode_PoseByName FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AnimNode_PoseByName(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AnimNode_PoseByName obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AnimNode_PoseByName.NativeDataSize;
    }
}