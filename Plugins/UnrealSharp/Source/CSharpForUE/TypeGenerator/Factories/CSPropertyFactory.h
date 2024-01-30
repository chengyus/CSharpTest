#pragma once

#include "UObject/UnrealType.h"
#include "CSharpForUE/TypeGenerator/CSFunction.h"

class FCSDefaultComponentProperty;
struct FPropertyMetaData;
class FCSPropertyFactory;
class FProperty;

using FMakeNewPropertyDelegate = FProperty* (*)(UField*, const FPropertyMetaData&, const EPropertyFlags PropertyFlags);

class FCSPropertyFactory
{
	
public:

	static void InitializePropertyFactory();
	
	static FProperty* CreateAndAssignProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags = CPF_None);
	static FProperty* CreateProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags = CPF_None);
	
	static void GeneratePropertiesForType(UField* Outer, const TArray<FPropertyMetaData>& PropertiesMetaData, const EPropertyFlags PropertyFlags = CPF_None);

	template<typename Property = FProperty>
	static void AddProperty(FMakeNewPropertyDelegate Function);

	template<typename PrimitiveProperty = FProperty>
	static void AddSimpleProperty();

	template<typename PrimitiveProperty = FProperty>
	static void AddSimpleProperty(const FName& Name);

	template <class FieldClass = FProperty>
	static FieldClass* CreateSimpleProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);

	static FProperty* CreateObjectProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateWeakObjectProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateSoftObjectProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateObjectPtrProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateSoftClassProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	
	static FProperty* CreateClassProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateStructProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateArrayProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateEnumProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	static FProperty* CreateDelegateProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	
	static bool IsOutParameter(const FProperty* InParam);

private:
	
	static void InitializeVariable(UFunction* Getter, UObject* Outer, FProperty* Property);

	template<typename ObjectProperty>
	static ObjectProperty* CreateObjectProperty(UField* Outer, const FPropertyMetaData& PropertyMetaData, const EPropertyFlags PropertyFlags);
	
	static TMap<FName, FMakeNewPropertyDelegate> MakeNewPropertyFunctionMap;
	
};
