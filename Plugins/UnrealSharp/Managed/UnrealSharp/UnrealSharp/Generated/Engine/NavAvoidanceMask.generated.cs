using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Engine;

[UStruct]
public partial struct NavAvoidanceMask
{
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup0
    static readonly int bGroup0_Offset;
    static readonly IntPtr bGroup0_NativeProperty;
    public bool Group0;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup1
    static readonly int bGroup1_Offset;
    static readonly IntPtr bGroup1_NativeProperty;
    public bool Group1;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup2
    static readonly int bGroup2_Offset;
    static readonly IntPtr bGroup2_NativeProperty;
    public bool Group2;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup3
    static readonly int bGroup3_Offset;
    static readonly IntPtr bGroup3_NativeProperty;
    public bool Group3;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup4
    static readonly int bGroup4_Offset;
    static readonly IntPtr bGroup4_NativeProperty;
    public bool Group4;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup5
    static readonly int bGroup5_Offset;
    static readonly IntPtr bGroup5_NativeProperty;
    public bool Group5;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup6
    static readonly int bGroup6_Offset;
    static readonly IntPtr bGroup6_NativeProperty;
    public bool Group6;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup7
    static readonly int bGroup7_Offset;
    static readonly IntPtr bGroup7_NativeProperty;
    public bool Group7;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup8
    static readonly int bGroup8_Offset;
    static readonly IntPtr bGroup8_NativeProperty;
    public bool Group8;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup9
    static readonly int bGroup9_Offset;
    static readonly IntPtr bGroup9_NativeProperty;
    public bool Group9;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup10
    static readonly int bGroup10_Offset;
    static readonly IntPtr bGroup10_NativeProperty;
    public bool Group10;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup11
    static readonly int bGroup11_Offset;
    static readonly IntPtr bGroup11_NativeProperty;
    public bool Group11;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup12
    static readonly int bGroup12_Offset;
    static readonly IntPtr bGroup12_NativeProperty;
    public bool Group12;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup13
    static readonly int bGroup13_Offset;
    static readonly IntPtr bGroup13_NativeProperty;
    public bool Group13;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup14
    static readonly int bGroup14_Offset;
    static readonly IntPtr bGroup14_NativeProperty;
    public bool Group14;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup15
    static readonly int bGroup15_Offset;
    static readonly IntPtr bGroup15_NativeProperty;
    public bool Group15;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup16
    static readonly int bGroup16_Offset;
    static readonly IntPtr bGroup16_NativeProperty;
    public bool Group16;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup17
    static readonly int bGroup17_Offset;
    static readonly IntPtr bGroup17_NativeProperty;
    public bool Group17;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup18
    static readonly int bGroup18_Offset;
    static readonly IntPtr bGroup18_NativeProperty;
    public bool Group18;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup19
    static readonly int bGroup19_Offset;
    static readonly IntPtr bGroup19_NativeProperty;
    public bool Group19;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup20
    static readonly int bGroup20_Offset;
    static readonly IntPtr bGroup20_NativeProperty;
    public bool Group20;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup21
    static readonly int bGroup21_Offset;
    static readonly IntPtr bGroup21_NativeProperty;
    public bool Group21;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup22
    static readonly int bGroup22_Offset;
    static readonly IntPtr bGroup22_NativeProperty;
    public bool Group22;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup23
    static readonly int bGroup23_Offset;
    static readonly IntPtr bGroup23_NativeProperty;
    public bool Group23;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup24
    static readonly int bGroup24_Offset;
    static readonly IntPtr bGroup24_NativeProperty;
    public bool Group24;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup25
    static readonly int bGroup25_Offset;
    static readonly IntPtr bGroup25_NativeProperty;
    public bool Group25;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup26
    static readonly int bGroup26_Offset;
    static readonly IntPtr bGroup26_NativeProperty;
    public bool Group26;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup27
    static readonly int bGroup27_Offset;
    static readonly IntPtr bGroup27_NativeProperty;
    public bool Group27;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup28
    static readonly int bGroup28_Offset;
    static readonly IntPtr bGroup28_NativeProperty;
    public bool Group28;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup29
    static readonly int bGroup29_Offset;
    static readonly IntPtr bGroup29_NativeProperty;
    public bool Group29;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup30
    static readonly int bGroup30_Offset;
    static readonly IntPtr bGroup30_NativeProperty;
    public bool Group30;
    
