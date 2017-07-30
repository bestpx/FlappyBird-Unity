using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

    public float speed = 5;
    public float moveUpUnits = 1;
    public float fallSpeed;
    public float movingUpDuration = 0.25f;

    private bool isMovingUp;
    private float movingUpStartTime;
    private float startY;
    private float endY;

    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0)) {
            isMovingUp = true;
            movingUpStartTime = Time.time;
            var pos = transform.position;
            startY = pos.y;
            endY = pos.y + moveUpUnits;
        }

        if (isMovingUp)
        {
            float t = Time.time;
            var pos = transform.position;
            float posY = Mathf.Lerp(startY, endY, (t - movingUpStartTime) / movingUpDuration);
            pos.y = posY;
            transform.position = pos;

            if (t - movingUpStartTime > movingUpDuration)
            {
                isMovingUp = false;
            }
            t += Time.deltaTime;
        }
        else
        {
            Fall();
        }
        // MoveForward();

        Camera.main.transform.position = new Vector3(transform.position.x, Camera.main.transform.position.y, Camera.main.transform.position.z);
    }

    void MoveForward()
    {
        var pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }

    void Fall()
    {
        var pos = transform.position;
        pos.y -= fallSpeed * Time.deltaTime;
        transform.position = pos;
    }

    void MoveUp() {
        isMovingUp = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameOver();
    }

    void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
