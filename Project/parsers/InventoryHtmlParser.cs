using System;
using System.Text;
using System.IO;
using HtmlAgilityPack;
using System.Collections;
using System.Collections.Generic;

namespace Project 
{

    class InventoryHtmlParser
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
            HtmlNode myNode = htmlDoc.GetElementbyId("InventoryList");

            myNode.RemoveAllChildren();

            Object[] BlocksList = {"dirt", "sand", "cobblestone", "glass"};

            foreach (var currentString in BlocksList)
            {
                HtmlNode newNode = HtmlNode.CreateNode("<div class=\"card\"><div class=\"card-content\"><p>" + currentString + "</p></div></div>");
                myNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;
        }
    }
}