using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.FieldNotification;

[UStruct(IsBlittable = true)]
public partial struct FieldNotificationId
{
    // NameProperty /Script/FieldNotification.FieldNotificationId:FieldName
    public Name FieldName;
    
}