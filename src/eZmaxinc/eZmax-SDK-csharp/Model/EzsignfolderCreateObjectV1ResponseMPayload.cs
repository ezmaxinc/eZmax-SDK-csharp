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
    /// Payload for the /1/object/ezsignfolder/createObject API Request
    /// </summary>
    [DataContract]
    public partial class EzsignfolderCreateObjectV1ResponseMPayload :  IEquatable<EzsignfolderCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiEzsignfolderID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public EzsignfolderCreateObjectV1ResponseMPayload(List<int> aPkiEzsignfolderID = default(List<int>))
        {
            // to ensure "aPkiEzsignfolderID" is required (not null)
            if (aPkiEzsignfolderID == null)
            {
                throw new InvalidDataException("aPkiEzsignfolderID is a required property for EzsignfolderCreateObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.a_pkiEzsignfolderID = aPkiEzsignfolderID;
            }

        }

        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name="a_pkiEzsignfolderID", EmitDefaultValue=true)]
        public List<int> a_pkiEzsignfolderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderCreateObjectV1ResponseMPayload {\n");
            sb.Append("  a_pkiEzsignfolderID: ").Append(a_pkiEzsignfolderID).Append("\n");
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
            return this.Equals(input as EzsignfolderCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignfolderCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_pkiEzsignfolderID == input.a_pkiEzsignfolderID ||
                    this.a_pkiEzsignfolderID != null &&
                    input.a_pkiEzsignfolderID != null &&
                    this.a_pkiEzsignfolderID.SequenceEqual(input.a_pkiEzsignfolderID)
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
                if (this.a_pkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.a_pkiEzsignfolderID.GetHashCode();
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
