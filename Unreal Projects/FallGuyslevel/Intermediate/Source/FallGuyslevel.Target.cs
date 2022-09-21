using UnrealBuildTool;

public class FallGuyslevelTarget : TargetRules
{
	public FallGuyslevelTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("FallGuyslevel");
	}
}
