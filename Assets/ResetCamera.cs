using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour {

    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private GameObject cameraRoot;
    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        this.cameraRoot = GameObject.Find("CameraRoot");
        this.mainCamera = this.cameraRoot.transform.Find("Main Camera").gameObject;

        this.initialPosition = this.mainCamera.transform.position;
        this.initialRotation = this.cameraRoot.transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Reset()
    {
        this.cameraRoot.transform.rotation = this.initialRotation;
        this.mainCamera.transform.position = this.initialPosition;
    }
}
