// Copyright Epic Games, Inc. All Rights Reserved.

using System;
using System.IO;
using UnrealBuildTool;

public class BoostPlugin : ModuleRules
{
	public BoostPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
        bUseRTTI = true;
        bEnableExceptions = true;

        PublicDependencyModuleNames.AddRange(
		new string[]
		{
			"Core",
            "BoostLibrary",
		});
	}
}
