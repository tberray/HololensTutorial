using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColor : MonoBehaviour {

	// Use this for initialization
	void Start () {

        var cubeColor = new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );

        this.GetComponent<Renderer>().material.color = cubeColor;
    }
    
    // Update is called once per frame
    void Update () {

    }
}
