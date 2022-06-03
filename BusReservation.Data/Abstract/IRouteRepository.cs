﻿using BusReservation.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusReservation.Data.Abstract
{
    public interface IRouteRepository : IRepository<Route>
    {
        List<Route> FindRoute(string cityStart, string cityLast, DateTime goingDate);
        Route FindRouteWithId(int id);
        public int GetRouteFromRouteId(int id);
    }
}