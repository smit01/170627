<%@ WebHandler Language="C#" Class="GetProductJson" %>

using System;
using System.Web;

public class GetProductJson : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        String sID = context.Request.QueryString["id"];
        if (String.IsNullOrEmpty(sID))
        {
            context.Response.Write("Parameter 'id' not found.");
            return;
        }

        string result = "{\"ProductID\": " + sID + ", "
        + "\"UnitsInStock\": 50" + sID + "}";  // 模擬庫存量

        // Lab 練習步驟 4-1 提到的註解。
        // context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        context.Response.ContentType = "text/plain";
        context.Response.Write(result);
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}