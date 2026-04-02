using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] float open = 90f;
    [SerializeField] float speed = 2f;
    bool isOpening;
    Quaternion targetRotation;

    private void Start()
    {
        targetRotation = Quaternion.Euler(0, open, 0) * door.transform.rotation;
    }

    private void Update()
    {
        if (isOpening)
        {
            door.transform.rotation = Quaternion.Lerp(door.transform.rotation, targetRotation, Time.deltaTime * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpening = true;
        }
    }


}
