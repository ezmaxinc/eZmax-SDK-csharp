/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.44
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
    /// Request for the /1/object/ezsignfoldersignerassociation/createObject API Request
    /// </summary>
    [DataContract]
    public partial class EzsignfoldersignerassociationCreateObjectV1Request :  IEquatable<EzsignfoldersignerassociationCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objEzsignfoldersignerassociation">objEzsignfoldersignerassociation.</param>
        /// <param name="objEzsignfoldersignerassociationCompound">objEzsignfoldersignerassociationCompound.</param>
        public EzsignfoldersignerassociationCreateObjectV1Request(EzsignfoldersignerassociationRequest objEzsignfoldersignerassociation = default(EzsignfoldersignerassociationRequest), EzsignfoldersignerassociationRequestCompound objEzsignfoldersignerassociationCompound = default(EzsignfoldersignerassociationRequestCompound))
        {
            this.ObjEzsignfoldersignerassociation = objEzsignfoldersignerassociation;
            this.ObjEzsignfoldersignerassociationCompound = objEzsignfoldersignerassociationCompound;
        }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldersignerassociation
        /// </summary>
        [DataMember(Name="objEzsignfoldersignerassociation", EmitDefaultValue=false)]
        public EzsignfoldersignerassociationRequest ObjEzsignfoldersignerassociation { get; set; }

        /// <summary>
        /// Gets or Sets ObjEzsignfoldersignerassociationCompound
        /// </summary>
        [DataMember(Name="objEzsignfoldersignerassociationCompound", EmitDefaultValue=false)]
        public EzsignfoldersignerassociationRequestCompound ObjEzsignfoldersignerassociationCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationCreateObjectV1Request {\n");
            sb.Append("  ObjEzsignfoldersignerassociation: ").Append(ObjEzsignfoldersignerassociation).Append("\n");
            sb.Append("  ObjEzsignfoldersignerassociationCompound: ").Append(ObjEzsignfoldersignerassociationCompound).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjEzsignfoldersignerassociation == input.ObjEzsignfoldersignerassociation ||
                    (this.ObjEzsignfoldersignerassociation != null &&
                    this.ObjEzsignfoldersignerassociation.Equals(input.ObjEzsignfoldersignerassociation))
                ) && 
                (
                    this.ObjEzsignfoldersignerassociationCompound == input.ObjEzsignfoldersignerassociationCompound ||
                    (this.ObjEzsignfoldersignerassociationCompound != null &&
                    this.ObjEzsignfoldersignerassociationCompound.Equals(input.ObjEzsignfoldersignerassociationCompound))
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
                if (this.ObjEzsignfoldersignerassociation != null)
                    hashCode = hashCode * 59 + this.ObjEzsignfoldersignerassociation.GetHashCode();
                if (this.ObjEzsignfoldersignerassociationCompound != null)
                    hashCode = hashCode * 59 + this.ObjEzsignfoldersignerassociationCompound.GetHashCode();
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
