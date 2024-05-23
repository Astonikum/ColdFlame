using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EllasticSize : MonoBehaviour
{
    public float horizontalSize;
    public string horizontalSizeAxis;

    public float verticalSize;
    public string verticalSizeAxis;

    private Transform transform;

    private Vector3 scale;

    private void Start()
    {
        transform = gameObject.GetComponent<Transform>();
    }


    public void Tick(Vector2 UISize)
    {
        switch (horizontalSizeAxis)
        {
            case "H":
                scale.x = (int)(UISize.x * (horizontalSize / 100));
                break;
            case "V":
                scale.x = (int)(UISize.y * (horizontalSize / 100));
                break;
        }

        switch (verticalSizeAxis)
        {
            case "H":
                scale.y = (int)(UISize.x * (verticalSize / 100));
                break;
            case "V":
                scale.y = (int)(UISize.y * (verticalSize / 100));
                break;
        }

        transform.localScale = scale;
    }
}
