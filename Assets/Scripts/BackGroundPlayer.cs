using UnityEngine;

public class BackGroundPlayer : MonoBehaviour
{
    public static BackGroundPlayer bgp;

    public GameObject screenStartButton;
    public GameObject screenStartMenu;
    public GameObject screen1_5;
    public GameObject screen6_10;
    public GameObject screen11_15;
    public GameObject screen16_20;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (!bgp)
        {
            bgp = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}