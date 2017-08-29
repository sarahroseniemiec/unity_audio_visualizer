using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour {
	public GameObject sampleCubePrefab;
	GameObject[] sampleCube = new GameObject[512];
	public float maxScale;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < sampleCube.Length; i++)
		{
			GameObject instanceOfSampleCube = (GameObject)Instantiate (sampleCubePrefab);
			instanceOfSampleCube.transform.position = this.transform.position;
			instanceOfSampleCube.transform.parent = this.transform;
			instanceOfSampleCube.name = "Cubely" + i;
			this.transform.eulerAngles = new Vector3 (0, -0.703125f * i, 0);
			instanceOfSampleCube.transform.position = Vector3.forward * 100;
			sampleCube [i] = instanceOfSampleCube;

		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < sampleCube.Length; i++) 
		{
			if (sampleCube != null) 
			{
				sampleCube [i].transform.localScale = new Vector3(10, (Visualizer.samples [i] * maxScale) + 2, 10);
			}
		}

	}
}
