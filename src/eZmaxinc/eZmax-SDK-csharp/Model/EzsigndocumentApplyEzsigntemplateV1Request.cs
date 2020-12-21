/* 
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign application.  We provide SDKs for customers. They are generated using OpenAPI codegen, we encourage customers to use them as we also provide samples for them.  You can choose to build your own implementation manually or can use any compatible OpenAPI 3.0 generator like Swagger Codegen, OpenAPI codegen or any commercial generators.  If you need helping understanding how to use this API, don't waste too much time looking for it. Contact support-api@ezmax.ca, we're here to help. We are developpers so we know programmers don't like bad documentation. If you don't find what you need in the documentation, let us know, we'll improve it and put you rapidly up on track.
 *
 * The version of the OpenAPI document: 1.0.22
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
    /// Request for the /1/object/ezsigndocument/{pkiEzsigndocumentID}/applyezsigntemplate API Request
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentApplyEzsigntemplateV1Request :  IEquatable<EzsigndocumentApplyEzsigntemplateV1Request>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateV1Request" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentApplyEzsigntemplateV1Request() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentApplyEzsigntemplateV1Request" /> class.
        /// </summary>
        /// <param name="fkiEzsigntemplateID">The unique ID of the Ezsigndocument (required).</param>
        /// <param name="aSEzsigntemplatesigner">aSEzsigntemplatesigner (required).</param>
        /// <param name="aPkiEzsignfoldersignerassociationID">aPkiEzsignfoldersignerassociationID (required).</param>
        public EzsigndocumentApplyEzsigntemplateV1Request(int fkiEzsigntemplateID = default(int), List<string> aSEzsigntemplatesigner = default(List<string>), List<int> aPkiEzsignfoldersignerassociationID = default(List<int>))
        {
            // to ensure "fkiEzsigntemplateID" is required (not null)
            if (fkiEzsigntemplateID == null)
            {
                throw new InvalidDataException("fkiEzsigntemplateID is a required property for EzsigndocumentApplyEzsigntemplateV1Request and cannot be null");
            }
            else
            {
                this.fkiEzsigntemplateID = fkiEzsigntemplateID;
            }
            
            // to ensure "aSEzsigntemplatesigner" is required (not null)
            if (aSEzsigntemplatesigner == null)
            {
                throw new InvalidDataException("aSEzsigntemplatesigner is a required property for EzsigndocumentApplyEzsigntemplateV1Request and cannot be null");
            }
            else
            {
                this.a_sEzsigntemplatesigner = aSEzsigntemplatesigner;
            }
            
            // to ensure "aPkiEzsignfoldersignerassociationID" is required (not null)
            if (aPkiEzsignfoldersignerassociationID == null)
            {
                throw new InvalidDataException("aPkiEzsignfoldersignerassociationID is a required property for EzsigndocumentApplyEzsigntemplateV1Request and cannot be null");
            }
            else
            {
                this.a_pkiEzsignfoldersignerassociationID = aPkiEzsignfoldersignerassociationID;
            }
            
        }
        
        /// <summary>
        /// The unique ID of the Ezsigndocument
        /// </summary>
        /// <value>The unique ID of the Ezsigndocument</value>
        [DataMember(Name="fkiEzsigntemplateID", EmitDefaultValue=true)]
        public int fkiEzsigntemplateID { get; set; }

        /// <summary>
        /// Gets or Sets a_sEzsigntemplatesigner
        /// </summary>
        [DataMember(Name="a_sEzsigntemplatesigner", EmitDefaultValue=true)]
        public List<string> a_sEzsigntemplatesigner { get; set; }

        /// <summary>
        /// Gets or Sets a_pkiEzsignfoldersignerassociationID
        /// </summary>
        [DataMember(Name="a_pkiEzsignfoldersignerassociationID", EmitDefaultValue=true)]
        public List<int> a_pkiEzsignfoldersignerassociationID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentApplyEzsigntemplateV1Request {\n");
            sb.Append("  fkiEzsigntemplateID: ").Append(fkiEzsigntemplateID).Append("\n");
            sb.Append("  a_sEzsigntemplatesigner: ").Append(a_sEzsigntemplatesigner).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EzsigndocumentApplyEzsigntemplateV1Request);
        }

        /// <summary>
        /// Returns true if EzsigndocumentApplyEzsigntemplateV1Request instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentApplyEzsigntemplateV1Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentApplyEzsigntemplateV1Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiEzsigntemplateID == input.fkiEzsigntemplateID ||
                    (this.fkiEzsigntemplateID != null &&
                    this.fkiEzsigntemplateID.Equals(input.fkiEzsigntemplateID))
                ) && 
                (
                    this.a_sEzsigntemplatesigner == input.a_sEzsigntemplatesigner ||
                    this.a_sEzsigntemplatesigner != null &&
                    input.a_sEzsigntemplatesigner != null &&
                    this.a_sEzsigntemplatesigner.SequenceEqual(input.a_sEzsigntemplatesigner)
                ) && 
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
                if (this.fkiEzsigntemplateID != null)
                    hashCode = hashCode * 59 + this.fkiEzsigntemplateID.GetHashCode();
                if (this.a_sEzsigntemplatesigner != null)
                    hashCode = hashCode * 59 + this.a_sEzsigntemplatesigner.GetHashCode();
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
