﻿// Copyright 2022 The Open Brush Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

namespace TiltBrush.Layers
{
    public class FocusLayerButton : ToggleButton
    {
        private void OnEnable()
        {
            LayerUI_Manager.onActiveSceneChanged += SyncButtonStateWithWidget;
        }

        protected override void OnDisable()
        {
            LayerUI_Manager.onActiveSceneChanged -= SyncButtonStateWithWidget;
        }

        protected override void OnButtonPressed()
        {
            base.OnButtonPressed();
            GetComponentInParent<LayerUI_Manager>().SetActiveLayer(transform.parent.gameObject);
        }

        public void SyncButtonStateWithWidget(GameObject activeLayerWidget)
        {
            if (activeLayerWidget == null) return;
            SetButtonActivation(activeLayerWidget == transform.parent.gameObject);
        }

    }
}
