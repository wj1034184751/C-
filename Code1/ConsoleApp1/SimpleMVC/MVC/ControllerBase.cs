﻿using SimpleMVC.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.MVC
{
    public abstract class ControllerBase:IController
    {
        protected IActionInvoker ActionInvoker { get; set; }

        public ControllerBase()
        {
            this.ActionInvoker = new ControllerActionInvoker();
        }

        public void Execute(RequestContext requestContext)
        {
           
        }
    }
}