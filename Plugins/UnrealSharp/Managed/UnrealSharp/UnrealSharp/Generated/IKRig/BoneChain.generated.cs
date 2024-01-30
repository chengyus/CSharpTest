using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.IKRig;

[UStruct]
public partial struct BoneChain
{
    // NameProperty /Script/IKRig.BoneChain:ChainName
    static readonly int ChainName_Offset;
    public Name ChainName;
    
    // NameProperty /Script/IKRig.BoneChain:IKGoalName
    static readonly int IKGoalName_Offset;
    public Name IKGoalName;
    
    
    public static readonly int NativeDataSize;
    static BoneChain()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("BoneChain");
        
        ChainName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ChainName");
        IKGoalName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "IKGoalName");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public BoneChain(IntPtr InNativeStruct)
    {
        unsafe
        {
            ChainName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, ChainName_Offset), 0, null);
            IKGoalName = BlittableMarshaller<Name>.FromNative(IntPtr.Add(InNativeStruct, IKGoalName_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, ChainName_Offset), 0, null, ChainName);
            BlittableMarshaller<Name>.ToNative(IntPtr.Add(Buffer, IKGoalName_Offset), 0, null, IKGoalName);
        }
    }
}

public static class BoneChainMarshaler
{
    public static BoneChain FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new BoneChain(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, BoneChain obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return BoneChain.NativeDataSize;
    }
}