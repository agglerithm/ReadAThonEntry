using System;
using TimeKeeper.DTOs;
using TimeKeeper.Repositories;

namespace TimekeeperTests
{
    using System;
    using NUnit.Framework;
    using ReadAThonEntry.Services;
    using ReadAThonEntryTests;
    using TimeKeeper.Services;
    using Cjr.Common.Testing;

    public class TestInvoiceGenerator
    {
        private IInvoiceGenerator _sut;


        [Test]
        public void can_generate_invoice()
        { 
            _sut = new InvoiceGenerator(new FakeTimeBlockRepo());
            var start = DateTime.Parse("11/1/2012");
            var end = DateTime.Parse("11/30/2012"); 
            var inv = _sut.Create(start, end);
            inv.Lines.Count.ShouldEqual(2);
        }


    }
}
