using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEnnemi : MonoBehaviour
{
    public GameObject canvas;
    public GameObject healphHolder;

    public int maxHealph = 3;

    // Start is called before the first frame update
    void Start()
    {
        try
        {
            healphHolder.GetComponent<Slider>().value = (float)GetComponent<Characteristiques>().pv / (float)this.maxHealph * 100f;
        }catch{}
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void modifyPv(int actualPv)
    {
        canvas.SetActive(true);
        healphHolder.GetComponent<Slider>().value = (float)actualPv / (float)this.maxHealph * 100f;
    }
}
