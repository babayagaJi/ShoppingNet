using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ShoppingSolution.Models;

namespace ShoppingSolution.Controllers
{
    public class Common
    {
        static bool IsAdmin()
        {

            /*

            if (Session["Name"] != null && Session["Role"] == 1)
            {
                return true;
            }
            */
            return false;
        }
    }
}