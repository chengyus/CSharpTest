using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MaterialEditor;

[UStruct(IsBlittable = true)]
public partial struct MaterialStatistics
{
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumVertexShaderInstructions
    public int NumVertexShaderInstructions;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumPixelShaderInstructions
    public int NumPixelShaderInstructions;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumSamplers
    public int NumSamplers;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumVertexTextureSamples
    public int NumVertexTextureSamples;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumPixelTextureSamples
    public int NumPixelTextureSamples;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumVirtualTextureSamples
    public int NumVirtualTextureSamples;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumUVScalars
    public int NumUVScalars;
    
    // IntProperty /Script/MaterialEditor.MaterialStatistics:NumInterpolatorScalars
    public int NumInterpolatorScalars;
    
}