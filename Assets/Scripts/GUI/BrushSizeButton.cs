using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TiltBrush
{

    public class BrushSizeButton : BaseButton
    {
        [SerializeField] private bool m_EatGazeInputOnPress = false;
        private bool ToggleActive = false;

        override public void UpdateVisuals()
        {
            base.UpdateVisuals();
            // Toggle buttons poll for status.
            if (m_ToggleButton)
            {
                SetButtonActivated(ToggleActive);
            }
        }

        override protected void OnButtonPressed()
        {
            ToggleActive = !ToggleActive; // Toggle the active state
        }

        void Update()
        {
            if (ToggleActive)
            {
                var controllerInfo = InputManager.Controllers[(int)InputManager.ControllerName.Wand];
                if (controllerInfo != null)
                {
                    // Get the vertical value of the left stick
                    float stickVertical = controllerInfo.GetScrollYDelta();

                    // When left stick is pushed up, increase brush size
                    if (stickVertical > 0.5f)
                    {
                        PointerManager.m_Instance.AdjustAllPointersBrushSize01(0.01f);
                    }
                    // When left stick is pushed down, decrease brush size
                    else if (stickVertical < -0.5f)
                    {
                        PointerManager.m_Instance.AdjustAllPointersBrushSize01(-0.01f);
                    }
                }
            }
        }
    }
} // namespace TiltBrush