using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

using static ItemsData;

public class PlayersData : MonoBehaviour
{
    //public Player[] players = new Player[] { };
    public Player player;

    void Start()
    {
        Debug.Log(player.AddItems(0, "test", 22));
    }
}

[Serializable]
public class Player
{
    public string nick = "player";

    public float HP = 20f;
    public float STAMINA = 100f;
    public float HUNGER = 20f;

    public Slot[] inventory;

    [SerializeField] private ItemsData itemData;
    private void Awake()
    {
        inventory = new Slot[21];
        itemData = GameObject.FindGameObjectWithTag("Data").GetComponent<ItemsData>();
    }

    public string AddItems(int slotID, string itemID, int amount, int repeatCount = 0)
    {
        if (repeatCount >= inventory.Length)
        {
            return "Inventory is full";
        }
        
        foreach (Item i in itemData.items)
        {
            foreach (Slot s in inventory)
            {
                if (s.slotID == slotID && (s.itemID == "" || s.itemID == itemID))
                {
                    if (i.id == itemID)
                    {
                       if (i.maxItemsInSlot - (s.itemAmmount + amount) >= 0) {
                            s.itemID = itemID;
                            s.itemAmmount += amount;
                            return $"Added {amount - s.itemAmmount} of {itemID}";
                       } else {
                            s.itemID = itemID;
                            s.itemAmmount = i.maxItemsInSlot;
                            if (slotID + 1 == inventory.Length) { AddItems(0, itemID, (s.itemAmmount + amount) - i.maxItemsInSlot, repeatCount + 1); }
                            else { AddItems(slotID + 1, itemID, (s.itemAmmount + amount) - i.maxItemsInSlot, repeatCount + 1);  }
                            return $"Added {amount - s.itemAmmount} of {itemID}";
                        }
                    }
                }
            }
            if (slotID + 1 == inventory.Length) { AddItems(0, itemID, amount, repeatCount + 1); }
            else { AddItems(slotID + 1, itemID, amount, repeatCount + 1); }
        }

        return "Invalid item ID";
    }
}


[Serializable]
public class Slot
{
    public int slotID;
    public string itemID;
    public int itemAmmount;
}

