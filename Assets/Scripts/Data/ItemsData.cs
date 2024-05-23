using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;

public class ItemsData : MonoBehaviour
{
    public Item[] items = new Item[] { };
}

[Serializable]
public class Item
{
    public string id;
    public int maxItemsInSlot = 64;
    public Sprite texture;

    public UnityEvent onClick;
    public UnityEvent onAltClick;
    public UnityEvent onTickWhenHold;
    public UnityEvent onStartHolding;
    public UnityEvent onEndHolding;
}
