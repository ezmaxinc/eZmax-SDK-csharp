/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.20
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
    ///  Class for testing ObjectEzsignfoldersignerassociationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ObjectEzsignfoldersignerassociationApiTests
    {
        private ObjectEzsignfoldersignerassociationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ObjectEzsignfoldersignerassociationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ObjectEzsignfoldersignerassociationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ObjectEzsignfoldersignerassociationApi
            //Assert.IsInstanceOf(typeof(ObjectEzsignfoldersignerassociationApi), instance);
        }

        
        /// <summary>
        /// Test EzsignfoldersignerassociationCreateObjectV1
        /// </summary>
        [Test]
        public void EzsignfoldersignerassociationCreateObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<EzsignfoldersignerassociationCreateObjectV1Request> ezsignfoldersignerassociationCreateObjectV1Request = null;
            //var response = instance.EzsignfoldersignerassociationCreateObjectV1(ezsignfoldersignerassociationCreateObjectV1Request);
            //Assert.IsInstanceOf(typeof(EzsignfoldersignerassociationCreateObjectV1Response), response, "response is EzsignfoldersignerassociationCreateObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsignfoldersignerassociationDeleteObjectV1
        /// </summary>
        [Test]
        public void EzsignfoldersignerassociationDeleteObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //var response = instance.EzsignfoldersignerassociationDeleteObjectV1(pkiEzsignfoldersignerassociationID);
            //Assert.IsInstanceOf(typeof(EzsignfoldersignerassociationDeleteObjectV1Response), response, "response is EzsignfoldersignerassociationDeleteObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsignfoldersignerassociationEditObjectV1
        /// </summary>
        [Test]
        public void EzsignfoldersignerassociationEditObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //EzsignfoldersignerassociationEditObjectV1Request ezsignfoldersignerassociationEditObjectV1Request = null;
            //var response = instance.EzsignfoldersignerassociationEditObjectV1(pkiEzsignfoldersignerassociationID, ezsignfoldersignerassociationEditObjectV1Request);
            //Assert.IsInstanceOf(typeof(EzsignfoldersignerassociationEditObjectV1Response), response, "response is EzsignfoldersignerassociationEditObjectV1Response");
        }
        
        /// <summary>
        /// Test EzsignfoldersignerassociationGetInPersonLoginUrlV1
        /// </summary>
        [Test]
        public void EzsignfoldersignerassociationGetInPersonLoginUrlV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //var response = instance.EzsignfoldersignerassociationGetInPersonLoginUrlV1(pkiEzsignfoldersignerassociationID);
            //Assert.IsInstanceOf(typeof(EzsignfoldersignerassociationGetInPersonLoginUrlV1Response), response, "response is EzsignfoldersignerassociationGetInPersonLoginUrlV1Response");
        }
        
        /// <summary>
        /// Test EzsignfoldersignerassociationGetObjectGetChildrenV1
        /// </summary>
        [Test]
        public void EzsignfoldersignerassociationGetObjectGetChildrenV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //instance.EzsignfoldersignerassociationGetObjectGetChildrenV1(pkiEzsignfoldersignerassociationID);
            
        }
        
        /// <summary>
        /// Test EzsignfoldersignerassociationGetObjectV1
        /// </summary>
        [Test]
        public void EzsignfoldersignerassociationGetObjectV1Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int pkiEzsignfoldersignerassociationID = null;
            //var response = instance.EzsignfoldersignerassociationGetObjectV1(pkiEzsignfoldersignerassociationID);
            //Assert.IsInstanceOf(typeof(EzsignfoldersignerassociationGetObjectV1Response), response, "response is EzsignfoldersignerassociationGetObjectV1Response");
        }
        
    }

}