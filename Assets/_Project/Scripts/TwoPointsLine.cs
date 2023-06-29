using UnityEngine;

[ExecuteInEditMode]
public class TwoPointsLine : MonoBehaviour
{
    
    public Transform pointA;

    public Transform pointB;

    private LineRenderer _lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        _lineRenderer.positionCount = 2;
        _lineRenderer.SetPosition(0,pointA.position);
        _lineRenderer.SetPosition(1,pointB.position);
        
    }
}
