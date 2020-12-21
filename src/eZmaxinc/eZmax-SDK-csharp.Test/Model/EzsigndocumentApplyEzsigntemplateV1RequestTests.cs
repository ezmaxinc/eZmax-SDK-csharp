/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.21
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
    ///  Class for testing EzsigndocumentApplyEzsigntemplateV1Request
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EzsigndocumentApplyEzsigntemplateV1RequestTests
    {
        // TODO uncomment below to declare an instance variable for EzsigndocumentApplyEzsigntemplateV1Request
        //private EzsigndocumentApplyEzsigntemplateV1Request instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of EzsigndocumentApplyEzsigntemplateV1Request
            //instance = new EzsigndocumentApplyEzsigntemplateV1Request();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EzsigndocumentApplyEzsigntemplateV1Request
        /// </summary>
        [Test]
        public void EzsigndocumentApplyEzsigntemplateV1RequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" EzsigndocumentApplyEzsigntemplateV1Request
            //Assert.IsInstanceOf(typeof(EzsigndocumentApplyEzsigntemplateV1Request), instance);
        }


        /// <summary>
        /// Test the property 'fkiEzsigntemplateID'
        /// </summary>
        [Test]
        public void fkiEzsigntemplateIDTest()
        {
            // TODO unit test for the property 'fkiEzsigntemplateID'
        }
        /// <summary>
        /// Test the property 'a_sEzsigntemplatesigner'
        /// </summary>
        [Test]
        public void a_sEzsigntemplatesignerTest()
        {
            // TODO unit test for the property 'a_sEzsigntemplatesigner'
        }
        /// <summary>
        /// Test the property 'a_pkiEzsignfoldersignerassociationID'
        /// </summary>
        [Test]
        public void a_pkiEzsignfoldersignerassociationIDTest()
        {
            // TODO unit test for the property 'a_pkiEzsignfoldersignerassociationID'
        }

    }

}
