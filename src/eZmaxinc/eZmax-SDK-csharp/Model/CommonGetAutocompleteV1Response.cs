/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.26
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
    /// Response for the /1/object/xxx/getAutocomplete API Request
    /// </summary>
    [DataContract]
    public partial class CommonGetAutocompleteV1Response :  IEquatable<CommonGetAutocompleteV1Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonGetAutocompleteV1Response" /> class.
        /// </summary>
        /// <param name="mPayload">mPayload (required).</param>
        /// <param name="objDebugPayload">objDebugPayload.</param>
        /// <param name="objDebug">objDebug.</param>
        public CommonGetAutocompleteV1Response(List<CommonGetAutocompleteV1ResponseMPayload> mPayload = default(List<CommonGetAutocompleteV1ResponseMPayload>), CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug))
        {
            // to ensure "mPayload" is required (not null)
            if (mPayload == null)
            {
                throw new InvalidDataException("mPayload is a required property for CommonGetAutocompleteV1Response and cannot be null");
            }
            else
            {
                this.mPayload = mPayload;
            }
            
            this.objDebugPayload = objDebugPayload;
            this.objDebug = objDebug;
        }
        
        /// <summary>
        /// Gets or Sets mPayload
        /// </summary>
        [DataMember(Name="mPayload", EmitDefaultValue=true)]
        public List<CommonGetAutocompleteV1ResponseMPayload> mPayload { get; set; }

        /// <summary>
        /// Gets or Sets objDebugPayload
        /// </summary>
        [DataMember(Name="objDebugPayload", EmitDefaultValue=false)]
        public CommonResponseObjDebugPayload objDebugPayload { get; set; }

        /// <summary>
        /// Gets or Sets objDebug
        /// </summary>
        [DataMember(Name="objDebug", EmitDefaultValue=false)]
        public CommonResponseObjDebug objDebug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonGetAutocompleteV1Response {\n");
            sb.Append("  mPayload: ").Append(mPayload).Append("\n");
            sb.Append("  objDebugPayload: ").Append(objDebugPayload).Append("\n");
            sb.Append("  objDebug: ").Append(objDebug).Append("\n");
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
            return this.Equals(input as CommonGetAutocompleteV1Response);
        }

        /// <summary>
        /// Returns true if CommonGetAutocompleteV1Response instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonGetAutocompleteV1Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonGetAutocompleteV1Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.mPayload == input.mPayload ||
                    this.mPayload != null &&
                    input.mPayload != null &&
                    this.mPayload.SequenceEqual(input.mPayload)
                ) && 
                (
                    this.objDebugPayload == input.objDebugPayload ||
                    (this.objDebugPayload != null &&
                    this.objDebugPayload.Equals(input.objDebugPayload))
                ) && 
                (
                    this.objDebug == input.objDebug ||
                    (this.objDebug != null &&
                    this.objDebug.Equals(input.objDebug))
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
                if (this.mPayload != null)
                    hashCode = hashCode * 59 + this.mPayload.GetHashCode();
                if (this.objDebugPayload != null)
                    hashCode = hashCode * 59 + this.objDebugPayload.GetHashCode();
                if (this.objDebug != null)
                    hashCode = hashCode * 59 + this.objDebug.GetHashCode();
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
