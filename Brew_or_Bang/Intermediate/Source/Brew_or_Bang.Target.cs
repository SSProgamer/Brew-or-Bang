using UnrealBuildTool;

public class Brew_or_BangTarget : TargetRules
{
	public Brew_or_BangTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Brew_or_Bang");
	}
}
