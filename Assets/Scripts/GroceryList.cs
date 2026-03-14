using UnityEngine;
using TMPro;
using System;

public class GroceryList : MonoBehaviour
{
    public List<InventoryItem> needToBuy = new List<InventoryItem>();
    public List<InventoryItem> wantToBuy = new List<InventoryItem>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GroceryList()
    {
        //initializing needToBuy list
        needToBuy.Add(new InventoryItem("Apple"));
        needToBuy.Add(new InventoryItem("Banana"));
        needToBuy.Add(new InventoryItem("1 meal (ex: Ramen, hot dog, cooked fish)"));

        //initializing wantToBuy list
        wantToBuy.Add(new InventoryItem("Apple pie"));
        wantToBuy.Add(new InventoryItem("Chips"));
        wantToBuy.Add(new InventoryItem("Eggs"));
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
