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
                HtmlNode newNode = HtmlNode.CreateNode("<div class=\"card mb-4\"><div class=\"card-content\"><p>" + item.BlockType + "</p></div></div>");
                myNode.AppendChild(newNode);
            }

            return htmlDoc.DocumentNode.InnerHtml;

        }
    }
}