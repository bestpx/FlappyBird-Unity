using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform birdTransform;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(birdTransform.position.x, transform.position.y, transform.position.z);
    }
}
