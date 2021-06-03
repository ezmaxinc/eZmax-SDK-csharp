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
    /// This is the base Webhook object
    /// </summary>
    [DataContract]
    public partial class WebhookEzsignDocumentCompleted :  IEquatable<WebhookEzsignDocumentCompleted>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEzsignDocumentCompleted" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookEzsignDocumentCompleted() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEzsignDocumentCompleted" /> class.
        /// </summary>
        /// <param name="objEzsigndocument">objEzsigndocument (required).</param>
        /// <param name="objWebhook">objWebhook (required).</param>
        /// <param name="aObjAttempt">An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt. (required).</param>
        public WebhookEzsignDocumentCompleted(EzsigndocumentResponse objEzsigndocument = default(EzsigndocumentResponse), WebhookResponse objWebhook = default(WebhookResponse), List<AttemptResponse> aObjAttempt = default(List<AttemptResponse>))
        {
            // to ensure "objEzsigndocument" is required (not null)
            if (objEzsigndocument == null)
            {
                throw new InvalidDataException("objEzsigndocument is a required property for WebhookEzsignDocumentCompleted and cannot be null");
            }
            else
            {
                this.ObjEzsigndocument = objEzsigndocument;
            }

            // to ensure "objWebhook" is required (not null)
            if (objWebhook == null)
            {
                throw new InvalidDataException("objWebhook is a required property for WebhookEzsignDocumentCompleted and cannot be null");
            }
            else
            {
                this.ObjWebhook = objWebhook;
            }

            // to ensure "aObjAttempt" is required (not null)
            if (aObjAttempt == null)
            {
                throw new InvalidDataException("aObjAttempt is a required property for WebhookEzsignDocumentCompleted and cannot be null");
            }
            else
            {
                this.AObjAttempt = aObjAttempt;
            }

        }

        /// <summary>
        /// Gets or Sets ObjEzsigndocument
        /// </summary>
        [DataMember(Name="objEzsigndocument", EmitDefaultValue=true)]
        public EzsigndocumentResponse ObjEzsigndocument { get; set; }

        /// <summary>
        /// Gets or Sets ObjWebhook
        /// </summary>
        [DataMember(Name="objWebhook", EmitDefaultValue=true)]
        public WebhookResponse ObjWebhook { get; set; }

        /// <summary>
        /// An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt.
        /// </summary>
        /// <value>An array containing details of previous attempts that were made to deliver the message. The array is empty if it&#39;s the first attempt.</value>
        [DataMember(Name="a_objAttempt", EmitDefaultValue=true)]
        public List<AttemptResponse> AObjAttempt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEzsignDocumentCompleted {\n");
            sb.Append("  ObjEzsigndocument: ").Append(ObjEzsigndocument).Append("\n");
            sb.Append("  ObjWebhook: ").Append(ObjWebhook).Append("\n");
            sb.Append("  AObjAttempt: ").Append(AObjAttempt).Append("\n");
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
            return this.Equals(input as WebhookEzsignDocumentCompleted);
        }

        /// <summary>
        /// Returns true if WebhookEzsignDocumentCompleted instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEzsignDocumentCompleted to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEzsignDocumentCompleted input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsigndocument == input.ObjEzsigndocument ||
                    (this.ObjEzsigndocument != null &&
                    this.ObjEzsigndocument.Equals(input.ObjEzsigndocument))
                ) && 
                (
                    this.ObjWebhook == input.ObjWebhook ||
                    (this.ObjWebhook != null &&
                    this.ObjWebhook.Equals(input.ObjWebhook))
                ) && 
                (
                    this.AObjAttempt == input.AObjAttempt ||
                    this.AObjAttempt != null &&
                    input.AObjAttempt != null &&
                    this.AObjAttempt.SequenceEqual(input.AObjAttempt)
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
                if (this.ObjEzsigndocument != null)
                    hashCode = hashCode * 59 + this.ObjEzsigndocument.GetHashCode();
                if (this.ObjWebhook != null)
                    hashCode = hashCode * 59 + this.ObjWebhook.GetHashCode();
                if (this.AObjAttempt != null)
                    hashCode = hashCode * 59 + this.AObjAttempt.GetHashCode();
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
