using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    [SerializeField] GameObject actObj;
    [SerializeField] GameObject deacObj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            actObj.SetActive(true);
            deacObj.SetActive(false);
        }
    }
}
