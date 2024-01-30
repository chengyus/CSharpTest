using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LevelSequenceEditor;

[UStruct(IsBlittable = true)]
public partial struct MovieSceneScriptingParams
{
    // EnumProperty /Script/LevelSequenceEditor.MovieSceneScriptingParams:TimeUnit
    public UnrealSharp.SequencerScripting.ESequenceTimeUnit TimeUnit;
    
}