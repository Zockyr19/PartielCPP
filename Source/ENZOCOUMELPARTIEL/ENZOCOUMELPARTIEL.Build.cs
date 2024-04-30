// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ENZOCOUMELPARTIEL : ModuleRules
{
	public ENZOCOUMELPARTIEL(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
