using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    private Vector3 lastMousePosition;
    private Vector3 totalMovePosition = Vector3.zero;

    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        this.mainCamera = this.transform.Find("Main Camera").gameObject;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            var mousePosition = Input.mousePosition;
            this.lastMousePosition = mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            var mousePosition = Input.mousePosition;
            var mouseMove = mousePosition - this.lastMousePosition;
            this.totalMovePosition += mouseMove;
            var angleMove = new Vector3(this.totalMovePosition.y, -1 * this.totalMovePosition.x, 0);

            this.transform.rotation = Quaternion.Euler(angleMove);

            this.lastMousePosition = mousePosition;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        this.mainCamera.transform.Translate(0, 0, scroll);
    }
}
