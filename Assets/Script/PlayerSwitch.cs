using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public GameObject playerBasic;

    public GameObject playerTank;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Switch()
    {
        if (playerBasic.activeInHierarchy)
        {
            playerBasic.SetActive(false);
            playerTank.SetActive(true);
        }
    }
}
