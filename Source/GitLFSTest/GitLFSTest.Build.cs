// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class GitLFSTest : ModuleRules
{
	public GitLFSTest(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}
