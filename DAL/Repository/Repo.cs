﻿using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    internal class Repo
    {
        protected VMSContext db;
        internal Repo()
        {
            db = new VMSContext();
        }
    }
}
