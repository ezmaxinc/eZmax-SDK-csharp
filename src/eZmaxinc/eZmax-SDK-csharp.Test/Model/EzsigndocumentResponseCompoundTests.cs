/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.20
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using eZmaxinc/eZmax-SDK-csharp.Api;
using eZmaxinc/eZmax-SDK-csharp.Model;
using eZmaxinc/eZmax-SDK-csharp.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace eZmaxinc/eZmax-SDK-csharp.Test
{
    /// <summary>
    ///  Class for testing EzsigndocumentResponseCompound
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EzsigndocumentResponseCompoundTests
    {
        // TODO uncomment below to declare an instance variable for EzsigndocumentResponseCompound
        //private EzsigndocumentResponseCompound instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EzsigndocumentResponseCompound
            //instance = new EzsigndocumentResponseCompound();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EzsigndocumentResponseCompound
        /// </summary>
        [Test]
        public void EzsigndocumentResponseCompoundInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" EzsigndocumentResponseCompound
            //Assert.IsInstanceOf(typeof(EzsigndocumentResponseCompound), instance);
        }


        /// <summary>
        /// Test the property 'fkiEzsignfolderID'
        /// </summary>
        [Test]
        public void fkiEzsignfolderIDTest()
        {
            // TODO unit test for the property 'fkiEzsignfolderID'
        }
        /// <summary>
        /// Test the property 'dtEzsigndocumentDuedate'
        /// </summary>
        [Test]
        public void dtEzsigndocumentDuedateTest()
        {
            // TODO unit test for the property 'dtEzsigndocumentDuedate'
        }
        /// <summary>
        /// Test the property 'fkiLanguageID'
        /// </summary>
        [Test]
        public void fkiLanguageIDTest()
        {
            // TODO unit test for the property 'fkiLanguageID'
        }
        /// <summary>
        /// Test the property 'sEzsigndocumentFilename'
        /// </summary>
        [Test]
        public void sEzsigndocumentFilenameTest()
        {
            // TODO unit test for the property 'sEzsigndocumentFilename'
        }
        /// <summary>
        /// Test the property 'sEzsigndocumentName'
        /// </summary>
        [Test]
        public void sEzsigndocumentNameTest()
        {
            // TODO unit test for the property 'sEzsigndocumentName'
        }
        /// <summary>
        /// Test the property 'pkiEzsigndocumentID'
        /// </summary>
        [Test]
        public void pkiEzsigndocumentIDTest()
        {
            // TODO unit test for the property 'pkiEzsigndocumentID'
        }
        /// <summary>
        /// Test the property 'eEzsigndocumentStep'
        /// </summary>
        [Test]
        public void eEzsigndocumentStepTest()
        {
            // TODO unit test for the property 'eEzsigndocumentStep'
        }
        /// <summary>
        /// Test the property 'dtEzsigndocumentFirstsend'
        /// </summary>
        [Test]
        public void dtEzsigndocumentFirstsendTest()
        {
            // TODO unit test for the property 'dtEzsigndocumentFirstsend'
        }
        /// <summary>
        /// Test the property 'dtEzsigndocumentLastsend'
        /// </summary>
        [Test]
        public void dtEzsigndocumentLastsendTest()
        {
            // TODO unit test for the property 'dtEzsigndocumentLastsend'
        }
        /// <summary>
        /// Test the property 'iEzsigndocumentOrder'
        /// </summary>
        [Test]
        public void iEzsigndocumentOrderTest()
        {
            // TODO unit test for the property 'iEzsigndocumentOrder'
        }
        /// <summary>
        /// Test the property 'iEzsigndocumentPagetotal'
        /// </summary>
        [Test]
        public void iEzsigndocumentPagetotalTest()
        {
            // TODO unit test for the property 'iEzsigndocumentPagetotal'
        }
        /// <summary>
        /// Test the property 'iEzsigndocumentSignaturesigned'
        /// </summary>
        [Test]
        public void iEzsigndocumentSignaturesignedTest()
        {
            // TODO unit test for the property 'iEzsigndocumentSignaturesigned'
        }
        /// <summary>
        /// Test the property 'iEzsigndocumentSignaturetotal'
        /// </summary>
        [Test]
        public void iEzsigndocumentSignaturetotalTest()
        {
            // TODO unit test for the property 'iEzsigndocumentSignaturetotal'
        }
        /// <summary>
        /// Test the property 'sEzsigndocumentMD5initial'
        /// </summary>
        [Test]
        public void sEzsigndocumentMD5initialTest()
        {
            // TODO unit test for the property 'sEzsigndocumentMD5initial'
        }
        /// <summary>
        /// Test the property 'sEzsigndocumentMD5signed'
        /// </summary>
        [Test]
        public void sEzsigndocumentMD5signedTest()
        {
            // TODO unit test for the property 'sEzsigndocumentMD5signed'
        }
        /// <summary>
        /// Test the property 'fkiUserIDCreated'
        /// </summary>
        [Test]
        public void fkiUserIDCreatedTest()
        {
            // TODO unit test for the property 'fkiUserIDCreated'
        }
        /// <summary>
        /// Test the property 'fkiUserIDModified'
        /// </summary>
        [Test]
        public void fkiUserIDModifiedTest()
        {
            // TODO unit test for the property 'fkiUserIDModified'
        }
        /// <summary>
        /// Test the property 'fkiApikeyIDCreated'
        /// </summary>
        [Test]
        public void fkiApikeyIDCreatedTest()
        {
            // TODO unit test for the property 'fkiApikeyIDCreated'
        }
        /// <summary>
        /// Test the property 'fkiApikeyIDModified'
        /// </summary>
        [Test]
        public void fkiApikeyIDModifiedTest()
        {
            // TODO unit test for the property 'fkiApikeyIDModified'
        }
        /// <summary>
        /// Test the property 'dtCreatedDate'
        /// </summary>
        [Test]
        public void dtCreatedDateTest()
        {
            // TODO unit test for the property 'dtCreatedDate'
        }
        /// <summary>
        /// Test the property 'dtModifiedDate'
        /// </summary>
        [Test]
        public void dtModifiedDateTest()
        {
            // TODO unit test for the property 'dtModifiedDate'
        }

    }

}
