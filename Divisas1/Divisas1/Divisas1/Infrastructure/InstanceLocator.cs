﻿using Divisas1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisas1.Infrastructure
{
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }

    }
}
