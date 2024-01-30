// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.AnimGraph;

[UClass]
public partial class AnimGraphNode_TransitionPoseEvaluator : UnrealSharp.AnimGraph.AnimGraphNode_Base
{
    
    static AnimGraphNode_TransitionPoseEvaluator()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("AnimGraphNode_TransitionPoseEvaluator");
        
        Node_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Node");
        
        
        
    }
    
    protected AnimGraphNode_TransitionPoseEvaluator(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StructProperty /Script/AnimGraph.AnimGraphNode_TransitionPoseEvaluator:Node
    static readonly int Node_Offset;
    
    public UnrealSharp.Engine.AnimNode_TransitionPoseEvaluator Node
    {
        get
        {
            CheckObjectForValidity();
            return UnrealSharp.Engine.AnimNode_TransitionPoseEvaluatorMarshaler.FromNative(IntPtr.Add(NativeObject, Node_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            UnrealSharp.Engine.AnimNode_TransitionPoseEvaluatorMarshaler.ToNative(IntPtr.Add(NativeObject, Node_Offset), 0, this, value);
        }
    }
    
    
}