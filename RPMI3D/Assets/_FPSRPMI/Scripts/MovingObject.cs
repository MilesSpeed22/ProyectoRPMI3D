using UnityEngine;

public class MovingObject : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int startingPoint;
    [SerializeField] Transform[] points;
    private int i;
    void Start()
    {
        transform.position = points[startingPoint].position;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, points[i].position) < 0.02)
        {
            i++;
            if (i == points.Length)
            {
                i = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
