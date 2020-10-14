/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.18
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
    /// Payload for the /1/object/ezsignfoldersignerassociation/editObject API Request
    /// </summary>
    [DataContract]
    public partial class EzsignfoldersignerassociationCreateObjectV1ResponseMPayload :  IEquatable<EzsignfoldersignerassociationCreateObjectV1ResponseMPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationCreateObjectV1ResponseMPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationCreateObjectV1ResponseMPayload" /> class.
        /// </summary>
        /// <param name="aPkiEzsignfoldersignerassociationID">An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request. (required).</param>
        public EzsignfoldersignerassociationCreateObjectV1ResponseMPayload(List<int> aPkiEzsignfoldersignerassociationID = default(List<int>))
        {
            // to ensure "aPkiEzsignfoldersignerassociationID" is required (not null)
            if (aPkiEzsignfoldersignerassociationID == null)
            {
                throw new InvalidDataException("aPkiEzsignfoldersignerassociationID is a required property for EzsignfoldersignerassociationCreateObjectV1ResponseMPayload and cannot be null");
            }
            else
            {
                this.a_pkiEzsignfoldersignerassociationID = aPkiEzsignfoldersignerassociationID;
            }
            
        }
        
        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name="a_pkiEzsignfoldersignerassociationID", EmitDefaultValue=true)]
        public List<int> a_pkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationCreateObjectV1ResponseMPayload {\n");
            sb.Append("  a_pkiEzsignfoldersignerassociationID: ").Append(a_pkiEzsignfoldersignerassociationID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as EzsignfoldersignerassociationCreateObjectV1ResponseMPayload);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationCreateObjectV1ResponseMPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationCreateObjectV1ResponseMPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationCreateObjectV1ResponseMPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.a_pkiEzsignfoldersignerassociationID == input.a_pkiEzsignfoldersignerassociationID ||
                    this.a_pkiEzsignfoldersignerassociationID != null &&
                    input.a_pkiEzsignfoldersignerassociationID != null &&
                    this.a_pkiEzsignfoldersignerassociationID.SequenceEqual(input.a_pkiEzsignfoldersignerassociationID)
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
                if (this.a_pkiEzsignfoldersignerassociationID != null)
                    hashCode = hashCode * 59 + this.a_pkiEzsignfoldersignerassociationID.GetHashCode();
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
