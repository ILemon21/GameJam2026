using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;


public class GroceryList : MonoBehaviour
{
    public List<InventoryItem> needToBuy = new List<InventoryItem>();
    public List<InventoryItem> wantToBuy = new List<InventoryItem>();
    private TextMeshPro m_textMeshPro;
    private float m_frame;

    private string list;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // public GroceryList()
    // {
        
    // }

    public string toString()
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

    void Start()
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
        m_textMeshPro = GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();
        m_textMeshPro.autoSizeTextContainer = true;

        //set text
        m_textMeshPro.text = list;
        // TextMeshPro textmeshPro = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        m_textMeshPro.SetText(list);
        // m_frame += 1 * Time.deltaTime;
    }
}
