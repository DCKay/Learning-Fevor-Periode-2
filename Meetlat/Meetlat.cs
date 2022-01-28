﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meetlat
{
    class Meetlat
    {
        private decimal _lengte;

        public Meetlat(decimal beginLengte)
        {
            _lengte = beginLengte;
        }
        public decimal BeginLengte
        {
            get => _lengte;

        }
        public decimal LengteInM => _lengte;

        public decimal LengteInCm => _lengte * 100;

        public decimal LengteInKm => _lengte / 1000;

        public decimal LengteInVoet => _lengte * 3.2808M;
    }
}