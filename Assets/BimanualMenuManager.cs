using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TiltBrush;

public class BimanualMenuManager : MonoBehaviour
{
    // public GameObject menu;
    // public Button paintPaletteButton;
    // public Button toolButton1;
    // public Button toolButton2;

    // private bool isMenuVisible = false;
    // private Transform leftControllerTransform;
    // private PaintPaletteTool paintPaletteTool;

    // void Start()
    // {
    //     // Hide the menu initially
    //     menu.SetActive(false);

    //     // Add listeners to the buttons
    //     paintPaletteButton.onClick.AddListener(OnPaintPaletteButtonClicked);
    //     toolButton1.onClick.AddListener(OnToolButton1Clicked);
    //     toolButton2.onClick.AddListener(OnToolButton2Clicked);

    //     // Find the left controller transform
    //     var controllerInfo = InputManager.Controllers[(int)InputManager.ControllerName.Wand];
    //     if (controllerInfo != null)
    //     {
    //         leftControllerTransform = controllerInfo.Transform;
    //         // Attach the menu to the left controller
    //         menu.transform.SetParent(leftControllerTransform, false);
    //     }
    //     else
    //     {
    //         Debug.LogError("Left controller not found");
    //     }

    //     // Find the PaintPaletteTool in the scene
    //     paintPaletteTool = FindObjectOfType<PaintPaletteTool>();
    //     if (paintPaletteTool == null)
    //     {
    //         Debug.LogError("PaintPaletteTool not found in the scene");
    //     }
    // }

    // void Update()
    // {
    //     // Check if the trigger button on the left controller is held down
    //     var controllerInfo = InputManager.Controllers[(int)InputManager.ControllerName.Wand];
    //     if (controllerInfo != null && controllerInfo.IsTrigger())
    //     {
    //         if (!isMenuVisible)
    //         {
    //             ShowMenu();
    //         }
    //     }
    //     else
    //     {
    //         if (isMenuVisible)
    //         {
    //             HideMenu();
    //         }
    //     }
    // }

    // void ShowMenu()
    // {
    //     menu.SetActive(true);
    //     isMenuVisible = true;
    // }

    // void HideMenu()
    // {
    //     menu.SetActive(false);
    //     isMenuVisible = false;
    // }

    // void OnPaintPaletteButtonClicked()
    // {
    //     if (paintPaletteTool != null)
    //     {
    //         paintPaletteTool.ShowPalette();
    //     }
    // }

    // void OnToolButton1Clicked()
    // {
    //     // Placeholder for future tool
    //     Debug.Log("ToolButton1 clicked");
    // }

    // void OnToolButton2Clicked()
    // {
    //     // Placeholder for future tool
    //     Debug.Log("ToolButton2 clicked");
    // }
}
