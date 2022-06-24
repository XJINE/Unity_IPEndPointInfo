using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

[CustomPropertyDrawer(typeof(IPEndPointInfo))]
public class IPEndPointInfoDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);

        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var height = position.height;
        var width  = (position.width - 10) / 4;

        var addressLabelRect = new Rect(position.xMin,                  position.y, width, height);
        var addressFieldRect = new Rect(position.xMin + width * 1,      position.y, width, height);
        var portLabelRect    = new Rect(position.xMin + width * 2 + 10, position.y, width, height);
        var portFieldRect    = new Rect(position.xMin + width * 3 + 10, position.y, width, height);

        var prevIndentLevel = EditorGUI.indentLevel;

        EditorGUI.indentLevel = 0;

        EditorGUI.LabelField    (addressLabelRect, "Address");
        EditorGUI.PropertyField (addressFieldRect, property.FindPropertyRelative("address"), GUIContent.none);
        EditorGUI.LabelField    (portLabelRect, "Port");
        EditorGUI.PropertyField (portFieldRect, property.FindPropertyRelative("port"), GUIContent.none);

        EditorGUI.indentLevel = prevIndentLevel;

        EditorGUI.EndProperty();
    }
}

#endif // UNITY_EDITOR