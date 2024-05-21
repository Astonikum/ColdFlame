using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllasticCore : MonoBehaviour
{
    public EllasticSize[] objects = { };

    public bool updateEveryTick = true;
    private Vector2 screenSize = new Vector2(1920, 1080);

    public Vector2 ScreenSize { get => screenSize; set => screenSize = value; }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (updateEveryTick)
        {
            foreach (EllasticSize obj in objects)
            {
                obj.Tick(screenSize);
            }
        }
    }
}
