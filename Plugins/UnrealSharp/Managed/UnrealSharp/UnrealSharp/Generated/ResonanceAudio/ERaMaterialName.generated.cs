using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.ResonanceAudio;

[UEnum]
public enum ERaMaterialName : byte
{
    TRANSPARENT=0,
    ACOUSTIC_CEILING_TILES=1,
    BRICK_BARE=2,
    BRICK_PAINTED=3,
    CONCRETE_BLOCK_COARSE=4,
    CONCRETE_BLOCK_PAINTED=5,
    CURTAIN_HEAVY=6,
    FIBER_GLASS_INSULATION=7,
    GLASS_THIN=8,
    GLASS_THICK=9,
    GRASS=10,
    LINOLEUM_ON_CONCRETE=11,
    MARBLE=12,
    METAL=13,
    PARQUET_ONCONCRETE=14,
    PLASTER_ROUGH=15,
    PLASTER_SMOOTH=16,
    PLYWOOD_PANEL=17,
    POLISHED_CONCRETE_OR_TILE=18,
    SHEETROCK=19,
    WATER_OR_ICE_SURFACE=20,
    WOOD_CEILING=21,
    WOOD_PANEL=22,
    UNIFORM=23,
}