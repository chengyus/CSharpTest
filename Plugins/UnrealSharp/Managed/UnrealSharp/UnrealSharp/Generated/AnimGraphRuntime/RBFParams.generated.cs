using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraphRuntime;

[UStruct]
public partial struct RBFParams
{
    // EnumProperty /Script/AnimGraphRuntime.RBFParams:SolverType
    static readonly int SolverType_Offset;
    public UnrealSharp.AnimGraphRuntime.ERBFSolverType SolverType;
    
    // FloatProperty /Script/AnimGraphRuntime.RBFParams:Radius
    static readonly int Radius_Offset;
    public float Radius;
    
    // BoolProperty /Script/AnimGraphRuntime.RBFParams:bAutomaticRadius
    static readonly int bAutomaticRadius_Offset;
    public bool AutomaticRadius;
    
    // EnumProperty /Script/AnimGraphRuntime.RBFParams:Function
    static readonly int Function_Offset;
    public UnrealSharp.AnimGraphRuntime.ERBFFunctionType Function;
    
    // EnumProperty /Script/AnimGraphRuntime.RBFParams:DistanceMethod
    static readonly int DistanceMethod_Offset;
    public UnrealSharp.AnimGraphRuntime.ERBFDistanceMethod DistanceMethod;
    
    // ByteProperty /Script/AnimGraphRuntime.RBFParams:TwistAxis
    static readonly int TwistAxis_Offset;
    public UnrealSharp.Engine.EBoneAxis TwistAxis;
    
    // FloatProperty /Script/AnimGraphRuntime.RBFParams:WeightThreshold
    static readonly int WeightThreshold_Offset;
    public float WeightThreshold;
    
    // EnumProperty /Script/AnimGraphRuntime.RBFParams:NormalizeMethod
    static readonly int NormalizeMethod_Offset;
    public UnrealSharp.AnimGraphRuntime.ERBFNormalizeMethod NormalizeMethod;
    
    // StructProperty /Script/AnimGraphRuntime.RBFParams:MedianReference
    static readonly int MedianReference_Offset;
    public System.DoubleNumerics.Vector3 MedianReference;
    
    // FloatProperty /Script/AnimGraphRuntime.RBFParams:MedianMin
    static readonly int MedianMin_Offset;
    public float MedianMin;
    
    // FloatProperty /Script/AnimGraphRuntime.RBFParams:MedianMax
    static readonly int MedianMax_Offset;
    public float MedianMax;
    
    
    public static readonly int NativeDataSize;
    static RBFParams()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("RBFParams");
        
        SolverType_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SolverType");
        Radius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Radius");
        bAutomaticRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bAutomaticRadius");
        Function_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Function");
        DistanceMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DistanceMethod");
        TwistAxis_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TwistAxis");
        WeightThreshold_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "WeightThreshold");
        NormalizeMethod_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NormalizeMethod");
        MedianReference_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MedianReference");
        MedianMin_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MedianMin");
        MedianMax_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MedianMax");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public RBFParams(IntPtr InNativeStruct)
    {
        unsafe
        {
            SolverType = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFSolverType>.FromNative(IntPtr.Add(InNativeStruct, SolverType_Offset), 0, null);
            Radius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, Radius_Offset), 0, null);
            AutomaticRadius = BoolMarshaller.FromNative(IntPtr.Add(InNativeStruct, bAutomaticRadius_Offset), 0, null);
            Function = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFFunctionType>.FromNative(IntPtr.Add(InNativeStruct, Function_Offset), 0, null);
            DistanceMethod = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFDistanceMethod>.FromNative(IntPtr.Add(InNativeStruct, DistanceMethod_Offset), 0, null);
            TwistAxis = BlittableMarshaller<UnrealSharp.Engine.EBoneAxis>.FromNative(IntPtr.Add(InNativeStruct, TwistAxis_Offset), 0, null);
            WeightThreshold = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, WeightThreshold_Offset), 0, null);
            NormalizeMethod = BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFNormalizeMethod>.FromNative(IntPtr.Add(InNativeStruct, NormalizeMethod_Offset), 0, null);
            MedianReference = BlittableMarshaller<System.DoubleNumerics.Vector3>.FromNative(IntPtr.Add(InNativeStruct, MedianReference_Offset), 0, null);
            MedianMin = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MedianMin_Offset), 0, null);
            MedianMax = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, MedianMax_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFSolverType>.ToNative(IntPtr.Add(Buffer, SolverType_Offset), 0, null, SolverType);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, Radius_Offset), 0, null, Radius);
            BoolMarshaller.ToNative(IntPtr.Add(Buffer, bAutomaticRadius_Offset), 0, null, AutomaticRadius);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFFunctionType>.ToNative(IntPtr.Add(Buffer, Function_Offset), 0, null, Function);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFDistanceMethod>.ToNative(IntPtr.Add(Buffer, DistanceMethod_Offset), 0, null, DistanceMethod);
            BlittableMarshaller<UnrealSharp.Engine.EBoneAxis>.ToNative(IntPtr.Add(Buffer, TwistAxis_Offset), 0, null, TwistAxis);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, WeightThreshold_Offset), 0, null, WeightThreshold);
            BlittableMarshaller<UnrealSharp.AnimGraphRuntime.ERBFNormalizeMethod>.ToNative(IntPtr.Add(Buffer, NormalizeMethod_Offset), 0, null, NormalizeMethod);
            BlittableMarshaller<System.DoubleNumerics.Vector3>.ToNative(IntPtr.Add(Buffer, MedianReference_Offset), 0, null, MedianReference);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MedianMin_Offset), 0, null, MedianMin);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, MedianMax_Offset), 0, null, MedianMax);
        }
    }
}

public static class RBFParamsMarshaler
{
    public static RBFParams FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new RBFParams(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, RBFParams obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return RBFParams.NativeDataSize;
    }
}