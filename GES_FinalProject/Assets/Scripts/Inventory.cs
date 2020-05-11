using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
     [SerializeField] GameObject[] Chickens = new GameObject[5];
    private int count = 0;

    public void addChicken(GameObject collidedChicken)
    {
        if (count < 5)
        {
            Chickens[count] = collidedChicken;
        }
    }

    public GameObject getChicken()
    {
        return Chickens[count];
    }
}
