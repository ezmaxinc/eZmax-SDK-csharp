/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.35
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
    /// Response for the /1/object/apikey/createObject API Request
    /// </summary>
    [DataContract]
    public partial class ApikeyCreateObjectV1Response :  IEquatable<ApikeyCreateObjectV1Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyCreateObjectV1Response" /> class.
        /// </summary>
        /// <param name="mPayload">mPayload (required).</param>
        /// <param name="objDebugPayload">objDebugPayload.</param>
        /// <param name="objDebug">objDebug.</param>
        public ApikeyCreateObjectV1Response(ApikeyCreateObjectV1ResponseMPayload mPayload = default(ApikeyCreateObjectV1ResponseMPayload), CommonResponseObjDebugPayload objDebugPayload = default(CommonResponseObjDebugPayload), CommonResponseObjDebug objDebug = default(CommonResponseObjDebug))
        {
            // to ensure "mPayload" is required (not null)
            if (mPayload == null)
            {
                throw new InvalidDataException("mPayload is a required property for ApikeyCreateObjectV1Response and cannot be null");
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
        public ApikeyCreateObjectV1ResponseMPayload mPayload { get; set; }

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
            sb.Append("class ApikeyCreateObjectV1Response {\n");
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
            return this.Equals(input as ApikeyCreateObjectV1Response);
        }

        /// <summary>
        /// Returns true if ApikeyCreateObjectV1Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyCreateObjectV1Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyCreateObjectV1Response input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.mPayload == input.mPayload ||
                    (this.mPayload != null &&
                    this.mPayload.Equals(input.mPayload))
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
