using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject EntGameController;
    
    // Start is called before the first frame update
    void Start()
    {
        EntGameController.GetComponent<GameController>().SpawnPipe();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Pipe"))
        {
            EntGameController.GetComponent<GameController>().SpawnPipe();
        }
    }
}
