/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.27
 * Contact: support-api@ezmax.ca
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = eZmaxinc/eZmax-SDK-csharp.Client.OpenAPIDateConverter;

namespace eZmaxinc/eZmax-SDK-csharp.Model
{
    /// <summary>
    /// The signature step of the Ezsignfolder.
    /// </summary>
    /// <value>The signature step of the Ezsignfolder.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEEzsignfolderStep
    {
        /// <summary>
        /// Enum Unsent for value: Unsent
        /// </summary>
        [EnumMember(Value = "Unsent")]
        Unsent = 1,

        /// <summary>
        /// Enum Sent for value: Sent
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent = 2,

        /// <summary>
        /// Enum PartiallySigned for value: PartiallySigned
        /// </summary>
        [EnumMember(Value = "PartiallySigned")]
        PartiallySigned = 3,

        /// <summary>
        /// Enum Expired for value: Expired
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired = 4,

        /// <summary>
        /// Enum Signed for value: Signed
        /// </summary>
        [EnumMember(Value = "Signed")]
        Signed = 5,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 6,

        /// <summary>
        /// Enum Archived for value: Archived
        /// </summary>
        [EnumMember(Value = "Archived")]
        Archived = 7

    }

}
