using UnityEngine;

public class PointDoor : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int startingPoint;
    [SerializeField] Transform[] points;
    [SerializeField] Transform finishingPoint;
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
            if (i >= points.Length)
            {
                enabled = false;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }

    public void Active()
    {
        transform.position = Vector3.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
    }
}
