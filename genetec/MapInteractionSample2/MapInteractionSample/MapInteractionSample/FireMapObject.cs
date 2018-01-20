﻿using Genetec.Sdk.Entities.Maps;
using System;

// ==========================================================================
// Copyright (C) 2017 by Genetec, Inc.
// All rights reserved.
// May be used only in accordance with a valid Source Code License Agreement.
// ==========================================================================
namespace MapInteractionSample
{
    /// <summary>
    /// This class represent an object to display on the map.
    /// With the MapObject attribute, you can specify the view to use.
    /// </summary>
    [MapObject(IdString, typeof(FireMapObjectView), false)]
    public sealed class FireMapObject : MapObject
    {
        #region Constants

        public static readonly Guid FiresLayerId = new Guid("{6108C748-217F-4FCF-A362-2A0EC1D03424}");

        private static readonly Guid FireMapObjectId = new Guid(IdString);
        private const string IdString = "{59AA6A48-2A1F-4EA2-B2DA-A24C791D435D}";

        public const string FireLayerName = "Fires";

        #endregion

        #region Properties

        public DateTime Date { get; set; }

        public string Description { get; set; }

        public override bool IsClusterable => false;

        public override Guid LayerId => FiresLayerId;

        #endregion

        #region Constructors

        public FireMapObject(double latitude, double longitude)
                    : base(FireMapObjectId)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        #endregion
    }
}

