using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models.Cotacao;

namespace Portfolio.Controllers.Cotacao
{
    public class CotacaoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            try
            {
                HttpClient client = new HttpClient();
                List<CotacaoModel> list = new List<CotacaoModel>();

            
                var response = await client.GetAsync("https://economia.awesomeapi.com.br/json/last/BRL-USD,BRL-ARS,BRL-AUD,BRL-CAD,BRL-CHF,BRL-CLP,BRL-DKK,BRL-HKD,BRL-JPY,BRL-MXN,BRL-SGD,BRL-AED,BRL-BBD,BRL-BHD,BRL-CNY,BRL-CZK,BRL-EGP,BRL-GBP,BRL-HUF,BRL-IDR,BRL-ILS,BRL-INR,BRL-ISK,BRL-JMD,BRL-JOD,BRL-KES,BRL-KRW,BRL-LBP,BRL-LKR,BRL-MAD,BRL-MYR,BRL-NAD,BRL-NOK,BRL-NPR,BRL-NZD,BRL-OMR,BRL-PAB,BRL-PHP,BRL-PKR,BRL-PLN,BRL-QAR,BRL-RON,BRL-RUB,BRL-SAR,BRL-SEK,BRL-THB,BRL-TRY,BRL-VEF,BRL-XAF,BRL-XCD,BRL-XOF,BRL-ZAR,BRL-TWD,BRL-PYG,BRL-UYU,BRL-COP,BRL-PEN,BRL-BOB");
                //var response = await client.GetAsync("https://economia.awesomeapi.com.br/BRL-ARS,BRL-AUD,BRL-CAD,BRL-CHF,BRL-CLP,BRL-DKK,BRL-HKD,BRL-JPY,BRL-MXN,BRL-SGD,BRL-AED,BRL-BBD,BRL-BHD,BRL-CNY,BRL-CZK,BRL-EGP,BRL-GBP,BRL-HUF,BRL-IDR,BRL-ILS,BRL-INR,BRL-ISK,BRL-JMD,BRL-JOD,BRL-KES,BRL-KRW,BRL-LBP,BRL-LKR,BRL-MAD,BRL-MYR,BRL-NAD,BRL-NOK,BRL-NPR,BRL-NZD,BRL-OMR,BRL-PAB,BRL-PHP,BRL-PKR,BRL-PLN,BRL-QAR,BRL-RON,BRL-RUB,BRL-SAR,BRL-SEK,BRL-THB,BRL-TRY,BRL-VEF,BRL-XAF,BRL-XCD,BRL-XOF,BRL-ZAR,BRL-TWD,BRL-PYG,BRL-UYU,BRL-COP,BRL-PEN,BRL-BOB");
                response.Headers.Add("x-api-key", "780bf372cfb4466a4afa6e5af14321c204b90b4ee007c651c0c3bb50ac7143b4"); 

                var document = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
                var root = document.RootElement;

                foreach (var property in root.EnumerateObject())
                {
                    string currencyPair = property.Name;
                    list.Add(JsonSerializer.Deserialize<CotacaoModel>(property.Value.GetRawText()));
                    
                }

                return View(list);
            }
            catch (Exception ex)
            {

            }

            return View();
        }
    }
}
