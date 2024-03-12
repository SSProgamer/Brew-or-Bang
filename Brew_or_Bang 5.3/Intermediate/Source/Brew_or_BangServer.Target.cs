using UnrealBuildTool;

public class Brew_or_BangServerTarget : TargetRules
{
	public Brew_or_BangServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Brew_or_Bang");
	}
}
