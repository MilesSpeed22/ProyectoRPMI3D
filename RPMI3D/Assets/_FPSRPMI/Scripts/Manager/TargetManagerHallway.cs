using TMPro;
using UnityEngine;

public class TargetManagerHallway : MonoBehaviour
{
    public int targetsLeft;
    int targetsToShoot = 0;
    PointDoor pointDoorScript;

    public void TargetElimination()
    {
        targetsToShoot++;

        if (targetsToShoot >= targetsLeft)
        {
            pointDoorScript.Active();
        }
    }
}
