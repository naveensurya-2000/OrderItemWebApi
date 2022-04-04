using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderItemWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace OrderItemWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public Cart Post(int menuItemId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://20.88.191.182/api/");
                var response = client.GetAsync($"MenuItem/{menuItemId}");
                response.Wait();
                var res = response.Result;
                var list = res.Content.ReadAsAsync<MenuItem>();
                list.Wait();
                var menuItem = list.Result;
                return new Cart(1, 1, menuItemId, menuItem.Name);
            }
        }
    }
}

