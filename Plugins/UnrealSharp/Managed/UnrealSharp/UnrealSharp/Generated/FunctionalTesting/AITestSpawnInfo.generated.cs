using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FunctionalTesting;

[UStruct]
public partial struct AITestSpawnInfo
{
    // ClassProperty /Script/FunctionalTesting.AITestSpawnInfo:PawnClass
    static readonly int PawnClass_Offset;
    public SubclassOf<UnrealSharp.Engine.Pawn> PawnClass;
    
    // ClassProperty /Script/FunctionalTesting.AITestSpawnInfo:ControllerClass
    static readonly int ControllerClass_Offset;
    public SubclassOf<UnrealSharp.AIModule.AIController> ControllerClass;
    
    // StructProperty /Script/FunctionalTesting.AITestSpawnInfo:TeamID
    static readonly int TeamID_Offset;
    public UnrealSharp.AIModule.GenericTeamId TeamID;
    
    // ObjectProperty /Script/FunctionalTesting.AITestSpawnInfo:BehaviorTree
    static readonly int BehaviorTree_Offset;
    public UnrealSharp.AIModule.BehaviorTree BehaviorTree;
    
    
    public static readonly int NativeDataSize;
    static AITestSpawnInfo()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("AITestSpawnInfo");
        
        PawnClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "PawnClass");
        ControllerClass_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ControllerClass");
        TeamID_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TeamID");
        BehaviorTree_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "BehaviorTree");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public AITestSpawnInfo(IntPtr InNativeStruct)
    {
        unsafe
        {
            PawnClass = SubclassOfMarshaller<UnrealSharp.Engine.Pawn>.FromNative(IntPtr.Add(InNativeStruct, PawnClass_Offset), 0, null);
            ControllerClass = SubclassOfMarshaller<UnrealSharp.AIModule.AIController>.FromNative(IntPtr.Add(InNativeStruct, ControllerClass_Offset), 0, null);
            TeamID = BlittableMarshaller<UnrealSharp.AIModule.GenericTeamId>.FromNative(IntPtr.Add(InNativeStruct, TeamID_Offset), 0, null);
            BehaviorTree = ObjectMarshaller<UnrealSharp.AIModule.BehaviorTree>.FromNative(IntPtr.Add(InNativeStruct, BehaviorTree_Offset), 0, null);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            SubclassOfMarshaller<UnrealSharp.Engine.Pawn>.ToNative(IntPtr.Add(Buffer, PawnClass_Offset), 0, null, PawnClass);
            SubclassOfMarshaller<UnrealSharp.AIModule.AIController>.ToNative(IntPtr.Add(Buffer, ControllerClass_Offset), 0, null, ControllerClass);
            BlittableMarshaller<UnrealSharp.AIModule.GenericTeamId>.ToNative(IntPtr.Add(Buffer, TeamID_Offset), 0, null, TeamID);
            ObjectMarshaller<UnrealSharp.AIModule.BehaviorTree>.ToNative(IntPtr.Add(Buffer, BehaviorTree_Offset), 0, null, BehaviorTree);
        }
    }
}

public static class AITestSpawnInfoMarshaler
{
    public static AITestSpawnInfo FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new AITestSpawnInfo(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, AITestSpawnInfo obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return AITestSpawnInfo.NativeDataSize;
    }
}