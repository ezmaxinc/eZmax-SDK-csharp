/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.37
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
    ///  Class for testing ObjectEzsignfolderApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignfolderApiTests
    {
        private ObjectEzsignfolderApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectEzsignfolderApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectEzsignfolderApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObjectEzsignfolderApi
            //Assert.IsInstanceOf(typeof(ObjectEzsignfolderApi), instance);
        }

        
        /// <summary>
        /// Test EzsignfolderCreateObjectV1
        /// </summary>
        [Test]
        public void EzsignfolderCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsignfolderCreateObjectV1Request> ezsignfolderCreateObjectV1Request = null;
            //var response = instance.EzsignfolderCreateObjectV1(ezsignfolderCreateObjectV1Request);
            //Assert.IsInstanceOf(typeof(EzsignfolderCreateObjectV1Response), response, "response is EzsignfolderCreateObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsignfolderDeleteObjectV1
        /// </summary>
        [Test]
        public void EzsignfolderDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //var response = instance.EzsignfolderDeleteObjectV1(pkiEzsignfolderID);
            //Assert.IsInstanceOf(typeof(EzsignfolderDeleteObjectV1Response), response, "response is EzsignfolderDeleteObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsignfolderGetChildrenV1
        /// </summary>
        [Test]
        public void EzsignfolderGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //instance.EzsignfolderGetChildrenV1(pkiEzsignfolderID);
            
        }
        
        /// <summary>
        /// Test EzsignfolderGetObjectV1
        /// </summary>
        [Test]
        public void EzsignfolderGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //var response = instance.EzsignfolderGetObjectV1(pkiEzsignfolderID);
            //Assert.IsInstanceOf(typeof(EzsignfolderGetObjectV1Response), response, "response is EzsignfolderGetObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsignfolderSendV1
        /// </summary>
        [Test]
        public void EzsignfolderSendV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfolderID = null;
            //EzsignfolderSendV1Request ezsignfolderSendV1Request = null;
            //var response = instance.EzsignfolderSendV1(pkiEzsignfolderID, ezsignfolderSendV1Request);
            //Assert.IsInstanceOf(typeof(EzsignfolderSendV1Response), response, "response is EzsignfolderSendV1Response");
        }
        
    }

}
