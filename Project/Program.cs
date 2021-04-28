﻿using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading.Tasks;

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
                Console.WriteLine();

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
                        if (myFileLoader.mimeType.IndexOf("text/HTML") >= 0)
                        {
                            string input = Encoding.UTF8.GetString(myFileLoader.data);
                            
                            if (path == "/index.html")
                                data = Encoding.UTF8.GetBytes(IndexHtmlParser.Process(input));
                            //else if (path == "/hello.html")
                            //    data = Encoding.UTF8.GetBytes(HelloHtmlParser.Process(input));
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
    
        static void Main(string[] args)
        {

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
