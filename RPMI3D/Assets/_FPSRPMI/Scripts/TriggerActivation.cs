using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    [SerializeField] GameObject obj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            obj.SetActive(true);
        }
    }
}
