using System.Collections.Generic;
using UnityEngine;
using System.Linq;


[RequireComponent(typeof(LineRenderer))]
public class Tail : MonoBehaviour
{
    LineRenderer line;
    EdgeCollider2D col;

    public Transform snake;

    List<Vector2> points;

    public float pointSpacing = 0.1f;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        col = GetComponent<EdgeCollider2D>();

        points = new List<Vector2>();

        setPoints();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(points.Last(), snake.position) > pointSpacing)
            setPoints();
    }

    void setPoints()
    {
        if (points.Count > 1)
        {
            col.points = points.ToArray<Vector2>();
        }
        points.Add(snake.position);

        line.positionCount = points.Count;
        line.SetPosition(points.Count - 1, snake.position);
        
    }
}
