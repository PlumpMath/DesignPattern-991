﻿/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter10
{
    public class SatNavVehicle : AbstractVehicleOption
    {
        public SatNavVehicle(IVehicle vehicle)
            : base(vehicle)
        {
        }

        public override int Price
        {
            get
            {
                return decoratedVehicle.Price + 1500;
            }
        }

        public virtual string Destination
        {
            set
            {
                // code to set the destination...
            }
        }

    }
}
