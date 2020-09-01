using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalProject.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProject.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Success(Accounts acc)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["admin_db"].ConnectionString;

            string query = "INSERT INTO Users VALUES ('" + acc.FName + "', '" + acc.Uname + "', '" + acc.Password + "')";

            SqlCommand cmd = new SqlCommand(query, con);
 
            con.Open();
            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LSuccess(Accounts acc)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["admin_db"].ConnectionString;

            string query = "SELECT * FROM Users WHERE FName = '" + acc.FName + "'and UName = '" + acc.Uname + "'and Password = '" + acc.Password + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return View("Success");
            }
            else
            {
                con.Close();
                return View("ErrorLogin");
            }
        }

        [HttpPost]
        public ActionResult Contact(ContactUs ct)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["admin_db"].ConnectionString;

            string query = "INSERT INTO Contact VALUES ('" + ct.name + "', '" + ct.email + "', '" + ct.message + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                con.Close();
                return View("Success");
            }
            else
            {
                con.Close();
                return View();
            }
        }

        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dispatch(Checkout cout)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["admin_db"].ConnectionString;

            string query = "INSERT INTO Checkout VALUES ('" + cout.Fname + "', '" + cout.Lname + "', '" + cout.username + "', '" + cout.email + "', '" + cout.Address + "', '" + cout.State + "', '" + cout.paymentMethod + "', '" + cout.cardnumber + "')";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            if (i == 1)
            {
                con.Close();
                return View();
            }
            else
            {
                con.Close();
                return View();
            }
        }
    }
}