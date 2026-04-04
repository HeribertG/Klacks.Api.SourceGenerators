// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Data models for deserializing settings-reader-skills.json definitions.
/// SettingsReaderSkillsFile is the root; each SettingsReaderSkillDef describes one generated skill class.
/// FieldDef maps a Settings constant expression to a result property name.
/// </summary>

using System.Collections.Generic;

namespace Klacks.Api.SourceGenerators.Models;

public class SettingsReaderSkillsFile
{
    public List<SettingsReaderSkillDef> Skills { get; set; } = new List<SettingsReaderSkillDef>();
}

public class SettingsReaderSkillDef
{
    public string Name { get; set; } = "";
    public string ClassName { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";
    public List<string> RequiredPermissions { get; set; } = new List<string>();
    public string ResultMessage { get; set; } = "";
    public List<FieldDef> Fields { get; set; } = new List<FieldDef>();
    public List<FieldDef> SensitiveFields { get; set; } = new List<FieldDef>();
}

public class FieldDef
{
    public string Key { get; set; } = "";
    public string ResultName { get; set; } = "";
    public string Constant { get; set; } = "";
}
