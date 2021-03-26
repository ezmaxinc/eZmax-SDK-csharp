/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.39
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
    /// Description of the API Key  
    /// </summary>
    [DataContract]
    public partial class MultilingualApikeyDescription :  IEquatable<MultilingualApikeyDescription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultilingualApikeyDescription" /> class.
        /// </summary>
        /// <param name="sApikeyDescription1">Value in French.</param>
        /// <param name="sApikeyDescription2">Value in English.</param>
        public MultilingualApikeyDescription(string sApikeyDescription1 = default(string), string sApikeyDescription2 = default(string))
        {
            this.SApikeyDescription1 = sApikeyDescription1;
            this.SApikeyDescription2 = sApikeyDescription2;
        }

        /// <summary>
        /// Value in French
        /// </summary>
        /// <value>Value in French</value>
        [DataMember(Name="sApikeyDescription1", EmitDefaultValue=false)]
        public string SApikeyDescription1 { get; set; }

        /// <summary>
        /// Value in English
        /// </summary>
        /// <value>Value in English</value>
        [DataMember(Name="sApikeyDescription2", EmitDefaultValue=false)]
        public string SApikeyDescription2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultilingualApikeyDescription {\n");
            sb.Append("  SApikeyDescription1: ").Append(SApikeyDescription1).Append("\n");
            sb.Append("  SApikeyDescription2: ").Append(SApikeyDescription2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultilingualApikeyDescription);
        }

        /// <summary>
        /// Returns true if MultilingualApikeyDescription instances are equal
        /// </summary>
        /// <param name="input">Instance of MultilingualApikeyDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultilingualApikeyDescription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SApikeyDescription1 == input.SApikeyDescription1 ||
                    (this.SApikeyDescription1 != null &&
                    this.SApikeyDescription1.Equals(input.SApikeyDescription1))
                ) && 
                (
                    this.SApikeyDescription2 == input.SApikeyDescription2 ||
                    (this.SApikeyDescription2 != null &&
                    this.SApikeyDescription2.Equals(input.SApikeyDescription2))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SApikeyDescription1 != null)
                    hashCode = hashCode * 59 + this.SApikeyDescription1.GetHashCode();
                if (this.SApikeyDescription2 != null)
                    hashCode = hashCode * 59 + this.SApikeyDescription2.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
