namespace AFPHttp.Tests
{
    using NUnit.Framework;
    using Parsers;
    using AFPST.Common;
    using Test.Common;

    [TestFixture]
    public class FrameParserTester
    {
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {

        }
        [SetUp]
        public void SetUpForEachTest()
        {

        }

        [Test]
        public void can_parse_html()
        {
            var frame =
                HtmlFrameParser.ExtractFrameSource(
                    @"


<!DOCTYPE HTML>
<html lang='en'>
    <head>
        <title>WWT </title>
        <meta http-equiv='content-type' content='text/html; charset=UTF-8'>
        <link href='/nidp/images/hf_menu.css' rel='stylesheet'> 
        <link href='/nidp/images/HF_message.css' rel='stylesheet'> 
        <link href='/nidp/images/HF_obj_list_table.css' rel='stylesheet'> 
	  <style>
          body
          {
              font: 12px 'Lucida Sans Unicode', 'Trebuchet MS', Arial, Helvetica;
              margin: 0;

          }
		* { margin: 0; padding: 0; }
	      #header		{ background-image: url('http://www.wwt.com/images/nam_header_bg.png'); background-repeat: repeat-x; }
	      #logo			{ position: absolute; top: 0px; right: 0px;	}   		
	      #title	     	{ position: absolute; font-size: 1.2em; color: white; top: 13px; left: 55px; }
		#subtitle		{ position: relative; font-size: .9em; color: black; white-space: nowrap; top: 0px; left: 0px; text-align: right; }
		#mcontent   	{ position: relative; padding: 5px; }
		#content    	{ width: 100%; border: 0; margin: 0; padding: 0; overflow: none; height:400px; }
		#logoutbut		{ position: absolute; top: 25px; right: 35px;	}			
		#helpbutlogin	{ position: absolute; color: yellow; top: 25px; right: 10px; }
		#loggingbut		{ position: absolute; color: blue; top: 25px; right: 65px;	}
        #loginFrame     { width:100%; }

		.NLtab .tab1s  	{  padding-left: 3px; padding-right: 8px; text-align: center; white-space: nowrap;   }
		.NLtab .tab1s a 	{ text-decoration: none; }
		.NLtab span.tab1s { padding:5; color: white; font-size: 0.9em; font-weight: bold; line-height: 17px; background-color: transparent; background-image: none; text-decoration: none; }
		.NLtab .tab1u 	{  padding-left: 3px; padding-right: 3px; text-align: center; white-space: nowrap; border-left: 1px solid #3983CC; border-right: 1px solid #3983CC; border-top: 1px solid #3983CC;          }
		.NLtab span.tab1u { border: none; padding:5; color: black; font-size: 0.8em; font-weight: bold; line-height: 17px; text-decoration: none; background-color: transparent;  }

		.NLtab tr.subtab td	{  color: white; padding: 2px }
		.NLtab tr.subtab a	{ font-size: .8em; color: white; text-decoration: none; padding: 2px 5px 2px 5px}

		.selx	{ border: 1px solid rgb(239, 238, 236); font-size: 1em; font-weight: bolder; background-repeat: repeat-x; background-position: 0pt bottom;}
		.unselx	{ border: 0px; font-size: .9em; font-weight: normal; background-image: none; }
        </style>

    </head>

    <body>
        <table width=100% height='100%' border=0 cellpadding=0 cellspacing=0 >
         <tr>
		    <td>
				        <div id='header'><img src='http://www.wwt.com/images/wwt_logo_white.png'></div>
				        <!-- <div id='logo'><img src='/nidp/images/http://www.wwt.com/images/wwt_logo_white.png'></div>-->	 
				        <div id='title'></div>
		    </td>
		</tr>
        <tr>
            <td>" + 
                    "<iframe scrolling='no' id='content' src=\"/nidp/jsp/content.jsp?sid=0&id=24&sid=0&amp;RequestID=idL2YEnF6fBgOFdfGED6QxqAGN1ZE&amp;MajorVersion=1&amp;MinorVersion=2&amp;IssueInstant=2012-09-13T02%3A38%3A13Z&amp;ProviderID=https%3A%2F%2Fesp.wwt.com%3A443%2Fnesp%2Fidff%2Fmetadata&amp;RelayState=MA%3D%3D&amp;consent=urn%3Aliberty%3Aconsent%3Aunavailable&amp;ForceAuthn=false&amp;IsPassive=false&amp;NameIDPolicy=onetime&amp;ProtocolProfile=http%3A%2F%2Fprojectliberty.org%2Fprofiles%2Fbrws-art&amp;target=https%3A%2F%2Freports.wwt.com%2Freports%2Frwservlet%3F17454_dell_supply_hub_alpha_vendor_schedule%26amp%3Bparamform%3Dno%26amp%3Bmimetype%3Dapplication%2Fvnd.ms-excel&amp;AuthnContextStatementRef=secure%2Fname%2Fpassword%2Furi\" frameborder=0></iframe>" +
                    @" </td>
        </tr>
	  </table>
    </body>
</html>


", "");
            frame.ShouldEqual(
                "/nidp/jsp/content.jsp?sid=0&id=24&sid=0&amp;RequestID=idL2YEnF6fBgOFdfGED6QxqAGN1ZE&amp;MajorVersion=1&amp;MinorVersion=2&amp;IssueInstant=2012-09-13T02%3A38%3A13Z&amp;ProviderID=https%3A%2F%2Fesp.wwt.com%3A443%2Fnesp%2Fidff%2Fmetadata&amp;RelayState=MA%3D%3D&amp;consent=urn%3Aliberty%3Aconsent%3Aunavailable&amp;ForceAuthn=false&amp;IsPassive=false&amp;NameIDPolicy=onetime&amp;ProtocolProfile=http%3A%2F%2Fprojectliberty.org%2Fprofiles%2Fbrws-art&amp;target=https%3A%2F%2Freports.wwt.com%2Freports%2Frwservlet%3F17454_dell_supply_hub_alpha_vendor_schedule%26amp%3Bparamform%3Dno%26amp%3Bmimetype%3Dapplication%2Fvnd.ms-excel&amp;AuthnContextStatementRef=secure%2Fname%2Fpassword%2Furi");
        }

        public void can_parse_html_and_url()
        {
            var url = "/nidp/idff/sso?RequestID=idbVWOQWP9KinTyXx5kPA2qr0Zlh4&MajorVersion=1&MinorVersion=2&IssueInstant=2012-09-17T18%3A03%3A05Z&ProviderID=https%3A%2F%2Fesp-test.wwt.com%3A443%2Fnesp%2Fidff%2Fmetadata&RelayState=MA%3D%3D&consent=urn%3Aliberty%3Aconsent%3Aunavailable&ForceAuthn=false&IsPassive=false&NameIDPolicy=onetime&ProtocolProfile=http%3A%2F%2Fprojectliberty.org%2Fprofiles%2Fbrws-art&target=https%3A%2F%2Freports-test.wwt.com%2Freports%2Frwservlet%3F17454_dell_supply_hub_alpha_vendor_schedule%26amp%3Bparamform%3Dno%26amp%3Bmimetype%3Dapplication%2Fvnd.ms-excel&AuthnContextStatementRef=basic%2Fname%2Fpassword%2Furi";
            var htm = 
                @"<!DOCTYPE HTML PUBLIC '-//W3C//Dtd HTML 4.0 transitional//en'>

<html lang='en'>
        <head>
                <META HTTP-EQUIV='expires' CONTENT='0'>
        </head>
        <body>
                <script language='JavaScript'>
		                <!--
						               window.parent.parent.location='sso?sid=0';

						-->
                </script>
        </body>
</html>";

            var location = JavascriptLocationParser.ExtractFromSource(htm, url);

            location.ShouldEqual("/nidp/idff/sso?sid=0");

        }

        [Test]
        public void can_extract_hidden()
        {
            var source =
                "<html><head><META HTTP-EQUIV=\"expires\" CONTENT=\"0\"></head><body><form method=\"POST\" enctype=\"application/x-www-form-urlencoded\" action=\"https://secure-test.wwt.com/nidp/idff/sso\"><input type=\"hidden\" name=\"target\" value=\"https://osso-test.wwt.com/pls/orasso/orasso.wwsso_app_admin.ls_login?Site2pstoreToken=v1.4~B2C449AF~369DAE5C13D6B086761687C72310B558DCF72B3B016FE65C1561B278477A627ED7E509A39DD236662CF8BBE36005093386EB379BA79D06A5855FB1208A733A4E80F995198B096E7E311356619BDF61713AA7DDD6ADAE0CCC916355C2BF30083483920D74146ABB1BBABB02467CACB87930D6D4A181197B93B334FDD2A8A3FAC34E0B79E0489DC83459E6576E9017B75CB24D7F4D07B6B74F808034443A177534CF7C5DF6CBCE455ACFEEBA8EA2664F8190024B500DD877ABB8FD63D104471FE3BAFAE79B89BDC44E1BB6B81557F1B76C2A43E4D8B1E9531C1669E0A5431D67F72A77411C0C0C0A9D2A84A78FD6DB1AA531F5B3B26AE5D665FC8C253ED40159BA98E5772D2CB959339E5612BF3B82DFB207AEC7E0669DDD11EB5ED0BFCBF88B23A20BD4A2447898E01215DBDD92AB035C9878513AAB9E76B12777A7C01F685C4F\"/><input type=\"hidden\" name=\"LAREQ\" value=\"PGxpYjpBdXRoblJlcXVlc3QgeG1sbnM6bGliPSJ1cm46bGliZXJ0eTppZmY6MjAwMy0wOCIgeG1sbnM6YWM9InVybjpsaWJlcnR5OmFjOjIwMDMtMDgiIHhtbG5zOnNhbWw9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjEuMDphc3NlcnRpb24iIHhtbG5zOnNhbWxwPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoxLjA6cHJvdG9jb2wiIElzc3VlSW5zdGFudD0iMjAxMi0wOS0xN1QxNToxMjo1OVoiIE1ham9yVmVyc2lvbj0iMSIgTWlub3JWZXJzaW9uPSIyIiBSZXF1ZXN0SUQ9ImlkbVFZcENidjJDTEhPdDkxY0lMbVc5LXR5OVlZIiBsaWI6Y29uc2VudD0idXJuOmxpYmVydHk6Y29uc2VudDp1bmF2YWlsYWJsZSI+PGxpYjpQcm92aWRlcklEPmh0dHBzOi8vZXNwLXRlc3Qud3d0LmNvbTo0NDMvbmVzcC9pZGZmL21ldGFkYXRhPC9saWI6UHJvdmlkZXJJRD48bGliOk5hbWVJRFBvbGljeT5vbmV0aW1lPC9saWI6TmFtZUlEUG9saWN5PjxsaWI6Rm9yY2VBdXRobj5mYWxzZTwvbGliOkZvcmNlQXV0aG4+PGxpYjpJc1Bhc3NpdmU+ZmFsc2U8L2xpYjpJc1Bhc3NpdmU+PGxpYjpQcm90b2NvbFByb2ZpbGU+aHR0cDovL3Byb2plY3RsaWJlcnR5Lm9yZy9wcm9maWxlcy9icndzLWFydDwvbGliOlByb3RvY29sUHJvZmlsZT48bGliOlJlcXVlc3RBdXRobkNvbnRleHQ+PGxpYjpBdXRobkNvbnRleHRTdGF0ZW1lbnRSZWY+c2VjdXJlL25hbWUvcGFzc3dvcmQvdXJpPC9saWI6QXV0aG5Db250ZXh0U3RhdGVtZW50UmVmPjwvbGliOlJlcXVlc3RBdXRobkNvbnRleHQ+PGxpYjpSZWxheVN0YXRlPk1nPT08L2xpYjpSZWxheVN0YXRlPjwvbGliOkF1dGhuUmVxdWVzdD4=\"/></form><script language=\"JavaScript\"><!--document.forms[0].submit();--></script></body></html>";
            var contents = HtmlFormParser.ExtractHiddenFromSource(source);

            contents.ShouldEqual("target=https%3A%2F%2Fosso-test.wwt.com%2Fpls%2Forasso%2Forasso.wwsso_app_admin.ls_login%3FSite2pstoreToken%3Dv1.4%7EB2C449AF%7E369DAE5C13D6B086761687C72310B558DCF72B3B016FE65C1561B278477A627ED7E509A39DD236662CF8BBE36005093386EB379BA79D06A5855FB1208A733A4E80F995198B096E7E311356619BDF61713AA7DDD6ADAE0CCC916355C2BF30083483920D74146ABB1BBABB02467CACB87930D6D4A181197B93B334FDD2A8A3FAC34E0B79E0489DC83459E6576E9017B75CB24D7F4D07B6B74F808034443A177534CF7C5DF6CBCE455ACFEEBA8EA2664F8190024B500DD877ABB8FD63D104471FE3BAFAE79B89BDC44E1BB6B81557F1B76C2A43E4D8B1E9531C1669E0A5431D67F72A77411C0C0C0A9D2A84A78FD6DB1AA531F5B3B26AE5D665FC8C253ED40159BA98E5772D2CB959339E5612BF3B82DFB207AEC7E0669DDD11EB5ED0BFCBF88B23A20BD4A2447898E01215DBDD92AB035C9878513AAB9E76B12777A7C01F685C4F&LAREQ=PGxpYjpBdXRoblJlcXVlc3QgeG1sbnM6bGliPSJ1cm46bGliZXJ0eTppZmY6MjAwMy0wOCIgeG1sbnM6YWM9InVybjpsaWJlcnR5OmFjOjIwMDMtMDgiIHhtbG5zOnNhbWw9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjEuMDphc3NlcnRpb24iIHhtbG5zOnNhbWxwPSJ1cm46b2FzaXM6bmFtZXM6dGM6U0FNTDoxLjA6cHJvdG9jb2wiIElzc3VlSW5zdGFudD0iMjAxMi0wOS0xN1QxNToxMjo1OVoiIE1ham9yVmVyc2lvbj0iMSIgTWlub3JWZXJzaW9uPSIyIiBSZXF1ZXN0SUQ9ImlkbVFZcENidjJDTEhPdDkxY0lMbVc5LXR5OVlZIiBsaWI6Y29uc2VudD0idXJuOmxpYmVydHk6Y29uc2VudDp1bmF2YWlsYWJsZSI%2BPGxpYjpQcm92aWRlcklEPmh0dHBzOi8vZXNwLXRlc3Qud3d0LmNvbTo0NDMvbmVzcC9pZGZmL21ldGFkYXRhPC9saWI6UHJvdmlkZXJJRD48bGliOk5hbWVJRFBvbGljeT5vbmV0aW1lPC9saWI6TmFtZUlEUG9saWN5PjxsaWI6Rm9yY2VBdXRobj5mYWxzZTwvbGliOkZvcmNlQXV0aG4%2BPGxpYjpJc1Bhc3NpdmU%2BZmFsc2U8L2xpYjpJc1Bhc3NpdmU%2BPGxpYjpQcm90b2NvbFByb2ZpbGU%2BaHR0cDovL3Byb2plY3RsaWJlcnR5Lm9yZy9wcm9maWxlcy9icndzLWFydDwvbGliOlByb3RvY29sUHJvZmlsZT48bGliOlJlcXVlc3RBdXRobkNvbnRleHQ%2BPGxpYjpBdXRobkNvbnRleHRTdGF0ZW1lbnRSZWY%2Bc2VjdXJlL25hbWUvcGFzc3dvcmQvdXJpPC9saWI6QXV0aG5Db250ZXh0U3RhdGVtZW50UmVmPjwvbGliOlJlcXVlc3RBdXRobkNvbnRleHQ%2BPGxpYjpSZWxheVN0YXRlPk1nPT08L2xpYjpSZWxheVN0YXRlPjwvbGliOkF1dGhuUmVxdWVzdD4%3D");
        
        }

        [Test]
        public void can_extract_relative_uri()
        {
            var html = Utilities.QuickFileText(@"..\..\..\TestFiles\Fiddler_7-46-19.htm");

            var path = HtmlFrameParser.ExtractFrameSource(html, "");

            path.ShouldEqual("/nidp/jsp/content.jsp?sid=0&id=24&sid=0&amp;RequestID=idjPmVdrzhDozvJ.ZxjrL8TU4hz8Q&amp;MajorVersion=1&amp;MinorVersion=2&amp;IssueInstant=2012-09-18T12%3A37%3A37Z&amp;ProviderID=https%3A%2F%2Fesp.wwt.com%3A443%2Fnesp%2Fidff%2Fmetadata&amp;RelayState=MA%3D%3D&amp;consent=urn%3Aliberty%3Aconsent%3Aunavailable&amp;ForceAuthn=false&amp;IsPassive=false&amp;NameIDPolicy=onetime&amp;ProtocolProfile=http%3A%2F%2Fprojectliberty.org%2Fprofiles%2Fbrws-art&amp;target=https%3A%2F%2Freports.wwt.com%2Freports%2Frwservlet%3F17454_dell_supply_hub_alpha_vendor_schedule%26amp%3Bparamform%3Dno%26amp%3Bmimetype%3Dapplication%2Fvnd.ms-excel&amp;AuthnContextStatementRef=secure%2Fname%2Fpassword%2Furi");
        }
        [TearDown]
        public void TearDownForEachTest()
        {

        }

        [TestFixtureTearDown]
        public void TearDownAfterAllTests()
        {

        }
    }
}
