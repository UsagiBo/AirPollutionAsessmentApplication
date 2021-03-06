// <copyright file="AirDataViewModelTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using Dissertation.DataModels;
using Dissertation.Models;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dissertation.Models.Tests
{
    /// <summary>This class contains parameterized unit tests for AirDataViewModel</summary>
    [PexClass(typeof(AirDataViewModel))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class AirDataViewModelTest
    {
        /// <summary>Test stub for AirDataTables()</summary>
        [TestMethod]
        [PexMethod]
        public List<AirDataTable> AirDataTablesTest([PexAssumeUnderTest]AirDataViewModel target)
        {
            List<AirDataTable> result = target.AirDataTables(0);
            Assert.IsNotNull(result);
            return result;
            // TODO: add assertions to method AirDataViewModelTest.AirDataTablesTest(AirDataViewModel)
        }

        /// <summary>Test stub for AirDataMap()</summary>
        [TestMethod]
        [PexMethod]
        public AirDataMap AirDataMapTest([PexAssumeUnderTest]AirDataViewModel target)
        {
            AirDataMap result = target.AirDataMap();
            Assert.IsNotNull(result);
            return result;
            // TODO: add assertions to method AirDataViewModelTest.AirDataMapTest(AirDataViewModel)
        }
    }
}
