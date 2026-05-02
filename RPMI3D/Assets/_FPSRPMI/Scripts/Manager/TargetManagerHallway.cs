using TMPro;
using UnityEngine;

public class TargetManagerHallway : MonoBehaviour
{
    public int targetsLeft;
    int targetsToShoot = 0;
    public GameObject objectToAdd;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI targetsLeftUI;
    public void TargetElimination()
    {
        targetsToShoot++;

        if (targetsToShoot >= targetsLeft)
        {
            objectToAdd.SetActive(false);
        }
    }
}
