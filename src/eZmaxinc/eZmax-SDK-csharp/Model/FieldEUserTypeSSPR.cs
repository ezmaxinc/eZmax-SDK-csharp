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
    /// The user type of the User for SSPR
    /// </summary>
    /// <value>The user type of the User for SSPR</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FieldEUserTypeSSPR
    {
        /// <summary>
        /// Enum EzsignUser for value: EzsignUser
        /// </summary>
        [EnumMember(Value = "EzsignUser")]
        EzsignUser = 1,

        /// <summary>
        /// Enum Native for value: Native
        /// </summary>
        [EnumMember(Value = "Native")]
        Native = 2

    }

}
