// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.Paper2D;

[UClass]
public partial class PaperTileMap : UnrealSharp.CoreUObject.Object
{
    
    static PaperTileMap()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("PaperTileMap");
        
        MapWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MapWidth");
        MapHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "MapHeight");
        TileWidth_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TileWidth");
        TileHeight_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TileHeight");
        SeparationPerLayer_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SeparationPerLayer");
        Material_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "Material");
        TileLayers_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "TileLayers");
        TileLayers_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "TileLayers");
        CollisionThickness_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CollisionThickness");
        SpriteCollisionDomain_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "SpriteCollisionDomain");
        ProjectionMode_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "ProjectionMode");
        
        
        
    }
    
    protected PaperTileMap(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // IntProperty /Script/Paper2D.PaperTileMap:MapWidth
    static readonly int MapWidth_Offset;
    
    public int MapWidth
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MapWidth_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Paper2D.PaperTileMap:MapHeight
    static readonly int MapHeight_Offset;
    
    public int MapHeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, MapHeight_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Paper2D.PaperTileMap:TileWidth
    static readonly int TileWidth_Offset;
    
    public int TileWidth
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, TileWidth_Offset), 0, this);
        }
    }
    
    // IntProperty /Script/Paper2D.PaperTileMap:TileHeight
    static readonly int TileHeight_Offset;
    
    public int TileHeight
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<int>.FromNative(IntPtr.Add(NativeObject, TileHeight_Offset), 0, this);
        }
    }
    
    // FloatProperty /Script/Paper2D.PaperTileMap:SeparationPerLayer
    static readonly int SeparationPerLayer_Offset;
    
    public float SeparationPerLayer
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, SeparationPerLayer_Offset), 0, this);
        }
    }
    
    // ObjectProperty /Script/Paper2D.PaperTileMap:Material
    static readonly int Material_Offset;
    
    public UnrealSharp.Engine.MaterialInterface Material
    {
        get
        {
            CheckObjectForValidity();
            return ObjectMarshaller<UnrealSharp.Engine.MaterialInterface>.FromNative(IntPtr.Add(NativeObject, Material_Offset), 0, this);
        }
    }
    
    // ArrayProperty /Script/Paper2D.PaperTileMap:TileLayers
    static readonly int TileLayers_Offset;
    static readonly IntPtr TileLayers_NativeProperty;
    UnrealArrayReadOnlyMarshaler<UnrealSharp.Paper2D.PaperTileLayer> TileLayers_Wrapper = null;
    
    public System.Collections.Generic.IReadOnlyList<UnrealSharp.Paper2D.PaperTileLayer> TileLayers
    {
        get
        {
            if(TileLayers_Wrapper == null)
            {
                TileLayers_Wrapper = new UnrealArrayReadOnlyMarshaler<UnrealSharp.Paper2D.PaperTileLayer>(1, TileLayers_NativeProperty, ObjectMarshaller<UnrealSharp.Paper2D.PaperTileLayer>.ToNative, ObjectMarshaller<UnrealSharp.Paper2D.PaperTileLayer>.FromNative);
            }
            
            return TileLayers_Wrapper.FromNative(IntPtr.Add(NativeObject,TileLayers_Offset),0,this);
        }
    }
    
    // FloatProperty /Script/Paper2D.PaperTileMap:CollisionThickness
    static readonly int CollisionThickness_Offset;
    
    public float CollisionThickness
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, CollisionThickness_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/Paper2D.PaperTileMap:SpriteCollisionDomain
    static readonly int SpriteCollisionDomain_Offset;
    
    public UnrealSharp.Paper2D.ESpriteCollisionMode SpriteCollisionDomain
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Paper2D.ESpriteCollisionMode>.FromNative(IntPtr.Add(NativeObject, SpriteCollisionDomain_Offset), 0, this);
        }
    }
    
    // ByteProperty /Script/Paper2D.PaperTileMap:ProjectionMode
    static readonly int ProjectionMode_Offset;
    
    public UnrealSharp.Paper2D.ETileMapProjectionMode ProjectionMode
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<UnrealSharp.Paper2D.ETileMapProjectionMode>.FromNative(IntPtr.Add(NativeObject, ProjectionMode_Offset), 0, this);
        }
    }
    
    
}