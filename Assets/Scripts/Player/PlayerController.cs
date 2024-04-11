using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private int JumpForce;

    [SerializeField]
    private GameObject EntSpawnPoint;

    void Start()
    {
        ResetPos();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, JumpForce));
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Wall"))
        {
            ResetPos();
        }
    }

    private void ResetPos()
    {
        gameObject.transform.position = EntSpawnPoint.transform.position;
    }
}
