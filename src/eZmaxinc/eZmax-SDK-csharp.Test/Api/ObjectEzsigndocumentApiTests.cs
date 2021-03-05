/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.32
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
    ///  Class for testing ObjectEzsigndocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsigndocumentApiTests
    {
        private ObjectEzsigndocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectEzsigndocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectEzsigndocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObjectEzsigndocumentApi
            //Assert.IsInstanceOf(typeof(ObjectEzsigndocumentApi), instance);
        }

        
        /// <summary>
        /// Test EzsigndocumentApplyEzsigntemplateV1
        /// </summary>
        [Test]
        public void EzsigndocumentApplyEzsigntemplateV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //EzsigndocumentApplyEzsigntemplateV1Request ezsigndocumentApplyEzsigntemplateV1Request = null;
            //var response = instance.EzsigndocumentApplyEzsigntemplateV1(pkiEzsigndocumentID, ezsigndocumentApplyEzsigntemplateV1Request);
            //Assert.IsInstanceOf(typeof(EzsigndocumentApplyEzsigntemplateV1Response), response, "response is EzsigndocumentApplyEzsigntemplateV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentCreateObjectV1
        /// </summary>
        [Test]
        public void EzsigndocumentCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsigndocumentCreateObjectV1Request> ezsigndocumentCreateObjectV1Request = null;
            //var response = instance.EzsigndocumentCreateObjectV1(ezsigndocumentCreateObjectV1Request);
            //Assert.IsInstanceOf(typeof(EzsigndocumentCreateObjectV1Response), response, "response is EzsigndocumentCreateObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentDeleteObjectV1
        /// </summary>
        [Test]
        public void EzsigndocumentDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //var response = instance.EzsigndocumentDeleteObjectV1(pkiEzsigndocumentID);
            //Assert.IsInstanceOf(typeof(EzsigndocumentDeleteObjectV1Response), response, "response is EzsigndocumentDeleteObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentGetChildrenV1
        /// </summary>
        [Test]
        public void EzsigndocumentGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //instance.EzsigndocumentGetChildrenV1(pkiEzsigndocumentID);
            
        }
        
        /// <summary>
        /// Test EzsigndocumentGetDownloadUrlV1
        /// </summary>
        [Test]
        public void EzsigndocumentGetDownloadUrlV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //string eDocumentType = null;
            //var response = instance.EzsigndocumentGetDownloadUrlV1(pkiEzsigndocumentID, eDocumentType);
            //Assert.IsInstanceOf(typeof(EzsigndocumentGetDownloadUrlV1Response), response, "response is EzsigndocumentGetDownloadUrlV1Response");
        }
        
        /// <summary>
        /// Test EzsigndocumentGetObjectV1
        /// </summary>
        [Test]
        public void EzsigndocumentGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsigndocumentID = null;
            //var response = instance.EzsigndocumentGetObjectV1(pkiEzsigndocumentID);
            //Assert.IsInstanceOf(typeof(EzsigndocumentGetObjectV1Response), response, "response is EzsigndocumentGetObjectV1Response");
        }
        
    }

}
