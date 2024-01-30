using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.LocationServicesBPLibrary;

[UStruct(IsBlittable = true)]
public partial struct LocationServicesData
{
    // FloatProperty /Script/LocationServicesBPLibrary.LocationServicesData:Timestamp
    public float Timestamp;
    
    // FloatProperty /Script/LocationServicesBPLibrary.LocationServicesData:Longitude
    public float Longitude;
    
    // FloatProperty /Script/LocationServicesBPLibrary.LocationServicesData:Latitude
    public float Latitude;
    
    // FloatProperty /Script/LocationServicesBPLibrary.LocationServicesData:HorizontalAccuracy
    public float HorizontalAccuracy;
    
    // FloatProperty /Script/LocationServicesBPLibrary.LocationServicesData:VerticalAccuracy
    public float VerticalAccuracy;
    
    // FloatProperty /Script/LocationServicesBPLibrary.LocationServicesData:Altitude
    public float Altitude;
    
}