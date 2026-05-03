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

        }
    }

    private void OnTriggerStay(Collider other)
    {
        AudioManager.Instance.PlayMusic(4);
    }
    private void OnTriggerExit(Collider other)
    {
        AudioManager.Instance.PlayMusic(1);
    }
}
