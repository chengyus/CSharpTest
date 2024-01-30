using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.GooglePAD;

[UEnum]
public enum EGooglePADStorageMethod : byte
{
    AssetPack_STORAGE_FILES=0,
    AssetPack_STORAGE_APK=1,
    AssetPack_STORAGE_UNKNOWN=2,
    AssetPack_STORAGE_NOT_INSTALLED=3,
}