    // BoolProperty /Script/Engine.NavAvoidanceMask:bGroup31
    static readonly int bGroup31_Offset;
    static readonly IntPtr bGroup31_NativeProperty;
    public bool Group31;
    
    
    public static readonly int NativeDataSize;
    static NavAvoidanceMask()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeStructFromName("NavAvoidanceMask");
        
        bGroup0_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup0");
        bGroup0_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup0");
        bGroup1_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup1");
        bGroup1_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup1");
        bGroup2_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup2");
        bGroup2_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup2");
        bGroup3_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup3");
        bGroup3_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup3");
        bGroup4_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup4");
        bGroup4_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup4");
        bGroup5_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup5");
        bGroup5_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup5");
        bGroup6_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup6");
        bGroup6_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup6");
        bGroup7_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup7");
        bGroup7_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup7");
        bGroup8_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup8");
        bGroup8_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup8");
        bGroup9_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup9");
        bGroup9_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup9");
        bGroup10_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup10");
        bGroup10_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup10");
        bGroup11_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup11");
        bGroup11_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup11");
        bGroup12_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup12");
        bGroup12_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup12");
        bGroup13_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup13");
        bGroup13_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup13");
        bGroup14_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup14");
        bGroup14_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup14");
        bGroup15_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup15");
        bGroup15_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup15");
        bGroup16_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup16");
        bGroup16_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup16");
        bGroup17_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup17");
        bGroup17_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup17");
        bGroup18_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup18");
        bGroup18_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup18");
        bGroup19_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup19");
        bGroup19_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup19");
        bGroup20_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup20");
        bGroup20_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup20");
        bGroup21_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup21");
        bGroup21_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup21");
        bGroup22_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup22");
        bGroup22_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup22");
        bGroup23_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup23");
        bGroup23_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup23");
        bGroup24_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup24");
        bGroup24_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup24");
        bGroup25_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup25");
        bGroup25_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup25");
        bGroup26_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup26");
        bGroup26_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup26");
        bGroup27_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup27");
        bGroup27_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup27");
        bGroup28_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup28");
        bGroup28_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup28");
        bGroup29_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup29");
        bGroup29_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup29");
        bGroup30_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup30");
        bGroup30_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup30");
        bGroup31_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "bGroup31");
        bGroup31_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "bGroup31");
        
        NativeDataSize = UScriptStructExporter.CallGetNativeStructSize(NativeClassPtr);
    }
    
    
    // Construct by marshalling from a native buffer.
    public NavAvoidanceMask(IntPtr InNativeStruct)
    {
        unsafe
        {
            Group0 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup0_NativeProperty, bGroup0_Offset);
            Group1 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup1_NativeProperty, bGroup1_Offset);
            Group2 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup2_NativeProperty, bGroup2_Offset);
            Group3 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup3_NativeProperty, bGroup3_Offset);
            Group4 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup4_NativeProperty, bGroup4_Offset);
            Group5 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup5_NativeProperty, bGroup5_Offset);
            Group6 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup6_NativeProperty, bGroup6_Offset);
            Group7 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup7_NativeProperty, bGroup7_Offset);
            Group8 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup8_NativeProperty, bGroup8_Offset);
            Group9 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup9_NativeProperty, bGroup9_Offset);
            Group10 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup10_NativeProperty, bGroup10_Offset);
            Group11 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup11_NativeProperty, bGroup11_Offset);
            Group12 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup12_NativeProperty, bGroup12_Offset);
            Group13 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup13_NativeProperty, bGroup13_Offset);
            Group14 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup14_NativeProperty, bGroup14_Offset);
            Group15 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup15_NativeProperty, bGroup15_Offset);
            Group16 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup16_NativeProperty, bGroup16_Offset);
            Group17 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup17_NativeProperty, bGroup17_Offset);
            Group18 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup18_NativeProperty, bGroup18_Offset);
            Group19 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup19_NativeProperty, bGroup19_Offset);
            Group20 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup20_NativeProperty, bGroup20_Offset);
            Group21 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup21_NativeProperty, bGroup21_Offset);
            Group22 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup22_NativeProperty, bGroup22_Offset);
            Group23 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup23_NativeProperty, bGroup23_Offset);
            Group24 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup24_NativeProperty, bGroup24_Offset);
            Group25 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup25_NativeProperty, bGroup25_Offset);
            Group26 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup26_NativeProperty, bGroup26_Offset);
            Group27 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup27_NativeProperty, bGroup27_Offset);
            Group28 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup28_NativeProperty, bGroup28_Offset);
            Group29 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup29_NativeProperty, bGroup29_Offset);
            Group30 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup30_NativeProperty, bGroup30_Offset);
            Group31 = FBoolPropertyExporter.CallGetBitfieldValueFromProperty(InNativeStruct, bGroup31_NativeProperty, bGroup31_Offset);
        }
    }
    
    // Marshal into a preallocated native buffer.
    public void ToNative(IntPtr Buffer)
    {
        unsafe
        {
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup0_NativeProperty, bGroup0_Offset, Group0);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup1_NativeProperty, bGroup1_Offset, Group1);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup2_NativeProperty, bGroup2_Offset, Group2);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup3_NativeProperty, bGroup3_Offset, Group3);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup4_NativeProperty, bGroup4_Offset, Group4);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup5_NativeProperty, bGroup5_Offset, Group5);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup6_NativeProperty, bGroup6_Offset, Group6);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup7_NativeProperty, bGroup7_Offset, Group7);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup8_NativeProperty, bGroup8_Offset, Group8);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup9_NativeProperty, bGroup9_Offset, Group9);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup10_NativeProperty, bGroup10_Offset, Group10);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup11_NativeProperty, bGroup11_Offset, Group11);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup12_NativeProperty, bGroup12_Offset, Group12);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup13_NativeProperty, bGroup13_Offset, Group13);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup14_NativeProperty, bGroup14_Offset, Group14);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup15_NativeProperty, bGroup15_Offset, Group15);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup16_NativeProperty, bGroup16_Offset, Group16);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup17_NativeProperty, bGroup17_Offset, Group17);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup18_NativeProperty, bGroup18_Offset, Group18);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup19_NativeProperty, bGroup19_Offset, Group19);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup20_NativeProperty, bGroup20_Offset, Group20);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup21_NativeProperty, bGroup21_Offset, Group21);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup22_NativeProperty, bGroup22_Offset, Group22);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup23_NativeProperty, bGroup23_Offset, Group23);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup24_NativeProperty, bGroup24_Offset, Group24);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup25_NativeProperty, bGroup25_Offset, Group25);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup26_NativeProperty, bGroup26_Offset, Group26);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup27_NativeProperty, bGroup27_Offset, Group27);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup28_NativeProperty, bGroup28_Offset, Group28);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup29_NativeProperty, bGroup29_Offset, Group29);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup30_NativeProperty, bGroup30_Offset, Group30);
            FBoolPropertyExporter.CallSetBitfieldValueForProperty(Buffer, bGroup31_NativeProperty, bGroup31_Offset, Group31);
        }
    }
}

public static class NavAvoidanceMaskMarshaler
{
    public static NavAvoidanceMask FromNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner)
    {
        return new NavAvoidanceMask(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static void ToNative(IntPtr nativeBuffer, int arrayIndex, UnrealSharpObject owner, NavAvoidanceMask obj)
    {
        obj.ToNative(nativeBuffer + arrayIndex * GetNativeDataSize());
    }
    
    public static int GetNativeDataSize()
    {
        return NavAvoidanceMask.NativeDataSize;
    }
}