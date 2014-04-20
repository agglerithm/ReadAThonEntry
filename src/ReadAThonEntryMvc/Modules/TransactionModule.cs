using System;
using System.Web;
using System.Web.Mvc;
using CJR.Persistence;
using Microsoft.Practices.ServiceLocation;

namespace ReadAThonEntryMvc.Modules
{
    public class TransactionModule : IHttpModule
    { 
   


        private ISessionWrapper DbSession { get; set; }
        public TransactionModule()
        {
            
        }
        public void Init(HttpApplication application)
        {
            application.BeginRequest +=
                (new EventHandler(this.Application_BeginRequest));
            application.EndRequest +=
                (new EventHandler(this.Application_EndRequest)); 
        }

   

        private Exception LastError
        {
            get { return HttpContext.Current.Server.GetLastError();}
        }
        private void Application_EndRequest(object sender, EventArgs e)
        { 
            DbSession.UnbindFromCurrentContext(LastError); 
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
//            HttpApplication application = (HttpApplication)sender;
//            HttpContext context = application.Context;
// 
//                context.Response.Write("<h1><font color=red>" +
//                    "HelloWorldModule: Beginning of Request" +
//                    "</font></h1><hr>"); 
 
            DbSession  = ServiceLocator.Current.GetInstance<ISessionWrapper>();
            DbSession.BindToCurrentContext(); 
        }

        public void Dispose()
        { 
        }
    }
}