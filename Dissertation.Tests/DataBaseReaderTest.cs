using System.Collections.Generic;
using Dissertation.DataModels;
// <copyright file="DataBaseReaderTest.cs">Copyright ©  2016</copyright>

using System;
using Dissertation.Consume;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dissertation.Consume.Tests
{
    [TestClass]
    [PexClass(typeof(DataBaseReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DataBaseReaderTest
    {

        [PexMethod]
        [PexAllowedException(typeof(NullReferenceException))]
        internal List<AirData> GetDataBase([PexAssumeUnderTest]DataBaseReader target)
        {
            List<AirData> result = target.GetDataBase(0);
            return result;
            // TODO: add assertions to method DataBaseReaderTest.GetDataBase(DataBaseReader)
        }
    }
}
