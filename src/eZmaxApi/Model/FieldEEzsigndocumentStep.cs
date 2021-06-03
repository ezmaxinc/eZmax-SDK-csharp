/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.46
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
using OpenAPIDateConverter = eZmaxApi.Client.OpenAPIDateConverter;

namespace eZmaxApi.Model
{
    /// <summary>
    /// The signature step of the Ezsigndocument.
    /// </summary>
    /// <value>The signature step of the Ezsigndocument.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEEzsigndocumentStep
    {
        /// <summary>
        /// Enum Unsent for value: Unsent
        /// </summary>
        [EnumMember(Value = "Unsent")]
        Unsent = 1,

        /// <summary>
        /// Enum Unsigned for value: Unsigned
        /// </summary>
        [EnumMember(Value = "Unsigned")]
        Unsigned = 2,

        /// <summary>
        /// Enum PartiallySigned for value: PartiallySigned
        /// </summary>
        [EnumMember(Value = "PartiallySigned")]
        PartiallySigned = 3,

        /// <summary>
        /// Enum DeclinedToSign for value: DeclinedToSign
        /// </summary>
        [EnumMember(Value = "DeclinedToSign")]
        DeclinedToSign = 4,

        /// <summary>
        /// Enum PrematurelyEnded for value: PrematurelyEnded
        /// </summary>
        [EnumMember(Value = "PrematurelyEnded")]
        PrematurelyEnded = 5,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 6

    }

}
