using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.RigVM;

[UEnum]
public enum ERigVMAnimEasingType : byte
{
    Linear=0,
    QuadraticEaseIn=1,
    QuadraticEaseOut=2,
    QuadraticEaseInOut=3,
    CubicEaseIn=4,
    CubicEaseOut=5,
    CubicEaseInOut=6,
    QuarticEaseIn=7,
    QuarticEaseOut=8,
    QuarticEaseInOut=9,
    QuinticEaseIn=10,
    QuinticEaseOut=11,
    QuinticEaseInOut=12,
    SineEaseIn=13,
    SineEaseOut=14,
    SineEaseInOut=15,
    CircularEaseIn=16,
    CircularEaseOut=17,
    CircularEaseInOut=18,
    ExponentialEaseIn=19,
    ExponentialEaseOut=20,
    ExponentialEaseInOut=21,
    ElasticEaseIn=22,
    ElasticEaseOut=23,
    ElasticEaseInOut=24,
    BackEaseIn=25,
    BackEaseOut=26,
    BackEaseInOut=27,
    BounceEaseIn=28,
    BounceEaseOut=29,
    BounceEaseInOut=30,
}