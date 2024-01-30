﻿using System.Runtime.InteropServices;
using System.Text;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;

namespace UnrealSharp;

[UStruct(IsBlittable=true), StructLayout(LayoutKind.Sequential)]
public struct Name : IEquatable<Name>, IComparable<Name>
{
    private int ComparisonIndex;
    private int DisplayIndex;
    private int Number;
    
    public static readonly Name None = new(0, 0);
    
    public Name(string name)
    {
        unsafe
        {
            fixed (char* stringPtr = name)
            {
                FNameExporter.CallStringToName(ref this, (IntPtr) stringPtr);
            }
        }
    }

    private Name(int comparisonIndex, int number)
    {
        ComparisonIndex = comparisonIndex;
        Number = number;
    }

    public override string ToString()
    {
        unsafe
        {
            UnmanagedArray buffer = new UnmanagedArray();
            FNameExporter.CallNameToString(this, ref buffer);
            return new string((char*) buffer.Data);
        }
    }
    
    public bool IsValid()
    {
        return FNameExporter.CallIsValid(this);
    }
    
    public bool IsNone()
    {
        return this == None;
    }
    
    public static bool operator == (Name lhs, Name rhs)
    {
        return lhs.ComparisonIndex == rhs.ComparisonIndex && lhs.Number == rhs.Number;
    }
    
    public static bool operator != (Name lhs, Name rhs)
    {
        return !(lhs == rhs);
    }
    
    public static implicit operator Name(string name)
    {
        return string.IsNullOrEmpty(name) ? None : new Name(name);
    }
    
    public bool Equals(Name other)
    {
        return this == other;
    }
    
    public override bool Equals(object obj)
    {
        if (obj is Name name)
        {
            return this == name;
        }

        return false;
    }
    
    public override int GetHashCode()
    {
        return ComparisonIndex;
    }
    
    public int CompareTo(Name other)
    {
        int diff = ComparisonIndex - other.ComparisonIndex;
        
        if (diff != 0)
        {
            return diff;
        }
        
        return Number - other.Number;
    }
}