using TMPro;
using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public int targetsLeft;
    int targetsToShoot = 0;
    public GameObject objectToRemove;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI targetsLeftUI;

    private void Start()
    {
        UpdateUI();
    }
    public void TargetElimination()
    {
        targetsToShoot++;
        UpdateUI();

        if (targetsToShoot >= targetsLeft)
        {
            objectToRemove.SetActive(false);
        }
    }

    void UpdateUI()
    {
        int numberLeft = targetsLeft - targetsToShoot;
        targetsLeftUI.text = "Targets Left: " + numberLeft;
    }
}
