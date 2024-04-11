using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject EntPipeSpawner;

    [Header("Pipe Obj Info")]
    [SerializeField]
    private string PipeTag;
    [SerializeField]
    private Sprite PipeSprite;
    [SerializeField]
    private Color PipeColor;
    // Pipe information
    [SerializeField]
    private int PipeWidth;
    [SerializeField]
    private int PipeSpeed;
    [Space(10)]

    
    [SerializeField]
    private int PipeInterval = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPipe()
    {
        Debug.Log("WTF");
        
        GameObject newPipe = new("Poipe");
        newPipe.transform.position = new Vector3(EntPipeSpawner.transform.position.x + PipeInterval, 0, 0);

        newPipe.tag = PipeTag;
        newPipe.AddComponent<SpriteRenderer>().color = new(PipeColor.r, PipeColor.g, PipeColor.b, 255);
        newPipe.GetComponent<SpriteRenderer>().sprite = PipeSprite;
        newPipe.AddComponent<BoxCollider2D>().size.Scale(new Vector2(PipeWidth, 2));
        newPipe.AddComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        newPipe.AddComponent<PipeBehaviour>().RateOfTravel = PipeSpeed;
    }
}
