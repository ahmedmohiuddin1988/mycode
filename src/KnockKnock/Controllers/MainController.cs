//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using System.Net;
 

//// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//namespace WebApplication6.Controllers
//{
    
//    //public class MainController : Controller
//    //{
//    //    [HttpGet]
//    //    [Route("api/ReverseWords")]
        
    
//    //    public string GetReverseWords(string sentence)
//    //    {
//    //        return  (string.Join(" ",
//    //     sentence.Split(' ')
//    //        .Select(x => new string(x.Reverse().ToArray()))));
//    //    }

//    //    [HttpGet]
//    //    [Route("api/Fibonacci")]
//    //    public IActionResult GetFibonacci(long n)
//    //    {
//    //        if (n >92)
//    //            return BadRequest();
//    //        else
//    //        return Ok( NthFibonacciNumber(n));
//    //    }

//    //    public static double NthFibonacciNumber(long n)
//    //    {
//    //        return ( Math.Round(
//    //            Math.Pow(GetPhi(),n)/Math.Sqrt(5)
//    //            ));
//    //    }

//    //    private static double GetPhi()
//    //    {
//    //        return (1 + Math.Sqrt(5)) / 2;
//    //    }

//    //    [HttpGet]
//    //    [Route("api/Token")]
//    //    public string GetToken()
//    //    {
//    //        return  ("64a767e4-8153-4e8d-a3f2-ddc2b9334fd4");
//    //    }

//    //    [HttpGet]
//    //    [Route("api/TriangleType/")]
//    //    public string GetTriangleType(int a, int b, int c)
//    //    {
          
//    //        try
//    //        {
//    //            //checked if any side of triagle is not zero
//    //            if (a <= 0 || b <= 0 || c <= 0)
//    //            {
//    //              return Triangle.Error.ToString();
//    //            }

//    //            //check for triangle inequality theorem

//    //            if (((b + c) < a) || ((a + c) < b) || ((a + b) < c))

//    //            {
//    //                return Triangle.Error.ToString();

//    //            }

             
//    //            if (a == b && a == c)
//    //            {
//    //                return Triangle.Equilateral.ToString();
//    //            }
//    //            else if (a == b || a == c || b == c)  
//    //            {
//    //                return Triangle.Isosceles.ToString();
//    //            }
//    //            else  
//    //            {
//    //                return Triangle.Scalene.ToString();
//    //            }
//    //        }
//    //        catch (Exception ex)
//    //        {
//    //            return Triangle.Error.ToString();
//    //        }
           
//    //    }
//    //}
//}
