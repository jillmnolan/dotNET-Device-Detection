﻿/* *********************************************************************
 * This Source Code Form is copyright of 51Degrees Mobile Experts Limited. 
 * Copyright © 2017 51Degrees Mobile Experts Limited, 5 Charlotte Close,
 * Caversham, Reading, Berkshire, United Kingdom RG4 7BY
 * 
 * This Source Code Form is the subject of the following patents and patent 
 * applications, owned by 51Degrees Mobile Experts Limited of 5 Charlotte
 * Close, Caversham, Reading, Berkshire, United Kingdom RG4 7BY: 
 * European Patent No. 2871816;
 * European Patent Application No. 17184134.9;
 * United States Patent Nos. 9,332,086 and 9,350,823; and
 * United States Patent Application No. 15/686,066.
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0.
 * 
 * If a copy of the MPL was not distributed with this file, You can obtain
 * one at http://mozilla.org/MPL/2.0/.
 * 
 * This Source Code Form is “Incompatible With Secondary Licenses”, as
 * defined by the Mozilla Public License, v. 2.0.
 * ********************************************************************* */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiftyOne.Foundation.Mobile.Detection.Factories;
using System.IO;

namespace FiftyOne.Tests.Integration.HttpHeaders.Enterprise
{
    [TestClass]
    public class V31Array : Combinations
    {
        protected override string DataFile
        {
            get { return Utils.GetDataFile(Constants.ENTERPRISE_PATTERN_V31); }
        }

        [TestInitialize()]
        public void CreateDataSet()
        {
            Utils.CheckFileExists(DataFile);
            _dataSet = StreamFactory.Create(File.ReadAllBytes(DataFile));
        }

        [TestMethod]
        public void EnterpriseV31Array_OperaMiniSamsung()
        {
            base.OperaMini_Samsung();
        }

        [TestMethod]
        public void EnterpriseV31Array_OperaMini_HTC()
        {
            base.OperaMini_HTC();
        }

        [TestMethod]
        public void EnterpriseV31Array_OperaMini_iPhone()
        {
            base.OperaMini_iPhone();
        }
    }
}
