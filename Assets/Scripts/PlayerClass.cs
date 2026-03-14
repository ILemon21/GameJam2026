using UnityEngine;
using System.Collections.Generic;
using System;

public class PlayerClass : MonoBehaviour
{
    public double currFunds = 100;
    public static double busFare = 5;
    public InventoryClass inventory;
    public int totalNutrition = 0;

    void Awake()
    {
        inventory = new InventoryClass();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //methods

    /*
     * pay the bus fare
     */
    public void payBusFare()
    {
        currFunds -= busFare;
        print("Successfully paid bus fare");
    }

    /*
     * add an item to inventory list
     */

    public void addItem(InventoryItem item)
    {
        inventory.AddItem(item);
        currFunds -= item.getPrice();
        totalNutrition += item.nutritionValue;
        print("Successfully removed: " + item.itemName);
    }

    public void removeItem(InventoryItem item)
    {
        inventory.removeItem(item);
        currFunds += item.getPrice();
        totalNutrition -= item.nutritionValue;
        print("Successfully bought: " + item.itemName);
    }

}
