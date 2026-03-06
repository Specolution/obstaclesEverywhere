// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ObstacleEverywhere : ModuleRules
{
	public ObstacleEverywhere(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ObstacleEverywhere",
			"ObstacleEverywhere/Variant_Platforming",
			"ObstacleEverywhere/Variant_Platforming/Animation",
			"ObstacleEverywhere/Variant_Combat",
			"ObstacleEverywhere/Variant_Combat/AI",
			"ObstacleEverywhere/Variant_Combat/Animation",
			"ObstacleEverywhere/Variant_Combat/Gameplay",
			"ObstacleEverywhere/Variant_Combat/Interfaces",
			"ObstacleEverywhere/Variant_Combat/UI",
			"ObstacleEverywhere/Variant_SideScrolling",
			"ObstacleEverywhere/Variant_SideScrolling/AI",
			"ObstacleEverywhere/Variant_SideScrolling/Gameplay",
			"ObstacleEverywhere/Variant_SideScrolling/Interfaces",
			"ObstacleEverywhere/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
