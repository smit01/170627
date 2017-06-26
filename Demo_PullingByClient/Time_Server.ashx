<%@ WebHandler Language="C#" Class="Time_Server" %>

using System;
using System.Web;

public class Time_Server : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}