﻿using System.Collections.Generic;
using Dev2.Communication;
using Dev2.Runtime.ServiceModel.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Dev2.Tests.Runtime.Plugins
{
    [TestClass]
    public class ServiceConstructorListTests
    {
        [TestMethod, DeploymentItem("EnableDocker.txt")]
        [Owner("Nkosinathi Sangweni")]
        public void ToString_GivenIsNotNull_ShouldJsonFormat()
        {
            //---------------Set up test pack-------------------
            var constructorList = new ServiceConstructorList();
            //---------------Assert Precondition----------------
            Assert.IsNotNull(constructorList);
            //---------------Execute Test ----------------------
            Assert.IsInstanceOfType(constructorList, typeof(List<ServiceConstructor>));
            //---------------Test Result -----------------------
            var s = constructorList.ToString();
            var dev2JsonSerializer = new Dev2JsonSerializer();
            var serialize = dev2JsonSerializer.Serialize(s);
            Assert.IsTrue(!string.IsNullOrEmpty(serialize));
        }
    }
}
