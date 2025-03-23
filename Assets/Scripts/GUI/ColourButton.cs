using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TiltBrush
{

    public class ColourButton : BaseButton
    {
        public Color colour;
        private ColorController m_ColorController;

        override protected void Start()
        {
            base.Start();

            // Default to brush color controller.
            m_ColorController = App.BrushColor;

            // // Walk upward and find the first ColorController relevant to us.
            // for (var manager = m_Manager; manager != null; manager = manager.ParentManager)
            // {
            //     ColorController controller = manager.GetComponent<ColorController>();
            //     if (controller != null)
            //     {
            //         m_ColorController = controller;
            //         break;
            //     }
            // }
        }

        override protected void OnButtonPressed()
        {
            m_ColorController.CurrentColor = colour;
        }
    }
} // namespace TiltBrush
