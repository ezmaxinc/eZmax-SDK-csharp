/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.42
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using eZmaxApi.Client;
using eZmaxApi.Api;
using eZmaxApi.Model;

namespace eZmaxApi.Test
{
    /// <summary>
    ///  Class for testing ObjectApikeyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectApikeyApiTests
    {
        private ObjectApikeyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectApikeyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectApikeyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObjectApikeyApi
            //Assert.IsInstanceOf(typeof(ObjectApikeyApi), instance);
        }

        
        /// <summary>
        /// Test ApikeyCreateObjectV1
        /// </summary>
        [Test]
        public void ApikeyCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<ApikeyCreateObjectV1Request> apikeyCreateObjectV1Request = null;
            //var response = instance.ApikeyCreateObjectV1(apikeyCreateObjectV1Request);
            //Assert.IsInstanceOf(typeof(ApikeyCreateObjectV1Response), response, "response is ApikeyCreateObjectV1Response");
        }
        
    }

}
