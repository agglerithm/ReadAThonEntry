namespace TimeKeeper.Modules
{
    using Nancy;
    using Nancy.ModelBinding;
    using ViewModels;

    public class InvoiceModule :NancyModule
    {
        public InvoiceModule(ITimesheetFactory sheetFactory)
            : base("invoice")
        {
            Get["/"] = parm =>
                           {
                               return View["Index"];
                           };
            Post["/summary"] = parm =>
            {
                var request = this.Bind<PayPeriod>();
                var timesheet = sheetFactory.Create(request);
                return View["Summary", timesheet];
            };

            Post["/invoice"] = parm =>
                                   {
                                       var request = this.Bind<PayPeriod>();
                                       return View["Invoice", request];
                                   };
        }
    }
}