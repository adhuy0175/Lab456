﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranQuangHuy_Lab456.Startup))]
namespace TranQuangHuy_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
