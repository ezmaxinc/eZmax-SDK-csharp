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
    /// Request for the /1/object/ezsignsignature/createObject API Request
    /// </summary>
    [DataContract]
    public partial class EzsignsignatureCreateObjectV1Request :  IEquatable<EzsignsignatureCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignsignatureCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignsignature">objEzsignsignature.</param>
        /// <param name="objEzsignsignatureCompound">objEzsignsignatureCompound.</param>
        public EzsignsignatureCreateObjectV1Request(EzsignsignatureRequest objEzsignsignature = default(EzsignsignatureRequest), EzsignsignatureRequestCompound objEzsignsignatureCompound = default(EzsignsignatureRequestCompound))
        {
            this.objEzsignsignature = objEzsignsignature;
            this.objEzsignsignatureCompound = objEzsignsignatureCompound;
        }

        /// <summary>
        /// Gets or Sets objEzsignsignature
        /// </summary>
        [DataMember(Name="objEzsignsignature", EmitDefaultValue=false)]
        public EzsignsignatureRequest objEzsignsignature { get; set; }

        /// <summary>
        /// Gets or Sets objEzsignsignatureCompound
        /// </summary>
        [DataMember(Name="objEzsignsignatureCompound", EmitDefaultValue=false)]
        public EzsignsignatureRequestCompound objEzsignsignatureCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignsignatureCreateObjectV1Request {\n");
            sb.Append("  objEzsignsignature: ").Append(objEzsignsignature).Append("\n");
            sb.Append("  objEzsignsignatureCompound: ").Append(objEzsignsignatureCompound).Append("\n");
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
            return this.Equals(input as EzsignsignatureCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsignsignatureCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignsignatureCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignsignatureCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objEzsignsignature == input.objEzsignsignature ||
                    (this.objEzsignsignature != null &&
                    this.objEzsignsignature.Equals(input.objEzsignsignature))
                ) && 
                (
                    this.objEzsignsignatureCompound == input.objEzsignsignatureCompound ||
                    (this.objEzsignsignatureCompound != null &&
                    this.objEzsignsignatureCompound.Equals(input.objEzsignsignatureCompound))
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
                if (this.objEzsignsignature != null)
                    hashCode = hashCode * 59 + this.objEzsignsignature.GetHashCode();
                if (this.objEzsignsignatureCompound != null)
                    hashCode = hashCode * 59 + this.objEzsignsignatureCompound.GetHashCode();
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
