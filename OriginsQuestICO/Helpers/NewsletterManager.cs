using MailChimp.Net;
using MailChimp.Net.Interfaces;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace OriginsQuestICO.Helpers
{
    public class NewsletterManager
    {
        public string APIKey { get; set; }

        public NewsletterManager(string _apiKey)
        {
            APIKey = "8502768580ac82248e796ee7c0643da5-us7";
        }

        public async Task<Member> SubscribeEmailToNewsletter(string _email)
        {
            try
            {
                IMailChimpManager manager = new MailChimpManager(APIKey);
                var mailChimpListCollection = await manager.Lists.GetAllAsync().ConfigureAwait(false);

                var listId = "94815bc58b";
                var member = new Member { EmailAddress = _email, StatusIfNew = Status.Subscribed };
                var res = await manager.Members.AddOrUpdateAsync(listId, member);

                return res;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
    }
}