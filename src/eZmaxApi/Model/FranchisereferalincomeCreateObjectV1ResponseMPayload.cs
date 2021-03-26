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
    /// Payload for the /1/object/franchisereferalincome/createObject API Request
    /// </summary>
    [DataContract]
    public partial class FranchisereferalincomeCreateObjectV1ResponseMPayload :  IEquatable<FranchisereferalincomeCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FranchisereferalincomeCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FranchisereferalincomeCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiFranchisereferalincomeID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public FranchisereferalincomeCreateObjectV1ResponseMPayload(List<int> aPkiFranchisereferalincomeID = default(List<int>))
        {
            // to ensure "aPkiFranchisereferalincomeID" is required (not null)
            if (aPkiFranchisereferalincomeID == null)
            {
                throw new InvalidDataException("aPkiFranchisereferalincomeID is a required property for FranchisereferalincomeCreateObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.APkiFranchisereferalincomeID = aPkiFranchisereferalincomeID;
            }

        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name="a_pkiFranchisereferalincomeID", EmitDefaultValue=true)]
        public List<int> APkiFranchisereferalincomeID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeCreateObjectV1ResponseMPayload {\n");
            sb.Append("  APkiFranchisereferalincomeID: ").Append(APkiFranchisereferalincomeID).Append("\n");
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
            return this.Equals(input as FranchisereferalincomeCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if FranchisereferalincomeCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of FranchisereferalincomeCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FranchisereferalincomeCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.APkiFranchisereferalincomeID == input.APkiFranchisereferalincomeID ||
                    this.APkiFranchisereferalincomeID != null &&
                    input.APkiFranchisereferalincomeID != null &&
                    this.APkiFranchisereferalincomeID.SequenceEqual(input.APkiFranchisereferalincomeID)
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
                if (this.APkiFranchisereferalincomeID != null)
                    hashCode = hashCode * 59 + this.APkiFranchisereferalincomeID.GetHashCode();
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
