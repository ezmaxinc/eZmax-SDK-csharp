/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.32
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
    /// Request for the /1/object/franchisereferalincome/createObject API Request
    /// </summary>
    [DataContract]
    public partial class FranchisereferalincomeCreateObjectV1Request :  IEquatable<FranchisereferalincomeCreateObjectV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1Request" /> class.
        /// </summary>
        /// <param name="objFranchisereferalincome">objFranchisereferalincome.</param>
        /// <param name="objFranchisereferalincomeCompound">objFranchisereferalincomeCompound.</param>
        public FranchisereferalincomeCreateObjectV1Request(FranchisereferalincomeRequest objFranchisereferalincome = default(FranchisereferalincomeRequest), FranchisereferalincomeRequestCompound objFranchisereferalincomeCompound = default(FranchisereferalincomeRequestCompound))
        {
            this.objFranchisereferalincome = objFranchisereferalincome;
            this.objFranchisereferalincomeCompound = objFranchisereferalincomeCompound;
        }

        /// <summary>
        /// Gets or Sets objFranchisereferalincome
        /// </summary>
        [DataMember(Name="objFranchisereferalincome", EmitDefaultValue=false)]
        public FranchisereferalincomeRequest objFranchisereferalincome { get; set; }

        /// <summary>
        /// Gets or Sets objFranchisereferalincomeCompound
        /// </summary>
        [DataMember(Name="objFranchisereferalincomeCompound", EmitDefaultValue=false)]
        public FranchisereferalincomeRequestCompound objFranchisereferalincomeCompound { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeCreateObjectV1Request {\n");
            sb.Append("  objFranchisereferalincome: ").Append(objFranchisereferalincome).Append("\n");
            sb.Append("  objFranchisereferalincomeCompound: ").Append(objFranchisereferalincomeCompound).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeCreateObjectV1Request);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeCreateObjectV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeCreateObjectV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeCreateObjectV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.objFranchisereferalincome == input.objFranchisereferalincome ||
                    (this.objFranchisereferalincome != null &&
                    this.objFranchisereferalincome.Equals(input.objFranchisereferalincome))
                ) && 
                (
                    this.objFranchisereferalincomeCompound == input.objFranchisereferalincomeCompound ||
                    (this.objFranchisereferalincomeCompound != null &&
                    this.objFranchisereferalincomeCompound.Equals(input.objFranchisereferalincomeCompound))
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
                if (this.objFranchisereferalincome != null)
                    hashCode = hashCode * 59 + this.objFranchisereferalincome.GetHashCode();
                if (this.objFranchisereferalincomeCompound != null)
                    hashCode = hashCode * 59 + this.objFranchisereferalincomeCompound.GetHashCode();
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
