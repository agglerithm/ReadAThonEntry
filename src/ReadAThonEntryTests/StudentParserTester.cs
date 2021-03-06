﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cjr.Common.Testing;

namespace ReadAThonEntryTests
{
    using NUnit.Framework;
    using PullReadAThonData;

    [TestFixture]
    public class StudentParserTester
    {
        private IStudentReportParser _sut;
        [TestFixtureSetUp]
        public void SetUpForAllTests()
        {
            _sut = new StudentReportParser(null);
        }


        [Test]
        public void can_parse_student_report()
        {
            var reportText = getReport();

            var students = _sut.GetStudentsFrom(reportText);

            students.Count().ShouldEqual(651);

        }

        private string getReport()
        {
            return @"<tr style=> 
				<td style=color: #fff;><b>First Name</b></td>
				<td style=color: #fff;><b>Last Name</b></td>
				<td style=color: #fff;><b>Status</b></td>
				<td style=color: #fff;><b>Team Name</b></td>
				<td style=color: #fff;><b>Type</b></td>
				<td style=color: #fff;><b>Total Raised</b></td>
				<td style=color: #fff;><b>Email</b></td>
				<td style=color: #fff;><b>Password</b></td>
				<td style=color: #fff;><b>Address 1 </b>
				<td style=color: #fff;><b>Address 2 </b>
				<td style=color: #fff;><b>City </b>
				<td style=color: #fff;><b>State </b>
				<td style=color: #fff;><b>Zip </b>
				<td style=color: #fff;><b>Phone </b> 
				 	 <td style=color: #fff;><b>School</b></td> 
				 	 <td style=color: #fff;><b>Teacher</b></td> 
				 	 <td style=color: #fff;><b>Grade</b></td> 
				 	 <td style=color: #fff;><b>Pages Read</b></td> 
				 	 <td style=color: #fff;><b>Shirt Size</b></td> 
				<td style=color: #fff;><b>Date Registered</b></td>


			</tr>

<TR>

		<td><b>marisol </b></td>
		<td><b>acuna</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ma85694@eanesisd.net</td>
	
	  <td>hcmsrqzwg</td>
	 
	  <td>1300 walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>mcgrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:13:40 PM
	</td>

</tr><TR>

		<td><b>Kate </b></td>
		<td><b>Agatston</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ka83639@eanesisd.net</td>
	
	  <td>hcmsxgaya</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:15:57 PM
	</td>

</tr><TR>

		<td><b>Lucas </b></td>
		<td><b>Allday</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>thealldays@msn.com</td>
	
	  <td>opal2</td>
	 
	  <td>8004 Stillwood Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 2:53:53 PM
	</td>

</tr><TR>

		<td><b>Zachary </b></td>
		<td><b>Allday</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>thealldays@msn.com</td>
	
	  <td>opal1</td>
	 
	  <td>8004 Stillwood Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Santiso</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 2:50:59 PM
	</td>

</tr><TR>

		<td><b>Jaidon and Avery </b></td>
		<td><b>Allen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>315</td>
	
	  <td>juliechenallen@gmail.com</td>
	
	  <td>jaidon1avery2</td>
	 
	  <td>7526 Stonecliff Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Ms. Johnson (3rd) and Ms. Hodges (K)</td><td>3</td><td></td><td></td>
	<td>
	 2/1/2013 11:11:29 AM
	</td>

</tr><TR>

		<td><b>Missy </b></td>
		<td><b>Almgren</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ma29943@eanesisd.net</td>
	
	  <td>ma29943</td>
	 
	  <td>Shadow oak lane 4108</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:48:29 PM
	</td>

</tr><TR>

		<td><b>Michael </b></td>
		<td><b>Alverson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>lisa_alverson@hotmail.com</td>
	
	  <td>Read2003</td>
	 
	  <td>2006 Alegria Rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5124677009</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 6:23:55 PM
	</td>

</tr><TR>

		<td><b>Abigail </b></td>
		<td><b>Ambrozic</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>paulaambrozic@hotmail.com</td>
	
	  <td>1021cfny</td>
	 
	  <td>6300 Sierra Tahoe</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512-373-6222</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Crowley</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 11:14:37 AM
	</td>

</tr><TR>

		<td><b>Analise </b></td>
		<td><b>Ambrozic</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>paulaambrozic@hotmail.com</td>
	
	  <td>1021cfny</td>
	 
	  <td>6300 Sierra Tahoe</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512-373-6222</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Brocato</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 11:13:15 AM
	</td>

</tr><TR>

		<td><b>Andrew </b></td>
		<td><b>Anderson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>125</td>
	
	  <td>lyndseyrice@gmail.com</td>
	
	  <td>flower</td>
	 
	  <td>4610 cliffstone cove</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78735</td>
	 
	  <td>5122899632</td>

	<!-- this is where the custom fields go -->
		 <td>Jardin de Ninos (south)</td><td>chatwick</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 8:30:12 PM
	</td>

</tr><TR>

		<td><b>Matthew </b></td>
		<td><b>Anderson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ma28845@eanesisd.net</td>
	
	  <td>hcmsbyn3j</td>
	 
	  <td>1208 Silver Hill Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:39:31 PM
	</td>

</tr><TR>

		<td><b>Ashia  </b></td>
		<td><b>Arline </b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>ashiaarline@yahoo.com</td>
	
	  <td>ilove2read</td>
	 
	  <td>4602 Callisto Terrace </td>
	 
	  <td></td>
	 
	  <td>Austin  </td>
	 
	  <td>TX</td>
	 
	  <td>78727</td>
	 
	  <td>512-820-4095</td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Escamilla </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 9:51:16 PM
	</td>

</tr><TR>

		<td><b>Sylvan </b></td>
		<td><b>Arrison</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>shannoncarabetta@gmail.com</td>
	
	  <td>amelia2012</td>
	 
	  <td>2716 Kinney Oaks Court</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>512-707-2492</td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>Swan</td><td>6</td><td></td><td></td>
	<td>
	 1/30/2013 6:17:56 PM
	</td>

</tr><TR>

		<td><b>Shastia </b></td>
		<td><b>Azulay</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>13.59</td>
	
	  <td>allegrazz@aol.com</td>
	
	  <td>allegrazz</td>
	 
	  <td>1409 W 51 street</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Nelson</td><td>6</td><td></td><td></td>
	<td>
	 2/9/2013 4:02:35 PM
	</td>

</tr><TR>

		<td><b>Priya </b></td>
		<td><b>bala</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>prishru@yahoo.com</td>
	
	  <td>qwertasdf</td>
	 
	  <td>1217 Cassiopeia way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>ta</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Joanna</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/31/2013 5:15:14 PM
	</td>

</tr><TR>

		<td><b>carla  </b></td>
		<td><b>balderas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>carlalemus83@yahoo.com</td>
	
	  <td>ohenry2013</td>
	 
	  <td>7908 Briarton Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>74787</td>
	 
	  <td>512-673-3114</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Ms. Florance</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 4:06:18 PM
	</td>

</tr><TR>

		<td><b>Jake </b></td>
		<td><b>Baldree</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jb82521@eanesisd.net</td>
	
	  <td>hcmsoqufd</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5123507719</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:04:14 PM
	</td>

</tr><TR>

		<td><b>Bella </b></td>
		<td><b>Barany</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>250</td>
	
	  <td>christiebarany@yahoo.com</td>
	
	  <td>puppy</td>
	 
	  <td>6004 Northern Dancer Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 6:12:36 PM
	</td>

</tr><TR>

		<td><b>Charles </b></td>
		<td><b>Barnett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>paigeobarnett@gmail.com</td>
	
	  <td>charlie1</td>
	 
	  <td>1807 Winter Park Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>773-307-8314</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Crump</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 8:49:14 PM
	</td>

</tr><TR>

		<td><b>Spencer </b></td>
		<td><b>Barnett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>paigeobarnett@gmail.com</td>
	
	  <td>spencer1</td>
	 
	  <td>1807 Winter Park Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>773-307-8314</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Cummins</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 8:56:17 PM
	</td>

</tr><TR>

		<td><b>Bridget </b></td>
		<td><b>Barragy</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>mmccolgan@att.net</td>
	
	  <td>bridgetb</td>
	 
	  <td>300 S Tumbleweed Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Koch</td><td>5</td><td></td><td></td>
	<td>
	 2/1/2013 10:51:37 AM
	</td>

</tr><TR>

		<td><b>Max </b></td>
		<td><b>Barragy</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>mmccolgan@att.net</td>
	
	  <td>maxwellb</td>
	 
	  <td>300 S Tumbleweed Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Brock</td><td>3</td><td></td><td></td>
	<td>
	 2/1/2013 10:47:16 AM
	</td>

</tr><TR>

		<td><b>clayton  </b></td>
		<td><b>Bartholomew</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>claytonbart14@gmail.com</td>
	
	  <td>Bart12345</td>
	 
	  <td>1913 holly hill dr </td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127883188</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mrs.McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:03:40 PM
	</td>

</tr><TR>

		<td><b>Simone </b></td>
		<td><b>Baskin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>185</td>
	
	  <td>Sally.baskin@gmail.com</td>
	
	  <td>enomis26</td>
	 
	  <td>7121 Via Dono Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td>512-394-0373</td>

	<!-- this is where the custom fields go -->
		 <td>Jardin de Ninos (south)</td><td>Romero</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 8:38:45 PM
	</td>

</tr><TR>

		<td><b>Marley </b></td>
		<td><b>Bass</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>185</td>
	
	  <td>thehuggirl@gmail.com</td>
	
	  <td>Gullett2</td>
	 
	  <td>12300 Danny Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512-965-6940</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/26/2013 8:50:15 AM
	</td>

</tr><TR>

		<td><b>Sabine </b></td>
		<td><b>Bass</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>thehuggirl@gmail.com</td>
	
	  <td>Gullett2</td>
	 
	  <td>12300 Danny Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512 965-6940</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/27/2013 1:14:34 PM
	</td>

</tr><TR>

		<td><b>Sophia </b></td>
		<td><b>Beardslee</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>iselagonz@aol.com</td>
	
	  <td>alyssa8</td>
	 
	  <td>5705 Susie Court</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-658-7814</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 5:23:27 PM
	</td>

</tr><TR>

		<td><b>Shane </b></td>
		<td><b>Becherer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>shanebcherer1@gmail.com</td>
	
	  <td>shane123</td>
	 
	  <td>4712 Mt. Vernon Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78745</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Sylvia</td><td>6</td><td></td><td></td>
	<td>
	 2/1/2013 10:39:00 AM
	</td>

</tr><TR>

		<td><b>Brody </b></td>
		<td><b>Bedford</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>atthebeachamy@yahoo.com</td>
	
	  <td>Elmo2</td>
	 
	  <td>11800 Palisades Pkwy</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td>512-266-1186</td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Cepeda</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/8/2013 2:46:54 PM
	</td>

</tr><TR>

		<td><b>Sebastian </b></td>
		<td><b>Benavides</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>485</td>
	
	  <td>lyndseyestair@gmail.com</td>
	
	  <td>lyndseyp</td>
	 
	  <td>300 Piedmont Hills Pass</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Gorelik</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 9:29:47 AM
	</td>

</tr><TR>

		<td><b>Jaclyn  </b></td>
		<td><b>Bentley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>joann_bentley@msn.com</td>
	
	  <td>95719571</td>
	 
	  <td>3306 Rivercrest Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-306-8710</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Bufkin</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 2:29:34 PM
	</td>

</tr><TR>

		<td><b>Jenny </b></td>
		<td><b>Bentley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>joann_bentley@msn.com</td>
	
	  <td>95719571</td>
	 
	  <td>3306 Rivercrest Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-306-8710</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Saikin</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 2:19:14 PM
	</td>

</tr><TR>

		<td><b>Morgan </b></td>
		<td><b>Berd</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mb82928@eanesisd.net</td>
	
	  <td>hcmsgulgh</td>
	 
	  <td>3513 fawn trl</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:00:04 PM
	</td>

</tr><TR>

		<td><b>Santiago </b></td>
		<td><b>Bernal</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>jessebernal@gmail.com</td>
	
	  <td>tacu0409</td>
	 
	  <td>1909 Forest Hill Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Galindo Elementary</td><td>Murdter</td><td>K</td><td></td><td></td>
	<td>
	 2/1/2013 9:21:57 AM
	</td>

</tr><TR>

		<td><b>Elijah </b></td>
		<td><b>Betton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>105</td>
	
	  <td>kobzabetton66@gmail.com</td>
	
	  <td>mancity</td>
	 
	  <td>2126 Brunswick Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 8:55:01 PM
	</td>

</tr><TR>

		<td><b>Joshua </b></td>
		<td><b>Betton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>105</td>
	
	  <td>kobzabetton66@gmail.com</td>
	
	  <td>chelsea</td>
	 
	  <td>2126 Brunswick Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Valentino</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 8:53:04 PM
	</td>

</tr><TR>

		<td><b>Linnea </b></td>
		<td><b>Bieri</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>174</td>
	
	  <td>tbieri@austin.rr.com</td>
	
	  <td>Pebbles1</td>
	 
	  <td>5924 Fairlane Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Ravare</td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 10:09:23 PM
	</td>

</tr><TR>

		<td><b>Will </b></td>
		<td><b>Black</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>tablack0602@gmail.com</td>
	
	  <td>Mosey0602</td>
	 
	  <td>6913 Tanaqua Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78739</td>
	 
	  <td>512-288-5138</td>

	<!-- this is where the custom fields go -->
		 <td>Rawson Saunders</td><td>Stokes</td><td>6</td><td></td><td></td>
	<td>
	 1/26/2013 5:51:49 PM
	</td>

</tr><TR>

		<td><b>Brianna </b></td>
		<td><b>Blackwell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>BB89256@eanesisd.net</td>
	
	  <td>hcms3much</td>
	 
	  <td>1300 Walsh Tarlton Austin, Texas 78746</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:31:08 AM
	</td>

</tr><TR>

		<td><b>Nathan </b></td>
		<td><b>Blue</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Nb28627@eanesisd.com</td>
	
	  <td>blue5181</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>111 </td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:43:54 PM
	</td>

</tr><TR>

		<td><b>James  </b></td>
		<td><b>Board</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jb28629@gmail.com</td>
	
	  <td>anthony50</td>
	 
	  <td>3704 moon lark</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:57:22 PM
	</td>

</tr><TR>

		<td><b>Daniel  </b></td>
		<td><b>Bomba</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>elizgonz@hotmail.com</td>
	
	  <td>lisi1517</td>
	 
	  <td>5901 Bullard Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 9:23:37 PM
	</td>

</tr><TR>

		<td><b>Edward </b></td>
		<td><b>Bomba</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>elizgonz@hotmail.com</td>
	
	  <td>lisi1517</td>
	 
	  <td>5901 Bullard Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 9:25:48 PM
	</td>

</tr><TR>

		<td><b>Olivia </b></td>
		<td><b>Bomba</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>elizgonz@hotmail.com</td>
	
	  <td>lisi1517</td>
	 
	  <td>5901 Bullard Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Crawford</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 9:24:57 PM
	</td>

</tr><TR>

		<td><b>Annabelle </b></td>
		<td><b>Borm</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>33.5</td>
	
	  <td>borm@earthlink.net</td>
	
	  <td>ibm7993</td>
	 
	  <td>1903 Holly Hill</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-329-8738</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Crump</td><td>3</td><td></td><td></td>
	<td>
	 2/10/2013 2:43:04 PM
	</td>

</tr><TR>

		<td><b>McKenzie </b></td>
		<td><b>Bowie</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>55</td>
	
	  <td>brandibowie@gmail.com</td>
	
	  <td>hotpink6550</td>
	 
	  <td>1305 Patterson Rd </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>512-709-0814</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Bogan</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 9:44:33 PM
	</td>

</tr><TR>

		<td><b>Quinn </b></td>
		<td><b>Bradshaw</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>bradshawtracy1@gmail.com</td>
	
	  <td>copper22</td>
	 
	  <td>2714 Creeks Edge Pkwy</td>
	 
	  <td></td>
	 
	  <td>TX</td>
	 
	  <td>us</td>
	 
	  <td>78733</td>
	 
	  <td>(512)680-0863</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Dreyer</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 6:20:27 PM
	</td>

</tr><TR>

		<td><b>Zachary </b></td>
		<td><b>Brand</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>sarathurwachter@yahoo.com</td>
	
	  <td>zachary512</td>
	 
	  <td>10121 Thistle Ridge</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>5126023753</td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Parolini</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 3:57:20 PM
	</td>

</tr><TR>

		<td><b>Lily </b></td>
		<td><b>Breaux</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>king_sally@hotmail.com</td>
	
	  <td>1Sinoloan</td>
	 
	  <td>703 W Mary</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>Holland</td><td>K</td><td></td><td></td>
	<td>
	 1/23/2013 9:45:52 PM
	</td>

</tr><TR>

		<td><b>Lizzie </b></td>
		<td><b>Briggs</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Eb86937@eanesisd.net</td>
	
	  <td>justin</td>
	 
	  <td>HCMS 1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>770-241-8729</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:24:10 PM
	</td>

</tr><TR>

		<td><b>Randy </b></td>
		<td><b>Briones</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Randy.Briones15@gmail.com</td>
	
	  <td>Randy2002</td>
	 
	  <td>701 woodward st apt 928</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>512-947-6909</td>

	<!-- this is where the custom fields go -->
		 <td>Galindo Elementary</td><td>Mrs.Rodriguez</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 9:58:10 PM
	</td>

</tr><TR>

		<td><b>Jackson </b></td>
		<td><b>Brown</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>thejunior1998@gmail.com</td>
	
	  <td>frankfurter1998</td>
	 
	  <td>3504 cookstown</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78759</td>
	 
	  <td>5127056912</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Phillips</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 4:02:45 PM
	</td>

</tr><TR>

		<td><b>Jackson </b></td>
		<td><b>Brown</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>thejunior1998@gmail.com</td>
	
	  <td>frankfurter1998</td>
	 
	  <td>3504 cookstown</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78759</td>
	 
	  <td>5127056912</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Phillips</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 4:03:14 PM
	</td>

</tr><TR>

		<td><b>Julia </b></td>
		<td><b>Brown</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jb28632@eanesisd.net</td>
	
	  <td>hcmsrf9ru</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123477354</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:46:00 PM
	</td>

</tr><TR>

		<td><b>Matthew </b></td>
		<td><b>Brown</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mosley.brown@gmail.com</td>
	
	  <td>bailey</td>
	 
	  <td>1315 Westover Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Pham</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 12:44:41 AM
	</td>

</tr><TR>

		<td><b>Michael </b></td>
		<td><b>Brown</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mosley.brown@gmail.com</td>
	
	  <td>bailey</td>
	 
	  <td>1315 Westover Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Batiansila</td><td>5</td><td></td><td></td>
	<td>
	 1/29/2013 12:43:19 AM
	</td>

</tr><TR>

		<td><b>PEYTON </b></td>
		<td><b>BROWN</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>kellibtx@gmail.com</td>
	
	  <td>biteme2464</td>
	 
	  <td>4311 RAVINE RIDGE TRAIL</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-917-7077</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>VAN ZANDT</td><td>3</td><td></td><td></td>
	<td>
	 2/4/2013 8:42:53 AM
	</td>

</tr><TR>

		<td><b>Peyton </b></td>
		<td><b>Brown</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>Peytonbrown12@icloud.com</td>
	
	  <td>boggie</td>
	 
	  <td>4311 ravine ridge trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-343-5505</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Mrs. Van Zandt</td><td>3</td><td></td><td></td>
	<td>
	 2/6/2013 9:10:42 PM
	</td>

</tr><TR>

		<td><b>ROWDY </b></td>
		<td><b>BROWN</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>kellibtx@gmail.com</td>
	
	  <td>rowdy1</td>
	 
	  <td>4311 RAVINE RIDGE TRAIL</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5129177077</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>SAIKIN</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 8:46:26 AM
	</td>

</tr><TR>

		<td><b>Malachi </b></td>
		<td><b>Browne</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>edandkittybrowne@gmail.com</td>
	
	  <td>zaq1xsw2</td>
	 
	  <td>3112 Honey Tree Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>9366898983</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Purvis</td><td>2</td><td></td><td></td>
	<td>
	 2/6/2013 5:45:21 PM
	</td>

</tr><TR>

		<td><b>Alexandra </b></td>
		<td><b>Bucher</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Alexclaire@gmail.com</td>
	
	  <td>exuzxl</td>
	 
	  <td>3205 rustic river cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-658-7271</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:18:19 PM
	</td>

</tr><TR>

		<td><b>Patricio </b></td>
		<td><b>Bunt</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>pb89246@eanesisd.net</td>
	
	  <td>22399bigbird</td>
	 
	  <td>2301 s Mopac app 233</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78742</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:01:23 PM
	</td>

</tr><TR>

		<td><b>Beau </b></td>
		<td><b>Burbach</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bb28752@gmail.com</td>
	
	  <td>Burbach</td>
	 
	  <td>3 Beecher lane</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5123309795</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/28/2013 9:48:59 AM
	</td>

</tr><TR>

		<td><b>Kristen </b></td>
		<td><b>Burns</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>58</td>
	
	  <td>busterburns@sbcglobal.net</td>
	
	  <td>buster</td>
	 
	  <td>4903 Mantle Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich</td><td>K</td><td></td><td></td>
	<td>
	 2/10/2013 4:52:58 PM
	</td>

</tr><TR>

		<td><b>Taylor </b></td>
		<td><b>Burns</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>58</td>
	
	  <td>busterburns@sbcglobal.net</td>
	
	  <td>buster</td>
	 
	  <td>4903 Mantle Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Smith</td><td>2</td><td></td><td></td>
	<td>
	 2/10/2013 4:47:30 PM
	</td>

</tr><TR>

		<td><b>Grant </b></td>
		<td><b>Byram</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Gb29178@eanesisd.net</td>
	
	  <td>bdb2430</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:16 AM
	</td>

</tr><TR>

		<td><b>Haley </b></td>
		<td><b>C</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Hc28512@eanesisd.net</td>
	
	  <td>hcmsvugne</td>
	 
	  <td>HCMS Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:52:24 PM
	</td>

</tr><TR>

		<td><b>Chandler </b></td>
		<td><b>Carlton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Cc30492@eanesisd.net</td>
	
	  <td>hcmsoldvw</td>
	 
	  <td>1300 Walsh Tarlton Austin Texas 78746</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:50:45 PM
	</td>

</tr><TR>

		<td><b>Zosia </b></td>
		<td><b>Carpentier</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>basia.carpentier@gmail.com</td>
	
	  <td>Kramer</td>
	 
	  <td>6605 Mesa Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>8319155863</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Brewer</td><td>1</td><td></td><td></td>
	<td>
	 1/31/2013 11:42:39 AM
	</td>

</tr><TR>

		<td><b>Major </b></td>
		<td><b>Carr</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>majorcarr7@gmail.com</td>
	
	  <td>lolokopok09</td>
	 
	  <td>4380 River Garden Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>RX</td>
	 
	  <td>78746</td>
	 
	  <td>5122217044</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Boyd</td><td>7</td><td></td><td></td>
	<td>
	 1/25/2013 8:00:23 PM
	</td>

</tr><TR>

		<td><b>Ben </b></td>
		<td><b>Carrell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>145</td>
	
	  <td>ehcarrell@yahoo.com</td>
	
	  <td>zipray</td>
	 
	  <td>3101 Toro Canyon Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Hester</td><td>K</td><td></td><td></td>
	<td>
	 2/7/2013 4:57:43 PM
	</td>

</tr><TR>

		<td><b>Kendall </b></td>
		<td><b>Carroll</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>58.5</td>
	
	  <td>kendallcarroll329@gmail.com</td>
	
	  <td>kc83704</td>
	 
	  <td>1317 tetbury lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78748</td>
	 
	  <td>512-431-6159</td>

	<!-- this is where the custom fields go -->
		 <td>West Ridge Middle School</td><td>Silva</td><td>6</td><td></td><td></td>
	<td>
	 1/30/2013 7:18:37 PM
	</td>

</tr><TR>

		<td><b>Lily </b></td>
		<td><b>Carroll</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>cossyh@yahoo.com</td>
	
	  <td>lily331</td>
	 
	  <td>2502 twin oaks dr</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td>512-420-0904</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Ravare</td><td>2</td><td></td><td></td>
	<td>
	 1/26/2013 9:15:49 AM
	</td>

</tr><TR>

		<td><b>Lily </b></td>
		<td><b>Chalk</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>300</td>
	
	  <td>Ginnyweasley734@gmail.com</td>
	
	  <td>b00ksr0ck</td>
	 
	  <td>4340 Bremner Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td>5124325066</td>

	<!-- this is where the custom fields go -->
		 <td>Cedars Montessori</td><td>Romig</td><td>5</td><td></td><td></td>
	<td>
	 1/25/2013 7:21:31 PM
	</td>

</tr><TR>

		<td><b>Barrett  </b></td>
		<td><b>Chambers</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bc28634@eanesisd.net</td>
	
	  <td>hcms8ccvt</td>
	 
	  <td>3115 Eaneswood Dr.</td>
	 
	  <td>3203 Foxfire </td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 11:12:55 AM
	</td>

</tr><TR>

		<td><b>ian </b></td>
		<td><b>chamoun</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mrschamoun@gmail.com</td>
	
	  <td>bismellah</td>
	 
	  <td>2800 waymaker way 22</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>5122217771</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>schatz</td><td>4</td><td></td><td></td>
	<td>
	 1/29/2013 9:20:45 AM
	</td>

</tr><TR>

		<td><b>Mia </b></td>
		<td><b>Chamoun</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mrschamoun@gmail.com</td>
	
	  <td>bismellah</td>
	 
	  <td>2800 waymaker way 22</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>5122217771</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Rojas</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 6:21:59 PM
	</td>

</tr><TR>

		<td><b>Courtney </b></td>
		<td><b>Cheek</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>cc81827@eanesisd.net</td>
	
	  <td>hcmsvhlhs</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127456793</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:14 AM
	</td>

</tr><TR>

		<td><b>Shrey </b></td>
		<td><b>Chettiar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Chettiar@gmail.com</td>
	
	  <td>s1u2k3u4</td>
	 
	  <td>3216 Rustic River Cv</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>6502246584</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich </td><td>K</td><td></td><td></td>
	<td>
	 2/8/2013 7:32:38 AM
	</td>

</tr><TR>

		<td><b>Tanish </b></td>
		<td><b>Chettiar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Chettiar@gmail.com</td>
	
	  <td>s1u2k3u4</td>
	 
	  <td>3216 Rustic River Cv</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>6502246584</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cimino</td><td>3</td><td></td><td></td>
	<td>
	 2/8/2013 7:28:31 AM
	</td>

</tr><TR>

		<td><b>Alvin </b></td>
		<td><b>Chew</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ac85251@eanesisd.net</td>
	
	  <td>hcmsqjdfl</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mc Grath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:54:50 PM
	</td>

</tr><TR>

		<td><b>Grady </b></td>
		<td><b>Chirogianis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>115</td>
	
	  <td>adinakc@yahoo.com</td>
	
	  <td>jason</td>
	 
	  <td>2937 Thousand Oaks Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-569-7299</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Miller</td><td>4</td><td></td><td></td>
	<td>
	 1/25/2013 11:21:31 AM
	</td>

</tr><TR>

		<td><b>Lila </b></td>
		<td><b>Chirogianis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>115</td>
	
	  <td>adinakc@yahoo.com</td>
	
	  <td>lilac</td>
	 
	  <td>2937 THOUSAND OAKS DR</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>787467661</td>
	 
	  <td>5125697299</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Brewer</td><td>1</td><td></td><td></td>
	<td>
	 2/6/2013 4:13:44 PM
	</td>

</tr><TR>

		<td><b>Ariela </b></td>
		<td><b>Choiniere</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>leela@noahhome.com</td>
	
	  <td>zztop4U</td>
	 
	  <td>2901 Whiteway Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 5:55:15 AM
	</td>

</tr><TR>

		<td><b>Lindsay </b></td>
		<td><b>Chong</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>chrischongtx@hotmail.com</td>
	
	  <td>firestar</td>
	 
	  <td>7520 Bonniebrook Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Chatterjee</td><td>3</td><td></td><td></td>
	<td>
	 2/2/2013 8:45:22 PM
	</td>

</tr><TR>

		<td><b>Emma </b></td>
		<td><b>Chu</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>smithzhu@gmail.com</td>
	
	  <td>y74amp</td>
	 
	  <td>9535 Ketona Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>4438502316</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Mrs. Shaver</td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 4:06:38 PM
	</td>

</tr><TR>

		<td><b>Tiffany </b></td>
		<td><b>Chung</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Tc28816@eanesisd.net</td>
	
	  <td>hcmsdhiyk</td>
	 
	  <td>203 Bulian Ln Apt B</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:13:00 PM
	</td>

</tr><TR>

		<td><b>Allison </b></td>
		<td><b>Church</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>90</td>
	
	  <td>eddie.church@hotmail.com</td>
	
	  <td>bigbluefan74</td>
	 
	  <td>9807 N. FM 620</td>
	 
	  <td>18106</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78726</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Zhasky</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 1:51:59 PM
	</td>

</tr><TR>

		<td><b>george </b></td>
		<td><b>clark</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>325</td>
	
	  <td>lizziecainclark@gmail.com</td>
	
	  <td>clark123</td>
	 
	  <td>3011 west ave</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78705</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>sharpe</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 10:09:57 AM
	</td>

</tr><TR>

		<td><b>warren </b></td>
		<td><b>clark</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>325</td>
	
	  <td>lizziecainclark@gmail.com</td>
	
	  <td>clark123</td>
	 
	  <td>3011 west ave</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78705</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>cross</td><td>4</td><td></td><td></td>
	<td>
	 1/30/2013 10:05:17 AM
	</td>

</tr><TR>

		<td><b>Mr. Butlers </b></td>
		<td><b>Class</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>james.butler@austinisd.org</td>
	
	  <td>snowpeople</td>
	 
	  <td>1134 Lawson Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78702</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/26/2013 3:00:29 PM
	</td>

</tr><TR>

		<td><b>Christy </b></td>
		<td><b>Cochran</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ccochran@austinisd.org</td>
	
	  <td>N0rthHi11s</td>
	 
	  <td>3700 North Hills Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-414-4547</td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Cochran</td><td>8</td><td></td><td></td>
	<td>
	 1/23/2013 2:03:16 PM
	</td>

</tr><TR>

		<td><b>Meyer </b></td>
		<td><b>Cohen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>125</td>
	
	  <td>pcohen710@gmail.com</td>
	
	  <td>bridgepoint</td>
	 
	  <td>3311 Lookout Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Crowley</td><td>3</td><td></td><td></td>
	<td>
	 2/2/2013 2:20:18 PM
	</td>

</tr><TR>

		<td><b>Diane </b></td>
		<td><b>Collier</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>galindolibrary@gmail.com</td>
	
	  <td>galindo</td>
	 
	  <td>2006 Ann Arbor Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>512-414-5981</td>

	<!-- this is where the custom fields go -->
		 <td>Galindo Elementary</td><td>Collier</td><td>5</td><td></td><td></td>
	<td>
	 2/7/2013 1:06:33 PM
	</td>

</tr><TR>

		<td><b>Sage </b></td>
		<td><b>Collier</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>dianna@collierlclan.net</td>
	
	  <td>elizabeth</td>
	 
	  <td>1904 Winter Park Rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Cummins</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 11:40:05 AM
	</td>

</tr><TR>

		<td><b>Zoe </b></td>
		<td><b>Collier</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>dianna@collierclan.net</td>
	
	  <td>noelle</td>
	 
	  <td>1904 Winter Park Rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Boyd-Harrington</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 11:41:55 AM
	</td>

</tr><TR>

		<td><b>Keira </b></td>
		<td><b>Collins</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>220</td>
	
	  <td>accdc1@gmail.com</td>
	
	  <td>T@k3AxnBo</td>
	 
	  <td>1801 Ann Arbor Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Iles</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 8:00:45 AM
	</td>

</tr><TR>

		<td><b>Gaby </b></td>
		<td><b>Colliot</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>260</td>
	
	  <td>colliote@yahoo.com</td>
	
	  <td>86062</td>
	 
	  <td>2906 Thousand Oaks Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Henson</td><td>3</td><td></td><td></td>
	<td>
	 1/31/2013 9:27:20 AM
	</td>

</tr><TR>

		<td><b>Jonah </b></td>
		<td><b>Combs</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>shanna.dickey@gmail.com</td>
	
	  <td>j@d-1700</td>
	 
	  <td>2248 Zach Scott Street</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Florence</td><td>7</td><td></td><td></td>
	<td>
	 2/9/2013 6:19:46 PM
	</td>

</tr><TR>

		<td><b>Martin </b></td>
		<td><b>Contreras</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mc28537@eanesisd.net</td>
	
	  <td>Dakayotik1</td>
	 
	  <td>5701 S. Mopac Expwy River Stone Ranch Apts. 1816</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78749</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:59:36 PM
	</td>

</tr><TR>

		<td><b>Janael </b></td>
		<td><b>Copeland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>karenwawak@gmail.com</td>
	
	  <td>readbird1234</td>
	 
	  <td>6803 Isabelle Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78752</td>
	 
	  <td>512 925 4875</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Russell</td><td>5</td><td></td><td></td>
	<td>
	 2/5/2013 10:19:15 PM
	</td>

</tr><TR>

		<td><b>Samantha </b></td>
		<td><b>Cowles</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>310</td>
	
	  <td>mathdude53@att.net</td>
	
	  <td>0317sam</td>
	 
	  <td>5906 Carleen Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-419-9727</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 1/26/2013 3:47:07 PM
	</td>

</tr><TR>

		<td><b>Willa </b></td>
		<td><b>Crocker</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>105.34</td>
	
	  <td>emilyecrocker@gmail.com</td>
	
	  <td>Chupa1313</td>
	 
	  <td>1221 Bickler Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>5129649250</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Brewer</td><td>1</td><td></td><td></td>
	<td>
	 2/10/2013 1:46:26 PM
	</td>

</tr><TR>

		<td><b>Marie </b></td>
		<td><b>Cruz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mmoise@austinisd.org</td>
	
	  <td>molly</td>
	 
	  <td>2610 w 10th st</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78703</td>
	 
	  <td>512 228-7490</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>stockbauer</td><td>6</td><td></td><td></td>
	<td>
	 2/5/2013 1:11:07 PM
	</td>

</tr><TR>

		<td><b>Maddie </b></td>
		<td><b>Cuellar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>hdoucha@yahoo.com</td>
	
	  <td>1fsh2fsh</td>
	 
	  <td>5501 Ravine Ridge Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5129640446</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 11:42:16 PM
	</td>

</tr><TR>

		<td><b>Annemarie  </b></td>
		<td><b>Curran</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>tycur1@yahoo.com</td>
	
	  <td>B1Annemarie</td>
	 
	  <td>5 Rob Roy</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>(512) 374-1087</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Stone</td><td>1</td><td></td><td></td>
	<td>
	 2/7/2013 8:02:44 PM
	</td>

</tr><TR>

		<td><b>Aneasa  </b></td>
		<td><b>Cuthbertson </b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ac86319@eanesisd.net</td>
	
	  <td>hcmscaire</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:54:32 PM
	</td>

</tr><TR>

		<td><b>franny </b></td>
		<td><b>cutter</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lanettecutter@gmail.com</td>
	
	  <td>boOkspring2008</td>
	 
	  <td>2008 headwater lane</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5128252635</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>cummins</td><td>1</td><td></td><td></td>
	<td>
	 2/8/2013 8:11:44 AM
	</td>

</tr><TR>

		<td><b>Sophia </b></td>
		<td><b>Dahlberg</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>300</td>
	
	  <td>Skdamd@gmail.com</td>
	
	  <td>brooke1</td>
	 
	  <td>3105 riva ridge</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5123349263</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 1/30/2013 2:22:58 PM
	</td>

</tr><TR>

		<td><b>Drew </b></td>
		<td><b>Damon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>vcahill@earthlink.net</td>
	
	  <td>puppy01</td>
	 
	  <td>6708 Shoal Creek Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512 788-4261</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 4:18:30 PM
	</td>

</tr><TR>

		<td><b>Luke </b></td>
		<td><b>Damon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>vcahill@earthlink.net</td>
	
	  <td>fish01</td>
	 
	  <td>6708 Shoal Creek Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512 788-4261</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Banta</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 4:17:21 PM
	</td>

</tr><TR>

		<td><b>Cameron </b></td>
		<td><b>Davis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>byronandcharlotte@yahoo.com</td>
	
	  <td>bedced6773</td>
	 
	  <td>8109 Endeavor Cir</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78726</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Zahasky</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 11:53:46 PM
	</td>

</tr><TR>

		<td><b>Henry </b></td>
		<td><b>Davis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>henrythellama@yahoo.com</td>
	
	  <td>lotrlover</td>
	 
	  <td>2808 Kinney Oakc Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Sylvia</td><td>6</td><td></td><td></td>
	<td>
	 2/3/2013 1:05:35 PM
	</td>

</tr><TR>

		<td><b>Lauryn </b></td>
		<td><b>Davis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>85</td>
	
	  <td>charlottedimery@yahoo.com</td>
	
	  <td>bedced6773</td>
	 
	  <td>8109 Endeavor Cir</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78726</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Vitres</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 3:23:18 PM
	</td>

</tr><TR>

		<td><b>logan </b></td>
		<td><b>davis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>loganedavis@icloud.com</td>
	
	  <td>gadget</td>
	 
	  <td>5901 highland hills ter</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>allin</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 2:36:57 PM
	</td>

</tr><TR>

		<td><b>Reece </b></td>
		<td><b>Deitrick</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>55</td>
	
	  <td>smlandry70@yahoo.com</td>
	
	  <td>westlake2025</td>
	 
	  <td>1921 Wimberly Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td>512-689-4393</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich</td><td>K</td><td></td><td></td>
	<td>
	 1/31/2013 5:58:48 PM
	</td>

</tr><TR>

		<td><b>Agon </b></td>
		<td><b>Demi</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ad28488@gmail.com</td>
	
	  <td>Aademi512</td>
	 
	  <td>1511 camp craft road unit d</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:24:46 PM
	</td>

</tr><TR>

		<td><b>Eli </b></td>
		<td><b>Derr</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>olivia@derr.org</td>
	
	  <td>eliderr</td>
	 
	  <td>2002 Mistywood</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127714047</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Moy</td><td>2</td><td></td><td></td>
	<td>
	 2/5/2013 8:18:57 PM
	</td>

</tr><TR>

		<td><b>Wyatt </b></td>
		<td><b>Derr</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>olivia@derr.org</td>
	
	  <td>wyattderr</td>
	 
	  <td>2002 Mistywood</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127714047</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Quattlebaum</td><td>4</td><td></td><td></td>
	<td>
	 2/5/2013 8:51:45 PM
	</td>

</tr><TR>

		<td><b>Charlie  </b></td>
		<td><b>Despins</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>jdespins@gmail.com</td>
	
	  <td>jen8341</td>
	 
	  <td>6519 Ladera Norte</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5129408564</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Mowry</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 8:27:51 AM
	</td>

</tr><TR>

		<td><b>Raufil </b></td>
		<td><b>Dhuka</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>RD30269@eanesisd.net</td>
	
	  <td>raufildhuka99</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-694-6513</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:03 PM
	</td>

</tr><TR>

		<td><b>William </b></td>
		<td><b>DiCarlo</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>121</td>
	
	  <td>lhdicarlo@yahoo.com</td>
	
	  <td>Hubb6161</td>
	 
	  <td>6307 Wilbur Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78757</td>
	 
	  <td>5123236929</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Santiso</td><td>4</td><td></td><td></td>
	<td>
	 2/5/2013 9:44:01 PM
	</td>

</tr><TR>

		<td><b>Devin </b></td>
		<td><b>Dickey</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ddickey@unitedcountry.com</td>
	
	  <td>dlddld</td>
	 
	  <td>Rue de St germaine</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Lee</td><td>3</td><td></td><td></td>
	<td>
	 2/6/2013 7:14:25 PM
	</td>

</tr><TR>

		<td><b>Lily </b></td>
		<td><b>Dickey</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>shannondickey@gmail.com</td>
	
	  <td>120603</td>
	 
	  <td>6410 wilbur</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>Te</td>
	 
	  <td>78757</td>
	 
	  <td>5126805956</td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>moore</td><td>3</td><td></td><td></td>
	<td>
	 1/26/2013 10:41:53 AM
	</td>

</tr><TR>

		<td><b>Francesca </b></td>
		<td><b>Dietz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mspecoul@gmail.com</td>
	
	  <td>puppies99</td>
	 
	  <td>5303 Woodview Ave.</td>
	 
	  <td>Austin</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>5127312110</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 2/9/2013 10:03:59 PM
	</td>

</tr><TR>

		<td><b>Isabella </b></td>
		<td><b>Dietz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mspecoul@gmail.com</td>
	
	  <td>princess88</td>
	 
	  <td>5303 Woodview Ave.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>5127312110</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hampton</td><td>4</td><td></td><td></td>
	<td>
	 2/9/2013 9:31:40 PM
	</td>

</tr><TR>

		<td><b>John </b></td>
		<td><b>Dietz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mspecoul@gmail.com</td>
	
	  <td>soccer66</td>
	 
	  <td>5303 Woodview Ave.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>5127312110</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 2/9/2013 10:11:21 PM
	</td>

</tr><TR>

		<td><b>Finley </b></td>
		<td><b>Dixon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>145</td>
	
	  <td>cdixon@grandecom.net</td>
	
	  <td>brentwood</td>
	 
	  <td>1411 Brentwood St</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 6:26:52 PM
	</td>

</tr><TR>

		<td><b>Maddie </b></td>
		<td><b>Dixon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>295</td>
	
	  <td>cdixon@grandecom.net</td>
	
	  <td>brentwood</td>
	 
	  <td>1411 Brentwood St</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Childs</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 6:29:07 PM
	</td>

</tr><TR>

		<td><b>Savannah </b></td>
		<td><b>Doerr</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>105</td>
	
	  <td>sarahlee6183@gmail.com</td>
	
	  <td>ginger123</td>
	 
	  <td>2112 lawnmont ave.</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78756</td>
	 
	  <td>5127733394</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>hinojosa</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 11:00:43 PM
	</td>

</tr><TR>

		<td><b>Brandon </b></td>
		<td><b>Doggett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lisamucci@hotmail.com</td>
	
	  <td>reggie1</td>
	 
	  <td>1605 Milagro Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Ward</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 9:33:51 PM
	</td>

</tr><TR>

		<td><b>Drew </b></td>
		<td><b>Donahue</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>adrienne_baugh@dell.com</td>
	
	  <td>Booksdona1</td>
	 
	  <td>6809 Jester Wild Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78750</td>
	 
	  <td>512-724-2147</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Rushing</td><td>K</td><td></td><td></td>
	<td>
	 1/23/2013 7:53:47 PM
	</td>

</tr><TR>

		<td><b>Kathryn </b></td>
		<td><b>Dooley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>lkdooley@gmail.com</td>
	
	  <td>bookspring13</td>
	 
	  <td>6609 Lexington Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5129704083</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 10:49:33 AM
	</td>

</tr><TR>

		<td><b>William </b></td>
		<td><b>Dooley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>lkdooley@gmail.com</td>
	
	  <td>bookspring13</td>
	 
	  <td>6609 Lexington Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5129704083</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Childs</td><td>4</td><td></td><td></td>
	<td>
	 2/4/2013 11:01:15 AM
	</td>

</tr><TR>

		<td><b>Ayanna </b></td>
		<td><b>Doolittle</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>85</td>
	
	  <td>Tara.trower@gmail.com</td>
	
	  <td>ayanna</td>
	 
	  <td>4202 Everest Kane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78727</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Huth</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 10:00:23 PM
	</td>

</tr><TR>

		<td><b>Grace </b></td>
		<td><b>Dreifuerst</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>dina13@gmail.com</td>
	
	  <td>Oaks1702</td>
	 
	  <td>1702 Thousand Oaks Cir.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-329-5244</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Norman</td><td>5</td><td></td><td></td>
	<td>
	 2/8/2013 12:24:57 PM
	</td>

</tr><TR>

		<td><b>Diya </b></td>
		<td><b>Dsouza</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>15</td>
	
	  <td>diya.dsouza@gmail.com</td>
	
	  <td>dd6405</td>
	 
	  <td>8109 jester blvd </td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78750</td>
	 
	  <td>5122154221</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>vieira</td><td>5</td><td></td><td></td>
	<td>
	 1/27/2013 7:55:05 PM
	</td>

</tr><TR>

		<td><b>James </b></td>
		<td><b>Dudley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>JD86320@eanesisd.net</td>
	
	  <td>jd86320</td>
	 
	  <td>3600 woodcutters way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:02:57 PM
	</td>

</tr><TR>

		<td><b>Katie </b></td>
		<td><b>DULIN</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>mdulin@austin.rr.com</td>
	
	  <td>mombasa1</td>
	 
	  <td>6703 TROLL HAVEN</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127513546</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Steimle</td><td>4</td><td></td><td></td>
	<td>
	 2/10/2013 2:19:18 PM
	</td>

</tr><TR>

		<td><b>Lauren </b></td>
		<td><b>DULIN</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>mdulin@austin.rr.com</td>
	
	  <td>mombasa1</td>
	 
	  <td>6703 TROLL HAVEN</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127513546</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Mills</td><td>2</td><td></td><td></td>
	<td>
	 2/10/2013 2:23:19 PM
	</td>

</tr><TR>

		<td><b>Miles </b></td>
		<td><b>Dvorak</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>tmewis@gmail.com</td>
	
	  <td>md1212</td>
	 
	  <td>1509 W. 30th St</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Holloway</td><td>3</td><td></td><td></td>
	<td>
	 1/24/2013 2:48:22 PM
	</td>

</tr><TR>

		<td><b>Camryn  </b></td>
		<td><b>Eatmon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>dramatickat@gmail.com</td>
	
	  <td>Cami1234</td>
	 
	  <td>4700 N. Capital of Texas Hwy #211</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>2488357823</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>King</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 9:10:52 PM
	</td>

</tr><TR>

		<td><b>Bowie </b></td>
		<td><b>Edwards</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Amy.edwards@mac.com</td>
	
	  <td>bookspring123</td>
	 
	  <td>10609 parkfield drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78758</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 12:52:29 AM
	</td>

</tr><TR>

		<td><b>Ramona </b></td>
		<td><b>Edwards</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>amysmithedwards@yahoo.com</td>
	
	  <td>enigma</td>
	 
	  <td>3605 Steck Ave</td>
	 
	  <td>#2069</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Moore</td><td>3</td><td></td><td></td>
	<td>
	 2/3/2013 10:08:26 PM
	</td>

</tr><TR>

		<td><b>Roman </b></td>
		<td><b>Edwards</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mch74@hotmail.com</td>
	
	  <td>lucky17</td>
	 
	  <td>2707 geraghty Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 1/31/2013 10:51:51 PM
	</td>

</tr><TR>

		<td><b>Victoria </b></td>
		<td><b>Edwards</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Victoriaswims@gmail.com</td>
	
	  <td>hcmsv3ctf</td>
	 
	  <td>1201 Wilson hts</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 11:56:13 AM
	</td>

</tr><TR>

		<td><b>Maddie  </b></td>
		<td><b>Ely</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Me28771@eanesisd.net</td>
	
	  <td>hcmsn36md</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:32 AM
	</td>

</tr><TR>

		<td><b>Svea  </b></td>
		<td><b>Ely</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>heather.ely@gmail.com</td>
	
	  <td>berlin</td>
	 
	  <td>617 Horseback Hollow</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td>512-266-6800</td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Bears</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/24/2013 1:05:59 PM
	</td>

</tr><TR>

		<td><b>Svea </b></td>
		<td><b>Ely</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>heather.ely@gmail.com</td>
	
	  <td>berlin</td>
	 
	  <td>617 Horseback Hollow</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Ms.Viktoria</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/5/2013 9:28:41 PM
	</td>

</tr><TR>

		<td><b>Aimee </b></td>
		<td><b>Embestro</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ae81500@eanesisd.net</td>
	
	  <td>aimeehcms</td>
	 
	  <td>1900 Cetona Ct. 78746 Austin, TX</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124977641</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:59:16 PM
	</td>

</tr><TR>

		<td><b>Joseph </b></td>
		<td><b>Emmett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>356</td>
	
	  <td>Ashleigh.emmett@yahoo.com</td>
	
	  <td>superreader</td>
	 
	  <td>2709 Regents Park</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Mrs. Friedman</td><td>K</td><td></td><td></td>
	<td>
	 1/31/2013 11:20:05 AM
	</td>

</tr><TR>

		<td><b>Nicole </b></td>
		<td><b>Engle</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>cecilie@englemail.com</td>
	
	  <td>Yellow12</td>
	 
	  <td>5800 Linaria Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512-345-1472</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Haynes</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 5:40:23 PM
	</td>

</tr><TR>

		<td><b>Allan </b></td>
		<td><b>Escobedo</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Arasando@yahoo.com</td>
	
	  <td>char34</td>
	 
	  <td>1409 cassiopeia way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Chalk</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/8/2013 5:30:57 PM
	</td>

</tr><TR>

		<td><b>Sarah </b></td>
		<td><b>Esquivel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>luckieocelot@hotmail.com</td>
	
	  <td>bluespeckeled</td>
	 
	  <td>5700 Driftwood Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5123451678</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>VRBA</td><td>K</td><td></td><td></td>
	<td>
	 1/26/2013 10:45:11 AM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Ewing</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>laura.ewing@gmail.com</td>
	
	  <td>paininbut20</td>
	 
	  <td>2100 Wood Acre Lane #8</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>9254076450</td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Alden</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 5:48:41 PM
	</td>

</tr><TR>

		<td><b>Stella </b></td>
		<td><b>Falkin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>16.5</td>
	
	  <td>afalkin@austin.rr.com</td>
	
	  <td>burnet</td>
	 
	  <td>2605 W 49 1/2 St</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-458-4688</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Prewitt</td><td>3</td><td></td><td></td>
	<td>
	 2/3/2013 8:50:00 PM
	</td>

</tr><TR>

		<td><b>James Mack </b></td>
		<td><b>Fanning</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>jennefanning@hotmail.com</td>
	
	  <td>hootie01</td>
	 
	  <td>6100 Woodview Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5123711987</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea</td><td>3</td><td></td><td></td>
	<td>
	 1/25/2013 10:18:32 PM
	</td>

</tr><TR>

		<td><b>William Brock </b></td>
		<td><b>Fanning</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>jennefanning@hotmail.com</td>
	
	  <td>hootie01</td>
	 
	  <td>6100 Woodview Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5123711987</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Moore</td><td>3</td><td></td><td></td>
	<td>
	 1/25/2013 10:16:21 PM
	</td>

</tr><TR>

		<td><b>Andrew  </b></td>
		<td><b>Faulkner</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>135</td>
	
	  <td>jenandboys@gmail.com</td>
	
	  <td>phelps1696</td>
	 
	  <td>6300 Cat Mountain Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Murr</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 5:19:09 PM
	</td>

</tr><TR>

		<td><b>Zach </b></td>
		<td><b>Faulkner</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>135</td>
	
	  <td>jenandboys@gmail.com</td>
	
	  <td>phelps1696</td>
	 
	  <td>6300 Cat Mountain Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Robertson</td><td>6</td><td></td><td></td>
	<td>
	 1/28/2013 6:19:32 PM
	</td>

</tr><TR>

		<td><b>Charlie </b></td>
		<td><b>Ferina</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>275</td>
	
	  <td>christif74@gmail.com</td>
	
	  <td>Twins2006</td>
	 
	  <td>6605 Argentia Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Denaga</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 2:06:31 PM
	</td>

</tr><TR>

		<td><b>Chris </b></td>
		<td><b>Ferina</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>275</td>
	
	  <td>christif74@gmail.com</td>
	
	  <td>Twins2006</td>
	 
	  <td>6605 Argentia Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 2:08:25 PM
	</td>

</tr><TR>

		<td><b>Racic </b></td>
		<td><b>Fernandez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Rf27304@eanesisd.net</td>
	
	  <td>hcmsfalby</td>
	 
	  <td>1 downie place</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:21:14 PM
	</td>

</tr><TR>

		<td><b>Catherine </b></td>
		<td><b>Field</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>field.gabrielle@gmail.com</td>
	
	  <td>fudgiy5678</td>
	 
	  <td>6500 Champion Grandview Way</td>
	 
	  <td>#33004</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78750</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Jones</td><td>2</td><td></td><td></td>
	<td>
	 2/7/2013 3:02:44 PM
	</td>

</tr><TR>

		<td><b>Ryann </b></td>
		<td><b>Finell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>orcawhale3000@gmail.com</td>
	
	  <td>ryannf</td>
	 
	  <td>1152 E. Cottonwood Ln.</td>
	 
	  <td></td>
	 
	  <td>Phoenix</td>
	 
	  <td>AZ</td>
	 
	  <td>85048</td>
	 
	  <td>4807529929</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Murphy</td><td>6</td><td></td><td></td>
	<td>
	 1/27/2013 1:19:09 PM
	</td>

</tr><TR>

		<td><b>Madison </b></td>
		<td><b>Fish</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>140</td>
	
	  <td>mafish28@gmail.com</td>
	
	  <td>jellies1</td>
	 
	  <td>40 N. IH 35</td>
	 
	  <td>4B2</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78701</td>
	 
	  <td>512-294-7932</td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>Holland</td><td>K</td><td></td><td></td>
	<td>
	 1/23/2013 1:31:51 PM
	</td>

</tr><TR>

		<td><b>Daniel </b></td>
		<td><b>Flores</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>df87841@eanesisd.net</td>
	
	  <td>hcmsxh5kr</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:33:04 AM
	</td>

</tr><TR>

		<td><b>Reagan </b></td>
		<td><b>Flynn</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>dfly72@gmail.com</td>
	
	  <td>poodle</td>
	 
	  <td>5704 Shoal Creek Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512.428.5038</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Banta</td><td>3</td><td></td><td></td>
	<td>
	 2/7/2013 2:55:03 PM
	</td>

</tr><TR>

		<td><b>Patrick </b></td>
		<td><b>Foley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>anniefoley02@hotmail.com</td>
	
	  <td>jamesbond</td>
	 
	  <td>2905 Trailview Mesa Ter.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Tremel</td><td>1</td><td></td><td></td>
	<td>
	 2/11/2013 7:25:27 AM
	</td>

</tr><TR>

		<td><b>Luke </b></td>
		<td><b>Foster</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>graceandcade@sbcglobal.net</td>
	
	  <td>pepperoni</td>
	 
	  <td>1608 Alta Vista Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>512-897-0450</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Austin</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 4:23:49 PM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Fox</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>eafox21@yahoo.com</td>
	
	  <td>gracie12</td>
	 
	  <td>6500 Champion Grandview #22002</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78750</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Laxton</td><td>2</td><td></td><td></td>
	<td>
	 2/5/2013 2:09:40 PM
	</td>

</tr><TR>

		<td><b>Ellia </b></td>
		<td><b>Fox</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>eafox21@yahoo.com</td>
	
	  <td>gr@cie12</td>
	 
	  <td>6500 Champion Grandview #22002</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78750</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Childs</td><td>4</td><td></td><td></td>
	<td>
	 2/4/2013 7:47:23 AM
	</td>

</tr><TR>

		<td><b>Sam  </b></td>
		<td><b>Franklin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>132</td>
	
	  <td>slohmer@hotmail.com</td>
	
	  <td>samfranklin</td>
	 
	  <td>4309 Shoalwood Ave.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>5129098498</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Boreing</td><td>4</td><td></td><td></td>
	<td>
	 2/9/2013 7:39:40 AM
	</td>

</tr><TR>

		<td><b>Dylan </b></td>
		<td><b>Franzen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>408</td>
	
	  <td>jillvv@earthlink.net</td>
	
	  <td>jilldylan8</td>
	 
	  <td>4500 Charles Ave.</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>McMillin</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 7:57:48 PM
	</td>

</tr><TR>

		<td><b>Emily </b></td>
		<td><b>Freeman</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>emmy.freeman@gmail.com</td>
	
	  <td>qwerty</td>
	 
	  <td>7517B Hart Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-762-1864</td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Jordan</td><td>6</td><td></td><td></td>
	<td>
	 1/27/2013 3:37:03 PM
	</td>

</tr><TR>

		<td><b>Scarlet </b></td>
		<td><b>Frese</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>300</td>
	
	  <td>scarletfrese@gmail.com</td>
	
	  <td>goodfast</td>
	 
	  <td>2602 Albata Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78757</td>
	 
	  <td>512-483-1606</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Banta</td><td>3</td><td></td><td></td>
	<td>
	 1/26/2013 11:50:13 AM
	</td>

</tr><TR>

		<td><b>Ethan </b></td>
		<td><b>Frischhertz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>Frischhertz@gmail.com</td>
	
	  <td>gegchi</td>
	 
	  <td>5620 Clarion Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Root</td><td>5</td><td></td><td></td>
	<td>
	 2/6/2013 5:28:01 PM
	</td>

</tr><TR>

		<td><b>Kate  </b></td>
		<td><b>Frischhertz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Frischhertz@gmail.com</td>
	
	  <td>momoffour</td>
	 
	  <td>5620 Clarion Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cowan</td><td>2</td><td></td><td></td>
	<td>
	 2/6/2013 5:21:00 PM
	</td>

</tr><TR>

		<td><b>Kate </b></td>
		<td><b>Frischhertz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>frischhertz@gmail.com</td>
	
	  <td>gegchi</td>
	 
	  <td>5620 Clarion Cv.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-329-6488</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cowan</td><td>2</td><td></td><td></td>
	<td>
	 2/7/2013 9:58:37 AM
	</td>

</tr><TR>

		<td><b>Milo </b></td>
		<td><b>Froese</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>Janafroese@gmail.com</td>
	
	  <td>hemi2</td>
	 
	  <td>3004 Silverleaf Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>See</td><td>4</td><td></td><td></td>
	<td>
	 1/30/2013 7:15:46 PM
	</td>

</tr><TR>

		<td><b>Sasha </b></td>
		<td><b>Froese</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>Janafroese@gmail.com</td>
	
	  <td>hemi1</td>
	 
	  <td>3004 Silverleaf Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 5:09:17 PM
	</td>

</tr><TR>

		<td><b>Mia </b></td>
		<td><b>Fuss</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>efuss4@gmail.com</td>
	
	  <td>melomom4</td>
	 
	  <td>29 Lovegrass Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td>5127960617</td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Canelos</td><td>2</td><td></td><td></td>
	<td>
	 2/10/2013 11:07:50 PM
	</td>

</tr><TR>

		<td><b>Charlie </b></td>
		<td><b>Galatzan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>emilygalatzan@me.com</td>
	
	  <td>joshua</td>
	 
	  <td>5005 Mantle Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5125075342</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Tremel</td><td>1</td><td></td><td></td>
	<td>
	 2/9/2013 11:47:33 AM
	</td>

</tr><TR>

		<td><b>Mason </b></td>
		<td><b>Galligan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>Tgalligan@gmail.com</td>
	
	  <td>Stanl3y</td>
	 
	  <td>7200 Mesa Dr. </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Mowry</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 8:37:00 PM
	</td>

</tr><TR>

		<td><b>Christopher </b></td>
		<td><b>Garana</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>thegaranas@sbcglobal.net</td>
	
	  <td>friend</td>
	 
	  <td>3702 Aspendale Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78727</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Carter</td><td>6</td><td></td><td></td>
	<td>
	 1/30/2013 9:38:41 PM
	</td>

</tr><TR>

		<td><b>lola </b></td>
		<td><b>Garberoglio</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>louellagrace@gmail.com</td>
	
	  <td>iwillraisemoney</td>
	 
	  <td>3561 Lake Austin Blvd #E</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512897730</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Mr.Rackowitz</td><td>5</td><td></td><td></td>
	<td>
	 1/23/2013 5:29:36 PM
	</td>

</tr><TR>

		<td><b>Julia </b></td>
		<td><b>Garcia</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>martha_b_a@yahoo.com</td>
	
	  <td>me0012</td>
	 
	  <td>9213 Prince Charles</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78730</td>
	 
	  <td>5123729014</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Crowley</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/26/2013 8:42:06 PM
	</td>

</tr><TR>

		<td><b>Jacqueline </b></td>
		<td><b>Garibay</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>linda@garibay.net</td>
	
	  <td>82494</td>
	 
	  <td>1730 Camp Craft Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123273597</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Cunningham</td><td>6</td><td></td><td></td>
	<td>
	 1/27/2013 11:13:13 PM
	</td>

</tr><TR>

		<td><b>Madison </b></td>
		<td><b>Garofolo</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>madi.garofolo@gmail.om</td>
	
	  <td>madison</td>
	 
	  <td>5300 Apache Creek Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td>512-560-8681</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Maher</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 5:14:46 PM
	</td>

</tr><TR>

		<td><b>Meaghan </b></td>
		<td><b>Geld</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>terrygeld@swbell.net</td>
	
	  <td>3975tjdm</td>
	 
	  <td>7000 Quill Leaf Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78750</td>
	 
	  <td>512-338-4268</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Nguyen</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 6:18:48 PM
	</td>

</tr><TR>

		<td><b>Zach </b></td>
		<td><b>Geller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>spfgeller@gmail.com</td>
	
	  <td>sarahp</td>
	 
	  <td>3502 Sacred Moon Cove</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-551-9258</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Iles</td><td>1</td><td></td><td></td>
	<td>
	 2/5/2013 2:09:58 PM
	</td>

</tr><TR>

		<td><b>Ava </b></td>
		<td><b>Georg</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>derek.georg@gmail.com</td>
	
	  <td>s0uthside</td>
	 
	  <td>5739 Palo Blanco</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78744</td>
	 
	  <td>5129655666</td>

	<!-- this is where the custom fields go -->
		 <td>Galindo Elementary</td><td>Murdter-Atkinson</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 11:11:43 PM
	</td>

</tr><TR>

		<td><b>Faith  </b></td>
		<td><b>Gerstein</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>faithghorsey@gmail.com</td>
	
	  <td>smudge419</td>
	 
	  <td>706 West Lynn street apt A</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>1310-413-3381</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Phillips</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:47:09 AM
	</td>

</tr><TR>

		<td><b>Graham </b></td>
		<td><b>Gilbert</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>Lizangilbert@gmail.com</td>
	
	  <td>mr.man</td>
	 
	  <td>4212 Bellvue Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78756</td>
	 
	  <td>5124619677</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Cavazos</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 9:24:36 PM
	</td>

</tr><TR>

		<td><b>Olivia </b></td>
		<td><b>Gilbert</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>Lizangilbert@gmail.com</td>
	
	  <td>apple</td>
	 
	  <td>4212 Bellvue Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78756</td>
	 
	  <td>5124619677</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Dowell</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 9:48:23 PM
	</td>

</tr><TR>

		<td><b>Mason Claire </b></td>
		<td><b>Gillingwater</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>m.gillingwater@sbcglobal.net</td>
	
	  <td>treymason1998</td>
	 
	  <td>4010 long champ dr.  #17</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>MOJICA</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 8:09:26 PM
	</td>

</tr><TR>

		<td><b>Trey </b></td>
		<td><b>Gillingwater</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Bg87549@eanesisd.net</td>
	
	  <td>treycubby7499</td>
	 
	  <td>4010 long champ dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mosher</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:59:01 PM
	</td>

</tr><TR>

		<td><b>Charlie </b></td>
		<td><b>Gilluly</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>dgilluly@att.net</td>
	
	  <td>emmak1</td>
	 
	  <td>3400 Day Star Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512 345-8204</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich</td><td>K</td><td></td><td></td>
	<td>
	 2/7/2013 9:28:36 AM
	</td>

</tr><TR>

		<td><b>Maggie </b></td>
		<td><b>Gilluly</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>dgilluly@att.net</td>
	
	  <td>emmak1</td>
	 
	  <td>3400 Day Star Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512 345-8204</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>McMillin</td><td>2</td><td></td><td></td>
	<td>
	 2/7/2013 9:30:06 AM
	</td>

</tr><TR>

		<td><b>Nicholas </b></td>
		<td><b>Gitcho</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bgitcho@hotmail.com</td>
	
	  <td>nicholas0318</td>
	 
	  <td>4212 Prickly Pear Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78731</td>
	 
	  <td>512-921-5595</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Mowry</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 11:20:28 PM
	</td>

</tr><TR>

		<td><b>William Bryant </b></td>
		<td><b>Gitcho</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bgitcho@hotmail.com</td>
	
	  <td>nicholas0318</td>
	 
	  <td>4212 Prickly Pear Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78731</td>
	 
	  <td>512-921-5595</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Hill</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 11:32:41 PM
	</td>

</tr><TR>

		<td><b>Luis </b></td>
		<td><b>Gomez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>aleyluiseduardo@yahoo.com</td>
	
	  <td>leleia</td>
	 
	  <td>4720 Rockcliff Rd. Unit 1</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5129409206</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Matus</td><td>3</td><td></td><td></td>
	<td>
	 2/9/2013 7:33:20 PM
	</td>

</tr><TR>

		<td><b>Isabell </b></td>
		<td><b>Grace</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>tgrace@bdo.com</td>
	
	  <td>414bella</td>
	 
	  <td>12345 lamplight village</td>
	 
	  <td>apt 1027</td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Cohen</td><td>5</td><td></td><td></td>
	<td>
	 1/30/2013 8:19:31 PM
	</td>

</tr><TR>

		<td><b>Coco </b></td>
		<td><b>Gravois</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>hgravois@yahoo.com</td>
	
	  <td>kookaburra</td>
	 
	  <td>5109 Avenue F</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td>228-2816</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 11:00:15 PM
	</td>

</tr><TR>

		<td><b>Jude </b></td>
		<td><b>Gravois</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>65</td>
	
	  <td>hgravois@yahoo.com</td>
	
	  <td>japanese</td>
	 
	  <td>5109 Avenue F</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td>228-2816</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hampton</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 11:03:25 PM
	</td>

</tr><TR>

		<td><b>Zoe </b></td>
		<td><b>Gravois</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>hgravois@yahoo.com</td>
	
	  <td>zoebird</td>
	 
	  <td>5109 Avenue F</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td>228-2816</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 10:54:00 PM
	</td>

</tr><TR>

		<td><b>Addison </b></td>
		<td><b>Green</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>220</td>
	
	  <td>Anitralw@gmail.com</td>
	
	  <td>nomoney4</td>
	 
	  <td>4808 Oldfort Hill Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td>512-296-8063</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/25/2013 8:30:03 PM
	</td>

</tr><TR>

		<td><b>Jordan  </b></td>
		<td><b>Green</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jg29260@eanesisd.net</td>
	
	  <td>pumica99</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:58:25 PM
	</td>

</tr><TR>

		<td><b>Eliza  </b></td>
		<td><b>Greenberg</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>166.6</td>
	
	  <td>greenbergrn@yahoo.com</td>
	
	  <td>rootbeer</td>
	 
	  <td>6806 Daugherty St</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-736-1831</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Russell</td><td>5</td><td></td><td></td>
	<td>
	 1/29/2013 1:05:09 PM
	</td>

</tr><TR>

		<td><b>Abby </b></td>
		<td><b>Greendyk</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>85</td>
	
	  <td>ahgreendyk@gmail.com</td>
	
	  <td>monkey</td>
	 
	  <td>4003 Petes Path</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78731</td>
	 
	  <td>5124190992</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Dayon</td><td>4</td><td></td><td></td>
	<td>
	 2/4/2013 8:48:44 PM
	</td>

</tr><TR>

		<td><b>Jacob </b></td>
		<td><b>Greendyk</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>taragreendyk@gmail.com</td>
	
	  <td>salazar1313</td>
	 
	  <td>4003 Petes path</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5124190992</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Powell</td><td>6</td><td></td><td></td>
	<td>
	 1/30/2013 5:41:58 PM
	</td>

</tr><TR>

		<td><b>Caden </b></td>
		<td><b>Grethel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>egrethel@yahoo.com</td>
	
	  <td>madison</td>
	 
	  <td>1505 Murray Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Farris</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 7:37:09 PM
	</td>

</tr><TR>

		<td><b>Gray </b></td>
		<td><b>Griffin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Lg87907@eanesisd.net</td>
	
	  <td>gray1234</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:29:44 AM
	</td>

</tr><TR>

		<td><b>Lloyd </b></td>
		<td><b>Griffin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Lg87907@eanesisd.net</td>
	
	  <td>gray1234</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:31:46 AM
	</td>

</tr><TR>

		<td><b>Caetano </b></td>
		<td><b>Griffiths</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>em2018@columbia.edu</td>
	
	  <td>redblankie</td>
	 
	  <td>6109A Shadow Valley Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>214-514-0911</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Johnson</td><td>3</td><td></td><td></td>
	<td>
	 2/4/2013 3:21:56 PM
	</td>

</tr><TR>

		<td><b>Bernardo </b></td>
		<td><b>Guerra</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>rgomez@mdycontactcenter.com</td>
	
	  <td>foca007</td>
	 
	  <td>2900 Meandering River Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127849679</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Krost</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 12:49:28 AM
	</td>

</tr><TR>

		<td><b>Maria </b></td>
		<td><b>Guerra</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>rgomez@mdycontactcenter.com</td>
	
	  <td>foca007</td>
	 
	  <td>2900 Meandering River Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127849679</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cook</td><td>4</td><td></td><td></td>
	<td>
	 2/4/2013 12:44:12 AM
	</td>

</tr><TR>

		<td><b>Mauricio </b></td>
		<td><b>Guerra</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>rgomez@mdycontactcenter.com</td>
	
	  <td>foca007</td>
	 
	  <td>2900 Meandering River Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127849679</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Smith</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 12:50:19 AM
	</td>

</tr><TR>

		<td><b>Landon  </b></td>
		<td><b>Gutierrez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>342.4</td>
	
	  <td>lil_ktm16@hotmail.com</td>
	
	  <td>katiedid</td>
	 
	  <td>9417 Great Hills Trail</td>
	 
	  <td>#1029</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512-787-1238</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Rushing</td><td>K</td><td></td><td></td>
	<td>
	 1/24/2013 12:37:18 PM
	</td>

</tr><TR>

		<td><b>Paige </b></td>
		<td><b>Hainline</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ph28649@eanesisd.net</td>
	
	  <td>hcmsaas9v</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:32:58 AM
	</td>

</tr><TR>

		<td><b>Bailey </b></td>
		<td><b>Hall</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>baileybhall@gmail.com</td>
	
	  <td>baileybhall</td>
	 
	  <td>1405 NORTHWOOD RD</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78703-1941</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Robertson</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 6:32:49 PM
	</td>

</tr><TR>

		<td><b>Nevin </b></td>
		<td><b>Hall</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nevinhall@gmail.com</td>
	
	  <td>nevinhall</td>
	 
	  <td>1405 NORTHWOOD RD</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78703-1941</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Lowrie</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 6:24:50 PM
	</td>

</tr><TR>

		<td><b>Nina </b></td>
		<td><b>Hallberg</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nh87864@eanesisd.org</td>
	
	  <td>penguin</td>
	 
	  <td>unicorn land mesa</td>
	 
	  <td></td>
	 
	  <td>billy bob joe chuck jr.</td>
	 
	  <td>PU</td>
	 
	  <td>657483</td>
	 
	  <td>222-545-6789</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Root</td><td>4</td><td></td><td></td>
	<td>
	 1/31/2013 8:25:46 PM
	</td>

</tr><TR>

		<td><b>Katie </b></td>
		<td><b>Hamill</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Kh28657@eanesisd.net</td>
	
	  <td>fekp8</td>
	 
	  <td> Hill Country middle school 1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-879-8371</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mcgrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 11:44:53 AM
	</td>

</tr><TR>

		<td><b>Rylie </b></td>
		<td><b>Hansen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>shelbyrain@hotmail.com</td>
	
	  <td>wrms0nvjx</td>
	 
	  <td>2100 wood acre lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78733</td>
	 
	  <td>512-215-9091</td>

	<!-- this is where the custom fields go -->
		 <td>West Ridge Middle School</td><td>Simmons </td><td>6</td><td></td><td></td>
	<td>
	 1/28/2013 7:52:16 PM
	</td>

</tr><TR>

		<td><b>Pierce </b></td>
		<td><b>Harrell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>PH29154@eanesisd.net</td>
	
	  <td>hcmsrfpun</td>
	 
	  <td>1300 Walsh Tarlton Austin, TX 78746</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:33:01 AM
	</td>

</tr><TR>

		<td><b>Natalie </b></td>
		<td><b>Harren</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>NH85456@eanesisd.net</td>
	
	  <td>campchampions</td>
	 
	  <td>Hcms 1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:10 AM
	</td>

</tr><TR>

		<td><b>Marguerite  </b></td>
		<td><b>Harrison</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mh28581@eanesisd.net</td>
	
	  <td>hcmsbpuoz</td>
	 
	  <td>Hill country middle school 1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>5122637584</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:31:57 AM
	</td>

</tr><TR>

		<td><b>Jackson </b></td>
		<td><b>Harshbarger</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>dawnbentley@mac.com</td>
	
	  <td>ilovemydog</td>
	 
	  <td>1102 Constant Springs Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-633-0825</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Purvis</td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 11:46:06 AM
	</td>

</tr><TR>

		<td><b>Ava </b></td>
		<td><b>Hartmann</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lhartmann@utsystem.edu</td>
	
	  <td>mussieugi</td>
	 
	  <td>4712 Walsall Loop</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Cummins</td><td>1</td><td></td><td></td>
	<td>
	 2/3/2013 6:51:59 PM
	</td>

</tr><TR>

		<td><b>Christian </b></td>
		<td><b>Hatley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>80</td>
	
	  <td>ch83149@eanesisd.net</td>
	
	  <td>furball</td>
	 
	  <td>1926 Holly Hill Dr. #A</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Norman</td><td>5</td><td></td><td></td>
	<td>
	 1/30/2013 8:05:32 PM
	</td>

</tr><TR>

		<td><b>Joshua </b></td>
		<td><b>Hatley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30.5</td>
	
	  <td>jh83150@eanesisd.net</td>
	
	  <td>furball</td>
	 
	  <td>1926 Holly Hill Dr #A</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-771-3517</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Kreps</td><td>5</td><td></td><td></td>
	<td>
	 2/10/2013 9:52:47 AM
	</td>

</tr><TR>

		<td><b>Harrison </b></td>
		<td><b>Hauf</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>HH29173@eanesisd.net</td>
	
	  <td>jamman25</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:54:32 PM
	</td>

</tr><TR>

		<td><b>Madeline </b></td>
		<td><b>Hawkins</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mh28659@eanesisd.net</td>
	
	  <td>hcms2deua</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746 </td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:04:50 PM
	</td>

</tr><TR>

		<td><b>Parker  </b></td>
		<td><b>Haydon </b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ph29672@eanesisd.net</td>
	
	  <td>haydon</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123309535</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:42:34 PM
	</td>

</tr><TR>

		<td><b>Lucia </b></td>
		<td><b>Heffron</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>150</td>
	
	  <td>Cookheffron@gmail.com</td>
	
	  <td>8*ifsz8*</td>
	 
	  <td>1501 Romeria</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hinojosa</td><td>K</td><td></td><td></td>
	<td>
	 1/25/2013 4:44:31 PM
	</td>

</tr><TR>

		<td><b>Nathaniel </b></td>
		<td><b>Heffron</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>150</td>
	
	  <td>Cookheffron@gmail.com</td>
	
	  <td>8*ifsz8*</td>
	 
	  <td>1501 Romeria</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea</td><td>3</td><td></td><td></td>
	<td>
	 1/25/2013 4:42:47 PM
	</td>

</tr><TR>

		<td><b>Gabriel </b></td>
		<td><b>Helal</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>khelal1@me.com</td>
	
	  <td>4151457</td>
	 
	  <td>3901 Michael Neill Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78730</td>
	 
	  <td>512-342-2388</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Knorr</td><td>2</td><td></td><td></td>
	<td>
	 1/31/2013 7:52:03 AM
	</td>

</tr><TR>

		<td><b>Mack </b></td>
		<td><b>Helble</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>beccahelble@gmail.com</td>
	
	  <td>mackhelble</td>
	 
	  <td>3314 THree Rivers Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5126956406</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Root</td><td>4</td><td></td><td></td>
	<td>
	 2/10/2013 4:54:27 PM
	</td>

</tr><TR>

		<td><b>William </b></td>
		<td><b>Helble</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>beccahelble@gmail.com</td>
	
	  <td>stepheng</td>
	 
	  <td>3314 Three Rivers Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5126956406</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Mills</td><td>2</td><td></td><td></td>
	<td>
	 2/10/2013 4:53:11 PM
	</td>

</tr><TR>

		<td><b>Thomas </b></td>
		<td><b>Helmbrecht</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>150</td>
	
	  <td>meganhelm0@gmail.com</td>
	
	  <td>red123</td>
	 
	  <td>6203 Shadow Mountain Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512.497.5579</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Stone</td><td>1</td><td></td><td></td>
	<td>
	 1/23/2013 7:19:06 PM
	</td>

</tr><TR>

		<td><b>Georgia </b></td>
		<td><b>Henderson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mizjez@hotmail.com</td>
	
	  <td>6975jess</td>
	 
	  <td>7600 Cameron R</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78752</td>
	 
	  <td>512-565-2626</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/25/2013 7:26:23 PM
	</td>

</tr><TR>

		<td><b>Allie </b></td>
		<td><b>Hendrix</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>195</td>
	
	  <td>alh_daisy@yahoo.com</td>
	
	  <td>cool7</td>
	 
	  <td>3106 Mistyglen Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Boyd-Herrington</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 5:08:25 PM
	</td>

</tr><TR>

		<td><b>Kasey </b></td>
		<td><b>Hendrix</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>195</td>
	
	  <td>kkfroggy29@yahoo.com</td>
	
	  <td>yellowkh</td>
	 
	  <td>3106 Mistyglen Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Puga</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 4:44:07 PM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Hicks</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>chrisohicks@gmail.com</td>
	
	  <td>amh84440</td>
	 
	  <td>3405 Day Star Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127998008</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cimino</td><td>3</td><td></td><td></td>
	<td>
	 2/4/2013 5:02:58 PM
	</td>

</tr><TR>

		<td><b>Jad </b></td>
		<td><b>Hijazi</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lajaffar@hotmail.com</td>
	
	  <td>austin2005</td>
	 
	  <td>5813 Kentucky Derby</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Iles</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 12:16:13 AM
	</td>

</tr><TR>

		<td><b>Ava </b></td>
		<td><b>Hodges</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>j_hodges12@yahoo.com</td>
	
	  <td>charlie</td>
	 
	  <td>4115 Paint Rock Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78731</td>
	 
	  <td>512-795-0885</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Warner</td><td>K</td><td></td><td></td>
	<td>
	 1/26/2013 10:46:57 AM
	</td>

</tr><TR>

		<td><b>Hank </b></td>
		<td><b>Holland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>faye5909@gmail.com</td>
	
	  <td>bookspring</td>
	 
	  <td>5909 Carleen Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 8:48:00 AM
	</td>

</tr><TR>

		<td><b>Lily  </b></td>
		<td><b>Holland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>faye5909@gmail.com</td>
	
	  <td>bookspring</td>
	 
	  <td>5909 Carleen Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea/ Sapp</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 8:45:44 AM
	</td>

</tr><TR>

		<td><b>Audrey </b></td>
		<td><b>Holm</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>mattanaholm@gmail.com</td>
	
	  <td>aholm2</td>
	 
	  <td>2003 Wychwood Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>5622251116</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>henson</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 6:07:26 PM
	</td>

</tr><TR>

		<td><b>Edith </b></td>
		<td><b>Holmsten</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>225</td>
	
	  <td>jonholmsten@hotmail.com</td>
	
	  <td>edith8as</td>
	 
	  <td>1904 Rogge Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Absher</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 7:46:50 PM
	</td>

</tr><TR>

		<td><b>Natalie </b></td>
		<td><b>Holmsten</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>225</td>
	
	  <td>jonholmsten@hotmail.com</td>
	
	  <td>nhlovesdogs</td>
	 
	  <td>1904 Rogge Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Barnes</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 7:56:24 PM
	</td>

</tr><TR>

		<td><b>Gabriella </b></td>
		<td><b>Holt</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>450</td>
	
	  <td>angieholtdds@yahoo.com</td>
	
	  <td>leroy</td>
	 
	  <td>3013 Teak Hawk Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-992-6375</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 9:28:17 AM
	</td>

</tr><TR>

		<td><b>Georgia Kate </b></td>
		<td><b>Honza</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>15</td>
	
	  <td>honzafamily@gmail.com</td>
	
	  <td>read2013</td>
	 
	  <td>4103 Far West Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-795-9266</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Raup</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 5:55:03 PM
	</td>

</tr><TR>

		<td><b>Ryan </b></td>
		<td><b>Honza</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>15</td>
	
	  <td>honzafamily@gmail.com</td>
	
	  <td>read2013</td>
	 
	  <td>4103 Far West Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-795-9266</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Francis</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 5:49:41 PM
	</td>

</tr><TR>

		<td><b>Olivia </b></td>
		<td><b>Horn</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>b_quinn316@yahoo.com</td>
	
	  <td>simone</td>
	 
	  <td>710 W 34th St</td>
	 
	  <td>apt 101</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78705</td>
	 
	  <td>2819613562</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Ahumada</td><td>K</td><td></td><td></td>
	<td>
	 2/3/2013 5:25:49 PM
	</td>

</tr><TR>

		<td><b>Hailey </b></td>
		<td><b>Howe</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Hh28517@eanesisd.net</td>
	
	  <td>hcmsqjsmo</td>
	 
	  <td>4901 South Crest Dr. </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:43:37 PM
	</td>

</tr><TR>

		<td><b>Nadia </b></td>
		<td><b>Hsu</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nadiahsu@zilladog.net</td>
	
	  <td>badkitty</td>
	 
	  <td>3403 Taylors Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Austin</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 10:32:34 PM
	</td>

</tr><TR>

		<td><b>Stella </b></td>
		<td><b>Hufford</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>105</td>
	
	  <td>Amhufford@gmail.com</td>
	
	  <td>jeffrey</td>
	 
	  <td>6814 Joyce St.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78757</td>
	 
	  <td>512-467-0028</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 8:43:33 PM
	</td>

</tr><TR>

		<td><b>Connor </b></td>
		<td><b>Hughes</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>180</td>
	
	  <td>Djhughes100@sbcglobal.net</td>
	
	  <td>redfish</td>
	 
	  <td>1161 Stone Forest Trail</td>
	 
	  <td></td>
	 
	  <td>Round Rock</td>
	 
	  <td>TX</td>
	 
	  <td>78681</td>
	 
	  <td>5127899110</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Baehr </td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 8:56:47 PM
	</td>

</tr><TR>

		<td><b>Elijah </b></td>
		<td><b>Hunziker</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>christyhunziker@hotmail.com</td>
	
	  <td>trolllol</td>
	 
	  <td>614 Highland Ave</td>
	 
	  <td>Apt A</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5123004954</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Price</td><td>6</td><td></td><td></td>
	<td>
	 1/23/2013 9:18:59 PM
	</td>

</tr><TR>

		<td><b>Makayla  </b></td>
		<td><b>Hurd</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>65</td>
	
	  <td>Kirsten311@gmail.com</td>
	
	  <td>kiki66</td>
	 
	  <td>14208 Flat Top Ranch Rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Viktoria</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/22/2013 11:14:51 PM
	</td>

</tr><TR>

		<td><b>Jenavieve </b></td>
		<td><b>Hurt</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>Nicolehurt78@yahoo.com</td>
	
	  <td>sophie00</td>
	 
	  <td>2631 Izoro Bend</td>
	 
	  <td></td>
	 
	  <td>Cedar Park</td>
	 
	  <td>TX</td>
	 
	  <td>78613</td>
	 
	  <td>5125876236</td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Cepeda</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/30/2013 9:39:40 PM
	</td>

</tr><TR>

		<td><b>yewon christina </b></td>
		<td><b>hwang</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>yunhyang2@gmail.com</td>
	
	  <td>dPdnjs2</td>
	 
	  <td>5217 old spicewood springs rd. #2103</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>raup</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 8:38:55 AM
	</td>

</tr><TR>

		<td><b>Sydney </b></td>
		<td><b>Imhoff</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Si28663@eanesisd.net</td>
	
	  <td>shadowthedog</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:46:04 PM
	</td>

</tr><TR>

		<td><b>Ella Claire  </b></td>
		<td><b>Ingraham</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>terri.ingraham@me.com</td>
	
	  <td>jackson</td>
	 
	  <td>3317 westlake drive</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td>5127320670</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 7:26:31 AM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Ivie</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>jcivie@gmail.com</td>
	
	  <td>s1mber</td>
	 
	  <td>5536 Hero Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78735</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Swan</td><td>6</td><td></td><td></td>
	<td>
	 1/24/2013 9:23:24 PM
	</td>

</tr><TR>

		<td><b>Luke </b></td>
		<td><b>Janek</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>janek@austin.utexas.edu</td>
	
	  <td>shannon1</td>
	 
	  <td>103 Pascal Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>McMillin</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 8:02:36 PM
	</td>

</tr><TR>

		<td><b>Juliet </b></td>
		<td><b>Jarrett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jj28499@eanesisd.net</td>
	
	  <td>musicmania24</td>
	 
	  <td>3050 Tamarron Blvd #9301</td>
	 
	  <td>1323 Wilderness Drive</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mcgrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:12:19 PM
	</td>

</tr><TR>

		<td><b>Alyssia  </b></td>
		<td><b>Jenkins</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>195</td>
	
	  <td>iiirene20@yahoo.com</td>
	
	  <td>Princess</td>
	 
	  <td>8404 Furness Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78753</td>
	 
	  <td>512-940-4367</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 1/26/2013 9:47:59 PM
	</td>

</tr><TR>

		<td><b>Kalie </b></td>
		<td><b>Jennings</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Kj86572@eanesisd.net</td>
	
	  <td>kaliejane</td>
	 
	  <td>1300 Walsh Tralton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:36:03 AM
	</td>

</tr><TR>

		<td><b>Eliza </b></td>
		<td><b>Jensen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>150</td>
	
	  <td>elizamo0603@gmail.com</td>
	
	  <td>bsk5zin1668</td>
	 
	  <td>2608 Ellise Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5129241242</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 2:57:18 PM
	</td>

</tr><TR>

		<td><b>Erik </b></td>
		<td><b>Jensen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>150</td>
	
	  <td>krayon516@gmail.com</td>
	
	  <td>bsk5zin1668</td>
	 
	  <td>2608 Ellise Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5129241242</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>See</td><td>4</td><td></td><td></td>
	<td>
	 1/28/2013 2:54:57 PM
	</td>

</tr><TR>

		<td><b>Ben  </b></td>
		<td><b>Johnson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>365</td>
	
	  <td>johnson.thomsen@gmail.com</td>
	
	  <td>happy2004</td>
	 
	  <td>5613 Mapleleaf Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78723</td>
	 
	  <td>512-791-4657</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 9:27:32 PM
	</td>

</tr><TR>

		<td><b>Zane </b></td>
		<td><b>Joly</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30.48</td>
	
	  <td>avatra@gmail.com</td>
	
	  <td>doodle6ug</td>
	 
	  <td>3002 White Rock Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-458-1962</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Denega</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 8:57:25 AM
	</td>

</tr><TR>

		<td><b>Lulu </b></td>
		<td><b>Jones</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>johnnajones@austin.rr.com</td>
	
	  <td>aspen123</td>
	 
	  <td>5401 Maryanna Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Saikin</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 7:55:04 PM
	</td>

</tr><TR>

		<td><b>Sarah </b></td>
		<td><b>Kastak-Carrillo</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>bkastak@gmail.com</td>
	
	  <td>bill7878</td>
	 
	  <td>3500 N Capital of Texas Hwy</td>
	 
	  <td>Apt 1612</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Hester</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 12:06:47 PM
	</td>

</tr><TR>

		<td><b>Sofia </b></td>
		<td><b>Kastak-Carrillo</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>bkastak@gmail.com</td>
	
	  <td>bill7878</td>
	 
	  <td>3500 N Capital of Texas Hwy</td>
	 
	  <td>Apt 1612</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>King</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 12:04:14 PM
	</td>

</tr><TR>

		<td><b>Simon </b></td>
		<td><b>Katz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>ashdejong3@gmail.com</td>
	
	  <td>Dietrich333</td>
	 
	  <td>3506 Native Dancer Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5128976390</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Krost</td><td>K</td><td></td><td></td>
	<td>
	 2/8/2013 9:09:05 AM
	</td>

</tr><TR>

		<td><b>Noah </b></td>
		<td><b>Kaufman</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>dmkaufmantx@gmail.com</td>
	
	  <td>Gossamer1</td>
	 
	  <td>3604 Shady Creek Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>KOLLER</td><td>2</td><td></td><td></td>
	<td>
	 2/5/2013 7:52:00 AM
	</td>

</tr><TR>

		<td><b>Eamonn </b></td>
		<td><b>Keane</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>251</td>
	
	  <td>amkeane@gmail.com</td>
	
	  <td>Bookspring88</td>
	 
	  <td>1503 Ridgehaven Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723-2530</td>
	 
	  <td>5124589715</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Denega</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 10:35:33 PM
	</td>

</tr><TR>

		<td><b>Avery </b></td>
		<td><b>Keefe</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>260</td>
	
	  <td>carolekeefe@yahoo.com</td>
	
	  <td>averycole</td>
	 
	  <td>9824 Scenic Bluff Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>5109262009</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Watterson</td><td>2</td><td></td><td></td>
	<td>
	 1/26/2013 4:16:40 PM
	</td>

</tr><TR>

		<td><b>William </b></td>
		<td><b>Keller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>gnkeller@aol.com</td>
	
	  <td>Estespark</td>
	 
	  <td>10501 Indigo Broom Loop</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Bogan</td><td>1</td><td></td><td></td>
	<td>
	 1/25/2013 4:38:03 PM
	</td>

</tr><TR>

		<td><b>Sydney </b></td>
		<td><b>Kelley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>sydneysablk@aol.com</td>
	
	  <td>zoco3s</td>
	 
	  <td>511 Easy 49th Street</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78751</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Maher</td><td>5</td><td></td><td></td>
	<td>
	 1/27/2013 8:08:48 PM
	</td>

</tr><TR>

		<td><b>Catherine </b></td>
		<td><b>Kennedy</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>Catkennedy1@gmail.com</td>
	
	  <td>10034430</td>
	 
	  <td>2416 Barton Creek Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78703</td>
	 
	  <td>9563373423</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Orchard</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 12:00:57 PM
	</td>

</tr><TR>

		<td><b>Sophie </b></td>
		<td><b>Kessler</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>erin@shuart.com</td>
	
	  <td>lovely</td>
	 
	  <td>6405 Shoal CReek Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-796-4125</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Denega</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 7:11:31 PM
	</td>

</tr><TR>

		<td><b>Won-jun </b></td>
		<td><b>Kim</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>soojinjrkim@gmail.com</td>
	
	  <td>soowon01</td>
	 
	  <td>7600 wood hollow dr. Apt#915</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Knowles</td><td>2</td><td></td><td></td>
	<td>
	 2/9/2013 10:13:41 AM
	</td>

</tr><TR>

		<td><b>Yu-Da </b></td>
		<td><b>Kimber</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>empresssushi@gmail.com</td>
	
	  <td>dadaism</td>
	 
	  <td>2704 Wilson Street</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>512-494-4517</td>

	<!-- this is where the custom fields go -->
		 <td>Dawson Elementary</td><td>Bernhard</td><td>3</td><td></td><td></td>
	<td>
	 1/31/2013 9:17:59 PM
	</td>

</tr><TR>

		<td><b>Bridget </b></td>
		<td><b>Kinsey</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>missv70@hotmail.com</td>
	
	  <td>bbkinsey07</td>
	 
	  <td>3801 Hidden Hollow</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Hodges</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 2:36:17 PM
	</td>

</tr><TR>

		<td><b>Connor </b></td>
		<td><b>Kirby</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100.19</td>
	
	  <td>paulkirby@austin.rr.com</td>
	
	  <td>2amhrain</td>
	 
	  <td>9208 Meadow Vale</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78758</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Santiso</td><td>4</td><td></td><td></td>
	<td>
	 1/25/2013 6:23:48 PM
	</td>

</tr><TR>

		<td><b>Hank </b></td>
		<td><b>Kirby</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>67.37</td>
	
	  <td>paulkirby@austin.rr.com</td>
	
	  <td>2amhrain</td>
	 
	  <td>9208 Meadow Vale</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78758</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Laxton</td><td>2</td><td></td><td></td>
	<td>
	 1/25/2013 6:21:19 PM
	</td>

</tr><TR>

		<td><b>Zephyr </b></td>
		<td><b>Kirby</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30.8</td>
	
	  <td>paulkirby@austin.rr.com</td>
	
	  <td>2amhrain</td>
	 
	  <td>9208 Meadow Vale</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78758</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Williams</td><td>K</td><td></td><td></td>
	<td>
	 1/25/2013 6:17:24 PM
	</td>

</tr><TR>

		<td><b>Bella  </b></td>
		<td><b>Kisler</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>janetkisler@earthlink.net</td>
	
	  <td>goodread123</td>
	 
	  <td>6601 Argentia Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5124209792</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Richardson</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 8:34:24 PM
	</td>

</tr><TR>

		<td><b>Gabriel </b></td>
		<td><b>Kisler</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>janetkisler@earthlink.net</td>
	
	  <td>goodread456</td>
	 
	  <td>6601 Argentia Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5124209792</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Doherty</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 8:41:14 PM
	</td>

</tr><TR>

		<td><b>Kellen </b></td>
		<td><b>Kitchen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>erinkitchen@gmail.com</td>
	
	  <td>142538</td>
	 
	  <td>5312 Valburn Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78731</td>
	 
	  <td>5129169252</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Stone</td><td>1</td><td></td><td></td>
	<td>
	 2/6/2013 8:54:02 AM
	</td>

</tr><TR>

		<td><b>Quinn </b></td>
		<td><b>Kitchen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>erinkitchen@gmail.com</td>
	
	  <td>142538</td>
	 
	  <td>5312 VALBURN CIR</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5129169252</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Taylor</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/6/2013 9:37:04 AM
	</td>

</tr><TR>

		<td><b>Cole </b></td>
		<td><b>Kivell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>135</td>
	
	  <td>kitkivell@gmail.com</td>
	
	  <td>cole1102</td>
	 
	  <td>8711 Camelia</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-762-6458</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Domingues</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 8:57:39 AM
	</td>

</tr><TR>

		<td><b>adriana </b></td>
		<td><b>klaas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>adrkla@icloud.com</td>
	
	  <td>do9FbzuC</td>
	 
	  <td>10612 senna hills dr.</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>5124020710</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Garner</td><td>1</td><td></td><td></td>
	<td>
	 2/10/2013 8:48:41 AM
	</td>

</tr><TR>

		<td><b>Natalie </b></td>
		<td><b>Klaas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>natkla@icloud.com</td>
	
	  <td>b8ffTjcg</td>
	 
	  <td>10612 senna hills dr</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>512402 0710</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Druart</td><td>3</td><td></td><td></td>
	<td>
	 2/9/2013 8:04:43 PM
	</td>

</tr><TR>

		<td><b>Fiona </b></td>
		<td><b>Kleeman</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>mskleeman75@gmail.com</td>
	
	  <td>lippie</td>
	 
	  <td>3302 Bridle Path</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Berezowski</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 4:04:10 PM
	</td>

</tr><TR>

		<td><b>Tyler </b></td>
		<td><b>Knape</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>gretchenknape@gmail.com</td>
	
	  <td>keller10780</td>
	 
	  <td>1724 Lemon Mint Court</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Garner</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 9:21:48 AM
	</td>

</tr><TR>

		<td><b>Alex </b></td>
		<td><b>Knapp</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Alexknapp@austin.rr.com</td>
	
	  <td>tipper123</td>
	 
	  <td>62 pascal lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5124613738</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:50:05 PM
	</td>

</tr><TR>

		<td><b>Ely </b></td>
		<td><b>Knaupe</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ek28744@eanesisd.net</td>
	
	  <td>hcmsy8ahy</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:34:58 AM
	</td>

</tr><TR>

		<td><b>Mills </b></td>
		<td><b>Knebel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>300</td>
	
	  <td>fancymills@yahoo.com</td>
	
	  <td>dallas1972</td>
	 
	  <td>3302 Greenlawn Parkway</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78757</td>
	 
	  <td>512-663-6526</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/27/2013 7:56:41 PM
	</td>

</tr><TR>

		<td><b>Diane </b></td>
		<td><b>Ko</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>yshjhappy@gmail.com</td>
	
	  <td>diane1</td>
	 
	  <td>7201 HART LN APT 1049</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5122033984</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Warner</td><td>K</td><td></td><td></td>
	<td>
	 2/6/2013 8:50:23 PM
	</td>

</tr><TR>

		<td><b>T.J. </b></td>
		<td><b>Koch</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Txkoch@prodigy.net</td>
	
	  <td>cute1234</td>
	 
	  <td>3500 N Capital of TX HWY</td>
	 
	  <td>#2332</td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Iles</td><td>1</td><td></td><td></td>
	<td>
	 1/23/2013 6:53:22 PM
	</td>

</tr><TR>

		<td><b>Divya </b></td>
		<td><b>Kopalle</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>DK89045@eanesisd.net</td>
	
	  <td>hcmsfwlvv</td>
	 
	  <td>1300 Walsh tartlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:48:09 PM
	</td>

</tr><TR>

		<td><b>Rebecca </b></td>
		<td><b>Kott</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>250</td>
	
	  <td>rbkott@gmail.com</td>
	
	  <td>reilly01</td>
	 
	  <td>5315 Duval St</td>
	 
	  <td>Unit A</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td>281-344-7022</td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Torres</td><td>8</td><td></td><td></td>
	<td>
	 1/26/2013 2:52:39 PM
	</td>

</tr><TR>

		<td><b>Pierce </b></td>
		<td><b>Kovacs</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>leasimo@hotmail.com</td>
	
	  <td>stodgo11</td>
	 
	  <td>7009 Winterberry Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78750</td>
	 
	  <td>512-343-5588</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Crowley</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/27/2013 7:25:17 PM
	</td>

</tr><TR>

		<td><b>Finian </b></td>
		<td><b>Kressin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>mkielt@hotmail.com</td>
	
	  <td>flygirl1</td>
	 
	  <td>5600 SHOALWOOD AVE</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>6154033011</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Absher</td><td>2</td><td></td><td></td>
	<td>
	 2/10/2013 9:25:29 PM
	</td>

</tr><TR>

		<td><b>Liam </b></td>
		<td><b>Kressin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>mkielt@hotmail.com</td>
	
	  <td>flygirl1</td>
	 
	  <td>5600 SHOALWOOD AVE</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>6154033011</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hamptom</td><td>4</td><td></td><td></td>
	<td>
	 2/10/2013 9:24:36 PM
	</td>

</tr><TR>

		<td><b>Audrey </b></td>
		<td><b>Kull</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>kathykull2@att.net</td>
	
	  <td>jimmy1</td>
	 
	  <td>3208 Riva Ridge Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Tremel</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 10:31:42 AM
	</td>

</tr><TR>

		<td><b>James </b></td>
		<td><b>Kull</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>kathykull2@att.net</td>
	
	  <td>jimmy1</td>
	 
	  <td>3208 Riva Ridge Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cowan</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 10:30:10 AM
	</td>

</tr><TR>

		<td><b>Karina </b></td>
		<td><b>Kumar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>cindy.kumar.usa@gmail.com</td>
	
	  <td>g789108B</td>
	 
	  <td>9306 TIBER CIR</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>HARGIS</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 3:14:13 PM
	</td>

</tr><TR>

		<td><b>Mayur </b></td>
		<td><b>Kumar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mayur@super8austin.com</td>
	
	  <td>Bobthebuilder2526</td>
	 
	  <td>11417 Sillmarillion Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78739</td>
	 
	  <td>512-773-5661</td>

	<!-- this is where the custom fields go -->
		 <td>Bailey Middle School</td><td>Bromberg</td><td>7</td><td></td><td></td>
	<td>
	 1/28/2013 7:00:55 PM
	</td>

</tr><TR>

		<td><b>Mayur </b></td>
		<td><b>Kumar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mayur@super8austin.com</td>
	
	  <td>Bobthebuilder2526</td>
	 
	  <td>11417 Sillmarillion Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78739</td>
	 
	  <td>512-773-5661</td>

	<!-- this is where the custom fields go -->
		 <td>Bailey Middle School</td><td>Bromberg</td><td>7</td><td></td><td></td>
	<td>
	 1/28/2013 7:01:43 PM
	</td>

</tr><TR>

		<td><b>Zi-Le </b></td>
		<td><b>Laeu</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>boon.hui.laeu@intel.com</td>
	
	  <td>12345</td>
	 
	  <td>3500 N Capital of Texas Hwy, Apt 512</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512 436 8198</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Smith</td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 10:20:14 PM
	</td>

</tr><TR>

		<td><b>Zi-Li </b></td>
		<td><b>Laeu</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>boon.hui.laeu@intel.com</td>
	
	  <td>12345</td>
	 
	  <td>3500 N Capital of Texas Hwy, Apt 512</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512 436 8198</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Bufkin</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 10:23:07 PM
	</td>

</tr><TR>

		<td><b>David </b></td>
		<td><b>Lambowitz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>dl28767@eanesisd.net</td>
	
	  <td>dalambowitz</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:13 PM
	</td>

</tr><TR>

		<td><b>Josie </b></td>
		<td><b>Land</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>tracyland@austin.rr.com</td>
	
	  <td>tracy1973</td>
	 
	  <td>5804 Timber Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-296-4863</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Crowley</td><td>K</td><td></td><td></td>
	<td>
	 2/3/2013 4:49:57 PM
	</td>

</tr><TR>

		<td><b>Vincent </b></td>
		<td><b>Land</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>tracyland@austin.rr.com</td>
	
	  <td>tracy1973</td>
	 
	  <td>5804 Timber Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-296-4863</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Huth</td><td>K</td><td></td><td></td>
	<td>
	 2/3/2013 4:49:22 PM
	</td>

</tr><TR>

		<td><b>Callie </b></td>
		<td><b>Lanier</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>lanier.production@sbcglobal.net</td>
	
	  <td>twinkles</td>
	 
	  <td>2202 Sharon Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-297-4024</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Olvera</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 3:21:12 PM
	</td>

</tr><TR>

		<td><b>corter </b></td>
		<td><b>laughlin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>tlaughlinwc@gmail.com</td>
	
	  <td>246810</td>
	 
	  <td>7804 shantivana</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>te</td>
	 
	  <td>78737</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedars Montessori</td><td>swinburne</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 1:36:02 PM
	</td>

</tr><TR>

		<td><b>Ava  </b></td>
		<td><b>LaWare</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20.5</td>
	
	  <td>kchonora@gmail.com</td>
	
	  <td>3477548mr</td>
	 
	  <td>2905 Silverleaf Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Ravare</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 12:01:33 PM
	</td>

</tr><TR>

		<td><b>Ruby </b></td>
		<td><b>LaWare</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>19.5</td>
	
	  <td>kchonora@gmail.com</td>
	
	  <td>3477548mr</td>
	 
	  <td>2905 Silverleaf Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 12:04:12 PM
	</td>

</tr><TR>

		<td><b>Amelie </b></td>
		<td><b>Lawrence</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>harasel13@yahoo.com</td>
	
	  <td>Amelie14</td>
	 
	  <td>4700 N Capital of Tx Hwy</td>
	 
	  <td>Apt 401</td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127169227</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Tremel</td><td>1</td><td></td><td></td>
	<td>
	 2/7/2013 9:30:13 PM
	</td>

</tr><TR>

		<td><b>Jake </b></td>
		<td><b>Lay</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nupat72@hotmail.com</td>
	
	  <td>tamtan</td>
	 
	  <td>4264 Westlake Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 1/30/2013 8:31:36 AM
	</td>

</tr><TR>

		<td><b>Mary Pearl </b></td>
		<td><b>Lay</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nupat72@hotmail.com</td>
	
	  <td>tamtan</td>
	 
	  <td>4264 Westlake Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Stone</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 8:33:56 AM
	</td>

</tr><TR>

		<td><b>Victoria </b></td>
		<td><b>Lee</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>vicjlee@me.com</td>
	
	  <td>hcmsfbvzu</td>
	 
	  <td>1806 Intervail Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Boyd</td><td>7</td><td></td><td></td>
	<td>
	 1/27/2013 10:50:58 PM
	</td>

</tr><TR>

		<td><b>Jenna </b></td>
		<td><b>Ley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nt999@sbcglobal.net</td>
	
	  <td>noodle99</td>
	 
	  <td>1600 Acacia Bud Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>512-263-9168</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Kutchman</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 6:44:34 PM
	</td>

</tr><TR>

		<td><b>Oliver </b></td>
		<td><b>Lienhard</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>nicola.lienhard@gmail.com</td>
	
	  <td>smarty</td>
	 
	  <td>1709 Resaca Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Se</td>
	 
	  <td>78738</td>
	 
	  <td>9498733077</td>

	<!-- this is where the custom fields go -->
		 <td>Cedars Montessori</td><td>Romig</td><td>4</td><td></td><td></td>
	<td>
	 1/28/2013 1:53:40 PM
	</td>

</tr><TR>

		<td><b>elizabeth </b></td>
		<td><b>link</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>elizabethjanelink@gmail.com</td>
	
	  <td>ginger123</td>
	 
	  <td>1305 verdant way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-423-1812</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Puga</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 9:19:53 PM
	</td>

</tr><TR>

		<td><b>Emily </b></td>
		<td><b>Link</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>el82123@eanesisd.net</td>
	
	  <td>hcmssrxea</td>
	 
	  <td>1305 Verdant Way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:19:25 PM
	</td>

</tr><TR>

		<td><b>Drew </b></td>
		<td><b>Linseisen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>Drew@linseisen.com</td>
	
	  <td>oakhilll15</td>
	 
	  <td>4302 Travis Country Circle</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78735</td>
	 
	  <td>512-431-6134</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>schoenfeld</td><td>6</td><td></td><td></td>
	<td>
	 1/27/2013 10:54:01 AM
	</td>

</tr><TR>

		<td><b>Annie  </b></td>
		<td><b>Liu</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>annieliutx@gmail.com</td>
	
	  <td>iloveviolin</td>
	 
	  <td>1505 Allen Road Unit C</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Funderburgh</td><td>7</td><td></td><td></td>
	<td>
	 1/28/2013 6:36:57 PM
	</td>

</tr><TR>

		<td><b>Asher </b></td>
		<td><b>Loewenstern</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>levyloew@sbcglobal.net</td>
	
	  <td>readingisfun</td>
	 
	  <td>6000 Woodview Ave.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5123029998</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Cohen</td><td>5</td><td></td><td></td>
	<td>
	 2/10/2013 9:45:01 PM
	</td>

</tr><TR>

		<td><b>Travis </b></td>
		<td><b>Looney</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>westlakekris@gmail.com</td>
	
	  <td>trav15</td>
	 
	  <td>2022 Rue de St Tropez</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich</td><td>K</td><td></td><td></td>
	<td>
	 2/5/2013 1:27:00 PM
	</td>

</tr><TR>

		<td><b>Mackenzie </b></td>
		<td><b>Lopez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>175</td>
	
	  <td>atxlopezfamily@gmail.com</td>
	
	  <td>disney97!</td>
	 
	  <td>8008 Parkdale Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Hayden</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 3:50:39 PM
	</td>

</tr><TR>

		<td><b>Stephanie  </b></td>
		<td><b>Lopez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>stephanie.lopez098@gmail.com</td>
	
	  <td>qwertyuiop</td>
	 
	  <td>4705 Craigwood dr </td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78725</td>
	 
	  <td>512 791 4170</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Shackelford</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 10:10:06 AM
	</td>

</tr><TR>

		<td><b>Tori </b></td>
		<td><b>Louhela</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Tl28928@eanesisd.net</td>
	
	  <td>hcmspdwkn</td>
	 
	  <td>196 Fresno springs</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-629-0915</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:17:36 PM
	</td>

</tr><TR>

		<td><b>Ana  </b></td>
		<td><b>Love </b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>al87832@eanesisd.net</td>
	
	  <td>hcmsensco</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:31:29 AM
	</td>

</tr><TR>

		<td><b>Connally Kate </b></td>
		<td><b>Love</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>katieconnally@gmail.com</td>
	
	  <td>ckl2013</td>
	 
	  <td>1603 Forest Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5127974130</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>PHAM</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 3:11:14 PM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Lovelady</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>JL86620@eanesisd.net</td>
	
	  <td>jacklovelady</td>
	 
	  <td>3 timberline ridge</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:48 PM
	</td>

</tr><TR>

		<td><b>Cullen </b></td>
		<td><b>Lowder</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>cl28668@gmail.com</td>
	
	  <td>hcmsiorx</td>
	 
	  <td>1300 Walsh Tarlron</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124504155</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mrs. McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:27:27 PM
	</td>

</tr><TR>

		<td><b>Cooper </b></td>
		<td><b>Lowe</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>paulalowe64@gmail.com</td>
	
	  <td>teaser</td>
	 
	  <td>7813 Harvestman Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78731</td>
	 
	  <td>512-633-4058</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Mowry</td><td>1</td><td></td><td></td>
	<td>
	 1/25/2013 12:00:08 PM
	</td>

</tr><TR>

		<td><b>Phoebe  </b></td>
		<td><b>Loya</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>pl88840@eanesisd.net</td>
	
	  <td>west17</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:03:59 PM
	</td>

</tr><TR>

		<td><b>Andrea </b></td>
		<td><b>Lukic</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>al88844@eanesisd.net</td>
	
	  <td>cokelo</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5128200264</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>High School</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:56 AM
	</td>

</tr><TR>

		<td><b>Kennon </b></td>
		<td><b>Lydick</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Kl28699@eanesisd.net</td>
	
	  <td>hcmsy94tb</td>
	 
	  <td>3711 westlake de</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:58:53 PM
	</td>

</tr><TR>

		<td><b>Bray </b></td>
		<td><b>Lynch</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>ctlynch1@yahoo.com</td>
	
	  <td>basketball38</td>
	 
	  <td>6216 Northern Dancer Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512 330 9402</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Powell</td><td>3</td><td></td><td></td>
	<td>
	 2/9/2013 12:33:38 PM
	</td>

</tr><TR>

		<td><b>Cam  </b></td>
		<td><b>Lynch</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>ctlynch1@yahoo.com</td>
	
	  <td>basketball4</td>
	 
	  <td>6216 Northern Dancer Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512 330 9402</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cook</td><td>4</td><td></td><td></td>
	<td>
	 2/9/2013 12:19:31 PM
	</td>

</tr><TR>

		<td><b>Sofia </b></td>
		<td><b>Maass</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>61</td>
	
	  <td>lilican2@gmail.com</td>
	
	  <td>toucan2</td>
	 
	  <td>10426 Snapdragon Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78739</td>
	 
	  <td>512-619-3179</td>

	<!-- this is where the custom fields go -->
		 <td>Cedars Montessori</td><td>Romig</td><td>5</td><td></td><td></td>
	<td>
	 1/23/2013 11:25:03 AM
	</td>

</tr><TR>

		<td><b>Lyla </b></td>
		<td><b>Macon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>veronica.macon@me.com</td>
	
	  <td>Believe</td>
	 
	  <td>2203 Schulle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>tx</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Hudgins</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 10:38:30 AM
	</td>

</tr><TR>

		<td><b>Gabriella </b></td>
		<td><b>Madianos</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>125</td>
	
	  <td>katklam@yahoo.com</td>
	
	  <td>austin123</td>
	 
	  <td>3606 Enfield Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-569-3262</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Allen</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 4:55:13 PM
	</td>

</tr><TR>

		<td><b>Anabelle </b></td>
		<td><b>Mahadevan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>anbumahadevan@yahoo.com</td>
	
	  <td>anna2julie</td>
	 
	  <td>3900 Bennedict Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Root</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 4:50:56 PM
	</td>

</tr><TR>

		<td><b>addie </b></td>
		<td><b>maher</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>theresa78731@yahoo.com</td>
	
	  <td>101400</td>
	 
	  <td>woodview</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>caruth</td><td>3</td><td></td><td></td>
	<td>
	 2/7/2013 3:30:45 PM
	</td>

</tr><TR>

		<td><b>Linda </b></td>
		<td><b>Maher</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lmaher@thegirlsschool.org</td>
	
	  <td>amber2001</td>
	 
	  <td>3708 Clarkson Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78722</td>
	 
	  <td>5129408825</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Maher</td><td>5</td><td></td><td></td>
	<td>
	 1/23/2013 5:46:06 PM
	</td>

</tr><TR>

		<td><b>mary </b></td>
		<td><b>maher</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>theresa78731@yahoo.com</td>
	
	  <td>101400</td>
	 
	  <td>woodview</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>bass</td><td>1</td><td></td><td></td>
	<td>
	 2/7/2013 3:25:47 PM
	</td>

</tr><TR>

		<td><b>Joell </b></td>
		<td><b>Manhart</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>170</td>
	
	  <td>ginger.manhart@gmail.com</td>
	
	  <td>100300</td>
	 
	  <td>6702 Shoal Creek Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 10:58:55 AM
	</td>

</tr><TR>

		<td><b>Liam </b></td>
		<td><b>Mankle</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lm89008@eanesisd.net</td>
	
	  <td>hcms4moks</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:08:10 PM
	</td>

</tr><TR>

		<td><b>Michael </b></td>
		<td><b>Mariotti</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>anthony@pro-finance.com</td>
	
	  <td>mm2003</td>
	 
	  <td>2001 South Mopac #2324</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>787346</td>
	 
	  <td>5126561702</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Raygor</td><td>4</td><td></td><td></td>
	<td>
	 2/6/2013 10:07:32 PM
	</td>

</tr><TR>

		<td><b>Lili </b></td>
		<td><b>Martin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>halltmartin@gmail.com</td>
	
	  <td>mustache</td>
	 
	  <td>2100 wychwood dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123277835</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Funderburgh</td><td>7</td><td></td><td></td>
	<td>
	 1/26/2013 9:09:12 PM
	</td>

</tr><TR>

		<td><b>reyes </b></td>
		<td><b>martinez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>reyes.martinez99@gmail.com</td>
	
	  <td>ofwgkta</td>
	 
	  <td>11011 domain dr apt 8448</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78758</td>
	 
	  <td>7049077600</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Orchard</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 3:40:03 PM
	</td>

</tr><TR>

		<td><b>Arianna  </b></td>
		<td><b>Marx</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>225</td>
	
	  <td>Matthew.marx@gmail.com</td>
	
	  <td>aribabba</td>
	 
	  <td>3421 indigo waters dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78732</td>
	 
	  <td>5122661408</td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Chalk</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 8:30:05 PM
	</td>

</tr><TR>

		<td><b>Ava </b></td>
		<td><b>Masterson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>105</td>
	
	  <td>sarah@sarahmasterson.com</td>
	
	  <td>venice21</td>
	 
	  <td>4412 Avenue D</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td>512-551-9303</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Prewitt</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 12:04:11 PM
	</td>

</tr><TR>

		<td><b>Jenna </b></td>
		<td><b>Mathias</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jm28588@eanesisd.net</td>
	
	  <td>jennam</td>
	 
	  <td>2915 regents park </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:05:51 PM
	</td>

</tr><TR>

		<td><b>Joseph </b></td>
		<td><b>Mathias</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>135</td>
	
	  <td>clairev.mathias@gmail.com</td>
	
	  <td>Joseph03</td>
	 
	  <td>7800B Watson St.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hampton</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 3:00:39 PM
	</td>

</tr><TR>

		<td><b>Avery </b></td>
		<td><b>Matthews</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>300</td>
	
	  <td>amy_e_matthews@yahoo.com</td>
	
	  <td>poppy</td>
	 
	  <td>3303 Mt. Bonnell Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78731</td>
	 
	  <td>5125227313</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Nestle</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 3:17:50 PM
	</td>

</tr><TR>

		<td><b>ashley </b></td>
		<td><b>matustik</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>mmatustik@hotmail.com</td>
	
	  <td>sierra17</td>
	 
	  <td>13 rob roy rd.</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-329-8048</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>smith</td><td>2</td><td></td><td></td>
	<td>
	 1/30/2013 7:14:56 PM
	</td>

</tr><TR>

		<td><b>matthew </b></td>
		<td><b>matustik</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>mmatustik@hotmail.com</td>
	
	  <td>sierra17</td>
	 
	  <td>13 rob roy rd.</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>5123298048</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>smith</td><td>2</td><td></td><td></td>
	<td>
	 1/30/2013 7:16:48 PM
	</td>

</tr><TR>

		<td><b>Sam </b></td>
		<td><b>Mayers</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>110</td>
	
	  <td>sammymayers@yahoo.com</td>
	
	  <td>sammyrocks</td>
	 
	  <td>4503 E. Rapid Springs Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124266632</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Powell</td><td>3</td><td></td><td></td>
	<td>
	 2/5/2013 8:45:01 PM
	</td>

</tr><TR>

		<td><b>Miles </b></td>
		<td><b>McCollum</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>210</td>
	
	  <td>todd.mccollum@gmail.com</td>
	
	  <td>mileswalker</td>
	 
	  <td>923 E. 50th St.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td>5125074963</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Laxton</td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 12:36:58 AM
	</td>

</tr><TR>

		<td><b>Fred </b></td>
		<td><b>McCoy</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>175</td>
	
	  <td>fzopp@grandecom.net</td>
	
	  <td>Books2013</td>
	 
	  <td>416 Northway Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78752</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Doherty</td><td>3</td><td></td><td></td>
	<td>
	 1/30/2013 8:30:29 AM
	</td>

</tr><TR>

		<td><b>George </b></td>
		<td><b>McCoy</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>175</td>
	
	  <td>fzopp@grandecom.net</td>
	
	  <td>Books2013</td>
	 
	  <td>416 Northway Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78752</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/30/2013 8:31:38 AM
	</td>

</tr><TR>

		<td><b>Ava </b></td>
		<td><b>McDonald</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ava.mcdonald.10@gmail.com</td>
	
	  <td>nantucket11</td>
	 
	  <td>5406 Maryanna Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Mrs. Root</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 7:28:47 PM
	</td>

</tr><TR>

		<td><b>Taylor </b></td>
		<td><b>McElhaney</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>125</td>
	
	  <td>jonheather.mc@gmail.com</td>
	
	  <td>marley</td>
	 
	  <td>4408 Falling Brook Cv.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-992-1386</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 6:24:10 PM
	</td>

</tr><TR>

		<td><b>Davis </b></td>
		<td><b>McEntire</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>dmacwakeboarder@gmail.com</td>
	
	  <td>starbucklucy</td>
	 
	  <td>3627 Stoneridge rd. #3</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124235131</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Boyd</td><td>7</td><td></td><td></td>
	<td>
	 1/27/2013 2:57:33 PM
	</td>

</tr><TR>

		<td><b>Megan </b></td>
		<td><b>McHorse</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>bethmchorse@hotmail.com</td>
	
	  <td>bethwmchorse</td>
	 
	  <td>5920 Carleen Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 1/23/2013 2:48:40 PM
	</td>

</tr><TR>

		<td><b>Tyler </b></td>
		<td><b>McHorse</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>bethmchorse@hotmail.com</td>
	
	  <td>bethwmchorset</td>
	 
	  <td>5920 Carleen Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Santiso</td><td>4</td><td></td><td></td>
	<td>
	 1/23/2013 2:54:11 PM
	</td>

</tr><TR>

		<td><b>Natalie  </b></td>
		<td><b>McMnaus</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nm28356@eanesisd.net</td>
	
	  <td>neversaynever</td>
	 
	  <td>1300 walsh tarlotn</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-431-5830</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:43:12 PM
	</td>

</tr><TR>

		<td><b>Allie  </b></td>
		<td><b>Meachum</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>251</td>
	
	  <td>amy@amymeachum.com</td>
	
	  <td>meachum1234</td>
	 
	  <td>5103 Cedro Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-795-5032</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Singerman</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 9:48:07 PM
	</td>

</tr><TR>

		<td><b>Kendall </b></td>
		<td><b>Meachum</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>251</td>
	
	  <td>amy@amymeachum.com</td>
	
	  <td>meachum1234</td>
	 
	  <td>5103 Cedro Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-795-5032</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Folts</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 9:51:52 PM
	</td>

</tr><TR>

		<td><b>jessica </b></td>
		<td><b>meek</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>donnameek@austin.rr.com</td>
	
	  <td>copper</td>
	 
	  <td>5910 bold ruler way</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>2144029048</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>mosher</td><td>8</td><td></td><td></td>
	<td>
	 2/8/2013 10:40:01 AM
	</td>

</tr><TR>

		<td><b>Shannon </b></td>
		<td><b>Mehner</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>shannon@mehner.biz</td>
	
	  <td>ratpm</td>
	 
	  <td>PO Box 160924</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78716</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>Dodson</td><td>High School</td><td></td><td></td>
	<td>
	 1/30/2013 11:14:33 AM
	</td>

</tr><TR>

		<td><b>Riley </b></td>
		<td><b>Meinke</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>jill@sbrdesign.com</td>
	
	  <td>read2013</td>
	 
	  <td>3903 Bennedict Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Matus</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 4:58:10 PM
	</td>

</tr><TR>

		<td><b>Antonio </b></td>
		<td><b>Melton-Molina</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>160</td>
	
	  <td>scorpionmber@hotmail.com</td>
	
	  <td>pinky</td>
	 
	  <td>3008 Silverleaf Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>See</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 5:57:59 PM
	</td>

</tr><TR>

		<td><b>Jake </b></td>
		<td><b>Melvin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>cat.melvin@sbcglobal.net</td>
	
	  <td>legos</td>
	 
	  <td>4010 Greenhill Pl.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Shaver</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 8:03:46 AM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Mendoza</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>sunshinegirl.anna@gmail.com</td>
	
	  <td>ninadear</td>
	 
	  <td>7108 Stoneledge Circle </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78736</td>
	 
	  <td>5127455485</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Florence</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 3:05:34 PM
	</td>

</tr><TR>

		<td><b>Emma </b></td>
		<td><b>Mendoza</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>280</td>
	
	  <td>emmitalove@gmail.com</td>
	
	  <td>Emmalove1</td>
	 
	  <td>5105 Evergreen Court</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-423-2245</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Richardson</td><td>4</td><td></td><td></td>
	<td>
	 1/29/2013 10:11:33 AM
	</td>

</tr><TR>

		<td><b>Madi </b></td>
		<td><b>Meserole</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Mm28671@eanesisd.net</td>
	
	  <td>mm28671</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:08:34 PM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Middleton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>240</td>
	
	  <td>juliemiddleton@austin.rr.com</td>
	
	  <td>darkblue</td>
	 
	  <td>3924 Arbor Glen Way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-345-4503</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Mrs. Stone</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 5:10:56 PM
	</td>

</tr><TR>

		<td><b>Trent </b></td>
		<td><b>Mierl</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>julie_mierl@harte-hanks.com</td>
	
	  <td>tsmierl</td>
	 
	  <td>3106 Whitepine Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 10:26:58 PM
	</td>

</tr><TR>

		<td><b>Trevor </b></td>
		<td><b>Mierl</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jmierl@harte-hanks.com</td>
	
	  <td>trmierl</td>
	 
	  <td>3106 Whitepine Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>See</td><td>4</td><td></td><td></td>
	<td>
	 1/28/2013 10:26:02 PM
	</td>

</tr><TR>

		<td><b>Cole </b></td>
		<td><b>Miller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>kirknsheri@austin.rr.com</td>
	
	  <td>longhorn</td>
	 
	  <td>3416 Rain Forest</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-656-0803</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Norman</td><td>5</td><td></td><td></td>
	<td>
	 1/29/2013 10:31:58 PM
	</td>

</tr><TR>

		<td><b>Danielle </b></td>
		<td><b>Miller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>kirknsheri@austin.rr.com</td>
	
	  <td>longhorn</td>
	 
	  <td>3416 Rain Forest Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td>5126560803</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Henson</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 9:14:16 PM
	</td>

</tr><TR>

		<td><b>Lisey </b></td>
		<td><b>Miller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>clsmiller@att.net</td>
	
	  <td>chili1</td>
	 
	  <td>308 Mediterra Point</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Ayres</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 11:30:03 PM
	</td>

</tr><TR>

		<td><b>Maddie </b></td>
		<td><b>Miller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>clsmiller@att.net</td>
	
	  <td>chili11</td>
	 
	  <td>308 Mediterra Point</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Reid</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 11:34:22 PM
	</td>

</tr><TR>

		<td><b>Warren </b></td>
		<td><b>Miller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>tracymlanier@hotmail.com</td>
	
	  <td>224Warren*909</td>
	 
	  <td>224 Emerald Ridge Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Reid</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/8/2013 3:52:04 PM
	</td>

</tr><TR>

		<td><b>Connor </b></td>
		<td><b>Miller-Payne</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>kim@taylorcollective.com</td>
	
	  <td>connorzoe07</td>
	 
	  <td>3605 Pinnacle Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124369311</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Reinhardt</td><td>K</td><td></td><td></td>
	<td>
	 1/31/2013 8:19:00 PM
	</td>

</tr><TR>

		<td><b>Blake </b></td>
		<td><b>Miri</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jeneanemiri@gmail.com</td>
	
	  <td>jim2jen</td>
	 
	  <td>5604 Clarion Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-502-5090</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Smith</td><td>2</td><td></td><td></td>
	<td>
	 1/30/2013 8:35:17 AM
	</td>

</tr><TR>

		<td><b>Jenna </b></td>
		<td><b>Mittan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jm87908@eanesisd.net</td>
	
	  <td>hcmsq37rb</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:29:29 AM
	</td>

</tr><TR>

		<td><b>Jennifer </b></td>
		<td><b>Mogonye</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jenmogo.shop@gmail.com</td>
	
	  <td>Z0n2dud3</td>
	 
	  <td>3428 Indigo Waters Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Chalk</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/28/2013 9:57:15 PM
	</td>

</tr><TR>

		<td><b>Josie </b></td>
		<td><b>Molnar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>140</td>
	
	  <td>molnargirl@yahoo.com</td>
	
	  <td>josephine07</td>
	 
	  <td>3207 Stardust Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5125604962</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Williams</td><td>K</td><td></td><td></td>
	<td>
	 1/30/2013 7:50:18 PM
	</td>

</tr><TR>

		<td><b>Aayan </b></td>
		<td><b>Momin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>smomin04@yahoo.com</td>
	
	  <td>aayan</td>
	 
	  <td>1613 acacia bud dr</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>5129092906</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Mrs roberson</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 8:33:58 PM
	</td>

</tr><TR>

		<td><b>Amaan </b></td>
		<td><b>Momin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>smomin04@yahoo.com</td>
	
	  <td>amaan</td>
	 
	  <td>1613 acacia bud dr</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>5129092906</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Mrs garner</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 8:35:30 PM
	</td>

</tr><TR>

		<td><b>Eric  </b></td>
		<td><b>Moon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>kimbominster@gmail.com</td>
	
	  <td>a45354</td>
	 
	  <td>3500 N Capital of Texas Hwy 508</td>
	 
	  <td>apt#508</td>
	 
	  <td>Austin</td>
	 
	  <td>Texas</td>
	 
	  <td>78746</td>
	 
	  <td>5129242619</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>VanZandt</td><td>3</td><td></td><td></td>
	<td>
	 2/4/2013 11:24:57 AM
	</td>

</tr><TR>

		<td><b>Bronte </b></td>
		<td><b>Moore</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>pmoore@raretrends.com</td>
	
	  <td>moore</td>
	 
	  <td>3201 Rain Dance Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-732-0456</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>King</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 10:57:14 AM
	</td>

</tr><TR>

		<td><b>Gabriela </b></td>
		<td><b>Morales</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lilymorales4536@gmail.com</td>
	
	  <td>prettypuppy</td>
	 
	  <td>1702 Madison</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-459-4529</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Childs</td><td>4</td><td></td><td></td>
	<td>
	 2/8/2013 7:44:58 PM
	</td>

</tr><TR>

		<td><b>Oscar  </b></td>
		<td><b>Morales</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>rkolar1970@gmail.com</td>
	
	  <td>angus1</td>
	 
	  <td>303 Nelray Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 2/3/2013 8:32:23 PM
	</td>

</tr><TR>

		<td><b>Anna-Nicole </b></td>
		<td><b>Morris</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>am86336@eanesisd.net</td>
	
	  <td>Banana2398</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td>6100 Nashua Court</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>(512)992-7981</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:33:39 AM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Morris</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jm29028@eanesisd.neg</td>
	
	  <td>jmjackalope13</td>
	 
	  <td>2801 Mecca rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78733</td>
	 
	  <td>512-280-5916</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:00:34 PM
	</td>

</tr><TR>

		<td><b>Abigaile </b></td>
		<td><b>Morrison</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>85</td>
	
	  <td>tinycartman@yahoo.com</td>
	
	  <td>13Abbie</td>
	 
	  <td>1800 Winter Park Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Sauls</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 1:46:15 PM
	</td>

</tr><TR>

		<td><b>Logan </b></td>
		<td><b>Morse</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lm28672@eanesisd.net</td>
	
	  <td>hcmswzier</td>
	 
	  <td>6816 canon wren dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>51233002917</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:50:30 PM
	</td>

</tr><TR>

		<td><b>Olivia </b></td>
		<td><b>Morse</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Om28673@eanesisd.net</td>
	
	  <td>hcmsbgkqz</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:06:15 PM
	</td>

</tr><TR>

		<td><b>Thomas </b></td>
		<td><b>Mosher</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>65</td>
	
	  <td>bmosher@eanesisd.net</td>
	
	  <td>joy4all</td>
	 
	  <td>8020 Evadean Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Geras</td><td>2</td><td></td><td></td>
	<td>
	 1/29/2013 8:29:10 PM
	</td>

</tr><TR>

		<td><b>Timothy </b></td>
		<td><b>Mosher</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>bmosher@eanesisd.net</td>
	
	  <td>callmeishmael</td>
	 
	  <td>8020 Evadean Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Kreps</td><td>5</td><td></td><td></td>
	<td>
	 1/29/2013 8:21:48 PM
	</td>

</tr><TR>

		<td><b>Kirstin </b></td>
		<td><b>Mueller</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>175</td>
	
	  <td>kirstin.a.mueller@gmail.com</td>
	
	  <td>kirstin03</td>
	 
	  <td>6206 Nasco Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512.743.5061</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>See</td><td>4</td><td></td><td></td>
	<td>
	 1/26/2013 6:19:55 PM
	</td>

</tr><TR>

		<td><b>Patricia </b></td>
		<td><b>Munoz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>pmun1@att.net</td>
	
	  <td>readathon1</td>
	 
	  <td>40 N IH-35, Apt. 3B1</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78701</td>
	 
	  <td>512-496-0596</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Carson</td><td>4</td><td></td><td></td>
	<td>
	 1/23/2013 8:58:29 PM
	</td>

</tr><TR>

		<td><b>Kevin </b></td>
		<td><b>Murray</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>59</td>
	
	  <td>darlene_ennis@hotmail.com</td>
	
	  <td>rooroo</td>
	 
	  <td>11920 Hardwood Trl</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78750</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>DeAtley</td><td>5</td><td></td><td></td>
	<td>
	 2/10/2013 9:36:06 AM
	</td>

</tr><TR>

		<td><b>M�ximo </b></td>
		<td><b>Murray</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Samantha.zam@live.com</td>
	
	  <td>samantha</td>
	 
	  <td>4800 Mantle Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5125388695</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Rojas</td><td>2</td><td></td><td></td>
	<td>
	 2/8/2013 9:33:56 PM
	</td>

</tr><TR>

		<td><b>Nathaniel  </b></td>
		<td><b>Namendorf</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Hhutton842@aol.com</td>
	
	  <td>Churchill</td>
	 
	  <td>8508 Calera Dr. </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Rawson Saunders</td><td>Grossfeld</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 10:07:18 AM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Nasi</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>tnasi@grandecom.net</td>
	
	  <td>keasbey</td>
	 
	  <td>1901 MEADOWBROOK DRIVE</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-481-0566</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Batiansila</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 8:23:23 AM
	</td>

</tr><TR>

		<td><b>Wilson </b></td>
		<td><b>Nasi</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>tnasi@grandecom.net</td>
	
	  <td>keasbey1</td>
	 
	  <td>1901 MEADOWBROOK DRIVE</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-481-0566</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Heleniak</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 8:28:15 AM
	</td>

</tr><TR>

		<td><b>Seetha </b></td>
		<td><b>Natesan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>sn81435@gmail.com</td>
	
	  <td>hcmsqhflt</td>
	 
	  <td>400 Riley Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123300415</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Boyd</td><td>7</td><td></td><td></td>
	<td>
	 1/28/2013 9:41:23 PM
	</td>

</tr><TR>

		<td><b>Max </b></td>
		<td><b>Navarro</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>140</td>
	
	  <td>bingo@mac.com</td>
	
	  <td>yvonne68</td>
	 
	  <td>2009 Delwood Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 9:45:22 PM
	</td>

</tr><TR>

		<td><b>Danilyn </b></td>
		<td><b>Neil</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>amylyn@austinelitevolleyball.com</td>
	
	  <td>kiddos</td>
	 
	  <td>2600 Buckminster </td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-351-8317</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>King</td><td>2</td><td></td><td></td>
	<td>
	 2/1/2013 7:34:38 AM
	</td>

</tr><TR>

		<td><b>Celeste </b></td>
		<td><b>Neusch</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Cn88060@eanesisd.net</td>
	
	  <td>newmoon</td>
	 
	  <td>4400 silent tr </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-771-3795</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:48:50 PM
	</td>

</tr><TR>

		<td><b>Jewel </b></td>
		<td><b>New</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>slnewtx@gmail.com</td>
	
	  <td>Milo1</td>
	 
	  <td>8819 Chalk Knoll Drive</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Prewitt</td><td>3</td><td></td><td></td>
	<td>
	 1/26/2013 11:41:53 AM
	</td>

</tr><TR>

		<td><b>Victoria </b></td>
		<td><b>Newman-Menendez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>j.menendez@me.com</td>
	
	  <td>terminate</td>
	 
	  <td>8506 Adirondack cove</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78759</td>
	 
	  <td>4735951</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Mrs.Ward</td><td>5</td><td></td><td></td>
	<td>
	 1/23/2013 7:13:07 PM
	</td>

</tr><TR>

		<td><b>Diego </b></td>
		<td><b>Nieto</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Dn87929@gmail.com</td>
	
	  <td>Orion1312</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>2104719381</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:51 PM
	</td>

</tr><TR>

		<td><b>Lily </b></td>
		<td><b>Nilan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ln88087@eanesisd.net</td>
	
	  <td>hcmsqbrau</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:33:21 PM
	</td>

</tr><TR>

		<td><b>Audrey </b></td>
		<td><b>Nims</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>bridgetbird80@yahoo.com</td>
	
	  <td>kennedyj</td>
	 
	  <td>4010 Long Champ dr #19</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Hester</td><td>K</td><td></td><td></td>
	<td>
	 2/7/2013 3:29:32 PM
	</td>

</tr><TR>

		<td><b>Ben </b></td>
		<td><b>Noffsinger</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Bn86543@gmail.com</td>
	
	  <td>Badman*55</td>
	 
	  <td>4700 north capital of Texas highway</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:00:20 PM
	</td>

</tr><TR>

		<td><b>Dean </b></td>
		<td><b>Noffsinger</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lnoffsinger@bellsouth.net</td>
	
	  <td>snowy809</td>
	 
	  <td>4700 N Capital of Texas Hwy #210</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-761-3810</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Cunningham</td><td>6</td><td></td><td></td>
	<td>
	 1/27/2013 8:54:17 PM
	</td>

</tr><TR>

		<td><b>James </b></td>
		<td><b>Norman</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>hollynorman42@gmail.com</td>
	
	  <td>johnlee</td>
	 
	  <td>2207 Bonita St.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5124998991</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Rains</td><td>3</td><td></td><td></td>
	<td>
	 1/24/2013 7:09:08 PM
	</td>

</tr><TR>

		<td><b>Samantha </b></td>
		<td><b>OConnell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>chris_oconnell@sbcglobal.net</td>
	
	  <td>snickers</td>
	 
	  <td>6806 rockledge cv</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Elbrecht</td><td>K</td><td></td><td></td>
	<td>
	 1/26/2013 10:47:37 AM
	</td>

</tr><TR>

		<td><b>Gavin </b></td>
		<td><b>OConnell-Schulte</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>janiejaneo@hotmail.com</td>
	
	  <td>wandajean</td>
	 
	  <td>7600 Shoal Creek Bv</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5124672683</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Greer</td><td>K</td><td></td><td></td>
	<td>
	 2/9/2013 7:41:25 PM
	</td>

</tr><TR>

		<td><b>Thea </b></td>
		<td><b>ONeal</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>To89496@eanesisd.net</td>
	
	  <td>to89496</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>4356594138</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:36:25 AM
	</td>

</tr><TR>

		<td><b>Caitlyn </b></td>
		<td><b>OToole</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>tottenpsu@hotmail.com</td>
	
	  <td>tatertot</td>
	 
	  <td>11709 Palisades Pkwy</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>James</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/4/2013 11:43:15 PM
	</td>

</tr><TR>

		<td><b>Marissa </b></td>
		<td><b>Obregon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>chunkymonkey0170@yahoo.com</td>
	
	  <td>031812</td>
	 
	  <td>5701 johnny morris rd #27</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78724</td>
	 
	  <td>5125760020</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Mr.Shackleford</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 8:19:52 PM
	</td>

</tr><TR>

		<td><b>Hannah </b></td>
		<td><b>OELKER</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>oelker3@yahoo.com</td>
	
	  <td>icebats1</td>
	 
	  <td>403 WARM MOON CV</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78717-5477</td>
	 
	  <td>5125898162</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Still</td><td>2</td><td></td><td></td>
	<td>
	 2/10/2013 5:27:59 PM
	</td>

</tr><TR>

		<td><b>Kaitlin </b></td>
		<td><b>Ogilvie</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>colleenogilvie@mac.com</td>
	
	  <td>par3par3</td>
	 
	  <td>10 Cicero Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-796-2175</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Koller</td><td>2</td><td></td><td></td>
	<td>
	 2/2/2013 4:32:00 PM
	</td>

</tr><TR>

		<td><b>Lauren </b></td>
		<td><b>Ogilvie</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>colleenogilvie@mac.com</td>
	
	  <td>par3par3</td>
	 
	  <td>10 Cicero Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-796-2175</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Rollins</td><td>4</td><td></td><td></td>
	<td>
	 2/2/2013 4:30:04 PM
	</td>

</tr><TR>

		<td><b>PJ </b></td>
		<td><b>Ogilvie</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>colleenogilvie@mac.com</td>
	
	  <td>par3par3</td>
	 
	  <td>10 Cicero Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-796-2175</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Skonieczny</td><td>K</td><td></td><td></td>
	<td>
	 2/2/2013 4:32:59 PM
	</td>

</tr><TR>

		<td><b>Benjamin </b></td>
		<td><b>Ohlmeyer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>ohlmeyerj@gmail.com</td>
	
	  <td>ohlmeyer</td>
	 
	  <td>2100 Canonero Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-329-5232</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Joseph</td><td>4</td><td></td><td></td>
	<td>
	 2/4/2013 8:45:32 PM
	</td>

</tr><TR>

		<td><b>Charlotte  </b></td>
		<td><b>Ohlmeyer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>ohlmeyerj@gmail.com</td>
	
	  <td>ohlmeyer</td>
	 
	  <td>2100 Canonero Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-329-5232</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Bufkin</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 8:17:28 PM
	</td>

</tr><TR>

		<td><b>Estevan </b></td>
		<td><b>Olivarez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Eo87047@eanesisd.net</td>
	
	  <td>hcmsb4lxa</td>
	 
	  <td>Bee caves</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:59:30 PM
	</td>

</tr><TR>

		<td><b>Max </b></td>
		<td><b>Olvera</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>52.5</td>
	
	  <td>seana.olvera@gmail.com</td>
	
	  <td>rabbit75</td>
	 
	  <td>3205 Skylark Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 9:20:03 PM
	</td>

</tr><TR>

		<td><b>Zephyr </b></td>
		<td><b>Ortiz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>220</td>
	
	  <td>erinkeydixon@gmail.com</td>
	
	  <td>firebolt2</td>
	 
	  <td>5301 Middale Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td>512-565-5784</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Sanderson</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 5:31:28 PM
	</td>

</tr><TR>

		<td><b>Max </b></td>
		<td><b>Pahlke</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>spahlke@gmail.com</td>
	
	  <td>tiger16</td>
	 
	  <td>6703 Lexington rd</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757-4370</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/26/2013 12:08:27 PM
	</td>

</tr><TR>

		<td><b>Joe </b></td>
		<td><b>Palmo</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jp28502@eanesisd.net</td>
	
	  <td>hcmsfwslx</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:08:23 PM
	</td>

</tr><TR>

		<td><b>Maegan </b></td>
		<td><b>Parfan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mp87831@eanesisd.net</td>
	
	  <td>mparfan97</td>
	 
	  <td>2001 South Mopac Apt. #2226</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:01:21 PM
	</td>

</tr><TR>

		<td><b>Maegan </b></td>
		<td><b>Parfan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mp87831@eanesisd.net</td>
	
	  <td>mparfan97</td>
	 
	  <td>1300 Walsh Tarlton Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:05:38 PM
	</td>

</tr><TR>

		<td><b>mia </b></td>
		<td><b>patteson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>miapatteson@gmail.com</td>
	
	  <td>libraryaid</td>
	 
	  <td>911 west live oak</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>orchard</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:50:22 AM
	</td>

</tr><TR>

		<td><b>Felix </b></td>
		<td><b>Pawlowski</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>178</td>
	
	  <td>felixpawlowski@me.com</td>
	
	  <td>felix123</td>
	 
	  <td>3505 Ambleside Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78759</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Murchison Middle School</td><td>Merriman</td><td>6</td><td></td><td></td>
	<td>
	 2/3/2013 5:56:22 PM
	</td>

</tr><TR>

		<td><b>Elisabeth </b></td>
		<td><b>Peeler</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jpeeler@att.net</td>
	
	  <td>JUICE0914</td>
	 
	  <td>1501 Gaston Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>(512)658-3633</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Rains</td><td>3</td><td></td><td></td>
	<td>
	 1/23/2013 6:37:12 PM
	</td>

</tr><TR>

		<td><b>Hunter </b></td>
		<td><b>Pe�a</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Tp29094@eanesisd.net</td>
	
	  <td>Cheese1998</td>
	 
	  <td>1300walshtarton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mrs mgrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:58:20 PM
	</td>

</tr><TR>

		<td><b>Emmy </b></td>
		<td><b>Penders</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>Ccpenders@live.com</td>
	
	  <td>babylove</td>
	 
	  <td>2500 twin oaks dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Ta</td>
	 
	  <td>78757</td>
	 
	  <td>5127315931</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/26/2013 12:26:09 PM
	</td>

</tr><TR>

		<td><b>Collin </b></td>
		<td><b>Penland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Cp83625@eanesisd.net</td>
	
	  <td>hcmsdcfu0</td>
	 
	  <td>Hcms 1300 Walsh Tarton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:18:08 PM
	</td>

</tr><TR>

		<td><b>Tatiana </b></td>
		<td><b>Perrino</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Tp89026@eanesisd.net</td>
	
	  <td>89026</td>
	 
	  <td>Spyglass </td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>6092042072</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:00:16 PM
	</td>

</tr><TR>

		<td><b>Lauren </b></td>
		<td><b>Perry</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Plauren6@gmail.com</td>
	
	  <td>blacksmith</td>
	 
	  <td>5909 carry back lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:58:25 PM
	</td>

</tr><TR>

		<td><b>Carson </b></td>
		<td><b>Peter</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>pixieap78@yahoo.com</td>
	
	  <td>carsonm08</td>
	 
	  <td>1910 Barge Street</td>
	 
	  <td>A</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td>512-300-5194</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Eicke</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 2:36:08 PM
	</td>

</tr><TR>

		<td><b>Dawson </b></td>
		<td><b>Phillips</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>saraleejam@austin.rr.com</td>
	
	  <td>DawsonDP</td>
	 
	  <td>2003 Elton ln, Austin TX</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>499-8981</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Rosenstein</td><td>4</td><td></td><td></td>
	<td>
	 1/28/2013 6:47:33 PM
	</td>

</tr><TR>

		<td><b>Trey </b></td>
		<td><b>Phillips</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>500</td>
	
	  <td>mwpaka90@aol.com</td>
	
	  <td>jesus01</td>
	 
	  <td>6511 St. Stephens Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-971-4677</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 8:13:34 PM
	</td>

</tr><TR>

		<td><b>william </b></td>
		<td><b>phillips</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>magennis3@gmail.com</td>
	
	  <td>william</td>
	 
	  <td>1509 b s 3rd</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78704</td>
	 
	  <td>5125502869</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>aguilar</td><td>4</td><td></td><td></td>
	<td>
	 1/30/2013 11:24:37 PM
	</td>

</tr><TR>

		<td><b>Lucinda  </b></td>
		<td><b>Pierce</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>Lucyp@swbell.net</td>
	
	  <td>amalie1</td>
	 
	  <td>7005 Fred morse drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78723</td>
	 
	  <td>5122176636</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Powell </td><td>6</td><td></td><td></td>
	<td>
	 1/23/2013 4:04:34 PM
	</td>

</tr><TR>

		<td><b>Zachary </b></td>
		<td><b>Pifer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Zp81504@eanesisd.net</td>
	
	  <td>kishmish007</td>
	 
	  <td>3050 tamarron blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:05:17 PM
	</td>

</tr><TR>

		<td><b>Max James </b></td>
		<td><b>Pipkin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>cleeree@yahoo.com</td>
	
	  <td>rocketguy1116</td>
	 
	  <td>6409 Shoal Creek Blvd</td>
	 
	  <td>6409 Shoal Creek Blvd</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-590-2050</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Banta</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 12:45:16 PM
	</td>

</tr><TR>

		<td><b>Isadora </b></td>
		<td><b>Pirkey</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mpirkey@gmail.com</td>
	
	  <td>Pirk1234</td>
	 
	  <td>5707 McCarthy Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>5127977474</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Brewer</td><td>1</td><td></td><td></td>
	<td>
	 2/7/2013 8:45:53 AM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Pitts</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>itispitts@gmail.com</td>
	
	  <td>maggie</td>
	 
	  <td>1821 Rutherford Lane</td>
	 
	  <td>Suite 400</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78754</td>
	 
	  <td>5124261342</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Laxton</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 5:08:01 PM
	</td>

</tr><TR>

		<td><b>Stella </b></td>
		<td><b>Pitts</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>itispitts@gmail.com</td>
	
	  <td>angus</td>
	 
	  <td>1821 Rutherford Lane</td>
	 
	  <td>Suite 400</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78754</td>
	 
	  <td>5124261342</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 5:08:46 PM
	</td>

</tr><TR>

		<td><b>Bella </b></td>
		<td><b>Pjecha</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>chrispj1@aol.com</td>
	
	  <td>ilovebooks</td>
	 
	  <td>4600 Monterey Oaks Blvd #2023</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Edgier </td><td>4</td><td></td><td></td>
	<td>
	 1/29/2013 8:24:17 AM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Povondra</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>amycbecker@yahoo.com</td>
	
	  <td>kirby1974</td>
	 
	  <td>8904 Lanna Bluff Loop</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Clark</td><td>1</td><td></td><td></td>
	<td>
	 2/10/2013 11:52:01 AM
	</td>

</tr><TR>

		<td><b>Una </b></td>
		<td><b>Powell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>jenwood09@gmail.com</td>
	
	  <td>abcdefgh</td>
	 
	  <td>1821 B Waterston Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5126986551</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Fisher</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 8:56:16 PM
	</td>

</tr><TR>

		<td><b>Xavier  </b></td>
		<td><b>Powell</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>jenwood09@gmail.com</td>
	
	  <td>abcdefgh</td>
	 
	  <td>1821 B Waterston Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5126986551</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Neal</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 8:50:05 PM
	</td>

</tr><TR>

		<td><b>Haley </b></td>
		<td><b>Prescott</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>haley0527@gmail.com</td>
	
	  <td>Ha1ey052799</td>
	 
	  <td>5102 Plumas Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td>5128109374</td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>Phillips</td><td>8</td><td></td><td></td>
	<td>
	 1/28/2013 10:13:56 PM
	</td>

</tr><TR>

		<td><b>Braeden </b></td>
		<td><b>Price</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>pricels@gmail.com</td>
	
	  <td>oliver</td>
	 
	  <td>6612 Argentia Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5127979890</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>MOORE</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 4:37:41 PM
	</td>

</tr><TR>

		<td><b>Grayson </b></td>
		<td><b>Price</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>christinaprice@hotmail.com</td>
	
	  <td>lonestar</td>
	 
	  <td>1311 Morrow St. </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hinojosa</td><td>K</td><td></td><td></td>
	<td>
	 2/10/2013 10:20:22 AM
	</td>

</tr><TR>

		<td><b>Owen </b></td>
		<td><b>price</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>pricels@gmail.com</td>
	
	  <td>oliver</td>
	 
	  <td>6612 Argentia Road</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5127979890</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>ALLIN</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 4:45:32 PM
	</td>

</tr><TR>

		<td><b>Owen </b></td>
		<td><b>Price</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>vickiegprice@hotmail.com</td>
	
	  <td>luketex</td>
	 
	  <td>2605 Maria Anna Rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Nelson</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 6:30:50 PM
	</td>

</tr><TR>

		<td><b>Aiden </b></td>
		<td><b>Puga</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>apuga@eanesisd.net</td>
	
	  <td>texas01</td>
	 
	  <td>149 Tomatillo Cove</td>
	 
	  <td></td>
	 
	  <td>Kyle</td>
	 
	  <td>TX</td>
	 
	  <td>78640</td>
	 
	  <td>512-262-9569</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Reinhardt</td><td>K</td><td></td><td></td>
	<td>
	 2/7/2013 8:28:23 PM
	</td>

</tr><TR>

		<td><b>Emily </b></td>
		<td><b>Pullen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ep28708@eanesisd.net</td>
	
	  <td>hcmssd8zx</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127322682</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:12:44 PM
	</td>

</tr><TR>

		<td><b>Lilly </b></td>
		<td><b>Quinn</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lillypads02@gmail.com</td>
	
	  <td>lillypads02</td>
	 
	  <td>2608 Great Oaks Pkwy</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Maher</td><td>5</td><td></td><td></td>
	<td>
	 1/23/2013 3:25:20 PM
	</td>

</tr><TR>

		<td><b>Vivian </b></td>
		<td><b>Quinn</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>smquinn@grandecom.net</td>
	
	  <td>viviq05</td>
	 
	  <td>2608 Great Oaks Pkwy</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Still</td><td>2</td><td></td><td></td>
	<td>
	 1/23/2013 3:26:59 PM
	</td>

</tr><TR>

		<td><b>Cruz </b></td>
		<td><b>Quintana</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>light-eagle@sbcglobal.net</td>
	
	  <td>dragon</td>
	 
	  <td>3007 Stardust</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/30/2013 9:11:02 AM
	</td>

</tr><TR>

		<td><b>Zoe </b></td>
		<td><b>Rabinowitz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>65</td>
	
	  <td>sevascu@gmail.com</td>
	
	  <td>formreadalot31</td>
	 
	  <td>7801 Lazy Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea</td><td>3</td><td></td><td></td>
	<td>
	 1/30/2013 12:33:17 PM
	</td>

</tr><TR>

		<td><b>Aleah </b></td>
		<td><b>Ragan</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>lisa_coronado@hotmail.com</td>
	
	  <td>10187925</td>
	 
	  <td>8535 N. Capital of TX Hwy #1069</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Humple</td><td>1</td><td></td><td></td>
	<td>
	 1/24/2013 1:43:08 PM
	</td>

</tr><TR>

		<td><b>Jayna </b></td>
		<td><b>Ravula</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>JaynaWaynaR@gmail.com</td>
	
	  <td>gymnastics</td>
	 
	  <td>5005 woodrow ave B</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>St. Germain</td><td>2</td><td></td><td></td>
	<td>
	 1/23/2013 5:27:11 PM
	</td>

</tr><TR>

		<td><b>Nathan </b></td>
		<td><b>Ray</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>kray@att.com</td>
	
	  <td>Kelir3ay</td>
	 
	  <td>3103 Yellowpine Ter.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Cohen</td><td>5</td><td></td><td></td>
	<td>
	 1/27/2013 11:03:28 PM
	</td>

</tr><TR>

		<td><b>Adriana  </b></td>
		<td><b>Regalado</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>regaladoaus@yahoo.com</td>
	
	  <td>School13</td>
	 
	  <td>6500 Ashland Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78723</td>
	 
	  <td>512-933-1001</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Shackelford</td><td>8</td><td></td><td></td>
	<td>
	 1/28/2013 4:37:27 PM
	</td>

</tr><TR>

		<td><b>Maxine  </b></td>
		<td><b>Reinig</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>70</td>
	
	  <td>jane_finkbeiner@hotmail.com</td>
	
	  <td>maxvance1</td>
	 
	  <td>3305 Whitepine Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-627-6348</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Hinojosa</td><td>K</td><td></td><td></td>
	<td>
	 2/4/2013 9:33:48 PM
	</td>

</tr><TR>

		<td><b>Ryan </b></td>
		<td><b>Remaley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>160</td>
	
	  <td>amremaley@yahoo.com</td>
	
	  <td>01232001</td>
	 
	  <td>3102 West Terrace Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-289-1355</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 1/29/2013 4:49:32 PM
	</td>

</tr><TR>

		<td><b>Sean </b></td>
		<td><b>Remaley</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>135</td>
	
	  <td>amremaley@yahoo.com</td>
	
	  <td>01232001</td>
	 
	  <td>3102 West Terrace Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-289-1355</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Carruth</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 4:52:12 PM
	</td>

</tr><TR>

		<td><b>Abby </b></td>
		<td><b>Rhett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>bmagill86@yahoo.com</td>
	
	  <td>524nlamar</td>
	 
	  <td>1308 Hillside</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Robertson</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 10:16:18 AM
	</td>

</tr><TR>

		<td><b>Evan </b></td>
		<td><b>Richards</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>krichards2001@gmail.com</td>
	
	  <td>piglet</td>
	 
	  <td>7300 Running Rope</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5125176038</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Bailey</td><td>3</td><td></td><td></td>
	<td>
	 1/30/2013 5:44:24 PM
	</td>

</tr><TR>

		<td><b>Hallie </b></td>
		<td><b>Richeson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>145</td>
	
	  <td>aricheson@gmail.com</td>
	
	  <td>richesonreader</td>
	 
	  <td>2709 Addison Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>773-1077</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Cohen</td><td>5</td><td></td><td></td>
	<td>
	 1/27/2013 11:52:20 AM
	</td>

</tr><TR>

		<td><b>Zachary </b></td>
		<td><b>Richeson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>aricheson@gmail.com</td>
	
	  <td>library!</td>
	 
	  <td>2709 Addison Avenue</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-773-1077</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 2/6/2013 9:25:08 PM
	</td>

</tr><TR>

		<td><b>hanna </b></td>
		<td><b>Rimel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>150</td>
	
	  <td>keri@homefreeaustin.com</td>
	
	  <td>annie</td>
	 
	  <td>2010 Indian Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>prewitt</td><td>3</td><td></td><td></td>
	<td>
	 2/8/2013 6:34:08 PM
	</td>

</tr><TR>

		<td><b>maddie </b></td>
		<td><b>rimel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>keri@homefreeaustin.com</td>
	
	  <td>hanna3523</td>
	 
	  <td>2010 Indian Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>brewer</td><td>1</td><td></td><td></td>
	<td>
	 2/9/2013 3:24:17 PM
	</td>

</tr><TR>

		<td><b>Jared </b></td>
		<td><b>Risinger</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>normanrisinger@aol.com</td>
	
	  <td>Jared1229</td>
	 
	  <td>18 Cicero Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5122916153</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>King</td><td>K</td><td></td><td></td>
	<td>
	 1/30/2013 10:31:02 AM
	</td>

</tr><TR>

		<td><b>dominic </b></td>
		<td><b>rivera</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>dominic_1124@yahoo.com</td>
	
	  <td>lilgil21</td>
	 
	  <td>1141 ebert ave</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78721</td>
	 
	  <td>512-217-9423</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>ms.phillips</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 10:54:44 AM
	</td>

</tr><TR>

		<td><b>cameron </b></td>
		<td><b>roberts</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>cameronlroberts@gmail.com</td>
	
	  <td>cameron20</td>
	 
	  <td>8730 North Mopac #202</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78759</td>
	 
	  <td>5126299367</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>olson</td><td>3</td><td></td><td></td>
	<td>
	 1/30/2013 6:58:31 PM
	</td>

</tr><TR>

		<td><b>Anneliese </b></td>
		<td><b>Rodriguez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ltrodriguez@austin.rr.com</td>
	
	  <td>anni123</td>
	 
	  <td>3100 Kittowa Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123309321</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Crowley</td><td>3</td><td></td><td></td>
	<td>
	 2/6/2013 3:13:00 PM
	</td>

</tr><TR>

		<td><b>Cecilia </b></td>
		<td><b>Rodriguez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ltrodriguez@austin.rr.com</td>
	
	  <td>ceci123</td>
	 
	  <td>3100 Kittowa Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123309321</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Pace</td><td>5</td><td></td><td></td>
	<td>
	 2/6/2013 3:10:11 PM
	</td>

</tr><TR>

		<td><b>Gabrielle </b></td>
		<td><b>Rodriguez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ltrodriguez@austin.rr.com</td>
	
	  <td>GAbby123</td>
	 
	  <td>3100 Kittowa Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5123309321</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mosher</td><td>8</td><td></td><td></td>
	<td>
	 2/6/2013 3:11:45 PM
	</td>

</tr><TR>

		<td><b>Austin </b></td>
		<td><b>Roland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>austinroland16@yahoo.com</td>
	
	  <td>austin</td>
	 
	  <td>mapelleaf Dr 5514</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>US</td>
	 
	  <td>78723</td>
	 
	  <td>1(512)450-4611</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>sylvia</td><td>6</td><td></td><td></td>
	<td>
	 1/25/2013 12:55:39 PM
	</td>

</tr><TR>

		<td><b>Grace </b></td>
		<td><b>Ross</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>ginavross@gmail.com</td>
	
	  <td>obumblebee</td>
	 
	  <td>5710 Marilyn Dr </td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5125694654</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Santiso</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 5:29:04 PM
	</td>

</tr><TR>

		<td><b>Willa </b></td>
		<td><b>Royder</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ericaroyder@gmail.com</td>
	
	  <td>willabean</td>
	 
	  <td>1505 Morrow Street</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512-709-0934</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Banta</td><td>3</td><td></td><td></td>
	<td>
	 2/10/2013 10:12:14 AM
	</td>

</tr><TR>

		<td><b>Blake </b></td>
		<td><b>Rozas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>br30473@eanesisd.net</td>
	
	  <td>hcmsd2uok</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127400077</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:42 AM
	</td>

</tr><TR>

		<td><b>Delia </b></td>
		<td><b>Rune</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>deliarune@gmail.com</td>
	
	  <td>Dr110404</td>
	 
	  <td>2312 Indian Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Still</td><td>2</td><td></td><td></td>
	<td>
	 2/5/2013 7:24:26 PM
	</td>

</tr><TR>

		<td><b>Rylie </b></td>
		<td><b>Ruppersburg</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>flowk78@yahoo.com</td>
	
	  <td>smooches</td>
	 
	  <td>3305 McElroy Dr</td>
	 
	  <td>#2</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 1/29/2013 1:59:42 PM
	</td>

</tr><TR>

		<td><b>Carly </b></td>
		<td><b>Saad</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>meredithkate@yahoo.com</td>
	
	  <td>love3163</td>
	 
	  <td>9403 Winchester Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>512-263-5077</td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Wotring</td><td>4</td><td></td><td></td>
	<td>
	 1/24/2013 9:14:23 PM
	</td>

</tr><TR>

		<td><b>Sammy </b></td>
		<td><b>Saenz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>alvinnort@gmail.com</td>
	
	  <td>sammiesignz</td>
	 
	  <td>enfield</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>orchard</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 10:15:23 AM
	</td>

</tr><TR>

		<td><b>Amira </b></td>
		<td><b>Sahba</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>as88057@eanesisd.net</td>
	
	  <td>bffmaddie</td>
	 
	  <td>3909 Willbert Rd.</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78751</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Boyd</td><td>7</td><td></td><td></td>
	<td>
	 1/28/2013 9:59:31 PM
	</td>

</tr><TR>

		<td><b>Isabel </b></td>
		<td><b>Salas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>is86537@eanesisd.net</td>
	
	  <td>floppycinnamon</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:07:17 PM
	</td>

</tr><TR>

		<td><b>Anderson </b></td>
		<td><b>Salisbury</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>As80925@eanesisd.net</td>
	
	  <td>hcmsz5gtf</td>
	 
	  <td>301 Bulian lane </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>70746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/28/2013 1:30:37 PM
	</td>

</tr><TR>

		<td><b>Kaya </b></td>
		<td><b>Samiloglu</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>335</td>
	
	  <td>londonandkaya@gmail.com</td>
	
	  <td>lolalola12</td>
	 
	  <td>2700 EAST Side Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>5122893163</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Guthrie</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 4:29:47 PM
	</td>

</tr><TR>

		<td><b>Rowan </b></td>
		<td><b>sammon</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>jsammon@austin.rr.com</td>
	
	  <td>pOkEmOn_23</td>
	 
	  <td>6812 Pioneer Pl</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Laxton</td><td>2</td><td></td><td></td>
	<td>
	 1/25/2013 6:26:44 PM
	</td>

</tr><TR>

		<td><b>Borja  </b></td>
		<td><b>Sanchez de Prado</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mjdeprado@yahoo.com.mx</td>
	
	  <td>layline</td>
	 
	  <td>1403 Elton Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5124840092</td>

	<!-- this is where the custom fields go -->
		 <td>Rawson Saunders</td><td>Love</td><td>5</td><td></td><td></td>
	<td>
	 2/3/2013 12:26:30 PM
	</td>

</tr><TR>

		<td><b>Bosco </b></td>
		<td><b>Sanchez de Prado</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mjdeprado@yahoo.com.mx</td>
	
	  <td>layline</td>
	 
	  <td>1403 Elton Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5124840092</td>

	<!-- this is where the custom fields go -->
		 <td>Rawson Saunders</td><td>Henke</td><td>2</td><td></td><td></td>
	<td>
	 2/3/2013 12:27:54 PM
	</td>

</tr><TR>

		<td><b>cuatro </b></td>
		<td><b>santos</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>fs28524@eanesisd.net</td>
	
	  <td>12345678</td>
	 
	  <td>1111 Westlake Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:01:53 PM
	</td>

</tr><TR>

		<td><b>Caroline </b></td>
		<td><b>Sauer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>heidisauer1@gmail.com</td>
	
	  <td>caroline21</td>
	 
	  <td>1899 Westlake Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Tremel</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 10:47:44 PM
	</td>

</tr><TR>

		<td><b>Carter </b></td>
		<td><b>Sauer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>heidisauer1@gmail.com</td>
	
	  <td>carter21</td>
	 
	  <td>1899 Westlake Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Cook</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 10:34:35 PM
	</td>

</tr><TR>

		<td><b>Brendan </b></td>
		<td><b>Savedra</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>kcrisp1@austin.rr.com</td>
	
	  <td>doodlebug</td>
	 
	  <td>2710 Park View Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>2547603844</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 2/7/2013 9:46:21 PM
	</td>

</tr><TR>

		<td><b>Jude </b></td>
		<td><b>Scarbrough</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jake.scarbrough@gmail.com</td>
	
	  <td>super2005</td>
	 
	  <td>2100 Forest Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Christian</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 11:49:52 AM
	</td>

</tr><TR>

		<td><b>Lou </b></td>
		<td><b>Schavrda</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>jill_whiteside@yahoo.com</td>
	
	  <td>punkin</td>
	 
	  <td>2911 Rogge Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td>512-663-3631</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 2/6/2013 7:16:55 PM
	</td>

</tr><TR>

		<td><b>Isaac </b></td>
		<td><b>Schlaud</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>chrisdls@att.net</td>
	
	  <td>chrisdls</td>
	 
	  <td>7003 Shoal Creek Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>DeAtley</td><td>5</td><td></td><td></td>
	<td>
	 2/5/2013 4:22:55 PM
	</td>

</tr><TR>

		<td><b>Sofia </b></td>
		<td><b>Schlaud</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>chrisdls@att.net</td>
	
	  <td>chrisdls</td>
	 
	  <td>7003 Shoal Creek Blvd.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Shea</td><td>3</td><td></td><td></td>
	<td>
	 2/5/2013 4:26:24 PM
	</td>

</tr><TR>

		<td><b>Jason </b></td>
		<td><b>Schmidt</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Js28621@eanesisd.net</td>
	
	  <td>hcmsclrt4</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:50:52 PM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Schocket</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>95</td>
	
	  <td>kimbyintex@yahoo.com</td>
	
	  <td>jts1112</td>
	 
	  <td>4201 Greystone Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>512-323-0999</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Vrba</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 3:53:47 PM
	</td>

</tr><TR>

		<td><b>Maya </b></td>
		<td><b>Schuessler</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>boandcoco@yahoo.com</td>
	
	  <td>jellikit</td>
	 
	  <td>804 Colonial Park Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78745</td>
	 
	  <td>5129442026</td>

	<!-- this is where the custom fields go -->
		 <td>Dawson Elementary</td><td>Martinets</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 12:34:52 PM
	</td>

</tr><TR>

		<td><b>Sophie </b></td>
		<td><b>Schultz</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>staci1505@yahoo.com</td>
	
	  <td>7915550</td>
	 
	  <td>2302 Cheswick Ct.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Plevich</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 6:11:14 PM
	</td>

</tr><TR>

		<td><b>C </b></td>
		<td><b>Schwenker</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>junder4@aol.com</td>
	
	  <td>46book46</td>
	 
	  <td>12311 capitol saddlery trail</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Coleman</td><td>K</td><td></td><td></td>
	<td>
	 2/3/2013 9:28:14 PM
	</td>

</tr><TR>

		<td><b>F </b></td>
		<td><b>Schwenker</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>junder4@aol.com</td>
	
	  <td>48book48</td>
	 
	  <td>12311 capitol saddlery trail</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Moore</td><td>2</td><td></td><td></td>
	<td>
	 2/3/2013 9:33:13 PM
	</td>

</tr><TR>

		<td><b>Adrina </b></td>
		<td><b>Scott</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>michaelpaul71@yahoo.com</td>
	
	  <td>friday</td>
	 
	  <td>3104 Hunt Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5123519685</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Butler</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/4/2013 2:08:13 PM
	</td>

</tr><TR>

		<td><b>Isabella </b></td>
		<td><b>Scott</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>michaelpaul71@yahoo.com</td>
	
	  <td>friday</td>
	 
	  <td>3104 Hunt Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5123519685</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Denega</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 2:10:00 PM
	</td>

</tr><TR>

		<td><b>Nolan </b></td>
		<td><b>Screen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>nolanpscreen@yahoo.com</td>
	
	  <td>london</td>
	 
	  <td>6007 front royal dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124368060</td>

	<!-- this is where the custom fields go -->
		 <td>West Ridge Middle School</td><td>Silva</td><td>6</td><td></td><td></td>
	<td>
	 1/29/2013 5:47:03 PM
	</td>

</tr><TR>

		<td><b>Miranda </b></td>
		<td><b>Seade</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>horselove@austin.rr.com</td>
	
	  <td>teddybear</td>
	 
	  <td>4601 Dusik Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>West Ridge Middle School</td><td>Silva</td><td>6</td><td></td><td></td>
	<td>
	 1/28/2013 6:26:00 PM
	</td>

</tr><TR>

		<td><b>Arden </b></td>
		<td><b>Seifert</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>ccseif@gmail.com</td>
	
	  <td>pass8024</td>
	 
	  <td>5405 Shoalwood Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td>512-507-7059</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/25/2013 5:52:22 PM
	</td>

</tr><TR>

		<td><b>Uriah </b></td>
		<td><b>Shaffer</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>rebekah477@hotmail.com</td>
	
	  <td>uriah217</td>
	 
	  <td>2214 A Lanier Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78757</td>
	 
	  <td>5126947710</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/31/2013 12:06:32 PM
	</td>

</tr><TR>

		<td><b>Conner </b></td>
		<td><b>Shaver</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>125</td>
	
	  <td>amandashaver@yahoo.com</td>
	
	  <td>japheth</td>
	 
	  <td>11725 Drayton Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78758</td>
	 
	  <td>2544665489</td>

	<!-- this is where the custom fields go -->
		 <td>INDIVIDUAL</td><td>Rauert</td><td>4</td><td></td><td></td>
	<td>
	 1/25/2013 10:56:38 AM
	</td>

</tr><TR>

		<td><b>Dylan  </b></td>
		<td><b>Shea </b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ds81436@eanesisd.net</td>
	
	  <td>hcmslhyge</td>
	 
	  <td>No</td>
	 
	  <td></td>
	 
	  <td>No</td>
	 
	  <td>No</td>
	 
	  <td>No</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:58:42 PM
	</td>

</tr><TR>

		<td><b>Zeke </b></td>
		<td><b>Sheffield</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ms29261@eanesisd.net</td>
	
	  <td>hcmssrr25</td>
	 
	  <td>1300 Walsh tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78733</td>
	 
	  <td>5123309917</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:53:34 PM
	</td>

</tr><TR>

		<td><b>Asa </b></td>
		<td><b>Shepard</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>386.5</td>
	
	  <td>missjames@netzero.net</td>
	
	  <td>K1tty2oo4</td>
	 
	  <td>2605 Twin Oaks Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757-2735</td>
	 
	  <td>5124584453</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 1/24/2013 1:05:30 AM
	</td>

</tr><TR>

		<td><b>Tatum </b></td>
		<td><b>Shiflet</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>275</td>
	
	  <td>anneshiflet@mac.com</td>
	
	  <td>tshiflet2</td>
	 
	  <td>65 Pascal Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>King</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 12:11:35 AM
	</td>

</tr><TR>

		<td><b>Nicholas </b></td>
		<td><b>Shilling</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>kdanysh@hotmail.com</td>
	
	  <td>starwars</td>
	 
	  <td>9411 Scenic Bluff Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td>5125731114</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Huth</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 11:20:47 PM
	</td>

</tr><TR>

		<td><b>Brad </b></td>
		<td><b>Siegel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>scott_siegel@centraltexascounseling.net</td>
	
	  <td>102104</td>
	 
	  <td>7604 Rustling Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Smith</td><td>2</td><td></td><td></td>
	<td>
	 2/7/2013 8:20:57 PM
	</td>

</tr><TR>

		<td><b>Carly </b></td>
		<td><b>Siegel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>scott_siegel@centraltexascounseling.net</td>
	
	  <td>090106</td>
	 
	  <td>7604 Rustling Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Warner</td><td>K</td><td></td><td></td>
	<td>
	 2/7/2013 8:23:54 PM
	</td>

</tr><TR>

		<td><b>Logan </b></td>
		<td><b>Sigel</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ls28896@eanesisd.net</td>
	
	  <td>hcmshnicf</td>
	 
	  <td>1718 mount Larson rd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:50:36 PM
	</td>

</tr><TR>

		<td><b>Leena </b></td>
		<td><b>Siiteri</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>siiteri.rose@gmail.com</td>
	
	  <td>hcmsosrx5</td>
	 
	  <td>1433 Allen rd</td>
	 
	  <td>1433 Allen rd</td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>512-382-5939</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:15:36 PM
	</td>

</tr><TR>

		<td><b>Clara </b></td>
		<td><b>Sjolseth</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>jessica_sjolseth@hotmail.com</td>
	
	  <td>csbs13</td>
	 
	  <td>4624 Trail West Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Swan</td><td>6</td><td></td><td></td>
	<td>
	 2/10/2013 10:03:03 PM
	</td>

</tr><TR>

		<td><b>Grant </b></td>
		<td><b>Skaggs</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>sgrimmell99@yahoo.com</td>
	
	  <td>sugar99</td>
	 
	  <td>304 Hensley Dr.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78738</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Coleman</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 4:43:30 PM
	</td>

</tr><TR>

		<td><b>Henry </b></td>
		<td><b>Skinner</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>hs83445@eanesisd.net</td>
	
	  <td>henry123</td>
	 
	  <td>3144 Honey Tree Ln.</td>
	 
	  <td>3144 Honey Tree Ln.</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>732-7276</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Browder</td><td>4</td><td></td><td></td>
	<td>
	 1/28/2013 4:46:22 PM
	</td>

</tr><TR>

		<td><b>Jack </b></td>
		<td><b>Skudlrczyk</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>js89010@eanesisd.net</td>
	
	  <td>jackskudz</td>
	 
	  <td>1610 wild basin south</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5129177221</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:14:58 PM
	</td>

</tr><TR>

		<td><b>Anne Marie </b></td>
		<td><b>Smith</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>220</td>
	
	  <td>ams3120@gmail.com</td>
	
	  <td>041604</td>
	 
	  <td>706 B Gamez Cv</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Galindo Elementary</td><td>Jacobs</td><td>3</td><td></td><td></td>
	<td>
	 1/30/2013 8:57:20 AM
	</td>

</tr><TR>

		<td><b>Mary </b></td>
		<td><b>Smith</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mcclls@austin.rr.com</td>
	
	  <td>011106</td>
	 
	  <td>16804 Goldenwood Way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78737</td>
	 
	  <td>512-894-3355</td>

	<!-- this is where the custom fields go -->
		 <td>Cedars Montessori</td><td>Romig</td><td>6</td><td></td><td></td>
	<td>
	 1/29/2013 9:11:45 PM
	</td>

</tr><TR>

		<td><b>Perrin </b></td>
		<td><b>Smith</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>reagankremmer1@yahoo.com</td>
	
	  <td>PerrinSmith</td>
	 
	  <td>7630 Wood Hollow Dr.</td>
	 
	  <td>Apt. 132</td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78731</td>
	 
	  <td>512-534-7892</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Bones</td><td>3</td><td></td><td></td>
	<td>
	 1/29/2013 8:21:42 AM
	</td>

</tr><TR>

		<td><b>Citlalli </b></td>
		<td><b>Soto-Ferate</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>themorningstar.9@gmail.com</td>
	
	  <td>Mire!2011</td>
	 
	  <td>7513 Marble Ridge Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78747</td>
	 
	  <td>512-292-6733</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Rackowitz</td><td>5</td><td></td><td></td>
	<td>
	 1/23/2013 9:28:33 PM
	</td>

</tr><TR>

		<td><b>Maya Itzel </b></td>
		<td><b>Soto-Ferate</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bachue_9@yahoo.com</td>
	
	  <td>NenaLinda18</td>
	 
	  <td>7513 Marble Ridge Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78747</td>
	 
	  <td>512-292-6733</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>DePutron</td><td>2</td><td></td><td></td>
	<td>
	 1/23/2013 9:36:54 PM
	</td>

</tr><TR>

		<td><b>Maya Itzel </b></td>
		<td><b>Soto-Ferate</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bachue_9@yahoo.com</td>
	
	  <td>NenaLinda18</td>
	 
	  <td>7513 Marble Ridge Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78747</td>
	 
	  <td>512-292-6733</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>DePutron</td><td>2</td><td></td><td></td>
	<td>
	 1/23/2013 9:39:58 PM
	</td>

</tr><TR>

		<td><b>Aidan  </b></td>
		<td><b>Southerland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>tricia@austin.rr.com</td>
	
	  <td>sugar1234</td>
	 
	  <td>1505 Quail Cover Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78758</td>
	 
	  <td>5126585109</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Banta</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 4:50:25 PM
	</td>

</tr><TR>

		<td><b>Eva Mae  </b></td>
		<td><b>Southerland</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>tricia@austin.rr.com</td>
	
	  <td>sugar123</td>
	 
	  <td>1505 Quail Cover Circle</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78758</td>
	 
	  <td>512658-5109</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Bass</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 4:40:39 PM
	</td>

</tr><TR>

		<td><b>cole </b></td>
		<td><b>spytek</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>jennyjo1967@gmail.com</td>
	
	  <td>rodeo</td>
	 
	  <td>6009 nasco dr</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>hinojosa</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/4/2013 7:01:24 PM
	</td>

</tr><TR>

		<td><b>Jackson </b></td>
		<td><b>Stahlman</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>bridgette.stahlman@gmail.com</td>
	
	  <td>blakee04</td>
	 
	  <td>1100 Belmont Parkway</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>5126732318</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Cavasos</td><td>1</td><td></td><td></td>
	<td>
	 1/26/2013 3:48:42 PM
	</td>

</tr><TR>

		<td><b>Pressley </b></td>
		<td><b>Stevens</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>kimsuestevens@gmail.com</td>
	
	  <td>belladog99</td>
	 
	  <td>5421 Shoalwood Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756-1619</td>
	 
	  <td>512 9255616</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>greer</td><td>K</td><td></td><td></td>
	<td>
	 1/29/2013 1:26:08 PM
	</td>

</tr><TR>

		<td><b>Bo </b></td>
		<td><b>Stewart</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ss87546@eanesisd.net</td>
	
	  <td>stewart5</td>
	 
	  <td>3409 toro canyon </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:19:19 PM
	</td>

</tr><TR>

		<td><b>Douglas </b></td>
		<td><b>Stewart</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>35</td>
	
	  <td>Douglas.stewart99@gmail.com</td>
	
	  <td>S012799s</td>
	 
	  <td>5327 King Henry Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78724</td>
	 
	  <td>5129289568</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>Orchard</td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 2:37:33 PM
	</td>

</tr><TR>

		<td><b>Madeleine </b></td>
		<td><b>Stokes</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>213.4</td>
	
	  <td>alexis@alumni.rice.edu</td>
	
	  <td>78746</td>
	 
	  <td>4300 Dunning Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5124669000</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Tremel</td><td>1</td><td></td><td></td>
	<td>
	 1/30/2013 8:39:38 AM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Stone</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>As28505@eanesisd.net</td>
	
	  <td>hcmsqchlx</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:02:55 PM
	</td>

</tr><TR>

		<td><b>Cotton </b></td>
		<td><b>Stone</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>jennyjo1967@gmail.com</td>
	
	  <td>rodeo</td>
	 
	  <td>6009 nasco dr</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>valentino</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 6:59:28 PM
	</td>

</tr><TR>

		<td><b>Will </b></td>
		<td><b>Stone</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jennystone@me.com</td>
	
	  <td>stonefam1215</td>
	 
	  <td>2002 Indian Trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-771-4795</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Ewing</td><td>2</td><td></td><td></td>
	<td>
	 2/8/2013 5:53:10 PM
	</td>

</tr><TR>

		<td><b>Bray </b></td>
		<td><b>Stratton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>familiastratton@gmail.com</td>
	
	  <td>snowy</td>
	 
	  <td>2512 Spring Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-494-8649</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Stephens</td><td>3</td><td></td><td></td>
	<td>
	 2/6/2013 6:16:29 PM
	</td>

</tr><TR>

		<td><b>Gus </b></td>
		<td><b>Stratton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>familiastratton@gmail.com</td>
	
	  <td>ravens</td>
	 
	  <td>2512 Spring Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-748-4984</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Ross</td><td>1</td><td></td><td></td>
	<td>
	 2/6/2013 6:42:05 PM
	</td>

</tr><TR>

		<td><b>Vivian </b></td>
		<td><b>Streber</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>90</td>
	
	  <td>Alexisstreber@gmail.com</td>
	
	  <td>sophielou12</td>
	 
	  <td>2911 Dover Place</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>917-969-3623</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Doherty</td><td>3</td><td></td><td></td>
	<td>
	 1/31/2013 9:39:08 AM
	</td>

</tr><TR>

		<td><b>Quentin </b></td>
		<td><b>Sublett</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>cpsublett@gmail.com</td>
	
	  <td>read13</td>
	 
	  <td>1601 gaston ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78703</td>
	 
	  <td>512-917-6759</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Nelson</td><td>3</td><td></td><td></td>
	<td>
	 1/24/2013 7:37:02 PM
	</td>

</tr><TR>

		<td><b>Boxuan </b></td>
		<td><b>Sun</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Bs89163@eanesisd.net</td>
	
	  <td>bs710327</td>
	 
	  <td>HCMS 1300 Walsh Tarlton Austin, TX 78746</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5712589866</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:41 PM
	</td>

</tr><TR>

		<td><b>Kristin </b></td>
		<td><b>Svahn</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>psvahn@austin.rr.com</td>
	
	  <td>horse</td>
	 
	  <td>1905 Stamford Ln.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-480-0141</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Myers</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 8:33:46 PM
	</td>

</tr><TR>

		<td><b>Brendan </b></td>
		<td><b>Swanstrom</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Bs85700@eanesisd.net</td>
	
	  <td>PUFFpuff171</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td>512-636-0860</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:13:47 PM
	</td>

</tr><TR>

		<td><b>Marcus </b></td>
		<td><b>Sweeney</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ms27876@gmail.com</td>
	
	  <td>hcms21yua</td>
	 
	  <td>1110 blackacre trail</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:06:10 PM
	</td>

</tr><TR>

		<td><b>Robert </b></td>
		<td><b>Taaffe</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Rt28809@eanesisd.net</td>
	
	  <td>roberttaaffe</td>
	 
	  <td>Djdbjhbjhbhjb</td>
	 
	  <td>Ggvifyvuftvuft</td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td>5125654123</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:53 PM
	</td>

</tr><TR>

		<td><b>Josh </b></td>
		<td><b>Tarbox</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jt25533@eanesisd.net</td>
	
	  <td>westlake33</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:33:17 AM
	</td>

</tr><TR>

		<td><b>Lexy  </b></td>
		<td><b>Taylor</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>200</td>
	
	  <td>ataylor7172@yahoo.com</td>
	
	  <td>Car9son9</td>
	 
	  <td>901 Lakewood Hills Terrace</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td>512-243-7860</td>

	<!-- this is where the custom fields go -->
		 <td>Rawson Saunders</td><td>Love</td><td>4</td><td></td><td></td>
	<td>
	 2/10/2013 4:53:29 PM
	</td>

</tr><TR>

		<td><b>Charlie  </b></td>
		<td><b>Thomas </b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>jenthomas2@me.com</td>
	
	  <td>Charliebear</td>
	 
	  <td>4501 Grider Pass</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td>512 656-1326</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Boltie</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 9:39:33 PM
	</td>

</tr><TR>

		<td><b>Will </b></td>
		<td><b>Thomas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>wt81511@eanesisd.net</td>
	
	  <td>hcms2k1jl</td>
	 
	  <td>1100 havre lafette dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mcgrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 11:59:40 AM
	</td>

</tr><TR>

		<td><b>Aidan </b></td>
		<td><b>Thompson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>lisabthompson@att.net</td>
	
	  <td>hotsauce1210</td>
	 
	  <td>6804 Glen Ridge Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5129173079</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Gustafson</td><td>4</td><td></td><td></td>
	<td>
	 1/28/2013 6:04:22 PM
	</td>

</tr><TR>

		<td><b>Amelia </b></td>
		<td><b>Thompson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>45</td>
	
	  <td>lisabthompson@att.net</td>
	
	  <td>stinky0426</td>
	 
	  <td>6804 Glen Ridge Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>5129173079</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Stone</td><td>1</td><td></td><td></td>
	<td>
	 1/28/2013 6:15:36 PM
	</td>

</tr><TR>

		<td><b>Ben </b></td>
		<td><b>Thompson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>bt28717@eanesisd.net</td>
	
	  <td>e468SAT2</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:06:07 PM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Thomsen</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>40</td>
	
	  <td>2kims@sonoshipping.com</td>
	
	  <td>sarahthomsen</td>
	 
	  <td>3705 Woodcutters Way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5126583767</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Pace</td><td>5</td><td></td><td></td>
	<td>
	 2/4/2013 7:06:18 PM
	</td>

</tr><TR>

		<td><b>Logan </b></td>
		<td><b>Thomson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>Wendy@wendythomson.com</td>
	
	  <td>logan</td>
	 
	  <td>1904 Mistywood Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-775-0071</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Boltie</td><td>K</td><td></td><td></td>
	<td>
	 1/30/2013 9:23:01 PM
	</td>

</tr><TR>

		<td><b>Thomas </b></td>
		<td><b>Throckmorton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>gwenburgess@yahoo.com</td>
	
	  <td>nolan103</td>
	 
	  <td>12013 Rayo De Luna</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78732</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>School in the Hills</td><td>Smith</td><td>Pre-K</td><td></td><td></td>
	<td>
	 2/1/2013 7:55:08 AM
	</td>

</tr><TR>

		<td><b>Jonah </b></td>
		<td><b>Thurman</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>DonnaT3@me.com</td>
	
	  <td>smokie123</td>
	 
	  <td>1800 Corto Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Wotring</td><td>4</td><td></td><td></td>
	<td>
	 2/7/2013 10:40:14 PM
	</td>

</tr><TR>

		<td><b>Audrey </b></td>
		<td><b>Thurmond</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>laura@thurmondmedia.com</td>
	
	  <td>momanddad2</td>
	 
	  <td>3815 Hillbrook Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Doherty</td><td>3</td><td></td><td></td>
	<td>
	 2/4/2013 9:34:41 AM
	</td>

</tr><TR>

		<td><b>Veronica </b></td>
		<td><b>Thurmond</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>30</td>
	
	  <td>laura@thurmondmedia.com</td>
	
	  <td>momanddad</td>
	 
	  <td>3815 Hillbrook Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Nichols</td><td>1</td><td></td><td></td>
	<td>
	 2/4/2013 9:32:57 AM
	</td>

</tr><TR>

		<td><b>Hazel </b></td>
		<td><b>Trominski</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>65</td>
	
	  <td>deboraht@rocketmail.com</td>
	
	  <td>goodtogo</td>
	 
	  <td>5708 Bullard Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Glidewell</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 8:07:03 PM
	</td>

</tr><TR>

		<td><b>Vivian </b></td>
		<td><b>Trominski</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>65</td>
	
	  <td>deboraht@rocketmail.com</td>
	
	  <td>goodtogo</td>
	 
	  <td>5708 Bullard Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Southwell</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 8:00:41 PM
	</td>

</tr><TR>

		<td><b>Joss </b></td>
		<td><b>Umlas</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>185</td>
	
	  <td>stardollface@gmail.com</td>
	
	  <td>JossLev66</td>
	 
	  <td>7685 Northcross Dr.</td>
	 
	  <td>#503</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>213.948.1363</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 7:03:44 PM
	</td>

</tr><TR>

		<td><b>Carter </b></td>
		<td><b>Utkov</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>55</td>
	
	  <td>cutkov@austin.rr.com</td>
	
	  <td>Moralestx1</td>
	 
	  <td>4027 Westlake Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-466-0612</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Hester</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 7:48:04 PM
	</td>

</tr><TR>

		<td><b>Elia </b></td>
		<td><b>Vaclav</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>110</td>
	
	  <td>eliavaclav@gmail.com</td>
	
	  <td>bookspring1</td>
	 
	  <td>1610 Waterston Ave #14</td>
	 
	  <td></td>
	 
	  <td>Austin TX</td>
	 
	  <td>tx</td>
	 
	  <td>78703</td>
	 
	  <td>5127626415</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Miars</td><td>2</td><td></td><td></td>
	<td>
	 1/24/2013 2:44:32 PM
	</td>

</tr><TR>

		<td><b>Kai </b></td>
		<td><b>Valadez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>kwill3805@sbcglobal.net</td>
	
	  <td>Rascal101</td>
	 
	  <td>6112 B Bullard Austin Tx</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>512 453-8101</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Deatley</td><td>5</td><td></td><td></td>
	<td>
	 1/29/2013 8:48:20 PM
	</td>

</tr><TR>

		<td><b>raul </b></td>
		<td><b>valdes</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>raulvaldes987@gmail.com</td>
	
	  <td>R2032213V</td>
	 
	  <td>911 bret ln</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78721</td>
	 
	  <td>512-939-1582</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>shackelford</td><td>8</td><td></td><td></td>
	<td>
	 2/4/2013 11:05:59 AM
	</td>

</tr><TR>

		<td><b>Jackson L. </b></td>
		<td><b>Van Sciver</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>130</td>
	
	  <td>mary-megs@hotmail.com</td>
	
	  <td>Sister7</td>
	 
	  <td>8704 Samuel Bishop Drive</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78736</td>
	 
	  <td>5124133396</td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Friedman</td><td>K</td><td></td><td></td>
	<td>
	 1/24/2013 6:35:55 PM
	</td>

</tr><TR>

		<td><b>Madeleine </b></td>
		<td><b>Van Slyke</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>20</td>
	
	  <td>laura@vanslyke.net</td>
	
	  <td>blue42</td>
	 
	  <td>1519 W. 30th</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Sharpe</td><td>1</td><td></td><td></td>
	<td>
	 2/3/2013 9:38:17 PM
	</td>

</tr><TR>

		<td><b>Manuela </b></td>
		<td><b>Vega</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mv89031@eanesisd.net</td>
	
	  <td>manuelavega</td>
	 
	  <td>3204 aztec fall cv</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>(512) 328-9251</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mc.Grath</td><td>8</td><td></td><td></td>
	<td>
	 2/11/2013 12:58:22 AM
	</td>

</tr><TR>

		<td><b>Nina </b></td>
		<td><b>Velacheri</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>ninavelacheri@gmail.com</td>
	
	  <td>chito</td>
	 
	  <td>10505 Prezia dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78733</td>
	 
	  <td>5122124599</td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Lawrence</td><td>3</td><td></td><td></td>
	<td>
	 2/10/2013 7:35:35 PM
	</td>

</tr><TR>

		<td><b>Nitya </b></td>
		<td><b>Vergis</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>nancy.mathew@gmail.com</td>
	
	  <td>n1tyan1sh</td>
	 
	  <td>6037 Kelsing Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78735</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Ward</td><td>1</td><td></td><td></td>
	<td>
	 2/3/2013 1:42:10 PM
	</td>

</tr><TR>

		<td><b>Maya </b></td>
		<td><b>Vit</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>180</td>
	
	  <td>bryony@underconsideration.com</td>
	
	  <td>04272007</td>
	 
	  <td>5618 Shoalwood Ave</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78756</td>
	 
	  <td>3472670838</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Greer</td><td>K</td><td></td><td></td>
	<td>
	 2/5/2013 11:00:37 AM
	</td>

</tr><TR>

		<td><b>Sophie </b></td>
		<td><b>Wales</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>rwales@gmail.com</td>
	
	  <td>puppies</td>
	 
	  <td>1603 Briarcliff Blvd</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Absher</td><td>2</td><td></td><td></td>
	<td>
	 2/4/2013 6:30:35 PM
	</td>

</tr><TR>

		<td><b>Jacob </b></td>
		<td><b>Walton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>190</td>
	
	  <td>Amyelisewalton@yahoo.com</td>
	
	  <td>plashigl</td>
	 
	  <td>3501 Native Dancer Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Hester</td><td>K</td><td></td><td></td>
	<td>
	 2/5/2013 8:01:21 PM
	</td>

</tr><TR>

		<td><b>Lucas </b></td>
		<td><b>Walton</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>160</td>
	
	  <td>Amyelisewalton@yahoo.com</td>
	
	  <td>plashigl</td>
	 
	  <td>3501 Native Dancer Cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Buffkin</td><td>1</td><td></td><td></td>
	<td>
	 2/5/2013 8:13:48 PM
	</td>

</tr><TR>

		<td><b>Haley </b></td>
		<td><b>warner</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>Haley.Warner.99@gmail.com</td>
	
	  <td>haley1014</td>
	 
	  <td>2017 real catorce</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5127053057</td>

	<!-- this is where the custom fields go -->
		 <td>West Ridge Middle School</td><td>Miller</td><td>7</td><td></td><td></td>
	<td>
	 2/7/2013 10:17:30 PM
	</td>

</tr><TR>

		<td><b>Mary Charlotte  </b></td>
		<td><b>Warner</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>cissywarner@gmail.com</td>
	
	  <td>piglet</td>
	 
	  <td>PO Box 5246</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78763</td>
	 
	  <td>512-476-4047</td>

	<!-- this is where the custom fields go -->
		 <td>Casis Elementary</td><td>Rains</td><td>3</td><td></td><td></td>
	<td>
	 1/28/2013 8:42:49 PM
	</td>

</tr><TR>

		<td><b>Johanna </b></td>
		<td><b>Watters</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>julieholdenrealtor@gmail.com</td>
	
	  <td>majado</td>
	 
	  <td>4320 Shadow Oak Ln</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Krost</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 10:46:55 AM
	</td>

</tr><TR>

		<td><b>Zoe </b></td>
		<td><b>Webb</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Zw28529@eanesisd.net</td>
	
	  <td>zoezoezoezoe</td>
	 
	  <td>211 WestHaven Drive</td>
	 
	  <td>211 WestHaven Drive</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>5128265888</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:04:46 PM
	</td>

</tr><TR>

		<td><b>Jessica </b></td>
		<td><b>Weegar</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>125</td>
	
	  <td>laurenpavlow@msn.com</td>
	
	  <td>jessereads</td>
	 
	  <td>9706 Sorrento Ct.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78759</td>
	 
	  <td>512-502-9419</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Elementary</td><td>Shaver</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 10:10:52 AM
	</td>

</tr><TR>

		<td><b>Scout </b></td>
		<td><b>Weeks</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>270</td>
	
	  <td>scoutweeks@gmail.com</td>
	
	  <td>cedarsrocks!</td>
	 
	  <td>4200 Cortina Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78749</td>
	 
	  <td>5129688294</td>

	<!-- this is where the custom fields go -->
		 <td>Cedars Montessori</td><td>romig</td><td>4</td><td></td><td></td>
	<td>
	 1/27/2013 3:40:58 PM
	</td>

</tr><TR>

		<td><b>Josh </b></td>
		<td><b>Welsh</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Jw85211@eanesisd.net</td>
	
	  <td>rocky1</td>
	 
	  <td>1300 Walsh tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5129094761</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:30:49 AM
	</td>

</tr><TR>

		<td><b>Morgan </b></td>
		<td><b>Wendlandt</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>MW86807@eanesisd.net</td>
	
	  <td>hcmsgiaun</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>(512) 477-6403</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 4:45:27 PM
	</td>

</tr><TR>

		<td><b>Hadley </b></td>
		<td><b>Wenk</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>lindsaywenk@gmail.com</td>
	
	  <td>Mallory05</td>
	 
	  <td>3110 Honey Tree Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Sauls</td><td>K</td><td></td><td></td>
	<td>
	 1/27/2013 9:00:52 PM
	</td>

</tr><TR>

		<td><b>Mallory </b></td>
		<td><b>Wenk</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>lindsaywenk@gmail.com</td>
	
	  <td>Mallory05</td>
	 
	  <td>3110 Honey Tree Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Moy</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 8:59:09 PM
	</td>

</tr><TR>

		<td><b>Katherine </b></td>
		<td><b>White</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>shelleywsells@gmail.com</td>
	
	  <td>peeker</td>
	 
	  <td>4500 ABELIA DR</td>
	 
	  <td></td>
	 
	  <td>AUSTIN</td>
	 
	  <td>TX</td>
	 
	  <td>78727</td>
	 
	  <td>512 913 3108</td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Brocato</td><td>1</td><td></td><td></td>
	<td>
	 2/5/2013 12:57:20 PM
	</td>

</tr><TR>

		<td><b>William  </b></td>
		<td><b>Whitfill</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>10</td>
	
	  <td>Wwpyro@gmail.com</td>
	
	  <td>will123</td>
	 
	  <td>4604 hero court</td>
	 
	  <td>4604 hero court</td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78735</td>
	 
	  <td>5127610628</td>

	<!-- this is where the custom fields go -->
		 <td>O. Henry Middle School</td><td>McMillan </td><td>8</td><td></td><td></td>
	<td>
	 1/29/2013 9:11:11 AM
	</td>

</tr><TR>

		<td><b>Helena </b></td>
		<td><b>Wiese</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>225</td>
	
	  <td>hollywiese+helena@gmail.com</td>
	
	  <td>w5HyPG6GTT</td>
	 
	  <td>4209</td>
	 
	  <td>Sinclair Ave</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78756</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Andrews</td><td>3</td><td></td><td></td>
	<td>
	 1/27/2013 7:56:48 PM
	</td>

</tr><TR>

		<td><b>Della </b></td>
		<td><b>Wilbratte</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>275</td>
	
	  <td>brookewilbratte@gmail.com</td>
	
	  <td>ollie2</td>
	 
	  <td>2501 Berenson Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5125274773</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Smith</td><td>2</td><td></td><td></td>
	<td>
	 1/28/2013 10:20:22 PM
	</td>

</tr><TR>

		<td><b>Elena </b></td>
		<td><b>Wilfong</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>EW29070@eanesisd.net</td>
	
	  <td>hcms2u5xs</td>
	 
	  <td>303 Reveille Road  </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>512-732-2828</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 1:49:04 PM
	</td>

</tr><TR>

		<td><b>Miller </b></td>
		<td><b>Williams</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jw28506@eanesisd.net</td>
	
	  <td>Mwilliams</td>
	 
	  <td>1300 Verdant Way</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath </td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 9:32:14 AM
	</td>

</tr><TR>

		<td><b>Peter </b></td>
		<td><b>Williams</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>phwms2003@yahoo.com</td>
	
	  <td>iloveviolin</td>
	 
	  <td>1505 Allen Road Unit C</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Cedar Creek Elementary</td><td>Freidman</td><td>K</td><td></td><td></td>
	<td>
	 1/28/2013 6:22:07 PM
	</td>

</tr><TR>

		<td><b>Anna </b></td>
		<td><b>Wilson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>allisonpwilson@yahoo.com</td>
	
	  <td>1122002</td>
	 
	  <td>10212 amwell cv</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>5122639777</td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Darling</td><td>5</td><td></td><td></td>
	<td>
	 1/27/2013 5:56:38 PM
	</td>

</tr><TR>

		<td><b>Matthew </b></td>
		<td><b>Wilson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>ossianic@yahoo.com</td>
	
	  <td>frankie</td>
	 
	  <td>4111 Idlewild</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Cavazos</td><td>1</td><td></td><td></td>
	<td>
	 2/9/2013 10:13:16 AM
	</td>

</tr><TR>

		<td><b>Sophia </b></td>
		<td><b>Wilson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>allisonpwilson@yahoo.com</td>
	
	  <td>5312005</td>
	 
	  <td>10212 amwell cv</td>
	 
	  <td></td>
	 
	  <td>austin</td>
	 
	  <td>tx</td>
	 
	  <td>78733</td>
	 
	  <td>5122639777</td>

	<!-- this is where the custom fields go -->
		 <td>Valley View Elementary</td><td>Tucci</td><td>2</td><td></td><td></td>
	<td>
	 1/27/2013 5:44:42 PM
	</td>

</tr><TR>

		<td><b>Sorcha  </b></td>
		<td><b>Wilson</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>25</td>
	
	  <td>ossianic@yahoo.com</td>
	
	  <td>frankie</td>
	 
	  <td>4111 Idlewild</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>78731</td>

	<!-- this is where the custom fields go -->
		 <td>Bryker Woods Elementary</td><td>Holloway</td><td>3</td><td></td><td></td>
	<td>
	 2/9/2013 10:09:50 AM
	</td>

</tr><TR>

		<td><b>Amelie </b></td>
		<td><b>Wolcott</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>christy@soy-delites.com</td>
	
	  <td>sadie1</td>
	 
	  <td>5711 Duval St</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78752-4517</td>
	 
	  <td>512.451.1217</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Allin</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 5:56:10 PM
	</td>

</tr><TR>

		<td><b>John </b></td>
		<td><b>Wolff</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>johnathon@promarksolutions.net</td>
	
	  <td>readathon123</td>
	 
	  <td>5300 Arbutus CV</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>7027550688</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Stone</td><td>1</td><td></td><td></td>
	<td>
	 2/1/2013 8:18:46 AM
	</td>

</tr><TR>

		<td><b>john </b></td>
		<td><b>Wolff</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mwolff@promarksolutions.net</td>
	
	  <td>12345john</td>
	 
	  <td>5300 arbutus cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td>702 755 0618</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>stone</td><td>1</td><td></td><td></td>
	<td>
	 2/1/2013 3:57:51 PM
	</td>

</tr><TR>

		<td><b>Julianna </b></td>
		<td><b>Wolff</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>50</td>
	
	  <td>julianna@promarksolutions.net</td>
	
	  <td>readathon123</td>
	 
	  <td>5300 Arbutus CV</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>7027550688</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>Guthrie</td><td>1</td><td></td><td></td>
	<td>
	 2/1/2013 8:20:52 AM
	</td>

</tr><TR>

		<td><b>julianna </b></td>
		<td><b>Wolff</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>mwolff@promarksolutions.net</td>
	
	  <td>12345j</td>
	 
	  <td>5300 arbutus cove</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Te</td>
	 
	  <td>78746</td>
	 
	  <td>702 755 0618</td>

	<!-- this is where the custom fields go -->
		 <td>Bridge Point Elementary</td><td>guthrie</td><td>1</td><td></td><td></td>
	<td>
	 2/1/2013 3:48:24 PM
	</td>

</tr><TR>

		<td><b>Jessica </b></td>
		<td><b>Wood</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jw28782@eanesisd.net</td>
	
	  <td>hcmsozihv</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5123477625</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 12:06:49 PM
	</td>

</tr><TR>

		<td><b>Abbey </b></td>
		<td><b>Woodard</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Aw28655@eanesisd.net</td>
	
	  <td>hcms8vkb6</td>
	 
	  <td>307 Westwood Terrace</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/25/2013 3:45:02 PM
	</td>

</tr><TR>

		<td><b>Aiden </b></td>
		<td><b>Wynn</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>75</td>
	
	  <td>rosemarywynn@sbcglobal.net</td>
	
	  <td>misty</td>
	 
	  <td>1402 W. 13th St</td>
	 
	  <td>Unit A</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78703</td>
	 
	  <td>512-657-9543</td>

	<!-- this is where the custom fields go -->
		 <td>Mathews Elementary</td><td>Fisher</td><td>1</td><td></td><td></td>
	<td>
	 1/24/2013 3:25:43 PM
	</td>

</tr><TR>

		<td><b>Jesse  </b></td>
		<td><b>Yahiaoui</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>jy89367@eanesisd.net</td>
	
	  <td>Hcms7cjw</td>
	 
	  <td>1300 Walsh Tarlton </td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78746</td>
	 
	  <td>408-823-5002</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:13:16 PM
	</td>

</tr><TR>

		<td><b>Chloe </b></td>
		<td><b>Yelkin</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>CY28719@eanesisd.net</td>
	
	  <td>hcmsqpqls</td>
	 
	  <td>1300 Walsh Tarlton</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:16:54 PM
	</td>

</tr><TR>

		<td><b>Jake </b></td>
		<td><b>Yepez</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>220</td>
	
	  <td>carlie2saints@gmail.com</td>
	
	  <td>L1ttleGuy</td>
	 
	  <td>1704 Ridgemont Dr</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78723</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Barnes</td><td>2</td><td></td><td></td>
	<td>
	 2/5/2013 5:11:57 PM
	</td>

</tr><TR>

		<td><b>Adelle </b></td>
		<td><b>Yong</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>joelynyyd@yahoo.com</td>
	
	  <td>adelle</td>
	 
	  <td>1800 Heliotrope Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Dreyer</td><td>2</td><td></td><td></td>
	<td>
	 1/24/2013 5:31:39 PM
	</td>

</tr><TR>

		<td><b>Eunice </b></td>
		<td><b>Yong</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>joelynyyd@yahoo.com</td>
	
	  <td>eunice</td>
	 
	  <td>1800 Heliotrope Ct</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78733</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>Barton Creek Elementary</td><td>Thomas</td><td>K</td><td></td><td></td>
	<td>
	 1/24/2013 5:26:57 PM
	</td>

</tr><TR>

		<td><b>Rachel </b></td>
		<td><b>Yost</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>100</td>
	
	  <td>chris.yost@mac.com</td>
	
	  <td>g0gators</td>
	 
	  <td>1900 Frazier Ave.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Brewer</td><td>1</td><td></td><td></td>
	<td>
	 2/10/2013 9:45:19 PM
	</td>

</tr><TR>

		<td><b>Sara </b></td>
		<td><b>Yost</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>250</td>
	
	  <td>chris.yost@me.com</td>
	
	  <td>SPY@2002</td>
	 
	  <td>1900 Frazier Ave.</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78704</td>
	 
	  <td>512-443-8575</td>

	<!-- this is where the custom fields go -->
		 <td>The Girls School of Austin</td><td>Ms. Maher</td><td>5</td><td></td><td></td>
	<td>
	 1/28/2013 7:06:50 PM
	</td>

</tr><TR>

		<td><b>Alex </b></td>
		<td><b>Young</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Ay86334@eanesisd.net</td>
	
	  <td>hcmszulba</td>
	 
	  <td>3701stevenson ave</td>
	 
	  <td>4517Rio Robles </td>
	 
	  <td>Austin</td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5127997841</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>McGrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 3:09:43 PM
	</td>

</tr><TR>

		<td><b>Zeyu </b></td>
		<td><b>Zhang</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>zeyuhappy@gmail.com</td>
	
	  <td>forcezlf</td>
	 
	  <td>3517 N Hills Dr</td>
	 
	  <td>Apt # T102</td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78731</td>
	 
	  <td>858-729-3410</td>

	<!-- this is where the custom fields go -->
		 <td>Doss Elementary</td><td>Folts</td><td>1</td><td></td><td></td>
	<td>
	 1/27/2013 5:20:17 PM
	</td>

</tr><TR>

		<td><b>Anne </b></td>
		<td><b>Zimmermann</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>zimmhomework@gmail.com</td>
	
	  <td>guitar</td>
	 
	  <td>7000 Greenshores Dr</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>tx</td>
	 
	  <td>78730</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Knorr</td><td>2</td><td></td><td></td>
	<td>
	 1/25/2013 7:12:28 PM
	</td>

</tr><TR>

		<td><b>Eva </b></td>
		<td><b>Zimmermann</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>zimmhomework@gmail.com</td>
	
	  <td>dance</td>
	 
	  <td>7000 Greenshores Dr</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>tx</td>
	 
	  <td>78730</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Covington</td><td>3</td><td></td><td></td>
	<td>
	 1/25/2013 7:14:40 PM
	</td>

</tr><TR>

		<td><b>Luke </b></td>
		<td><b>Zimmermann</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>zimmhomework@gmail.com</td>
	
	  <td>boyscout</td>
	 
	  <td>7000 Greenshores Dr</td>
	 
	  <td></td>
	 
	  <td>Austin </td>
	 
	  <td>tx</td>
	 
	  <td>78730</td>
	 
	  <td></td>

	<!-- this is where the custom fields go -->
		 <td>St. Theresas Catholic School</td><td>Moore</td><td>2</td><td></td><td></td>
	<td>
	 1/25/2013 7:16:25 PM
	</td>

</tr><TR>

		<td><b>Hannah  </b></td>
		<td><b>Zuniga</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>60</td>
	
	  <td>mison.zuniga@gmail.com</td>
	
	  <td>cave0101</td>
	 
	  <td>3309A Foster Lane</td>
	 
	  <td></td>
	 
	  <td>Austin</td>
	 
	  <td>TX</td>
	 
	  <td>78757</td>
	 
	  <td>5123586329</td>

	<!-- this is where the custom fields go -->
		 <td>Gullett Elementary</td><td>Richardson</td><td>4</td><td></td><td></td>
	<td>
	 1/29/2013 1:29:55 AM
	</td>

</tr><TR>

		<td><b>Claire </b></td>
		<td><b>Zurovec</b></td>
		
		<td><span >Live</span></td>

		<td></td>
	 
	  <td>Individual participant</td>
	
		<td>0</td>
	
	  <td>Cz28507@gmail.com</td>
	
	  <td>hcmscca2012</td>
	 
	  <td>1900 mistywood Dr</td>
	 
	  <td>1900 mistywood dr</td>
	 
	  <td>Austin </td>
	 
	  <td>Tx</td>
	 
	  <td>78746</td>
	 
	  <td>5125689559</td>

	<!-- this is where the custom fields go -->
		 <td>Hill Country Middle School</td><td>Mcgrath</td><td>8</td><td></td><td></td>
	<td>
	 1/24/2013 11:55:55 AM
	</td>

</tr>
</body>
</html>"		
;  
        }
    }
}
