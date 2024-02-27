using UnityEngine;
using UnityEditor;

/// <summary>
/// Draws the <see cref="RenameAttribute"/>. 
/// </summary>
[CustomPropertyDrawer(typeof(RenameAttribute))]
public sealed class RenameAttributeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label )
    {
        EditorGUI.PropertyField(position, property, new GUIContent((attribute as RenameAttribute)?.name));
    }
}