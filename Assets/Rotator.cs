using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 50f;
    public float duration = 1f;
    private Vector2 startScale;
    public Vector2 endScale;
    // private Vector2 startPosition;
    // public Vector2 endPosition;
    public bool returnToStart = true;
    
    private float startTime;
    private bool isReturning = false;

    void Start()
    {
        startTime = Time.time;
        startScale = transform.localScale;
        // Debug.Log(startScale);
        // startPosition = transform.position;
        // Debug.Log(startPosition);
    }

    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);

        float t = (Time.time - startTime) / duration;

        // float cycle = Mathf.Floor(t);

        // t -= cycle;

        // startTime += cycle * duration;

        // transform.localScale = Vector3.Lerp(startScale, endScale, t);

        if (t >= duration){
            isReturning = !isReturning;
            startTime = Time.time;
            t = 0f;
        }

        if (!isReturning){
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
        } else {
            transform.localScale = Vector3.Lerp(endScale, startScale, t);
        }

        // if (returnToStart && t>= 1f && !isReturning)
        // {
        //     isReturning = true;
            
        //     startTime = Time.time;
        //     t = 0;
        // }

        // if(!isReturning){
        //     transform.localScale = Vector3.Lerp(startScale, endScale, t);
        //     // transform.position = Vector3.Lerp(startPosition, endPosition, t);
        // } else {
        //     transform.localScale = Vector3.Lerp(endScale, startScale, t);
        //     // transform.position = Vector3.Lerp(endPosition, startPosition, t);
        // }
        
    }
}
