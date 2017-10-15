using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

    public GameObject backgroundPrefab;
    public float generateInterval;

    private float timeLastGenerated;

    // Use this for initialization
    void Start () {
        GenerateBackground();
    }
    
    // Update is called once per frame
    void Update () {
        if (Time.time - timeLastGenerated > generateInterval)
        {
            GenerateBackground();
            timeLastGenerated = Time.time;
        }
    }
    
    void GenerateBackground()
    {
        GameObject.Instantiate(backgroundPrefab, transform.position, Quaternion.identity);
        GameObject.Instantiate(backgroundPrefab, transform.position + new Vector3(16, 0, 0), Quaternion.identity);
    }
}
