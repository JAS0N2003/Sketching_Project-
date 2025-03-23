#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class SaveTextureAsAsset : MonoBehaviour
{
    public Color textureColor = Color.red;
    public int textureWidth = 128;
    public int textureHeight = 128;
    public string textureName = "RedTexture";

    void Start()
    {
        Texture2D texture = new Texture2D(textureWidth, textureHeight);
        Color[] pixels = new Color[textureWidth * textureHeight];
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = textureColor;
        }
        texture.SetPixels(pixels);
        texture.Apply();

#if UNITY_EDITOR
        // Save the texture as a PNG file in the Assets folder
        byte[] bytes = texture.EncodeToPNG();
        string path = "Assets/Materials/Colours/" + textureName + ".png";
        System.IO.File.WriteAllBytes(path, bytes);
        AssetDatabase.Refresh();
        Debug.Log("Texture saved to " + path);
#endif
    }
}