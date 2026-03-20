using UnityEngine;

public class OnWheelsDestroy : MonoBehaviour
{
    private GameObject playersHolder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.playersHolder = GameObject.FindGameObjectWithTag("PlayerParent");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        foreach (Transform t in this.playersHolder.transform)
        {
            if (t.gameObject.tag == "Player")
            {
                t.gameObject.GetComponent<PlayerSwitch>().Switch();
            }
        }
    }
}
