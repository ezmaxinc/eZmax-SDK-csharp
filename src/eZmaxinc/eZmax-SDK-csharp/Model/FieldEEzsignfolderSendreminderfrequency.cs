/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.35
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
    /// Frequency at which reminders will be sent to signers that haven&#39;t signed the documents
    /// </summary>
    /// <value>Frequency at which reminders will be sent to signers that haven&#39;t signed the documents</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEEzsignfolderSendreminderfrequency
    {
        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 1,

        /// <summary>
        /// Enum Daily for value: Daily
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily = 2,

        /// <summary>
        /// Enum Weekly for value: Weekly
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly = 3

    }

}
