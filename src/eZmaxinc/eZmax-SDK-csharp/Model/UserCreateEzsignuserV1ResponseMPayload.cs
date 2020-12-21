/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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
                this.a_sEmailAddressSuccess = aSEmailAddressSuccess;
            }
            
            // to ensure "aSEmailAddressFailure" is required (not null)
            if (aSEmailAddressFailure == null)
            {
                throw new InvalidDataException("aSEmailAddressFailure is a required property for UserCreateEzsignuserV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.a_sEmailAddressFailure = aSEmailAddressFailure;
            }
            
        }
        
        /// <summary>
        /// An array of email addresses that succeeded.
        /// </summary>
        /// <value>An array of email addresses that succeeded.</value>
        [DataMember(Name="a_sEmailAddressSuccess", EmitDefaultValue=true)]
        public List<string> a_sEmailAddressSuccess { get; set; }

        /// <summary>
        /// An array of email addresses that failed.
        /// </summary>
        /// <value>An array of email addresses that failed.</value>
        [DataMember(Name="a_sEmailAddressFailure", EmitDefaultValue=true)]
        public List<string> a_sEmailAddressFailure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserCreateEzsignuserV1ResponseMPayload {\n");
            sb.Append("  a_sEmailAddressSuccess: ").Append(a_sEmailAddressSuccess).Append("\n");
            sb.Append("  a_sEmailAddressFailure: ").Append(a_sEmailAddressFailure).Append("\n");
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
                    this.a_sEmailAddressSuccess == input.a_sEmailAddressSuccess ||
                    this.a_sEmailAddressSuccess != null &&
                    input.a_sEmailAddressSuccess != null &&
                    this.a_sEmailAddressSuccess.SequenceEqual(input.a_sEmailAddressSuccess)
                ) && 
                (
                    this.a_sEmailAddressFailure == input.a_sEmailAddressFailure ||
                    this.a_sEmailAddressFailure != null &&
                    input.a_sEmailAddressFailure != null &&
                    this.a_sEmailAddressFailure.SequenceEqual(input.a_sEmailAddressFailure)
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
                if (this.a_sEmailAddressSuccess != null)
                    hashCode = hashCode * 59 + this.a_sEmailAddressSuccess.GetHashCode();
                if (this.a_sEmailAddressFailure != null)
                    hashCode = hashCode * 59 + this.a_sEmailAddressFailure.GetHashCode();
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
