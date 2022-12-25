using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BuildObject))]
public class BuildObjectEditor : Editor
{
	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		BuildObject script = (BuildObject)target;
		if (GUILayout.Button("Create Object"))
		{
			script.CreateObject();
		}
	}
}
