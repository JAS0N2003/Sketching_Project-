using System.Collections;
using System.Collections.Generic;
using TiltBrush;
using UnityEngine;

public class ColorButton : MonoBehaviour
{
    public Color colorToSet;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            BrushColorController brush = other.GetComponent<BrushColorController>();
            if (brush != null)
            {
                brush.CurrentColor = colorToSet;
            }
        }
    }
}

