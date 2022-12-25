using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildObject : MonoBehaviour
{
	public GameObject obj;
	public Vector3 spawnLocation;

	public void CreateObject()
	{
		Instantiate(obj, spawnLocation, Quaternion.identity);
	}
}
