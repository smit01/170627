<%@ WebHandler Language="C#" Class="GetProductJsonP" %>

using System;
using System.Web;

public class GetProductJsonP : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        String sID = context.Request.QueryString["id"];
        if (String.IsNullOrEmpty(sID))
        {
            context.Response.Write("Parameter 'id' not found.");
            return;
        }
        String sCallback = context.Request.QueryString["callback"];
        if (String.IsNullOrEmpty(sID))
        {
            context.Response.Write("Parameter 'callback' not found.");
            return;
        }

        string result = "{\"ProductID\": " + sID + ", "
        + "\"UnitsInStock\": 50" + sID + "}";  // 模擬庫存量
        // 包裝成呼叫函式
        result = sCallback + "(" + result + ")";

        context.Response.ContentType = "text/plain";
        context.Response.Write(result);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}