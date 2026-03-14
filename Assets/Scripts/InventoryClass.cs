using UnityEngine;

public class InventoryClass : MonoBehaviour
{
    private List<InventoryItem> inventoryItems; //list of items currently in player inventory
    int maxNumItems = 5; //max num of items is 5
    int currentItemCount = 0; //number of items currently in inventory

    public InventoryClass()
    {
        inventoryItems = new List<InventoryItem>(); //initializing empty list
    }
    public class InventoryItem
    {
        public string itemName;
        public double price;
        public int nutritionValue;

        // Constructors for InventoryItem
        public InventoryItem(string name, double prc, int nutrients)
        {
            itemName = name;
            price = prc;
            nutritionValue = nutrients;
        }

        //GroceryList Contructor
        public InventoryItem(string name)
        {
            itemName = name;
            price = 0;
            nutritionValue = 0;
        }

        public double getPrice()
        {
            return price;
        }

        public bool equals(string name1, string name2)
        {
            //only comparing strings to remove technical discrepancies (ie, for grocery list, bad apple technically equals good apple)
            return name1.equals(name2);
        }
    }

    //methods

    /*
    * @Method add an item to the inventory list
    * @Return true if successful, false otherwise
    */
    public bool AddItem(InventoryItem item)
    {
        if (currentItemCount == maxNumItems)
        {
            return false;
        }
        //adding item
        bool check = inventoryItems.Add(item);
        if (check) {
            currentItemCount++;
        }
        return check;
    }

    /*
    * @Method remove item parameter from inventory list
    * @Return True if successful, False otherwise
    */
    public bool removeItem(InventoryItem item)
    {
        //removing item
        bool check = inventoryItems.Remove(item);
        if (check) {
            currentItemCount--;
        }
        return check;
    }

    /*
    * get access to the inventory list
    */
    public List<InventoryItem> GetList()
    {
        return inventoryItems;
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
