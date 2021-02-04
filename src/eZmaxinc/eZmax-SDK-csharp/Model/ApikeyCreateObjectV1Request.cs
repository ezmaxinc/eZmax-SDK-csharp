/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.28
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
    /// Request for the /1/object/apikey/createObject API Request
    /// </summary>
    [DataContract]
    public partial class ApikeyCreateObjectV1Request :  IEquatable<ApikeyCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApikeyCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objApikey">objApikey.</param>
        /// <param name="objApikeyCompound">objApikeyCompound.</param>
        public ApikeyCreateObjectV1Request(ApikeyRequest objApikey = default(ApikeyRequest), ApikeyRequestCompound objApikeyCompound = default(ApikeyRequestCompound))
        {
            this.objApikey = objApikey;
            this.objApikeyCompound = objApikeyCompound;
        }
        
        /// <summary>
        /// Gets or Sets objApikey
        /// </summary>
        [DataMember(Name="objApikey", EmitDefaultValue=false)]
        public ApikeyRequest objApikey { get; set; }

        /// <summary>
        /// Gets or Sets objApikeyCompound
        /// </summary>
        [DataMember(Name="objApikeyCompound", EmitDefaultValue=false)]
        public ApikeyRequestCompound objApikeyCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApikeyCreateObjectV1Request {\n");
            sb.Append("  objApikey: ").Append(objApikey).Append("\n");
            sb.Append("  objApikeyCompound: ").Append(objApikeyCompound).Append("\n");
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
            return this.Equals(input as ApikeyCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if ApikeyCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of ApikeyCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApikeyCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objApikey == input.objApikey ||
                    (this.objApikey != null &&
                    this.objApikey.Equals(input.objApikey))
                ) && 
                (
                    this.objApikeyCompound == input.objApikeyCompound ||
                    (this.objApikeyCompound != null &&
                    this.objApikeyCompound.Equals(input.objApikeyCompound))
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
                if (this.objApikey != null)
                    hashCode = hashCode * 59 + this.objApikey.GetHashCode();
                if (this.objApikeyCompound != null)
                    hashCode = hashCode * 59 + this.objApikeyCompound.GetHashCode();
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
