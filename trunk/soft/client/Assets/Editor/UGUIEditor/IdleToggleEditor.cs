﻿using UnityEditor.UI;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(IdleToggle), true)]
[CanEditMultipleObjects]
public class IdleToggleEditor : SelectableEditor
{
	SerializedProperty m_OnValueChangedProperty;
    SerializedProperty m_TransitionProperty;
    SerializedProperty m_GraphicProperty;
    SerializedProperty m_GroupProperty;
    SerializedProperty m_IsOnProperty;
	SerializedProperty m_TextGraphic;

	protected override void OnEnable()
	{
		base.OnEnable();
		m_TransitionProperty = serializedObject.FindProperty("toggleTransition");
        m_GraphicProperty = serializedObject.FindProperty("graphic");
        m_GroupProperty = serializedObject.FindProperty("m_Group");
        m_IsOnProperty = serializedObject.FindProperty("m_IsOn");
        m_OnValueChangedProperty = serializedObject.FindProperty("onValueChanged");
        m_TextGraphic = serializedObject.FindProperty("m_TextGraphic");
        
	}

	public override void OnInspectorGUI()
	{
        base.OnInspectorGUI();
        EditorGUILayout.Space();

        serializedObject.Update();
        EditorGUILayout.PropertyField(m_IsOnProperty);
        EditorGUILayout.PropertyField(m_TransitionProperty);
        EditorGUILayout.PropertyField(m_GraphicProperty);
        EditorGUILayout.PropertyField(m_GroupProperty);
        EditorGUILayout.PropertyField(m_TextGraphic);
        EditorGUILayout.Space();
        // Draw the event notification options
        EditorGUILayout.PropertyField(m_OnValueChangedProperty);

        serializedObject.ApplyModifiedProperties();
    }
}
