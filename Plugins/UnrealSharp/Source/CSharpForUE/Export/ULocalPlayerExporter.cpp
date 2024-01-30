﻿// Fill out your copyright notice in the Description page of Project Settings.


#include "ULocalPlayerExporter.h"

void UULocalPlayerExporter::ExportFunctions(FRegisterExportedFunction RegisterExportedFunction)
{
	EXPORT_FUNCTION(GetLocalPlayerSubsystem)
}

void* UULocalPlayerExporter::GetLocalPlayerSubsystem(UClass* SubsystemClass, APlayerController* PlayerController)
{
	if (!IsValid(PlayerController) || !IsValid(SubsystemClass))
	{
		return nullptr;
	}

	ULocalPlayerSubsystem* LocalPlayerSubsystem = PlayerController->GetLocalPlayer()->GetSubsystemBase(SubsystemClass);
	return FCSManager::Get().FindManagedObject(LocalPlayerSubsystem).GetIntPtr();
}
