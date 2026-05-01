using UnityEngine;

public class TriggerAct : MonoBehaviour
{
    [SerializeField] GameObject Canvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Canvas.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Canvas.SetActive(false);
        }
    }
}
