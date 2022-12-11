﻿using OrderItemsWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrderItemsWeb.Controllers
{
	public class OrderCartController : Controller
	{
		private DevConn db = new DevConn();

		private string cart = "Cart";

		// GET: OrderCart
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult OrderNow(string id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
			}

			if (Session[cart] == null)
			{
				List<Cart> carts = new List<Cart> { new Cart(db.Products.Find(id), 1) };

				Session[cart] = carts;
			}
			else
			{
				List<Cart> carts = (List<Cart>) Session[cart];

				int indexAt = IsExisting(id);

				if (indexAt == -1)
				{
					carts.Add(new Cart(db.Products.Find(id), 1));
				}
				else
				{
					carts[indexAt].Quantity++;
				}

				Session[cart] = carts;
			}

			return RedirectToAction("Index");
		}

		private int IsExisting(string id)
		{
			List<Cart> carts = (List<Cart>)Session[cart];

			for (int i = 0; i < carts.Count; i++)
			{
				if (carts[i].Product.ProductID == id)
				{
					return i;
				}
			}

			return -1;
		}

		public ActionResult Delete(string id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
			}

			int indexAt = IsExisting(id);

			List<Cart> carts = (List<Cart>)Session[cart];

			carts.RemoveAt(indexAt);

			if (carts.Count == 0)
			{
				Session[cart] = null;
			}
			else
			{
				Session[cart] = carts;
			}

			return RedirectToAction("Index");
		}

		public ActionResult UpdateOrder(FormCollection formCollection)
		{
			string[] quantities = formCollection.GetValues("quantity");

			List<Cart> carts = (List<Cart>)Session[cart];

			for (int i = 0; i < carts.Count; i++)
			{
				carts[i].Quantity = Convert.ToInt32(quantities[i]);
			}

			Session[cart] = carts;

			return RedirectToAction("Index");
		}

		public ActionResult ProcessingCash()
		{
			var agents = db.Agents.ToList();

			if (agents != null)
			{
				ViewBag.Agents = agents;
			}

			return View();
		}

		public ActionResult Cash(FormCollection formCollection)
		{
			List<Cart> carts = (List<Cart>)Session[cart];

			// save order receipt
			int totalPrice = carts.Sum(c => c.Quantity * c.Product.ProductPrice);
			int totalQuantity = carts.Sum(c => c.Quantity);
			DateTime today = DateTime.Now;
			string agentId = formCollection["AgentName"];

			OrderReceipt order = new OrderReceipt()
			{
				TotalOrderPrice = totalPrice,
				TotalOrderQuantity = totalQuantity,
				OrderedDate = today,
				Status = "Unpaid",
				AgentID = agentId
			};

			db.OrderReceipts.Add(order);
			db.SaveChanges();

			// save order detail receipt
			for (int i = 0; i < carts.Count; i++)
			{
				IncludeOrderProduct detailOrder = new IncludeOrderProduct()
				{
					OrderID = order.OrderID,
					ProductID = carts[i].Product.ProductID,
					TotalProductPrice = carts[i].Product.ProductPrice * carts[i].Quantity,
					TotalProductQuantity = carts[i].Quantity
				};

				db.IncludeOrderProducts.Add(detailOrder);
				db.SaveChanges();
			}
			
			Session.Remove(cart);

			return RedirectToAction("Orders");
		}

		public ActionResult Orders()
		{
			var orders = db.OrderReceipts.ToList();

			ViewBag.Agents = db.Agents.ToList();

			return View(orders);
		}

		public ActionResult OrderDetail(int id)
		{
			var orderDetail = db.IncludeOrderProducts.Where(o => o.OrderID == id).ToList();

			ViewBag.Products = db.Products.ToList();

			return View(orderDetail);
		}
	}
}