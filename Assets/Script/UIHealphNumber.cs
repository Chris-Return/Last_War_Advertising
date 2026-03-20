using TMPro;
using UnityEngine;

public class UIHealphNumber : MonoBehaviour
{
    public GameObject healphHolder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         this.healphHolder.GetComponent<TextMeshProUGUI>().SetText(GetComponent<Characteristiques>().pv.ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void showPv(int pv)
    {
        this.healphHolder.GetComponent<TextMeshProUGUI>().SetText(pv.ToString());
    }
}
