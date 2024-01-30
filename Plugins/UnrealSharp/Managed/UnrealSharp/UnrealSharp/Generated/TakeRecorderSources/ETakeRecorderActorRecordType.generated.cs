using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.TakeRecorderSources;

[UEnum]
public enum ETakeRecorderActorRecordType : byte
{
    Possessable=0,
    Spawnable=1,
    ProjectDefault=2,
}