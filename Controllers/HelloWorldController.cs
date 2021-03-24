using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Get：/HelloWorld/Welcome
        //名字为目标URI
        //Controller/ActionNAme/Param
        //加上参数： HelloWorld/Welcome?name = Rick & numtimes = 4
        public IActionResult Welcome(string name, int numTimes = 1)
        {

            //使用视图模版生成动态响应
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}