using UnrealBuildTool;

public class anitadevClientTarget : TargetRules
{
	public anitadevClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("anitadev");
	}
}
