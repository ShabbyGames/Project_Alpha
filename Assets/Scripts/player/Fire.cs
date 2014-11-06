using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour
{

    void Update()
    {
        if (Input.GetAxis(Axis.FireMain) > 0)
        {

        }

        if (Input.GetAxis(Axis.FireBomb) > 0)
        {

        }

        if (Input.GetAxis(Axis.FireUlt) > 0)
        {

        }

        if (Input.GetAxis(Axis.Shield) > 0)
        {
            gameData.PlayerStat.shieldActive = true;
        }
        else
        {
            gameData.PlayerStat.shieldActive = false;
        }
    }
}
