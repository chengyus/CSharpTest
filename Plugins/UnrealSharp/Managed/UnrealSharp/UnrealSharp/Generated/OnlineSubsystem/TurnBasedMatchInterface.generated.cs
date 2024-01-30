using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.OnlineSubsystem;

public partial interface ITurnBasedMatchInterface
{
    public void OnMatchReceivedTurn(string match, bool bDidBecomeActive);
    public void OnMatchEnded(string match);
}