using TMPro;
using UnityEngine;

public class SortingFunction : MonoBehaviour
{
    public TextMeshPro numberDisplay;
    public static SortingFunction instance;
    private void Awake()
    {
        instance = this;
    }

    public void ThatsWhat(int i)
    {
        numberDisplay.text = i.ToString();
    }


}
