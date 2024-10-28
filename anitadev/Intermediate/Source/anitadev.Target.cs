using UnrealBuildTool;

public class anitadevTarget : TargetRules
{
	public anitadevTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("anitadev");
	}
}
