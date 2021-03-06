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
            HtmlNode recipeNode = htmlDoc.GetElementbyId("RecipeList");

            // REMOVE CHILDREN FROM INVENTORY LIST
            myNode.RemoveAllChildren();
            recipeNode.RemoveAllChildren();

            // NEW INSTANCE OF INVENTORY
            Inventory inventory = new Inventory();
            
            // POPULATE CARDS INTO INVENTORY LIST FROM ARRAY
            foreach (Block item in inventory.Items)
            {
                //HtmlNode newNode = HtmlNode.CreateNode("<div class=\"card mb-3\"><div class=\"card-image\"><figure class=\"image is-96x96\"><img src=\"" + item.Image + "\" alt=\"" +item.BlockType + "\"></figure></div><div class=\"card-content\"><p class=\"title is-6\">" + item.BlockType + " | Count: " + item.Count + "</p></div><footer class=\"card-footer\"><div class=\"card-footer-item\"><label for=\""+ item.BlockType +"\">Change Count: </label><input type=\"text\" name=\""+ item.BlockType +"\" value=\""+ item.Count +"\"/><input type=\"submit\" value=\"Set Count\"></div></footer></div>");
                HtmlNode newNode = HtmlNode.CreateNode("<div class=\"col\"><div class=\"card text-center\" style=\"background-color: #232627; border-radius: 12px;\"><div class=\"card-body\"><img src=\"" + item.Image + "\" alt=\"" + item.BlockType + "\" height=\"95\" width=\"95\" class=\"justify-content-center\"><h5 class=\"card-title\">" + item.BlockType + " | " + item.Count + "</h5><p class=\"card-text\">Change Count:</p><form action=\"/inventory.html\" method=\"POST\"><input style=\"border-radius: 12px;\" type=\"text\" name=\" " + item.BlockType + "\" value=\" " + item.Count + " \" /><input style=\"background-color: #289A5C; color: #fff; border-radius: 12px; font-weight: bold; padding: 10px 60px; font-size: 15px; box-shadow: 0px 8px 24px rgba(0, 0, 0, 0.2); margin-top: 10px;\" class=\"btn\" type=\"submit\" value=\"Set Count\"/></form></div></div></div>");
                myNode.AppendChild(newNode);
                // myNode.AppendChild(newNode);

                // HtmlNode recipeNewNode = HtmlNode.CreateNode("");
                // recipeNode.AppendChild(recipeNewNode);

            };

            // foreach (Recipe curRecipe in RecipeBook.Recipes)
            // {
            //     HtmlNode newRecipeNode = HtmlNode.CreateNode("<form action=\"/inventory.html\" method=\"POST\" id=\"recipeForm\"><input id=\"inputRecipe\" name=\"recipe\" value=\" "
            //         + curRecipe.Result.BlockType
            //         + " \" class=\"input\"><input type=\"submit\" value=\"Craft\" class=\"btn\" style=\"background-color: #000000; color: #fff; border-radius: 12px; font-weight: bold; padding: 10px 60px; font-size: 15px; box-shadow: 0px 8px 24px rgba(0, 0, 0, 0.2); margin-top: 10px;\"></form>");
            //     recipeNode.AppendChild(new)
            // };

            return htmlDoc.DocumentNode.InnerHtml;

        }
    }
}