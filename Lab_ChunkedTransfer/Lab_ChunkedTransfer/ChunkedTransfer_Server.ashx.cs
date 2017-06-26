using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_ChunkedTransfer {
    /// <summary>
    /// Summary description for ChunkedTransfer_Server
    /// </summary>
    public class ChunkedTransfer_Server : IHttpHandler {

        public void ProcessRequest(HttpContext context) {
            // 將步驟 2 的程式貼在這裏:



        }

        public bool IsReusable {
            get {
                return false;
            }
        }
    }
}