﻿using Mono.Cecil;

namespace UnrealSharpWeaver.NativeTypes;

class NativeDataClassType(TypeReference typeRef, TypeReference innerTypeReference, int arrayDim) 
    : NativeDataGenericObjectType(typeRef, innerTypeReference, "SubclassOfMarshaller`1", "ClassProperty", arrayDim, PropertyType.Class);