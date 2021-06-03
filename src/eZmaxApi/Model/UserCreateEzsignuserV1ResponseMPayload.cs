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
    /// Payload for the /1/module/user/createEzsignuser API Request
    /// </summary>
    [DataContract]
    public partial class UserCreateEzsignuserV1ResponseMPayload :  IEquatable<UserCreateEzsignuserV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateEzsignuserV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserCreateEzsignuserV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreateEzsignuserV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aSEmailAddressSuccess">An array of email addresses that succeeded. (required).</param>
        /// <param name="aSEmailAddressFailure">An array of email addresses that failed. (required).</param>
        public UserCreateEzsignuserV1ResponseMPayload(List<string> aSEmailAddressSuccess = default(List<string>), List<string> aSEmailAddressFailure = default(List<string>))
        {
            // to ensure "aSEmailAddressSuccess" is required (not null)
            if (aSEmailAddressSuccess == null)
            {
                throw new InvalidDataException("aSEmailAddressSuccess is a required property for UserCreateEzsignuserV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.ASEmailAddressSuccess = aSEmailAddressSuccess;
            }

            // to ensure "aSEmailAddressFailure" is required (not null)
            if (aSEmailAddressFailure == null)
            {
                throw new InvalidDataException("aSEmailAddressFailure is a required property for UserCreateEzsignuserV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.ASEmailAddressFailure = aSEmailAddressFailure;
            }

        }

        /// <summary>
        /// An array of email addresses that succeeded.
        /// </summary>
        /// <value>An array of email addresses that succeeded.</value>
        [DataMember(Name="a_sEmailAddressSuccess", EmitDefaultValue=true)]
        public List<string> ASEmailAddressSuccess { get; set; }

        /// <summary>
        /// An array of email addresses that failed.
        /// </summary>
        /// <value>An array of email addresses that failed.</value>
        [DataMember(Name="a_sEmailAddressFailure", EmitDefaultValue=true)]
        public List<string> ASEmailAddressFailure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreateEzsignuserV1ResponseMPayload {\n");
            sb.Append("  ASEmailAddressSuccess: ").Append(ASEmailAddressSuccess).Append("\n");
            sb.Append("  ASEmailAddressFailure: ").Append(ASEmailAddressFailure).Append("\n");
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
            return this.Equals(input as UserCreateEzsignuserV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if UserCreateEzsignuserV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCreateEzsignuserV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCreateEzsignuserV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ASEmailAddressSuccess == input.ASEmailAddressSuccess ||
                    this.ASEmailAddressSuccess != null &&
                    input.ASEmailAddressSuccess != null &&
                    this.ASEmailAddressSuccess.SequenceEqual(input.ASEmailAddressSuccess)
                ) && 
                (
                    this.ASEmailAddressFailure == input.ASEmailAddressFailure ||
                    this.ASEmailAddressFailure != null &&
                    input.ASEmailAddressFailure != null &&
                    this.ASEmailAddressFailure.SequenceEqual(input.ASEmailAddressFailure)
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
                if (this.ASEmailAddressSuccess != null)
                    hashCode = hashCode * 59 + this.ASEmailAddressSuccess.GetHashCode();
                if (this.ASEmailAddressFailure != null)
                    hashCode = hashCode * 59 + this.ASEmailAddressFailure.GetHashCode();
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