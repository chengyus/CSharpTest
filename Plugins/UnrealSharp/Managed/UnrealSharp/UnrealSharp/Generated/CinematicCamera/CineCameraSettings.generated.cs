// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.CinematicCamera;

[UClass]
public partial class CineCameraSettings : UnrealSharp.DeveloperSettings.DeveloperSettings
{
    
    static readonly IntPtr NativeClassPtr;
    static CineCameraSettings()
    {
        NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("CineCameraSettings");
        
        DefaultLensPresetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultLensPresetName");
        DefaultLensPresetName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DefaultLensPresetName");
        DefaultLensFocalLength_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultLensFocalLength");
        DefaultLensFStop_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultLensFStop");
        LensPresets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "LensPresets");
        LensPresets_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "LensPresets");
        DefaultFilmbackPreset_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultFilmbackPreset");
        DefaultFilmbackPreset_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DefaultFilmbackPreset");
        FilmbackPresets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "FilmbackPresets");
        FilmbackPresets_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "FilmbackPresets");
        DefaultCropPresetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "DefaultCropPresetName");
        DefaultCropPresetName_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "DefaultCropPresetName");
        CropPresets_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(NativeClassPtr, "CropPresets");
        CropPresets_NativeProperty = FPropertyExporter.CallGetNativePropertyFromName(NativeClassPtr, "CropPresets");
        
        GetLensPresetByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetLensPresetByName");
        GetLensPresetByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetLensPresetByName_NativeFunction);
        GetLensPresetByName_PresetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLensPresetByName_NativeFunction, "PresetName");
        GetLensPresetByName_LensSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLensPresetByName_NativeFunction, "LensSettings");
        GetLensPresetByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetLensPresetByName_NativeFunction, "ReturnValue");
        GetFilmbackPresetByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetFilmbackPresetByName");
        GetFilmbackPresetByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetFilmbackPresetByName_NativeFunction);
        GetFilmbackPresetByName_PresetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFilmbackPresetByName_NativeFunction, "PresetName");
        GetFilmbackPresetByName_FilmbackSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFilmbackPresetByName_NativeFunction, "FilmbackSettings");
        GetFilmbackPresetByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetFilmbackPresetByName_NativeFunction, "ReturnValue");
        GetCropPresetByName_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCropPresetByName");
        GetCropPresetByName_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCropPresetByName_NativeFunction);
        GetCropPresetByName_PresetName_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCropPresetByName_NativeFunction, "PresetName");
        GetCropPresetByName_CropSettings_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCropPresetByName_NativeFunction, "CropSettings");
        GetCropPresetByName_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCropPresetByName_NativeFunction, "ReturnValue");
        GetCineCameraSettings_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetCineCameraSettings");
        GetCineCameraSettings_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetCineCameraSettings_NativeFunction);
        GetCineCameraSettings_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetCineCameraSettings_NativeFunction, "ReturnValue");
        
        
    }
    
    protected CineCameraSettings(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // StrProperty /Script/CinematicCamera.CineCameraSettings:DefaultLensPresetName
    static readonly int DefaultLensPresetName_Offset;
    static readonly IntPtr DefaultLensPresetName_NativeProperty;
    
    public string DefaultLensPresetName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,DefaultLensPresetName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,DefaultLensPresetName_Offset),0,this,value);
        }
    }
    
    // FloatProperty /Script/CinematicCamera.CineCameraSettings:DefaultLensFocalLength
    static readonly int DefaultLensFocalLength_Offset;
    
    public float DefaultLensFocalLength
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DefaultLensFocalLength_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DefaultLensFocalLength_Offset), 0, this, value);
        }
    }
    
    // FloatProperty /Script/CinematicCamera.CineCameraSettings:DefaultLensFStop
    static readonly int DefaultLensFStop_Offset;
    
    public float DefaultLensFStop
    {
        get
        {
            CheckObjectForValidity();
            return BlittableMarshaller<float>.FromNative(IntPtr.Add(NativeObject, DefaultLensFStop_Offset), 0, this);
        }
        set
        {
            CheckObjectForValidity();
            BlittableMarshaller<float>.ToNative(IntPtr.Add(NativeObject, DefaultLensFStop_Offset), 0, this, value);
        }
    }
    
    // ArrayProperty /Script/CinematicCamera.CineCameraSettings:LensPresets
    static readonly int LensPresets_Offset;
    static readonly IntPtr LensPresets_NativeProperty;
    UnrealArrayReadWriteMarshaler<UnrealSharp.CinematicCamera.NamedLensPreset> LensPresets_Wrapper = null;
    
    public System.Collections.Generic.IList<UnrealSharp.CinematicCamera.NamedLensPreset> LensPresets
    {
        get
        {
            if(LensPresets_Wrapper == null)
            {
                LensPresets_Wrapper = new UnrealArrayReadWriteMarshaler<UnrealSharp.CinematicCamera.NamedLensPreset>(1, LensPresets_NativeProperty, UnrealSharp.CinematicCamera.NamedLensPresetMarshaler.ToNative, UnrealSharp.CinematicCamera.NamedLensPresetMarshaler.FromNative);
            }
            
            return LensPresets_Wrapper.FromNative(IntPtr.Add(NativeObject,LensPresets_Offset),0,this);
        }
    }
    
    // StrProperty /Script/CinematicCamera.CineCameraSettings:DefaultFilmbackPreset
    static readonly int DefaultFilmbackPreset_Offset;
    static readonly IntPtr DefaultFilmbackPreset_NativeProperty;
    
    public string DefaultFilmbackPreset
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,DefaultFilmbackPreset_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,DefaultFilmbackPreset_Offset),0,this,value);
        }
    }
    
    // ArrayProperty /Script/CinematicCamera.CineCameraSettings:FilmbackPresets
    static readonly int FilmbackPresets_Offset;
    static readonly IntPtr FilmbackPresets_NativeProperty;
    UnrealArrayReadWriteMarshaler<UnrealSharp.CinematicCamera.NamedFilmbackPreset> FilmbackPresets_Wrapper = null;
    
    public System.Collections.Generic.IList<UnrealSharp.CinematicCamera.NamedFilmbackPreset> FilmbackPresets
    {
        get
        {
            if(FilmbackPresets_Wrapper == null)
            {
                FilmbackPresets_Wrapper = new UnrealArrayReadWriteMarshaler<UnrealSharp.CinematicCamera.NamedFilmbackPreset>(1, FilmbackPresets_NativeProperty, UnrealSharp.CinematicCamera.NamedFilmbackPresetMarshaler.ToNative, UnrealSharp.CinematicCamera.NamedFilmbackPresetMarshaler.FromNative);
            }
            
            return FilmbackPresets_Wrapper.FromNative(IntPtr.Add(NativeObject,FilmbackPresets_Offset),0,this);
        }
    }
    
    // StrProperty /Script/CinematicCamera.CineCameraSettings:DefaultCropPresetName
    static readonly int DefaultCropPresetName_Offset;
    static readonly IntPtr DefaultCropPresetName_NativeProperty;
    
    public string DefaultCropPresetName
    {
        get
        {
            CheckObjectForValidity();
            return StringMarshaller.FromNative(IntPtr.Add(NativeObject,DefaultCropPresetName_Offset),0,this);
        }
        set
        {
            CheckObjectForValidity();
            StringMarshaller.ToNative(IntPtr.Add(NativeObject,DefaultCropPresetName_Offset),0,this,value);
        }
    }
    
    // ArrayProperty /Script/CinematicCamera.CineCameraSettings:CropPresets
    static readonly int CropPresets_Offset;
    static readonly IntPtr CropPresets_NativeProperty;
    UnrealArrayReadWriteMarshaler<UnrealSharp.CinematicCamera.NamedPlateCropPreset> CropPresets_Wrapper = null;
    
    public System.Collections.Generic.IList<UnrealSharp.CinematicCamera.NamedPlateCropPreset> CropPresets
    {
        get
        {
            if(CropPresets_Wrapper == null)
            {
                CropPresets_Wrapper = new UnrealArrayReadWriteMarshaler<UnrealSharp.CinematicCamera.NamedPlateCropPreset>(1, CropPresets_NativeProperty, UnrealSharp.CinematicCamera.NamedPlateCropPresetMarshaler.ToNative, UnrealSharp.CinematicCamera.NamedPlateCropPresetMarshaler.FromNative);
            }
            
            return CropPresets_Wrapper.FromNative(IntPtr.Add(NativeObject,CropPresets_Offset),0,this);
        }
    }
    
    // Function /Script/CinematicCamera.CineCameraSettings:GetLensPresetByName
    static readonly IntPtr GetLensPresetByName_NativeFunction;
    static readonly int GetLensPresetByName_ParamsSize;
    static readonly int GetLensPresetByName_PresetName_Offset;
    static readonly int GetLensPresetByName_LensSettings_Offset;
    static readonly int GetLensPresetByName_ReturnValue_Offset;
    
    public bool GetLensPresetByName(string presetName, out UnrealSharp.CinematicCamera.CameraLensSettings lensSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetLensPresetByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr PresetName_NativePtr = IntPtr.Add(ParamsBuffer,GetLensPresetByName_PresetName_Offset);
            StringMarshaller.ToNative(PresetName_NativePtr,0,null,presetName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetLensPresetByName_NativeFunction, ParamsBuffer);
            
            lensSettings = BlittableMarshaller<UnrealSharp.CinematicCamera.CameraLensSettings>.FromNative(IntPtr.Add(ParamsBuffer, GetLensPresetByName_LensSettings_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetLensPresetByName_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(PresetName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/CinematicCamera.CineCameraSettings:GetFilmbackPresetByName
    static readonly IntPtr GetFilmbackPresetByName_NativeFunction;
    static readonly int GetFilmbackPresetByName_ParamsSize;
    static readonly int GetFilmbackPresetByName_PresetName_Offset;
    static readonly int GetFilmbackPresetByName_FilmbackSettings_Offset;
    static readonly int GetFilmbackPresetByName_ReturnValue_Offset;
    
    public bool GetFilmbackPresetByName(string presetName, out UnrealSharp.CinematicCamera.CameraFilmbackSettings filmbackSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetFilmbackPresetByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr PresetName_NativePtr = IntPtr.Add(ParamsBuffer,GetFilmbackPresetByName_PresetName_Offset);
            StringMarshaller.ToNative(PresetName_NativePtr,0,null,presetName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetFilmbackPresetByName_NativeFunction, ParamsBuffer);
            
            filmbackSettings = BlittableMarshaller<UnrealSharp.CinematicCamera.CameraFilmbackSettings>.FromNative(IntPtr.Add(ParamsBuffer, GetFilmbackPresetByName_FilmbackSettings_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetFilmbackPresetByName_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(PresetName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/CinematicCamera.CineCameraSettings:GetCropPresetByName
    static readonly IntPtr GetCropPresetByName_NativeFunction;
    static readonly int GetCropPresetByName_ParamsSize;
    static readonly int GetCropPresetByName_PresetName_Offset;
    static readonly int GetCropPresetByName_CropSettings_Offset;
    static readonly int GetCropPresetByName_ReturnValue_Offset;
    
    public bool GetCropPresetByName(string presetName, out UnrealSharp.CinematicCamera.PlateCropSettings cropSettings)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCropPresetByName_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr PresetName_NativePtr = IntPtr.Add(ParamsBuffer,GetCropPresetByName_PresetName_Offset);
            StringMarshaller.ToNative(PresetName_NativePtr,0,null,presetName);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetCropPresetByName_NativeFunction, ParamsBuffer);
            
            cropSettings = BlittableMarshaller<UnrealSharp.CinematicCamera.PlateCropSettings>.FromNative(IntPtr.Add(ParamsBuffer, GetCropPresetByName_CropSettings_Offset), 0, null);
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, GetCropPresetByName_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(PresetName_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/CinematicCamera.CineCameraSettings:GetCineCameraSettings
    static readonly IntPtr GetCineCameraSettings_NativeFunction;
    static readonly int GetCineCameraSettings_ParamsSize;
    static readonly int GetCineCameraSettings_ReturnValue_Offset;
    
    public static UnrealSharp.CinematicCamera.CineCameraSettings GetCineCameraSettings()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetCineCameraSettings_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeStaticFunction(NativeClassPtr, GetCineCameraSettings_NativeFunction, ParamsBuffer);
            
            UnrealSharp.CinematicCamera.CineCameraSettings returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.CinematicCamera.CineCameraSettings>.FromNative(IntPtr.Add(ParamsBuffer, GetCineCameraSettings_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}