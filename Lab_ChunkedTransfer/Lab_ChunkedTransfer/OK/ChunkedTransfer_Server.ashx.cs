using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_ChunkedTransfer.OK {
    /// <summary>
    /// Summary description for ChunkedTransfer_Server
    /// </summary>
    public class ChunkedTransfer_Server : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            context.Response.BufferOutput = false;

            context.Response.Write("[");
            HttpContext.Current.Response.Flush();

            for (int i = 1; i <= 10; i++) {
                System.Threading.Thread.Sleep(1000);
                context.Response.Write(
                    "{\"event\": \"progress\", \"data\": " + (i * 10).ToString() + "}");
                if (i <= 10)
                    context.Response.Write(",");
                HttpContext.Current.Response.Flush();
            }
        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}