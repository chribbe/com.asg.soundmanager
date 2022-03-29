using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using ASmallGame.Sounds;


    [CustomPropertyDrawer(typeof(Sound))]
    public class SoundDrawer : PropertyDrawer
    {

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        //GUI.backgroundColor = Color.cyan;
        EditorGUI.PropertyField(position, property, label, true);
        if (property.isExpanded)
        {
            if (GUI.Button(new Rect(position.xMin + 100f, position.yMax - 20f, position.width - 100f, 20f), "Test Play"))
            {
                // do things
            }
        }
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        if (property.isExpanded)
            return EditorGUI.GetPropertyHeight(property) + 20f;
        return EditorGUI.GetPropertyHeight(property);
    }

}


