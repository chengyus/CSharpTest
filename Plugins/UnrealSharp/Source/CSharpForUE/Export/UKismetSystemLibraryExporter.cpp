﻿#include "UKismetSystemLibraryExporter.h"
#include "Kismet/KismetSystemLibrary.h"

void UUKismetSystemLibraryExporter::ExportFunctions(FRegisterExportedFunction RegisterExportedFunction)
{
	EXPORT_FUNCTION(PrintString)
}

void UUKismetSystemLibraryExporter::PrintString(const UObject* WorldContextObject, const UTF16CHAR* Message, float Duration, FLinearColor Color, bool PrintToScreen, bool PrintToConsole)
{
	UKismetSystemLibrary::PrintString(WorldContextObject, Message, PrintToScreen, PrintToConsole, FLinearColor(0.0, 0.66, 1.0), Duration);
}
