using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spellcast : MonoBehaviour
{
    //private LineRenderer cLineRenderer;
    private List<Vector3> LinePoints;
    [SerializeField] private Material iLineMaterial;
    [SerializeField] private float iLineWidth;
    
    // Start is called before the first frame update
    void Start()
    {
        //cLineRenderer = GetComponent<LineRenderer>();
        //LinePoints = new List<Vector3>
        //{
        //    new(0, 0),
        //    new(1, 1)
        //};
    }

    // Update is called once per frame
    void Update()
    {
        //LinePoints[1] = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //cLineRenderer.positionCount = LinePoints.Count;
        //cLineRenderer.SetPositions(LinePoints.ToArray());
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            LinePoints = new List<Vector3>();
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            CreateLineObject(LinePoints);
            LinePoints.Clear();
        }
        
        if (Input.GetKey(KeyCode.Mouse0))
        {
            LinePoints.Add(Camera.main.ScreenToWorldPoint(
                new(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane))
            );
        }
    }
    

    void CreateLineObject(List<Vector3> positions)
    {
        GameObject newLine = new("Line Object");
        LineRenderer lr = newLine.AddComponent<LineRenderer>();
        lr.positionCount = positions.Count;
        lr.SetPositions(positions.ToArray());
        lr.startWidth = iLineWidth;
        lr.endWidth = iLineWidth;
        lr.material = iLineMaterial;
        lr.enabled = true;
    }
}
