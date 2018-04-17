using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {
    private GameObject mainCamera;

    // Use this for initialization
    void Start()
    {
        this.mainCamera = this.transform.Find("Main Camera").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        this.mainCamera.transform.Translate(0, 0, scroll);
    }
}
