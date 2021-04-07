using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIToolKit : SerializedScriptableObject
{
    [EnumPaging]
    public TextureImporterType textureType;
    public TextureImporterShape textureShape;

    
    [LabelText("sRGB（Color Texture）")]
    [ShowIf("@textureType==TextureImporterType.Default||textureType==TextureImporterType.NormalMap")]
    public bool sRGB;

    [LabelText("Create from Grayscale")]
    [ShowIf("textureType", TextureImporterType.NormalMap)]
    public bool CreateFromeGrayScale;

    [EnumToggleButtons, HideLabel]
    public Platform PlatformField;
}

public enum Platform
{
    Default,
    [Title("PC,Mac&Linux Standalone")]
    PC,
    Android,
    IOS
}

/*
 * [Title("Default")]
public SomeBitmaskEnum DefaultEnumBitmask;

[Title("Standard Enum")]
[EnumToggleButtons]
public SomeEnum SomeEnumField;

[EnumToggleButtons, HideLabel]
public SomeEnum WideEnumField;

[Title("Bitmask Enum")]
[EnumToggleButtons]
public SomeBitmaskEnum BitmaskEnumField;

[EnumToggleButtons, HideLabel]
public SomeBitmaskEnum EnumFieldWide;

public enum SomeEnum
{
    First, Second, Third, Fourth, AndSoOn
}

[System.Flags]
public enum SomeBitmaskEnum
{
    A = 1 << 1,
    B = 1 << 2,
    C = 1 << 3,
    All = A | B | C
}

 */