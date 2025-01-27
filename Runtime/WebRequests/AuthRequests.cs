﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ReadyPlayerMe.AvatarCreator
{
    public static class AuthRequests
    {
        public static async Task<UserSession> LoginAsAnonymous(string domain)
        {
            var url = Endpoints.AUTH.Replace("[domain]", domain);
            var headers = new Dictionary<string, string>
            {
                { "Content-Type", "application/json" },
            };

            var request = await WebRequestDispatcher.SendRequest(url, Method.POST, headers);

            if (string.IsNullOrEmpty(request.Text))
            {
                throw new Exception("No response received");
            }

            var response = JObject.Parse(request.Text);
            var data = response.GetValue("data");

            if (data == null)
            {
                throw new Exception("No data received");
            }

            return JsonConvert.DeserializeObject<UserSession>(data!.ToString());
        }
    }
}
