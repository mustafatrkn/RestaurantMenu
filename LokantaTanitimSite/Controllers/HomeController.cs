using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace LokantaTanitimSite.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult AnaSayfa()
        {
            return View();
        }

        public void sendMessage(string name, string message, string eposta)
        {
            MailMessage mesajim = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("mustafatrkn93@outlook.com", "haskovo35");
            istemci.Port = 587;
            istemci.Host="smtp.live.com";
            istemci.EnableSsl = true;
            mesajim.To.Add("mustafatrkn93@outlook.com");
            mesajim.From=new MailAddress(eposta);
            mesajim.Subject="Müşteri Bilgilendirme";
            mesajim.Body=message;
            istemci.Send(mesajim);

        }

        [HttpPost]
        public JsonResult PostMessage(string name, string message, string eposta)
        {
            var deger = "";
            if (eposta !=null)
            {                
                sendMessage(name, message, eposta);
                deger = "1";
            }
            else
            {
                deger = "0";
            }


            return Json(deger);
        }



    }
}