using UnityEngine;

public class TriggerHallway : MonoBehaviour
{
    [SerializeField] PointDoor pointDoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pointDoor.Active();
        }
    }
}
