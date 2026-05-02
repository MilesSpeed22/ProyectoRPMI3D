using UnityEngine;

public class PointDoor : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform startingPoint;
    [SerializeField] Transform finishingPoint;
    bool isActive = false;

    private void Start()
    {
        transform.position = startingPoint.transform.position;
    }
    private void Update()
    {
        if (isActive) transform.position = Vector3.MoveTowards(transform.position, finishingPoint.transform.position, speed * Time.deltaTime);
    }

    public void Active()
    {
        isActive = true;
    }
}
