using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductWeb.Models;                        // 引用 Models 資料夾

namespace ProductWeb.Controllers
{
    public class HomeController : Controller    // 控制器繼承自 Controller
    {
        ProductDBEntities db = new ProductDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var products = db.產品.ToList();
            return View(products);
        }
        public ActionResult Delete(string pid)
        {
            var product = db.產品.Where(m=>m.編號==pid).FirstOrDefault();
            db.產品.Remove(product);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(HttpPostedFileBase image, 產品 product)
        {
            try
            {
                string imgFileName = "q.jpg";
                if (image != null && image.ContentLength > 0)
                {
                    imgFileName = $"{Guid.NewGuid().ToString()}.jpg";
                    string path = $"{Server.MapPath("~/Images")}/{imgFileName}";
                }
                product.圖示 = imgFileName;
                db.產品.Add(product);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                ViewBag.Msg = $"編號重複";
                return View(product);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(string pid)
        {
            var product = db.產品.Where(m => m.編號 == pid).FirstOrDefault();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(HttpPostedFileBase imgfile, 產品 product)
        {
            // 找出要修改的產品紀錄 temp
            string pid = product.編號;
            var temp = db.產品.Where(m => m.編號 == pid).FirstOrDefault();
            // 預設 imgFileName 為舊的圖檔
            string imgFileName = temp.圖示;
            // 上傳新的圖檔
            if(imgfile != null && imgfile.ContentLength > 0)
            {
                // 重新指定新上傳的圖檔名稱給 imgFileName
                imgFileName = $"{Guid.NewGuid().ToString()}.jpg";
                string path = $"{Server.MapPath("~/Images")}/{imgFileName}";
                imgfile.SaveAs(path);
            }
            // 修改產品紀錄
            temp.品名 = product.品名;
            temp.單價 = product.單價;
            temp.數量 = product.數量;
            temp.圖示 = imgFileName;
            db.SaveChanges();           // 將修改的產品紀錄寫回資料庫
            return RedirectToAction("Index");
        }
    }
}