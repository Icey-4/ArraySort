using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Arrraysorting : MonoBehaviour
{
    HashSet<int> ints = new HashSet<int>();
    public int[] tainer, pear;
    internal int amount = 1;
    public GameObject squareFab, menuScreen, pain;
    internal Vector3 spawn = new(-8, 3.5f, 0);
    internal Quaternion qua = Quaternion.identity;
    public Button yourButton;
    public TMP_InputField numberInput;
    public GameObject[] prefabNames;
    public Vector3 GirlPos;
    public float delay = 4f, timer;
    bool first = false, second = false, herewego = false;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > delay && second)
        {
            fortheloveofgodpleasehelpMe();
            PogChamp();
            second = false;
        }

        if (timer > delay && first)
        {
            fortheloveofgodpleasehelpMe();
            first = false;
            second = true;
            timer = 0;
        }

        if (herewego)
        {
            ThisisitLuigi();
        }
    }

    void Gals()
    {
        for (int i = 0; i < amount; i++)
        {
            pain = Instantiate(squareFab, spawn, qua);
            pain.name = $"Girl{tainer[i]}";
            prefabNames[i] = pain;
            SortingFunction.instance.ThatsWhat(tainer[i]);
            spawn.x += 1.5f;
            if (spawn.x > 7)
            {
                spawn.x = -8;
                spawn.y -= 1.5f;
            }
        }
    }
    void TaskOnClick()
    {
        amount = int.Parse(numberInput.text);
        prefabNames = new GameObject[amount];
        HashNclass();
        Gals();
        menuScreen.SetActive(false);
        MergseSort(tainer);
        first = true;
        timer = 0;
    }

    public void HashNclass()
    {

        for (int i = 0; i < amount; i++)
        {
            ints.Add(Random.Range(1, 35));
        }

        tainer = new int[amount];
        ints.CopyTo(tainer);
        pear = new int[amount];
        ints.CopyTo(pear);
    }


    public void MergseSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;

        int mid = arr.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        for (int i = 0; i < mid; i++)
            left[i] = arr[i];

        for (int i = mid; i < arr.Length; i++)
            right[i - mid] = arr[i];

        MergseSort(left);
        MergseSort(right);

        Merge(arr, left, right);
    }

    private void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k++] = left[i++];
            }

            else
                arr[k++] = right[j++];
        }

        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];

    }

    void fortheloveofgodpleasehelpMe()
    {
        Vector3 OwO = new Vector3(-6, 3, 0);
        Vector3 UwU = new Vector3(-6, 0, 0);

        for (int i = 0; i < amount; i++)
        {
            prefabNames[i].transform.position = Vector3.Lerp(prefabNames[i].transform.position, OwO, 1);
            OwO.x += 1.5f;
            if (i >= amount / 2)
            {
                prefabNames[i].transform.position = UwU;
                UwU.x += 1.5f;
            }
        }

    }

    void PogChamp()
    {
        if (amount > 4)
        {
            Vector3 hug = new Vector3(2, 0, 0);
            for (int i = 1; i < amount / 2; i++)
            {
                prefabNames[i].transform.position += hug;
                hug.x += 2;

            }
            hug = new Vector3(2, 0, 0);
            for (int i = 1 + amount / 2; i < amount; i++)
            {
                prefabNames[i].transform.position += hug;
                hug.x += 2;

            }
        }
        timer = 0;
        herewego = true;
    }

    void ThisisitLuigi()
    {
        Vector3 MushroomKingdom = new Vector3(-6.5f, 3.5f, 0);
        int j = 0;
        int i = 0;
        while (j < amount)
        {
            if (tainer[j] == pear[i])
            {
                prefabNames[i].transform.position = MushroomKingdom;
                MushroomKingdom.x += 2;
                j++;
                if (MushroomKingdom.x >= 8)
                {
                    MushroomKingdom.x = -6.5f;
                    MushroomKingdom.y -= 1.5f;

                }
            }
            i++;
            if (i == amount) { i = 0; }
        }
    }
}
