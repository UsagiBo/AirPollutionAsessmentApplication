using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dissertation.Consume;
using System.Collections.Generic;
using Dissertation.DataModels;
// <copyright file="DataBaseReaderTest.GetDataBase.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace Dissertation.Consume.Tests
{
    public partial class DataBaseReaderTest
    {

[TestMethod]
[PexGeneratedBy(typeof(DataBaseReaderTest))]
[ExpectedException(typeof(NullReferenceException))]
public void GetDataBaseThrowsNullReferenceException809()
{
    List<AirData> list;
    DataBaseReader s0 = new DataBaseReader();
    list = this.GetDataBase(s0);
}
    }
}
