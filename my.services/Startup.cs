﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(my.services.Startup))]

namespace my.services
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Dummy comment
            ConfigureAuth(app);
        }
    }
}
