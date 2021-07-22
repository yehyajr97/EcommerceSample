using Business_Layer__BL_.AppServices;
using Business_Layer__BL_.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class OrderController : Controller
    {

        OrderAppSevice orderAppSevice = new OrderAppSevice();

        //Allow for user
        #region Get All
        public ActionResult Index()
        {
            return View(orderAppSevice.GetAllOrder());
        }
        #endregion

        //Allow for user
        #region Create New
        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(OrderViewModel order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }
            else
            {
                try
                {
                    orderAppSevice.SaveNewOrder(order);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(order);
                }
            }
        }
        #endregion

        //Allow for user
        #region Details
        public ActionResult Details(int id)
        {
            return View(orderAppSevice.GetOrder(id));
        }
        #endregion

        //Allow for user
        #region Update
        public ActionResult Update(int id) => View();

        [HttpPost]
        public ActionResult Update(int id, OrderViewModel order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }
            else
            {
                try
                {
                    orderAppSevice.UpdateOrder(order);
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(order);
                }
            }
        }
        #endregion

        //Allow for user
        #region Delete
        public ActionResult Delete(int id)
        {
            orderAppSevice.DeleteOrder(id);
            return RedirectToAction("Index");
        } 
        #endregion
    }
}