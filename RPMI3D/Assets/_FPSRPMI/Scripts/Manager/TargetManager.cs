using UnityEngine;

public class TargetManager : MonoBehaviour
{
    public int targetsLeft;
    int targetsToShoot = 0;
    public GameObject objectToRemove;

    public void TargetElimination()
    {
        targetsToShoot++;

        if (targetsToShoot >= targetsLeft)
        {
            objectToRemove.SetActive(false);
        }
    }
}
