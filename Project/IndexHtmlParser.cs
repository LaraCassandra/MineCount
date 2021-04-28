using System;
using System.Text;
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;

namespace Project 
{
    class IndexHtmlParser
    {
        public static string Process(string input)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(input);

            if (htmlDoc.ParseErrors != null || htmlDoc.DocumentNode == null)
            {
                int count = 0;
                foreach (var htmlParseError in htmlDoc.ParseErrors)
                {
                    count++;
                    Console.Write("Parse error: " + htmlParseError.Reason);
                }

                if (count > 0)
                    throw new FileNotFoundException("File corrupt!");
            }

            // IEnumerable<HtmlNode> someNode = htmlDoc.DocumentNode.SelectNodes("//li");
            // foreach (HtmlNode currentNode in someNode)
            //     Console.WriteLine(currentNode.OuterHtml);

            HtmlNode someNode = htmlDoc.GetElementbyId("TheList");
            Console.WriteLine(someNode.OuterHtml);

            // REMOVE LIST ITEMS IN HTML FILE
            someNode.RemoveAllChildren();

            // CREATE NEW ITEMS AND ADD TO HTML
            string[] newItems = {"new item 1", "new item 2", "new item 3"};
            foreach (string currentString in newItems)
            {
                HtmlNode newNode = HtmlNode.CreateNode("<li>" + currentString + "</li>");
                someNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}