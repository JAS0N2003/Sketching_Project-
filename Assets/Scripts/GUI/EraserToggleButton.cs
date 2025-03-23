using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TiltBrush
{

    public class EraserToggleButton : BaseButton
    {
        [SerializeField] private bool m_EatGazeInputOnPress = false;
        [SerializeField] private BaseTool.ToolType m_Tool;
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
            if (ToggleActive)
            {
                ToggleActive = false;
            }
            else
            {
                ToggleActive = true;
            }
        }

        void Update()
        {
            if (ToggleActive)
            {
                var controllerInfo = InputManager.Controllers[(int)InputManager.ControllerName.Wand];
                if (controllerInfo != null && controllerInfo.IsTrigger())
                {
                    SketchSurfacePanel.m_Instance.EnableSpecificTool(m_Tool);
                } else {
                    SketchSurfacePanel.m_Instance.DisableSpecificTool(m_Tool);
                }
            }
        }
    }
} // namespace TiltBrush
