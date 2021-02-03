using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncorrectButtonHandler : MonoBehaviour
{
    public void DiasbleButton()
    {
        this.gameObject.SetActive(false);
        PermUI.perm.score -= 20;
        SoundManager.PlaySound("Death");
    }
}