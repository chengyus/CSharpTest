using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct NavAgentProperties
{
    // FloatProperty /Script/Engine.NavAgentProperties:AgentRadius
    static readonly int AgentRadius_Offset;
    public float AgentRadius;
    
    // FloatProperty /Script/Engine.NavAgentProperties:AgentHeight
    static readonly int AgentHeight_Offset;
    public float AgentHeight;
    
    // FloatProperty /Script/Engine.NavAgentProperties:AgentStepHeight
    static readonly int AgentStepHeight_Offset;
    public float AgentStepHeight;
    
    // FloatProperty /Script/Engine.NavAgentProperties:NavWalkingSearchHeightScale
    static readonly int NavWalkingSearchHeightScale_Offset;
    public float NavWalkingSearchHeightScale;
    
    // StructProperty /Script/Engine.NavAgentProperties:PreferredNavData
    static readonly int PreferredNavData_Offset;
    public UnrealSharp.CoreUObject.SoftClassPath PreferredNavData;
    
    
    public static readonly int NativeDataSize;
    static NavAgentProperties()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NavAgentProperties");
        
        AgentRadius_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AgentRadius");
        AgentHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AgentHeight");
        AgentStepHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "AgentStepHeight");
        NavWalkingSearchHeightScale_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "NavWalkingSearchHeightScale");
        PreferredNavData_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PreferredNavData");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NavAgentProperties(IntPtr InNativeStruct)
    {
        unsafe
        {
            AgentRadius = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AgentRadius_Offset), 0, null);
            AgentHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AgentHeight_Offset), 0, null);
            AgentStepHeight = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, AgentStepHeight_Offset), 0, null);
            NavWalkingSearchHeightScale = BlittableMarshaller<float>.FromNative(IntPtr.Add(InNativeStruct, NavWalkingSearchHeightScale_Offset), 0, null);
            PreferredNavData = UnrealSharp.CoreUObject.SoftClassPathMarshaler.FromNative(IntPtr.Add(InNativeStruct, PreferredNavData_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AgentRadius_Offset), 0, null, AgentRadius);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AgentHeight_Offset), 0, null, AgentHeight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, AgentStepHeight_Offset), 0, null, AgentStepHeight);
            BlittableMarshaller<float>.ToNative(IntPtr.Add(Buffer, NavWalkingSearchHeightScale_Offset), 0, null, NavWalkingSearchHeightScale);
            UnrealSharp.CoreUObject.SoftClassPathMarshaler.ToNative(IntPtr.Add(Buffer, PreferredNavData_Offset), 0, null, PreferredNavData);
        }
    }
}

public static class NavAgentPropertiesMarshaler
{
    public static NavAgentProperties FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NavAgentProperties(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NavAgentProperties obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NavAgentProperties.NativeDataSize;
    }
}