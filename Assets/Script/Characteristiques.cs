using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Characteristiques : MonoBehaviour
{
    public int pv;

    public void modifyPv(int pv)
    {
        this.pv += pv;
        if (this.pv <= 0)
        {
            Destroy(this.gameObject);
        }

        try
        {
            GetComponent<UIEnnemi>().modifyPv(this.pv);
        }catch{}
        
    }
}
