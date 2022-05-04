// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.Azure.SpatialAnchors.Unity.Examples
{
    public class CoarseRelocSettings
    {
        /// <summary>
        /// Whitelist of Bluetooth-LE beacons used to find anchors and improve the locatability
        /// of existing anchors.
        /// Add the UUIDs for your own Bluetooth beacons here to use them with Azure Spatial Anchors.
        /// </summary>
        public static readonly string[] KnownBluetoothProximityUuids =
        {
            "61687109-905f-4436-91f8-e602f514c96d",
            "e1f54e02-1e23-44e0-9c3d-512eb56adec9",
            "01234567-8901-2345-6789-012345678903",
            "B9407F30-F5F8-466E-AFF9-25556B57FE6D", //TheiaWayfinding Mint Beacon - only enabled for iOS currently. NOT WORKING?
            "815FA964-D990-4150-A768-4289CEE7F180", //TheiaWayfinding Blueberry beacon - only iBeacon is enabled on it currently. NOT WORKING?
            "8492E75F-4FD6-469D-B132-043FE94921D8", //virtual beacon NOT WORKING?
            "EDD1EBEA-C04E-5DEF-A017-410514E11DA9", //Blueberry broadcasting eddystone, Namespace + Instance. WORKING!
            "EDD1EBEA-C04E-5DEF-A018-C99EB10332CC", //Mint broadcasting eddystone, Namepase + Instance. WORKING!
        };
    }
}