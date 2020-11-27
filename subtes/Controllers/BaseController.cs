using Flurl.Http;
using subtes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace subtes.Controllers
{
    public class BaseController : Controller
    {
        private String baseURL = "https://apitransporte.buenosaires.gob.ar/subtes/";
        private String client_secret = "5dA54E38858C42818512967490C03dB7";
        private String client_id = "2738f8b2029445d99e14f44fafa41401";

        internal Root TraerDatos()
        {
            String url = baseURL + "forecastGTFS?client_secret=" + client_secret + "&client_id=" + client_id;

            try
            {
                var request = url.GetJsonAsync<Root>();
                return request.Result;
            }
            catch (FlurlHttpTimeoutException ex)
            {
               
            }
            catch (FlurlHttpException ex)
            {
               
            }
            catch (Exception ex)
            {
               
            }
            return null;
        }


    }
}