using UnrealBuildTool;

public class anitadevEditorTarget : TargetRules
{
	public anitadevEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("anitadev");
	}
}
