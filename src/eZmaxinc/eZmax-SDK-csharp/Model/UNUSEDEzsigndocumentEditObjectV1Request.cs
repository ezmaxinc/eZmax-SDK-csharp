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
    /// Request for the /1/object/ezsigndocument/editObject API Request
    /// </summary>
    [DataContract]
    public partial class UNUSEDEzsigndocumentEditObjectV1Request :  IEquatable<UNUSEDEzsigndocumentEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UNUSEDEzsigndocumentEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsigndocument">objEzsigndocument.</param>
        public UNUSEDEzsigndocumentEditObjectV1Request(EzsigndocumentRequest objEzsigndocument = default(EzsigndocumentRequest))
        {
            this.objEzsigndocument = objEzsigndocument;
        }

        /// <summary>
        /// Gets or Sets objEzsigndocument
        /// </summary>
        [DataMember(Name="objEzsigndocument", EmitDefaultValue=false)]
        public EzsigndocumentRequest objEzsigndocument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UNUSEDEzsigndocumentEditObjectV1Request {\n");
            sb.Append("  objEzsigndocument: ").Append(objEzsigndocument).Append("\n");
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
            return this.Equals(input as UNUSEDEzsigndocumentEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if UNUSEDEzsigndocumentEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UNUSEDEzsigndocumentEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UNUSEDEzsigndocumentEditObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objEzsigndocument == input.objEzsigndocument ||
                    (this.objEzsigndocument != null &&
                    this.objEzsigndocument.Equals(input.objEzsigndocument))
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
                if (this.objEzsigndocument != null)
                    hashCode = hashCode * 59 + this.objEzsigndocument.GetHashCode();
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
