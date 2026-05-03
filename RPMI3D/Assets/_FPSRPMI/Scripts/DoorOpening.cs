using System.Collections;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] float openAngle = 90f;
    [SerializeField] float speed = 5f;
    [SerializeField] float waitTime = 2f;
    
    bool isOpening;
    bool isClosing;

    Quaternion targetRotation;
    private Quaternion initialRotation;

    private void Start()
    {
        initialRotation = door.transform.rotation;
        targetRotation = Quaternion.Euler(0, openAngle, 0) * initialRotation;
    }

    private void Update()
    {
        if (isOpening)
        {
            door.transform.rotation = Quaternion.Lerp(door.transform.rotation, targetRotation, Time.deltaTime * speed);

            if (Quaternion.Angle(door.transform.rotation, targetRotation) < 0.1f)
            {
                isOpening = false;
                StartCoroutine(DoorClosing());
            }
        }

        if (isClosing) door.transform.rotation = Quaternion.Lerp(door.transform.rotation, initialRotation, Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.PlaySFX(7);
            isOpening = true;
        }
    }

    IEnumerator DoorClosing()
    {
        AudioManager.Instance.PlaySFX(8);
        yield return new WaitForSeconds(waitTime);
        isClosing = true;
    }

}
