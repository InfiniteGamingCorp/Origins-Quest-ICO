using OriginsQuestICO.Helpers;
using OriginsQuestICO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OriginsQuestICO.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public async Task<ActionResult> ContactFormAsync(ContactFormViewModel vm)
        {
            var email = new EmailModel()
            {
                FromEmail = vm.Email,
                FromName = vm.Name,
                Message = vm.Comment,
            };

            var result = await MailManager.SendEmailAsync(email);

            return Json(new { success = result, mailId = 0});
        }

        [HttpPost]
        public async Task<ActionResult> SubscribeAsync(string SubscriberEmail)
        {
            var success = false;

            try
            {
                var manager = new NewsletterManager();
                var newSubscriber = await manager.SubscribeEmailToNewsletter(SubscriberEmail);
                if (newSubscriber != null) success = true;
            }
            catch (Exception e)
            {
                success = false;
            }
            
            return Json(new { success = success });
        }
    }
}