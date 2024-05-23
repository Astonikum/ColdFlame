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

public class ControlsData : MonoBehaviour
{
    [SerializeField] public Control[] controls;

    void Start()
    {

    }

    void Update()
    {

    }
}

[Serializable]
public class Control
{
    public string name;
    public KeyCode key;
}