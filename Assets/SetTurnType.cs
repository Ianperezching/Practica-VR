using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapturn;
    public ActionBasedContinuousTurnProvider ContinuosTurn;

    public void setTypeFromIndex(int index)
    {
        if(index == 0)
        {
            snapturn.enabled = false;
            ContinuosTurn.enabled = true;

        }else if(index == 1)
        {
            snapturn.enabled = true;
            ContinuosTurn.enabled = false;
        }
    }
}
