using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCamera : MonoBehaviour {

    private Vector3 initialPosition;
    private Vector3 initialRotation;

    private GameObject cameraRoot;
    private GameObject mainCamera;

	// Use this for initialization
	void Start () {
        this.cameraRoot = GameObject.Find("CameraRoot");
        this.mainCamera = this.cameraRoot.transform.Find("Main Camera").gameObject;

        this.initialPosition = this.mainCamera.transform.position;
        this.initialRotation = this.cameraRoot.transform.rotation.eulerAngles;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Reset()
    {
        var seq = DOTween.Sequence();
        seq.Append(this.cameraRoot.transform.DOLocalRotate(this.initialRotation, 0.3f));
        seq.Join(this.mainCamera.transform.DOLocalMove(this.initialPosition, 0.3f));
    }
}
