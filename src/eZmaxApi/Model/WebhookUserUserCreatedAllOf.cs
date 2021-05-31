/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.44
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
    /// WebhookUserUserCreatedAllOf
    /// </summary>
    [DataContract]
    public partial class WebhookUserUserCreatedAllOf :  IEquatable<WebhookUserUserCreatedAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUserUserCreatedAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookUserUserCreatedAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUserUserCreatedAllOf" /> class.
        /// </summary>
        /// <param name="objUser">objUser (required).</param>
        public WebhookUserUserCreatedAllOf(UserResponse objUser = default(UserResponse))
        {
            // to ensure "objUser" is required (not null)
            if (objUser == null)
            {
                throw new InvalidDataException("objUser is a required property for WebhookUserUserCreatedAllOf and cannot be null");
            }
            else
            {
                this.ObjUser = objUser;
            }

        }

        /// <summary>
        /// Gets or Sets ObjUser
        /// </summary>
        [DataMember(Name="objUser", EmitDefaultValue=true)]
        public UserResponse ObjUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookUserUserCreatedAllOf {\n");
            sb.Append("  ObjUser: ").Append(ObjUser).Append("\n");
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
            return this.Equals(input as WebhookUserUserCreatedAllOf);
        }

        /// <summary>
        /// Returns true if WebhookUserUserCreatedAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUserUserCreatedAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUserUserCreatedAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjUser == input.ObjUser ||
                    (this.ObjUser != null &&
                    this.ObjUser.Equals(input.ObjUser))
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
                if (this.ObjUser != null)
                    hashCode = hashCode * 59 + this.ObjUser.GetHashCode();
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
