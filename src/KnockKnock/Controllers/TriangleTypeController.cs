using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KnockKnock.Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KnockKnock.Controllers
{
    [Route("api/[controller]")]
    

    public class TriangleTypeController : Controller
    {   /// <summary>
        /// Returns the type of triange given the lengths of its sides.
        /// </summary>
        // GET: api/values Returns the type of triange given the lengths of its sides.
        //[HttpGet("{a:string}/{b:string}/{c:string}")]
        [HttpGet]
        public IActionResult Get([System.Web.Http.FromUri] TriParam obj)
        {
            try
            {
                if (!ModelState.IsValid)
                   return  BadRequest("The request is invalid.");
                int a = obj.a;
                int b = obj.b;
                int c = obj.c;
                //checked if any side of triagle is not zero

                //check for triangle inequality theorem


                if (!this.IsExistentTriangle(a, b, c))
                {
                    return    Ok(Triangle.Error.ToString());
                }
                else if (this.IsEquilateralType(a, b, c))
                {
                    return Ok(Triangle.Equilateral.ToString());
                }
                else if (this.IsScaleneType(a, b, c))
                {
                    return Ok(Triangle.Scalene.ToString());
                }
                else if (this.IsIsoscelesType(a, b, c))
                {
                    return Ok(Triangle.Isosceles.ToString());
                }
            }
            catch (Exception ex)
            {
                return Ok(Triangle.Error.ToString());
            }
            return Ok(Triangle.Error.ToString());
        }


        protected bool IsExistentTriangle(int a, int b, int c)
        {
            bool triangleExist = true;

            if (a <= 0 || b <= 0 || c <= 0)
            {
                triangleExist = false;
            }
            else if (((long)a + b) <= c)
            {
                triangleExist = false;
            }
            else if (((long)a + c) <= b)
            {
                triangleExist = false;
            }
            else if (((long)b + c) <= a)
            {
                triangleExist = false;
            }

            return triangleExist;
        }

        // An equilateral triangle has all sides the same length. 
        // An equilateral triangle is also a regular polygon with all angles measuring 60°.
        protected bool IsEquilateralType(int a, int b, int c)
        {
            return (a == b && a == c);
        }

        // An isosceles triangle has two sides of equal length.
        // An isosceles triangle also has two angles of the same measure.
        protected bool IsIsoscelesType(int a, int b, int c)
        {
            return (a == b || a == c || b == c);
        }

        // A scalene triangle has all sides different lengths, or equivalently all angles are unequal.
        protected bool IsScaleneType(int a, int b, int c)
        {
            return (a != b && a != c && b != c);
        }

    }
}
