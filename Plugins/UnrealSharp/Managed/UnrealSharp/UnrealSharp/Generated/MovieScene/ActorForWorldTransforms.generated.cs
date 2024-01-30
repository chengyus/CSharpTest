using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MovieScene;

[UStruct(IsBlittable = true)]
public partial struct ActorForWorldTransforms
{
    // WeakObjectProperty /Script/MovieScene.ActorForWorldTransforms:Actor
    public WeakObject<UnrealSharp.Engine.Actor> Actor;
    
    // WeakObjectProperty /Script/MovieScene.ActorForWorldTransforms:Component
    public WeakObject<UnrealSharp.Engine.SceneComponent> Component;
    
    // NameProperty /Script/MovieScene.ActorForWorldTransforms:SocketName
    public Name SocketName;
    
}