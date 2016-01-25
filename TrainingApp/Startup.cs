using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(TrainingApp.Startup))]
namespace TrainingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // dunno
        }
    }
}