using UnrealBuildTool;

public class anitadevServerTarget : TargetRules
{
	public anitadevServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("anitadev");
	}
}
