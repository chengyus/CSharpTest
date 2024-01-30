// This file is automatically generated
using UnrealSharp.Engine;
using UnrealSharp.Attributes;
using UnrealSharp.Interop;
using System.DoubleNumerics;
using System.Runtime;
using System.Runtime.InteropServices;

namespace UnrealSharp.MediaAssets;

[UClass]
public partial class MediaPlaylist : UnrealSharp.CoreUObject.Object
{
    
    static MediaPlaylist()
    {
        IntPtr NativeClassPtr = UCoreUObjectExporter.CallGetNativeClassFromName("MediaPlaylist");
        
        
        Replace_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Replace");
        Replace_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Replace_NativeFunction);
        Replace_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Replace_NativeFunction, "Index");
        Replace_Replacement_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Replace_NativeFunction, "Replacement");
        Replace_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Replace_NativeFunction, "ReturnValue");
        RemoveAt_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "RemoveAt");
        RemoveAt_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(RemoveAt_NativeFunction);
        RemoveAt_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveAt_NativeFunction, "Index");
        RemoveAt_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(RemoveAt_NativeFunction, "ReturnValue");
        Remove_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Remove");
        Remove_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Remove_NativeFunction);
        Remove_MediaSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Remove_NativeFunction, "MediaSource");
        Remove_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Remove_NativeFunction, "ReturnValue");
        Num_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Num");
        Num_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Num_NativeFunction);
        Num_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Num_NativeFunction, "ReturnValue");
        Insert_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Insert");
        Insert_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Insert_NativeFunction);
        Insert_MediaSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Insert_NativeFunction, "MediaSource");
        Insert_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Insert_NativeFunction, "Index");
        GetRandom_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetRandom");
        GetRandom_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetRandom_NativeFunction);
        GetRandom_OutIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRandom_NativeFunction, "OutIndex");
        GetRandom_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetRandom_NativeFunction, "ReturnValue");
        GetPrevious_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetPrevious");
        GetPrevious_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetPrevious_NativeFunction);
        GetPrevious_InOutIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPrevious_NativeFunction, "InOutIndex");
        GetPrevious_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetPrevious_NativeFunction, "ReturnValue");
        GetNext_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "GetNext");
        GetNext_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(GetNext_NativeFunction);
        GetNext_InOutIndex_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNext_NativeFunction, "InOutIndex");
        GetNext_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(GetNext_NativeFunction, "ReturnValue");
        Get_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Get");
        Get_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Get_NativeFunction);
        Get_Index_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Get_NativeFunction, "Index");
        Get_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Get_NativeFunction, "ReturnValue");
        AddUrl_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddUrl");
        AddUrl_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddUrl_NativeFunction);
        AddUrl_Url_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddUrl_NativeFunction, "Url");
        AddUrl_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddUrl_NativeFunction, "ReturnValue");
        AddFile_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "AddFile");
        AddFile_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(AddFile_NativeFunction);
        AddFile_FilePath_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddFile_NativeFunction, "FilePath");
        AddFile_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(AddFile_NativeFunction, "ReturnValue");
        Add_NativeFunction = UClassExporter.CallGetNativeFunctionFromClassAndName(NativeClassPtr, "Add");
        Add_ParamsSize = UFunctionExporter.CallGetNativeFunctionParamsSize(Add_NativeFunction);
        Add_MediaSource_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_NativeFunction, "MediaSource");
        Add_ReturnValue_Offset = FPropertyExporter.CallGetPropertyOffsetFromName(Add_NativeFunction, "ReturnValue");
        
        
    }
    
    protected MediaPlaylist(IntPtr nativeObject) : base(nativeObject)
    {
    }
    // Function /Script/MediaAssets.MediaPlaylist:Replace
    static readonly IntPtr Replace_NativeFunction;
    static readonly int Replace_ParamsSize;
    static readonly int Replace_Index_Offset;
    static readonly int Replace_Replacement_Offset;
    static readonly int Replace_ReturnValue_Offset;
    
    public bool Replace(int index, UnrealSharp.MediaAssets.MediaSource replacement)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Replace_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Replace_Index_Offset), 0, null, index);
            ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.ToNative(IntPtr.Add(ParamsBuffer, Replace_Replacement_Offset), 0, null, replacement);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Replace_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, Replace_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:RemoveAt
    static readonly IntPtr RemoveAt_NativeFunction;
    static readonly int RemoveAt_ParamsSize;
    static readonly int RemoveAt_Index_Offset;
    static readonly int RemoveAt_ReturnValue_Offset;
    
    public bool RemoveAt(int index)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[RemoveAt_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, RemoveAt_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, RemoveAt_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, RemoveAt_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:Remove
    static readonly IntPtr Remove_NativeFunction;
    static readonly int Remove_ParamsSize;
    static readonly int Remove_MediaSource_Offset;
    static readonly int Remove_ReturnValue_Offset;
    
    public bool Remove(UnrealSharp.MediaAssets.MediaSource mediaSource)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Remove_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.ToNative(IntPtr.Add(ParamsBuffer, Remove_MediaSource_Offset), 0, null, mediaSource);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Remove_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, Remove_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:Num
    static readonly IntPtr Num_NativeFunction;
    static readonly int Num_ParamsSize;
    static readonly int Num_ReturnValue_Offset;
    
    public int Num()
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Num_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Num_NativeFunction, ParamsBuffer);
            
            int returnValue;
            returnValue = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, Num_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:Insert
    static readonly IntPtr Insert_NativeFunction;
    static readonly int Insert_ParamsSize;
    static readonly int Insert_MediaSource_Offset;
    static readonly int Insert_Index_Offset;
    
    public void Insert(UnrealSharp.MediaAssets.MediaSource mediaSource, int index)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Insert_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.ToNative(IntPtr.Add(ParamsBuffer, Insert_MediaSource_Offset), 0, null, mediaSource);
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Insert_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Insert_NativeFunction, ParamsBuffer);
            
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:GetRandom
    static readonly IntPtr GetRandom_NativeFunction;
    static readonly int GetRandom_ParamsSize;
    static readonly int GetRandom_OutIndex_Offset;
    static readonly int GetRandom_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaSource GetRandom(out int outIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetRandom_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetRandom_NativeFunction, ParamsBuffer);
            
            outIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetRandom_OutIndex_Offset), 0, null);
            UnrealSharp.MediaAssets.MediaSource returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.FromNative(IntPtr.Add(ParamsBuffer, GetRandom_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:GetPrevious
    static readonly IntPtr GetPrevious_NativeFunction;
    static readonly int GetPrevious_ParamsSize;
    static readonly int GetPrevious_InOutIndex_Offset;
    static readonly int GetPrevious_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaSource GetPrevious(out int inOutIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetPrevious_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetPrevious_NativeFunction, ParamsBuffer);
            
            inOutIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetPrevious_InOutIndex_Offset), 0, null);
            UnrealSharp.MediaAssets.MediaSource returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.FromNative(IntPtr.Add(ParamsBuffer, GetPrevious_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:GetNext
    static readonly IntPtr GetNext_NativeFunction;
    static readonly int GetNext_ParamsSize;
    static readonly int GetNext_InOutIndex_Offset;
    static readonly int GetNext_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaSource GetNext(out int inOutIndex)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[GetNext_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, GetNext_NativeFunction, ParamsBuffer);
            
            inOutIndex = BlittableMarshaller<int>.FromNative(IntPtr.Add(ParamsBuffer, GetNext_InOutIndex_Offset), 0, null);
            UnrealSharp.MediaAssets.MediaSource returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.FromNative(IntPtr.Add(ParamsBuffer, GetNext_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:Get
    static readonly IntPtr Get_NativeFunction;
    static readonly int Get_ParamsSize;
    static readonly int Get_Index_Offset;
    static readonly int Get_ReturnValue_Offset;
    
    public UnrealSharp.MediaAssets.MediaSource Get(int index)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Get_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            BlittableMarshaller<int>.ToNative(IntPtr.Add(ParamsBuffer, Get_Index_Offset), 0, null, index);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Get_NativeFunction, ParamsBuffer);
            
            UnrealSharp.MediaAssets.MediaSource returnValue;
            returnValue = ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.FromNative(IntPtr.Add(ParamsBuffer, Get_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:AddUrl
    static readonly IntPtr AddUrl_NativeFunction;
    static readonly int AddUrl_ParamsSize;
    static readonly int AddUrl_Url_Offset;
    static readonly int AddUrl_ReturnValue_Offset;
    
    public bool AddUrl(string url)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddUrl_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr Url_NativePtr = IntPtr.Add(ParamsBuffer,AddUrl_Url_Offset);
            StringMarshaller.ToNative(Url_NativePtr,0,null,url);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddUrl_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddUrl_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(Url_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:AddFile
    static readonly IntPtr AddFile_NativeFunction;
    static readonly int AddFile_ParamsSize;
    static readonly int AddFile_FilePath_Offset;
    static readonly int AddFile_ReturnValue_Offset;
    
    public bool AddFile(string filePath)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[AddFile_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            IntPtr FilePath_NativePtr = IntPtr.Add(ParamsBuffer,AddFile_FilePath_Offset);
            StringMarshaller.ToNative(FilePath_NativePtr,0,null,filePath);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, AddFile_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, AddFile_ReturnValue_Offset), 0, null);
            
            StringMarshaller.DestructInstance(FilePath_NativePtr, 0);
            return returnValue;
        }
    }
    
    // Function /Script/MediaAssets.MediaPlaylist:Add
    static readonly IntPtr Add_NativeFunction;
    static readonly int Add_ParamsSize;
    static readonly int Add_MediaSource_Offset;
    static readonly int Add_ReturnValue_Offset;
    
    public bool Add(UnrealSharp.MediaAssets.MediaSource mediaSource)
    {
        unsafe
        {
            byte* ParamsBufferAllocation = stackalloc byte[Add_ParamsSize];
            nint ParamsBuffer = (IntPtr) ParamsBufferAllocation;
            ObjectMarshaller<UnrealSharp.MediaAssets.MediaSource>.ToNative(IntPtr.Add(ParamsBuffer, Add_MediaSource_Offset), 0, null, mediaSource);
            
            UObjectExporter.CallInvokeNativeFunction(NativeObject, Add_NativeFunction, ParamsBuffer);
            
            bool returnValue;
            returnValue = BoolMarshaller.FromNative(IntPtr.Add(ParamsBuffer, Add_ReturnValue_Offset), 0, null);
            
            return returnValue;
        }
    }
    
    
}