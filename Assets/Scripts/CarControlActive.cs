﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour {
    public GameObject CarControl;
    public GameObject OpponentCarControl;

	void Start () {
        CarControl.GetComponent<CarController>().enabled = true;
        OpponentCarControl.GetComponent<CarController>().enabled = true;
    }
}
