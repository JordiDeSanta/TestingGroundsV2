// Copyright 1998-2016 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class S05_TestingGrounds : ModuleRules
{
	public S05_TestingGrounds(ReadOnlyTargetRules Target) : base(Target)
	{
		PrivatePCHHeaderFile = "S05_TestingGrounds.h";

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "AIModule", "GameplayTasks" });
	}
}
