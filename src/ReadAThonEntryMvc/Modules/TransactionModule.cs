using System;
using System.Web;
using System.Web.Mvc;
using CJR.Persistence; 

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
            DbSession  = DependencyResolver.Current.GetService<ISessionWrapper>();
            DbSession.BindToCurrentContext(); 
        }

        public void Dispose()
        { 
        }
    }
}