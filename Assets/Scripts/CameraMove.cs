using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private Vector3 lastMousePosition;

    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        this.mainCamera = this.transform.Find("Main Camera").gameObject;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            var mousePosition = Input.mousePosition;
            this.lastMousePosition = mousePosition;
        }
        else if (Input.GetMouseButton(1))
        {
            var mousePosition = Input.mousePosition;
            var mouseMove = mousePosition - this.lastMousePosition;
            var move = mouseMove * -0.01f;

            this.mainCamera.transform.Translate(move.x, move.y, 0);

            this.lastMousePosition = mousePosition;
        }
    }
}
