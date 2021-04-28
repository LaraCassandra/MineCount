using System;
using System.Text;
using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;

namespace Project 
{

    class TestHtmlParser
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


            // GET LIST ID
            HtmlNode myNode = htmlDoc.GetElementbyId("ClassList");

            myNode.RemoveAllChildren();

            string[] myItems = {"Step 1: Create Html file", "Step 2: Create Html Parser", "Step 3: ??", "Step 4: Profit"};
            foreach (string currentString in myItems)
            {
                HtmlNode newNode = HtmlNode.CreateNode("<li>" + currentString + "</li>");
                myNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}