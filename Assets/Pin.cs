using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    
    public float speed = 20f;
    public Rigidbody2D rb;

    void Update()
    {
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Rotator") {
            transform.SetParent(other.transform);
            // other.GetComponent<Rotator>().speed *= -1; Change direction
            isPinned = true;
        } else if (other.tag == "Pin") {
            FindObjectOfType<GameManager>().EndGame();
        }
        // } else if (other.tag == "Pin") {
        //     FindObjectOfType<GameManager>().EndGame();
        // }
    }
}
