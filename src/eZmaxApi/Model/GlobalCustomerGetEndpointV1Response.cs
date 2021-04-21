/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.42
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
    /// Response for the /1/customer/{pksCustomerCode}/endpoint API Request
    /// </summary>
    [DataContract]
    public partial class GlobalCustomerGetEndpointV1Response :  IEquatable<GlobalCustomerGetEndpointV1Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalCustomerGetEndpointV1Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GlobalCustomerGetEndpointV1Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalCustomerGetEndpointV1Response" /> class.
        /// </summary>
        /// <param name="sEndpointURL">The endpoint&#39;s URL (required).</param>
        public GlobalCustomerGetEndpointV1Response(string sEndpointURL = default(string))
        {
            // to ensure "sEndpointURL" is required (not null)
            if (sEndpointURL == null)
            {
                throw new InvalidDataException("sEndpointURL is a required property for GlobalCustomerGetEndpointV1Response and cannot be null");
            }
            else
            {
                this.SEndpointURL = sEndpointURL;
            }

        }

        /// <summary>
        /// The endpoint&#39;s URL
        /// </summary>
        /// <value>The endpoint&#39;s URL</value>
        [DataMember(Name="sEndpointURL", EmitDefaultValue=true)]
        public string SEndpointURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalCustomerGetEndpointV1Response {\n");
            sb.Append("  SEndpointURL: ").Append(SEndpointURL).Append("\n");
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
            return this.Equals(input as GlobalCustomerGetEndpointV1Response);
        }

        /// <summary>
        /// Returns true if GlobalCustomerGetEndpointV1Response instances are equal
        /// </summary>
        /// <param name="input">Instance of GlobalCustomerGetEndpointV1Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GlobalCustomerGetEndpointV1Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SEndpointURL == input.SEndpointURL ||
                    (this.SEndpointURL != null &&
                    this.SEndpointURL.Equals(input.SEndpointURL))
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
                if (this.SEndpointURL != null)
                    hashCode = hashCode * 59 + this.SEndpointURL.GetHashCode();
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
