using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
     [SerializeField] GameObject Chicken;

    public void addChicken(GameObject collidedChicken)
    {
        Chicken = collidedChicken;
    }

    public GameObject getChicken()
    {
        return Chicken;
    }
}
