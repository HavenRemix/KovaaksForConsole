// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class KovaaksForConsoleTarget : TargetRules
{
	public KovaaksForConsoleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "KovaaksForConsole" } );
	}
}
