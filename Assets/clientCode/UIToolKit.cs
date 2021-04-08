using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UIToolKit : SerializedScriptableObject
{
    [ValueDropdown("TextureTypeList")]
    public TextureImporterType TextureType =TextureImporterType.Default;
    private static IEnumerable TextureTypeList = new ValueDropdownList<TextureImporterType>()
    {
      { "Default", TextureImporterType.Default },
      { "Normal map", TextureImporterType.NormalMap },
      { "Editor GUI and Legacy GUI", TextureImporterType.GUI },

      { "Sprite (2D and UI)", TextureImporterType.Sprite },
      { "Cursor", TextureImporterType.Cursor },
      { "Cookie", TextureImporterType.Cookie },
      { "Lightmap", TextureImporterType.Lightmap },
      { "Single Channel", TextureImporterType.SingleChannel },
    };

    [ValueDropdown("textureShapeList")]
    [EnableIf("@(this.TextureType==TextureImporterType.NormalMap)|| (this.TextureType == TextureImporterType.Default) || (this.TextureType == TextureImporterType.SingleChannel)")]
    public int textureShape=(int)TextureImporterShape.Texture2D;
    private static IEnumerable textureShapeList = new ValueDropdownList<int>()
    {
      { "2D", (int)TextureImporterShape.Texture2D },
      { "Cube", (int)TextureImporterShape.TextureCube },
    };

    [LabelText("sRGB（Color Texture）")]
    [ShowIf("@this.TextureType==TextureImporterType.Default")]
    public bool sRGB;

    [ShowIf("@this.TextureType==TextureImporterType.Default")]
    public TextureImporterAlphaSource AlphaSource;

    [LabelText("Alpha Is Transparency")]
    [ShowIf("@this.TextureType==TextureImporterType.Default")]
    public bool IsTransparency;

    [LabelText("Create from Grayscale")]
    [ShowIf("@this.TextureType==TextureImporterType.NormalMap")]
    public bool CreateFromeGrayScale;



    [BoxGroup("SpriteModeGroup", ShowLabel = false)]
    [ReadOnly]
    [HideInEditorMode]
    //[ShowIfGroup("TextureType", Value = TextureImporterType.Sprite)]
    public string Name;

    [ValueDropdown("SpriteModeList")]
  
    [BoxGroup("SpriteModeGroup/TextureType")]
    [ShowIfGroup("SpriteModeGroup/TextureType", Value = TextureImporterType.Sprite)]
    public SpriteImportMode SpriteMode=SpriteImportMode.Single;
    private static IEnumerable SpriteModeList = new ValueDropdownList<SpriteImportMode>()
    {
      { "Single", SpriteImportMode.Single },
      { "Multiple", SpriteImportMode.Multiple },
      { "Polygon", SpriteImportMode.Polygon },
    };

    
    [BoxGroup("SpriteModeGroup/TextureType")]
    [Indent(2)]
    public string PackingTag;

    [EnumToggleButtons, HideLabel]
    public Platform PlatformField;


    //// Like the regular If-attributes, ShowIfGroup also supports specifying values.
    //// You can also chain multiple ShowIfGroup attributes together for more complex behaviour.
    //[ShowIfGroup("Box/Toggle/EnumField", Value = InfoMessageType.Info)]
    //[BoxGroup("Box/Toggle/EnumField/Border", ShowLabel = false)]
    //public string Name;

    //[BoxGroup("Box/Toggle/EnumField/Border")]
    //public Vector3 Vector;

    //[BoxGroup("Box", ShowLabel = false)]
    //public InfoMessageType EnumField = InfoMessageType.Info;

    //[BoxGroup("Box")]
    //public Vector3 X, Y;

    //// Like the regular If-attributes, ShowIfGroup also supports specifying values.
    //// You can also chain multiple ShowIfGroup attributes together for more complex behaviour.
    
   

    //[BoxGroup("Box/Toggle/EnumField/Border")]
    //public Vector3 Vector;
}

public enum Platform
{
    Default,
    [Title("PC,Mac&Linux Standalone")]
    PC,
    Android,
    IOS
}

public enum SomeEnum
{
    A, B, C
}

/*
 * 
 * public bool Toggle = true;

[ShowIfGroup("Toggle")]
[BoxGroup("Toggle/Shown Box")]
public int A, B;

[BoxGroup("Box")]
public InfoMessageType EnumField = InfoMessageType.Info;

[BoxGroup("Box")]
[ShowIfGroup("Box/Toggle")]
public Vector3 X, Y;

// Like the regular If-attributes, ShowIfGroup also supports specifying values.
// You can also chain multiple ShowIfGroup attributes together for more complex behaviour.
[ShowIfGroup("Box/Toggle/EnumField", Value = InfoMessageType.Info)]
[BoxGroup("Box/Toggle/EnumField/Border", ShowLabel = false)]
public string Name;

[BoxGroup("Box/Toggle/EnumField/Border")]
public Vector3 Vector;

// ShowIfGroup will by default use the name of the group,
// but you can also use the MemberName property to override this.
[ShowIfGroup("RectGroup", Condition = "Toggle")]
public Rect Rect;

 * 
 * 
 * [OnValueChanged("CreateMaterial")]
public Shader Shader;

[ReadOnly, InlineEditor(InlineEditorModes.LargePreview)]
public Material Material;

private void CreateMaterial()
{
    if (this.Material != null)
    {
        Material.DestroyImmediate(this.Material);
    }

    if (this.Shader != null)
    {
        this.Material = new Material(this.Shader);
    }
}

 * 
 * 
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