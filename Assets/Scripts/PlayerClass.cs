using UnityEngine;

public class PlayerClass : MonoBehaviour
{
    public double currFunds = 100;
    public static double busFare = 5;
    public InventoryClass inventory;
    public GroceryList groceryList;
    public int totalNutrition = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventory = new InventoryClass();
        groceryList = new GroceryList();
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
        Debug.Log("Successfully paid bus fare");
    }

    /*
     * add an item to inventory list
     */

    public void addItem(InventoryItem item)
    {
        bool check = inventory.AddItem(item);
        if (check)
        {
            currFunds -= item.getPrice();
            totalNutrition += item.nutritionValue;
            Debug.Log("Successfully removed: " + item.itemName);
        }
    }

    public void removeItem(InventoryItem item)
    {
        bool check = inventory.removeItem(item);
        if (check)
        {
            currFunds += item.getPrice();
            totalNutrition -= item.nutritionValue;
            Debug.Log("Successfully bought: " + item.itemName);
        }
    }

}
