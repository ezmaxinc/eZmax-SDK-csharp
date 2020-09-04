/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.11
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
    /// All API response will inherit this based Response
    /// </summary>
    [DataContract]
    public partial class CommonResponse :  IEquatable<CommonResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonResponse" /> class.
        /// </summary>
        /// <param name="objDebugPayload">objDebugPayload.</param>
        /// <param name="objDebug">objDebug.</param>
        public CommonResponse(CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug))
        {
            this.objDebugPayload = objDebugPayload;
            this.objDebug = objDebug;
        }
        
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
            sb.Append("class CommonResponse {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonResponse);
        }

        /// <summary>
        /// Returns true if CommonResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonResponse input)
        {
            if (input == null)
                return false;

            return 
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
