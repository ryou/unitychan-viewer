using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
    private Vector3 lastMousePosition;
    private Vector3 totalMovePosition = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
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
            var angleMove = new Vector3(this.totalMovePosition.y, this.totalMovePosition.x, 0);

            this.transform.rotation = Quaternion.Euler(angleMove);

            this.lastMousePosition = mousePosition;
        }
    }
}
