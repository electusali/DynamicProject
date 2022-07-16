using Newtonsoft.Json.Linq;
using System;

namespace DynamicProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = @"[{
                                'Title': 'Json.NET is awesome!',
                                'Author': {
                                  'Name': 'James Newton-King',
                                  'Twitter': '@JamesNK',
                                  'Picture': '/jamesnk.png'
                                },
                                'Date': '2013-01-23T19:30:00',
                                'BodyHtml': '&lt;h3&gt;Title!&lt;/h3&gt;\r\n&lt;p&gt;Content!&lt;/p&gt;'
                              }
                            ]";
            dynamic blog=JArray.Parse(json);
            dynamic blogPost = blog[0];
            string title=blogPost.Title;
            
            Console.WriteLine("Title json :"+title);

            string author = blogPost.Author.Name;
            DateTime date = blogPost.Date;

            Console.WriteLine("Date json"+date);



            Console.WriteLine("Author name!"+author);


            string json2 = @"{
                      CPU: 'Intel',
                      Drives: [
                        'DVD read/writer',
                        '500 gigabyte hard drive'
                      ]
                    }";

            JObject o = JObject.Parse(json2);

            Console.WriteLine(o.ToString());
        }
    }
}
