using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ControlsData;

public class OpenCloseInventory : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    private ControlsData controlsData;

    private KeyCode openCloseKey;
    private KeyCode openCloseKeyAlt;


    private void Start()
    {
        controlsData = GameObject.FindGameObjectWithTag("Data").GetComponent<ControlsData>();

        foreach (Control c in controlsData.controls)
        {
            if (c.name == "client_inventory_open") { openCloseKey = c.key; }
            else if (c.name == "client_inventory_open_alt") { openCloseKeyAlt = c.key; }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(openCloseKey) || Input.GetKeyDown(openCloseKeyAlt))
        {
            ChangeActiveness();
        }
    }

    public void ChangeActiveness()
    {
        obj.SetActive(!obj.activeSelf);
    }

}
