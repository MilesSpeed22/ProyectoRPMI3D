using UnityEngine;

public class TriggerActivation : MonoBehaviour
{
    [SerializeField] GameObject actObj;
    [SerializeField] GameObject deacObj;
    [SerializeField] GameObject enemyDeac;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            actObj.SetActive(true);
            deacObj.SetActive(false);
            enemyDeac.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        enemyDeac.SetActive(true);
    }
}
