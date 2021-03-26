/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.39
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
    /// Request for the /1/object/ezsignfolder/editObject API Request
    /// </summary>
    [DataContract]
    public partial class UNUSEDEzsignfolderEditObjectV1Request :  IEquatable<UNUSEDEzsignfolderEditObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UNUSEDEzsignfolderEditObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignfolder">objEzsignfolder.</param>
        public UNUSEDEzsignfolderEditObjectV1Request(EzsignfolderRequest objEzsignfolder = default(EzsignfolderRequest))
        {
            this.ObjEzsignfolder = objEzsignfolder;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignfolder
        /// </summary>
        [DataMember(Name="objEzsignfolder", EmitDefaultValue=false)]
        public EzsignfolderRequest ObjEzsignfolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UNUSEDEzsignfolderEditObjectV1Request {\n");
            sb.Append("  ObjEzsignfolder: ").Append(ObjEzsignfolder).Append("\n");
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
            return this.Equals(input as UNUSEDEzsignfolderEditObjectV1Request);
        }

        /// <summary>
        /// Returns true if UNUSEDEzsignfolderEditObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of UNUSEDEzsignfolderEditObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UNUSEDEzsignfolderEditObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsignfolder == input.ObjEzsignfolder ||
                    (this.ObjEzsignfolder != null &&
                    this.ObjEzsignfolder.Equals(input.ObjEzsignfolder))
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
                if (this.ObjEzsignfolder != null)
                    hashCode = hashCode * 59 + this.ObjEzsignfolder.GetHashCode();
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
