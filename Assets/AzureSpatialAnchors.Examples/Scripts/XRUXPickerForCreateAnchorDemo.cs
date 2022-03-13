// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Microsoft.Azure.SpatialAnchors.Unity.Examples
{
    /// <summary>
    /// Picks the appropriate UI game object to be used in the CreateAnchor demo.
    /// This allows us to have both HoloLens and Mobile UX in the same
    /// scene.
    /// </summary>
    public class XRUXPickerForCreateAnchorDemo : XRUXPicker
    {
        private static XRUXPickerForCreateAnchorDemo _Instance;
        public new static XRUXPickerForCreateAnchorDemo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = FindObjectOfType<XRUXPickerForCreateAnchorDemo>();
                }

                return _Instance;
            }
        }

        /// <summary>
        /// Gets the input field used in the demo.
        /// </summary>
        /// <returns>The input field used in the demo.</returns>
        public InputField GetDemoInputField()
        {
#if UNITY_WSA
            return HoloLensUXTree.GetComponentInChildren<InputField>(true);
#else
            return MobileAndEditorUXTree.GetComponentInChildren<InputField>(true);
#endif
        }
    }
}
