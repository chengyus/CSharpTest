using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

public partial interface IUserObjectListEntry
{
    public void OnListItemObjectSet(UnrealSharp.CoreUObject.Object listItemObject);
}