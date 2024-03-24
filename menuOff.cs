using UnityEngine;
using UnityEngine.UI;

public class menuOff : MonoBehaviour
{
    public Button credBut, backBut;
    public GameObject Mmenu, Cmenu;
    bool main = false;

    void Start()
    {
        Button btn = credBut.GetComponent<Button>();
        Button butn = backBut.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        butn.onClick.AddListener(TaskOnClick);

    }
    void TaskOnClick()
    {
        if (!main)
        {
            Mmenu.SetActive(false);
            Cmenu.SetActive(true);
            main = true;
        }
        else
        {
            Mmenu.SetActive(true);
            Cmenu.SetActive(false);
            main = false;
        }

    }
}
