/* 
 * Swagger breached emails
 *
 * This is a sample server breachedemails server.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing BreachedemailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestClass]
    public class BreachedemailApiTests
    {
        private BreachedemailApi instance;
        private string basePath = "http://localhost:50352/v2/";

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        public void Init()
        {
            
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BreachedemailApi
        /// </summary>
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BreachedemailApi
            //Assert.IsInstanceOfType(typeof(BreachedemailApi), instance, "instance is a BreachedemailApi");
        }


        /// <summary>
        /// Test Add
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            Configuration c = new Configuration();
            c.BasePath = basePath;
            instance = new BreachedemailApi(c);
            // TODO uncomment below to test the method and replace null with proper value
            Breachedemail body = new Breachedemail("janez@test.si");
            int r = instance.Add(body);
            Assert.AreEqual(r, 200);
            
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [TestMethod]
        public void DeleteTest()
        {
            Configuration c = new Configuration();
            c.BasePath = basePath;
            instance = new BreachedemailApi(c);
            // TODO uncomment below to test the method and replace null with proper value
            string breachedemail = "janez@test.si";
            int r = instance.Delete(breachedemail);
            Assert.AreEqual(r, 200);

        }

        /// <summary>
        /// Test Get
        /// </summary>
        [TestMethod]
        public void GetTest()
        {
            Configuration c = new Configuration();
            c.BasePath = basePath;
            instance = new BreachedemailApi(c);
            // TODO uncomment below to test the method and replace null with proper value
            string breachedemail = "janez@test.si";
            int r = instance.Get(breachedemail);
            Assert.AreEqual(r, 404);


        }

    }

}
