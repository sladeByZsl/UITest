using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

[CustomEditor(typeof(UIConfig))]
public class UIConfigInspector : AssetImporterEditor
{
    public Dictionary<TextureImporterType, string> dic = new Dictionary<TextureImporterType, string>();
    public override void OnEnable()
    {
        dic.Add(TextureImporterType.Default, "Default");
        dic.Add(TextureImporterType.NormalMap, "Normal map");
        dic.Add(TextureImporterType.GUI, "Editor GUI and Legacy GUI");
        dic.Add(TextureImporterType.Sprite, "Sprite (2D and UI)");
        dic.Add(TextureImporterType.Cursor, "Cursor");
        dic.Add(TextureImporterType.Cookie, "Cookie");
        dic.Add(TextureImporterType.Lightmap, "Lightmap");
        dic.Add(TextureImporterType.SingleChannel, "Single Channel");
    }

    public override void OnInspectorGUI()
    {

    }
}
