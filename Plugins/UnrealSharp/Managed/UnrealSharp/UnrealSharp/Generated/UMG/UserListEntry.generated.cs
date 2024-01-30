using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.UMG;

public partial interface IUserListEntry
{
    public void BP_OnItemSelectionChanged(bool bIsSelected);
    public void BP_OnItemExpansionChanged(bool bIsExpanded);
    public void BP_OnEntryReleased();
}