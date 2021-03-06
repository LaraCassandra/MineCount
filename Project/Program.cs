using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    class Program
    {

        public static HttpListener listener;
        public static string url = "http://localhost:8000/";
        public static int pageViews = 0;
        public static int requestCount = 0;

        public static async Task HandleIncomingConnections()
        {
            bool runServer = true;

            //  WHILE A USER HASNT VISITED THE SHUTDOWN URL / KEEP ON HANDLING REQUESTS
            while (runServer)
            {
                // WILL WAIT HERE UNTIL WE HEAR FROM A CONNECTION
                HttpListenerContext ctx = await listener.GetContextAsync();
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse res = ctx.Response;

                // PRINT OUT SOME INFORMATION ABOUT THE REQUEST
                Console.WriteLine("Request #: {0}", ++requestCount);
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine("Has entity body: " + req.HasEntityBody);
                Console.WriteLine();

                if(req.HasEntityBody)
                {
                    System.IO.Stream body = req.InputStream;
                    System.Text.Encoding encoding = req.ContentEncoding;
                    System.IO.StreamReader reader = new System.IO.StreamReader(body, encoding);
                    if(req.ContentType != null)
                    {
                        Console.WriteLine("Client data content type: " + req.ContentType);
                    }
                    Console.WriteLine("Client data content length: " + req.ContentLength64);
                    
                    Console.WriteLine("Start of data:");
                    string data = reader.ReadToEnd();
                    Console.WriteLine(data);
                    Console.WriteLine("End of data:");
                    body.Close();
                    reader.Close();

                    string[] properties = data.Split('&');
                    foreach(string curProp in properties)
                    {
                        string[] pair = curProp.Split('=');
                        string key = pair[0].Replace('+', ' ');
                        
                        if(key == "recipe")
                        {
                            RecipeBook.ApplyRecipe(pair[1].Replace('+', ' '));
                        }
                        else if (Inventory.GetClass(key) != null)
                        {
                            
                            int value = Int32.Parse(pair[1]);
                            Inventory.GetClass(key).Count = value;
                        }
                    }

                }

                string path = req.Url.AbsolutePath;


                // IF SHUTDOWN IS REQUESTED W/ POST / SHUTDOWN THE SERVER AFTER SERVING THE PAGE
                if((req.HttpMethod == "POST") && path == "/shutdown")
                {
                    path = "/index.html";
                    Console.WriteLine("Shutdown requested");
                    runServer = false;
                }

                // DONT INCREMENT THE PAGE VIEWS COUNTER IF FAVICON.ICO IS REQUESTED
                if(path != "/favicon.ico")
                {
                    pageViews += 1;

                    try
                    {
                        FileLoader myFileLoader = new FileLoader(path);
                        myFileLoader.ReadFile();

                        // WRITE THE RESPONSE INFO
                        string disableSubmit = !runServer ? "disabled" : "";
                        
                        byte[] data;
                        if (myFileLoader.mimeType.IndexOf("text/html") >= 0)
                        {
                            string input = Encoding.UTF8.GetString(myFileLoader.data);
                            
                            if (path == "/index.html")
                                data = Encoding.UTF8.GetBytes(IndexHtmlParser.Process(input));
                            else if (path == "/inventory.html")
                                data = Encoding.UTF8.GetBytes(InventoryHtmlParser.Process(input));
                            else if (path == "/about.html")
                                data = Encoding.UTF8.GetBytes(AboutHtmlParser.Process(input));
                            else 
                                throw new FileNotFoundException("Not a page");

                        }
                        else
                        {
                            data = myFileLoader.data;
                        }

                        res.ContentType = myFileLoader.mimeType;
                        res.ContentEncoding = Encoding.UTF8;
                        res.ContentLength64 = data.LongLength;
                        
                        await res.OutputStream.WriteAsync(data, 0, data.Length);
                    }
                    catch (FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        byte[] data;
                        data = Encoding.UTF8.GetBytes("<h2>A 404 error occured</h2>");

                        res.ContentType = "text/html";
                        res.ContentEncoding = Encoding.UTF8;
                        res.ContentLength64 = data.LongLength;
                        res.StatusCode = 404;
                        
                        // WRITE OUT TO THE RESPONSE AYNCSCHRONOUSLY THEN CLOSE IT
                        await res.OutputStream.WriteAsync(data, 0, data.Length);
                    }

                    res.Close();
                }
            }
        }
    
        public static void Main(string[] args)
        {

            Console.WriteLine(Database.GetVersion());
            
            Inventory.Populate();
            Console.WriteLine(Inventory.GetClass("Wood block").BlockType + Inventory.GetClass("Wood block").Count);
            Console.WriteLine(Inventory.GetClass("Stick").BlockType + Inventory.GetClass("Stick").Count);
            Console.WriteLine(Inventory.GetClass("WoodSword").BlockType + Inventory.GetClass("WoodSword").Count);
            Console.WriteLine(Inventory.GetClass("IronIngot").BlockType + Inventory.GetClass("IronIngot").Count);


            RecipeBook.Populate();
            foreach (Recipe curRecipe in RecipeBook.Recipes)
            {
                Console.WriteLine("recipe is " + curRecipe.Result.BlockType);
            }

            // LISTEN FOR INCOMING CONNECTIONS
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();

            Console.WriteLine("Listening on connections on " + url);

            Task listenTask = HandleIncomingConnections();
            Console.WriteLine("before sync");
            listenTask.GetAwaiter().GetResult();
            Console.WriteLine("after sync");


            // CLOSE CONNECTION
            listener.Close();
        }
    }
}
