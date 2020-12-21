/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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

using eZmaxinc/eZmax-SDK-csharp.Client;
using eZmaxinc/eZmax-SDK-csharp.Api;
using eZmaxinc/eZmax-SDK-csharp.Model;

namespace eZmaxinc/eZmax-SDK-csharp.Test
{
    /// <summary>
    ///  Class for testing ObjectFranchiseofficeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectFranchiseofficeApiTests
    {
        private ObjectFranchiseofficeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectFranchiseofficeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectFranchiseofficeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObjectFranchiseofficeApi
            //Assert.IsInstanceOf(typeof(ObjectFranchiseofficeApi), instance);
        }

        
        /// <summary>
        /// Test FranchiseofficeGetAutocompleteV1
        /// </summary>
        [Test]
        public void FranchiseofficeGetAutocompleteV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sSelector = null;
            //string sQuery = null;
            //var response = instance.FranchiseofficeGetAutocompleteV1(sSelector, sQuery);
            //Assert.IsInstanceOf(typeof(CommonGetAutocompleteV1Response), response, "response is CommonGetAutocompleteV1Response");
        }
        
    }

}
