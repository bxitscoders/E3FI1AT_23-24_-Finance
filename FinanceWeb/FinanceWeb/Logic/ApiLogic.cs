using Microsoft.AspNetCore.SignalR;
using System.Net.Http;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.CodeAnalysis;

namespace FinanceWeb.Logic
{

    public class ApiLogic
    {
        /// <summary>
        /// Load finance data from api point and load it into database
        /// </summary>
        public static async void GetAPIStocks()
        {
            JObject body;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-chart?interval=1d&symbol=ETH-CAD&range=1d&region=US"),
                Headers =
    {
        { "X-RapidAPI-Key", "9b5a28a000msh71df68bcec28ae3p126943jsn9a687871484b" },
        { "X-RapidAPI-Host", "apidojo-yahoo-finance-v1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = JObject.Parse(await response.Content.ReadAsStringAsync());
            }
            var result = body["chart"]["result"][0] as JObject;
            var metaData = result["meta"] as JObject;

            if (!SharesLogic.ShareExists(metaData["symbol"].ToString()))
            {
                int shareId = SharesLogic.CreateShare(new Entities.Shares() { Name = metaData["symbol"].ToString() });

                var value = (int)Math.Floor(decimal.Parse(metaData["regularMarketPrice"].ToString()));
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds((double)metaData["regularMarketTime"]);
                ShareValueLogic.CreateShareValue(new Entities.ShareValue() { SharesID = shareId, Value = value, Timestamp = dateTime });
            }
        }
    }
}
