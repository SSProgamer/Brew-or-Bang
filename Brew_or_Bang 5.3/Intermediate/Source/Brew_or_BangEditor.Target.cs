using UnrealBuildTool;

public class Brew_or_BangEditorTarget : TargetRules
{
	public Brew_or_BangEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Brew_or_Bang");
	}
}
