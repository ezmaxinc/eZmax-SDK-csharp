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
                this.a_pkiFranchisereferalincomeID = aPkiFranchisereferalincomeID;
            }
            
        }
        
        /// <summary>
        /// An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.
        /// </summary>
        /// <value>An array of unique IDs representing the object that were requested to be created.  They are returned in the same order as the array containing the objects to be created that was sent in the request.</value>
        [DataMember(Name="a_pkiFranchisereferalincomeID", EmitDefaultValue=true)]
        public List<int> a_pkiFranchisereferalincomeID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FranchisereferalincomeCreateObjectV1ResponseMPayload {\n");
            sb.Append("  a_pkiFranchisereferalincomeID: ").Append(a_pkiFranchisereferalincomeID).Append("\n");
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
                    this.a_pkiFranchisereferalincomeID == input.a_pkiFranchisereferalincomeID ||
                    this.a_pkiFranchisereferalincomeID != null &&
                    input.a_pkiFranchisereferalincomeID != null &&
                    this.a_pkiFranchisereferalincomeID.SequenceEqual(input.a_pkiFranchisereferalincomeID)
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
                if (this.a_pkiFranchisereferalincomeID != null)
                    hashCode = hashCode * 59 + this.a_pkiFranchisereferalincomeID.GetHashCode();
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
