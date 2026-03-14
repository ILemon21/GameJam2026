using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;


public class GroceryList : MonoBehaviour
{
    public static List<InventoryItem> needToBuy = new List<InventoryItem>();
    public static List<InventoryItem> wantToBuy = new List<InventoryItem>();
    private TMP_Text m_text;
    // private float m_frame;
    // public enum objectType { TextMeshPro = 0, TextMeshProUGUI = 1 };

    // public objectType ObjectType;

    private string list;

    private static bool updateNeeded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // public GroceryList()
    // {
        
    // }

    public static string toString()
    {
        string done = "Need to Buy:\n";
        //adding needToBuy
        foreach (InventoryItem item in needToBuy)
        {
            done += item.itemName + "\n";
        }
        //adding wantToBuy
        done += "Want to Buy:\n";
        foreach (InventoryItem item in wantToBuy)
        {
            done += item.itemName + "\n";
        }
        print("final string: " + done);
        // done = done.Replace("\n", System.Environment.NewLine);
        return done;
    }

    public void setUpdateNeeded(bool holder)
    {
        updateNeeded = holder;
    }

    //used for initialization
    void Awake()
    {
        //initializing needToBuy list
        needToBuy.Add(new InventoryItem("Apple"));
        needToBuy.Add(new InventoryItem("Banana"));
        needToBuy.Add(new InventoryItem("1 meal (ex: Ramen, hot dog, cooked fish)"));

        //initializing wantToBuy list
        wantToBuy.Add(new InventoryItem("Apple pie"));
        wantToBuy.Add(new InventoryItem("Chips"));
        wantToBuy.Add(new InventoryItem("Eggs"));

        list = "Apple pie";
        print(list);

        //making textMeshPro stuff
        // print("ObjectType: " + ObjectType);
        // if (ObjectType == 0) {
        //     m_text = GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        // }
        // else
        // {
        m_text = GetComponent<TextMeshProUGUI>() ?? gameObject.AddComponent<TextMeshProUGUI>();
        print("in else");
        // }
        m_text.autoSizeTextContainer = true;

        //set text
        m_text.text = list;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (updateNeeded) {
            m_text.SetText(list);
        }
        // m_frame += 1 * Time.deltaTime;
    }
}
