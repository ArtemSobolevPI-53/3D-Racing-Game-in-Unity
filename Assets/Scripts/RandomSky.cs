﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSky : MonoBehaviour {
    public Material[] materials;

	void Start () {
        GetComponent<Skybox>().material = materials[Random.Range(0, materials.Length)];
	}
}
