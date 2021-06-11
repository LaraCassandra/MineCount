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

            // GET INVENTORY LIST
            HtmlNode myNode = htmlDoc.GetElementbyId("InventoryList");
            // REMOVE CHILDREN FROM INVENTORY LIST
            myNode.RemoveAllChildren();

            // NEW INSTANCE OF INVENTORY
            Inventory inventory = new Inventory();
            
            // POPULATE CARDS INTO INVENTORY LIST FROM ARRAY
            foreach (Block item in inventory.Items)
            {
                // HtmlNode newNode = HtmlNode.CreateNode("<div class=\"card mb-3\"><div class=\"media\"><figure class=\"image is-48x48\"><img src=\""+ item.Image +"\"></figure><div><h5 class=\"title is-6\">" + item.BlockType + "</h5></div></div><div class=\"card-content\">" + "Count: " + item.Count +"</div></div></div>");
                HtmlNode newNode = HtmlNode.CreateNode("<div class=\"card mb-3\"><div class=\"card-content\"><div class=\"media\"><div class\"media-left\"><figure class=\"image is-48x48\"><img src=\""+ item.Image +"\"></figure></div><div class=\"media-content\"><p class=\"title is-6\">"+ item.BlockType +"</p></div></div><div class=\"content\"> Count: " + item.Count +"<div><footer class=\"card-footer\"><a class=\"card-footer-item\">-</a><a class=\"card-footer-item\">+</a></footer></div></div>");
                Console.WriteLine(newNode.OuterHtml);
                myNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;

        }
    }
}