using UnrealBuildTool;

public class Brew_or_BangClientTarget : TargetRules
{
	public Brew_or_BangClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Brew_or_Bang");
	}
}
