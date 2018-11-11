/*
    Team 1-3: Tiara Johnson, Bailey Coleman, HaiJung Hsu, and Ethan Guinn
    Description: This website offers specific information about missions 
                as well as opportunities for user to both ask new questions 
                and give answers regarding specific mission details.
    Date: 11/10/2018
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MissionSite_Project1_Team1_3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Missions()
        {
            return View();
        }

        public ActionResult MissionFAQ(string MissionName)
        {
            return View();
        }

        public ActionResult LondonEngland()
        {
            ViewBag.mTitle = "London England";
            ViewBag.mFlag = "/Content/Images/UKFlag.png";
            ViewBag.mPresident = "President Mark W. Stevens";
            ViewBag.mAddress = "64-68 Princes Gate, Exhibition Road, South Kensington, London England";
            ViewBag.mLanguage = "English";
            ViewBag.mReligion = "Church of England, Catholic";
            return View("MissionFAQ");
        }

        public ActionResult ChinaHongKong()
        {
            ViewBag.mTitle = "China Hong Kong";
            ViewBag.mFlag = "/Content/Images/HongKongFlag.png";
            ViewBag.mPresident = "President Maurice Lam";
            ViewBag.mAddress = "18 Dorset Crescent, Kowloon Tong, Kowloon, Hong Kong";
            ViewBag.mLanguage = "Cantonese, Mandarin, English, and Tagalog";
            ViewBag.mReligion = "Ancestor worship, Buddhism, Taoism, and Christianity";
            return View("MissionFAQ");
        }

        public ActionResult UtahOgden()
        {
            ViewBag.mTitle = "Utah Ogden";
            ViewBag.mFlag = "";
            ViewBag.mPresident = "";
            ViewBag.mAddress = "";
            ViewBag.mLanguage = "";
            ViewBag.mReligion = "";
            return View("MissionFAQ");
        }
    }
}
