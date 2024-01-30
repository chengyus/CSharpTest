using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UnrealEd;

[UEnum]
public enum EFBXSceneOptionsCreateHierarchyType : byte
{
    FBXSOCHT_CreateLevelActors=0,
    FBXSOCHT_CreateActorComponents=1,
    FBXSOCHT_CreateBlueprint=2,
}