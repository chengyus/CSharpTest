using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CoreUObject;

[UEnum]
public enum EUnit : byte
{
    Micrometers=0,
    Millimeters=1,
    Centimeters=2,
    Meters=3,
    Kilometers=4,
    Inches=5,
    Feet=6,
    Yards=7,
    Miles=8,
    Lightyears=9,
    Degrees=10,
    Radians=11,
    CentimetersPerSecond=12,
    MetersPerSecond=13,
    KilometersPerHour=14,
    MilesPerHour=15,
    Celsius=16,
    Farenheit=17,
    Kelvin=18,
    Micrograms=19,
    Milligrams=20,
    Grams=21,
    Kilograms=22,
    MetricTons=23,
    Ounces=24,
    Pounds=25,
    Stones=26,
    Newtons=27,
    PoundsForce=28,
    KilogramsForce=29,
    KilogramCentimetersPerSecondSquared=30,
    NewtonMeters=31,
    KilogramCentimetersSquaredPerSecondSquared=32,
    Hertz=33,
    Kilohertz=34,
    Megahertz=35,
    Gigahertz=36,
    RevolutionsPerMinute=37,
    Bytes=38,
    Kilobytes=39,
    Megabytes=40,
    Gigabytes=41,
    Terabytes=42,
    Lumens=43,
    Milliseconds=44,
    Seconds=45,
    Minutes=46,
    Hours=47,
    Days=48,
    Months=49,
    Years=50,
    Multiplier=51,
    Percentage=52,
    Unspecified=53,
}