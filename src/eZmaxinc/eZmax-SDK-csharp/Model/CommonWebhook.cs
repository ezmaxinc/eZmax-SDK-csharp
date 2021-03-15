/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.33
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
    /// This is the base Webhook object
    /// </summary>
    [DataContract]
    public partial class CommonWebhook :  IEquatable<CommonWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommonWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonWebhook" /> class.
        /// </summary>
        /// <param name="objWebhook">objWebhook (required).</param>
        /// <param name="aObjAttempt">An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt. (required).</param>
        public CommonWebhook(WebhookResponse objWebhook = default(WebhookResponse), List<AttemptResponse> aObjAttempt = default(List<AttemptResponse>))
        {
            // to ensure "objWebhook" is required (not null)
            if (objWebhook == null)
            {
                throw new InvalidDataException("objWebhook is a required property for CommonWebhook and cannot be null");
            }
            else
            {
                this.objWebhook = objWebhook;
            }

            // to ensure "aObjAttempt" is required (not null)
            if (aObjAttempt == null)
            {
                throw new InvalidDataException("aObjAttempt is a required property for CommonWebhook and cannot be null");
            }
            else
            {
                this.a_objAttempt = aObjAttempt;
            }

        }

        /// <summary>
        /// Gets or Sets objWebhook
        /// </summary>
        [DataMember(Name="objWebhook", EmitDefaultValue=true)]
        public WebhookResponse objWebhook { get; set; }

        /// <summary>
        /// An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt.
        /// </summary>
        /// <value>An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt.</value>
        [DataMember(Name="a_objAttempt", EmitDefaultValue=true)]
        public List<AttemptResponse> a_objAttempt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonWebhook {\n");
            sb.Append("  objWebhook: ").Append(objWebhook).Append("\n");
            sb.Append("  a_objAttempt: ").Append(a_objAttempt).Append("\n");
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
            return this.Equals(input as CommonWebhook);
        }

        /// <summary>
        /// Returns true if CommonWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonWebhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objWebhook == input.objWebhook ||
                    (this.objWebhook != null &&
                    this.objWebhook.Equals(input.objWebhook))
                ) && 
                (
                    this.a_objAttempt == input.a_objAttempt ||
                    this.a_objAttempt != null &&
                    input.a_objAttempt != null &&
                    this.a_objAttempt.SequenceEqual(input.a_objAttempt)
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
                if (this.objWebhook != null)
                    hashCode = hashCode * 59 + this.objWebhook.GetHashCode();
                if (this.a_objAttempt != null)
                    hashCode = hashCode * 59 + this.a_objAttempt.GetHashCode();
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
