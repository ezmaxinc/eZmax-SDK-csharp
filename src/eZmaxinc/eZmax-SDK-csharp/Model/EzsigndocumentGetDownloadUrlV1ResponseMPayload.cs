/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.12
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
    /// Payload for the /1/object/ezsigndocument/{pkiEzsigndocument}/getDownloadUrl API Request
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentGetDownloadUrlV1ResponseMPayload :  IEquatable<EzsigndocumentGetDownloadUrlV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetDownloadUrlV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentGetDownloadUrlV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentGetDownloadUrlV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="sDownloadUrl">The Url to the requested document.  Url will expire after 5 minutes. (required).</param>
        public EzsigndocumentGetDownloadUrlV1ResponseMPayload(string sDownloadUrl = default(string))
        {
            // to ensure "sDownloadUrl" is required (not null)
            if (sDownloadUrl == null)
            {
                throw new InvalidDataException("sDownloadUrl is a required property for EzsigndocumentGetDownloadUrlV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.sDownloadUrl = sDownloadUrl;
            }
            
        }
        
        /// <summary>
        /// The Url to the requested document.  Url will expire after 5 minutes.
        /// </summary>
        /// <value>The Url to the requested document.  Url will expire after 5 minutes.</value>
        [DataMember(Name="sDownloadUrl", EmitDefaultValue=true)]
        public string sDownloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentGetDownloadUrlV1ResponseMPayload {\n");
            sb.Append("  sDownloadUrl: ").Append(sDownloadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsigndocumentGetDownloadUrlV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsigndocumentGetDownloadUrlV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentGetDownloadUrlV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentGetDownloadUrlV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.sDownloadUrl == input.sDownloadUrl ||
                    (this.sDownloadUrl != null &&
                    this.sDownloadUrl.Equals(input.sDownloadUrl))
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
                if (this.sDownloadUrl != null)
                    hashCode = hashCode * 59 + this.sDownloadUrl.GetHashCode();
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
