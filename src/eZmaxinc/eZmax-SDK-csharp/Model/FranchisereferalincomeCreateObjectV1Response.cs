/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.13
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
    /// Response for the /1/object/franchisereferalincome/createObject API Request
    /// </summary>
    [DataContract]
    public partial class FranchisereferalincomeCreateObjectV1Response : CommonResponse,  IEquatable<FranchisereferalincomeCreateObjectV1Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1Response" /> class.
        /// </summary>
        /// <param name="mPayload">mPayload (required).</param>
        public FranchisereferalincomeCreateObjectV1Response(FranchisereferalincomeCreateObjectV1ResponseMPayload mPayload = default(FranchisereferalincomeCreateObjectV1ResponseMPayload), CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug)) : base()
        {
            // to ensure "mPayload" is required (not null)
            if (mPayload == null)
            {
                throw new InvalidDataException("mPayload is a required property for FranchisereferalincomeCreateObjectV1Response and cannot be null");
            }
            else
            {
                this.mPayload = mPayload;
            }
            
        }
        
        /// <summary>
        /// Gets or Sets mPayload
        /// </summary>
        [DataMember(Name="mPayload", EmitDefaultValue=true)]
        public FranchisereferalincomeCreateObjectV1ResponseMPayload mPayload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeCreateObjectV1Response {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  mPayload: ").Append(mPayload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FranchisereferalincomeCreateObjectV1Response);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeCreateObjectV1Response instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeCreateObjectV1Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeCreateObjectV1Response input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.mPayload == input.mPayload ||
                    (this.mPayload != null &&
                    this.mPayload.Equals(input.mPayload))
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
                int hashCode = base.GetHashCode();
                if (this.mPayload != null)
                    hashCode = hashCode * 59 + this.mPayload.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
