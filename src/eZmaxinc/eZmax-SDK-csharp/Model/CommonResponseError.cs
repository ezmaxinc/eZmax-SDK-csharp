/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.
 *
 * The version of the OpenAPI document: 1.0.30
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
    /// Generic Error Message
    /// </summary>
    [DataContract]
    public partial class CommonResponseError :  IEquatable<CommonResponseError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonResponseError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponseError" /> class.
        /// </summary>
        /// <param name="sErrorMessage">More detail about the error (required).</param>
        public CommonResponseError(string sErrorMessage = default(string))
        {
            // to ensure "sErrorMessage" is required (not null)
            if (sErrorMessage == null)
            {
                throw new InvalidDataException("sErrorMessage is a required property for CommonResponseError and cannot be null");
            }
            else
            {
                this.sErrorMessage = sErrorMessage;
            }
            
        }
        
        /// <summary>
        /// More detail about the error
        /// </summary>
        /// <value>More detail about the error</value>
        [DataMember(Name="sErrorMessage", EmitDefaultValue=true)]
        public string sErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonResponseError {\n");
            sb.Append("  sErrorMessage: ").Append(sErrorMessage).Append("\n");
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
            return this.Equals(input as CommonResponseError);
        }

        /// <summary>
        /// Returns true if CommonResponseError instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponseError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sErrorMessage == input.sErrorMessage ||
                    (this.sErrorMessage != null &&
                    this.sErrorMessage.Equals(input.sErrorMessage))
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
                if (this.sErrorMessage != null)
                    hashCode = hashCode * 59 + this.sErrorMessage.GetHashCode();
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
