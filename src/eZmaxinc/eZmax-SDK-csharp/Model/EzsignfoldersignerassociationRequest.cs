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
    /// An Ezsignfoldersignerassociation Object
    /// </summary>
    [DataContract]
    public partial class EzsignfoldersignerassociationRequest :  IEquatable<EzsignfoldersignerassociationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfoldersignerassociationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfoldersignerassociationRequest" /> class.
        /// </summary>
        /// <param name="fkiUserID">A reference to a valid User.  This is only used if the signatory will be a user from the system..</param>
        /// <param name="fkiEzsignfolderID">A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation. (required).</param>
        public EzsignfoldersignerassociationRequest(int fkiUserID = default(int), int fkiEzsignfolderID = default(int))
        {
            // to ensure "fkiEzsignfolderID" is required (not null)
            if (fkiEzsignfolderID == null)
            {
                throw new InvalidDataException("fkiEzsignfolderID is a required property for EzsignfoldersignerassociationRequest and cannot be null");
            }
            else
            {
                this.fkiEzsignfolderID = fkiEzsignfolderID;
            }

            this.fkiUserID = fkiUserID;
        }

        /// <summary>
        /// A reference to a valid User.  This is only used if the signatory will be a user from the system.
        /// </summary>
        /// <value>A reference to a valid User.  This is only used if the signatory will be a user from the system.</value>
        [DataMember(Name="fkiUserID", EmitDefaultValue=false)]
        public int fkiUserID { get; set; }

        /// <summary>
        /// A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.</value>
        [DataMember(Name="fkiEzsignfolderID", EmitDefaultValue=true)]
        public int fkiEzsignfolderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfoldersignerassociationRequest {\n");
            sb.Append("  fkiUserID: ").Append(fkiUserID).Append("\n");
            sb.Append("  fkiEzsignfolderID: ").Append(fkiEzsignfolderID).Append("\n");
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
            return this.Equals(input as EzsignfoldersignerassociationRequest);
        }

        /// <summary>
        /// Returns true if EzsignfoldersignerassociationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfoldersignerassociationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfoldersignerassociationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.fkiUserID == input.fkiUserID ||
                    (this.fkiUserID != null &&
                    this.fkiUserID.Equals(input.fkiUserID))
                ) && 
                (
                    this.fkiEzsignfolderID == input.fkiEzsignfolderID ||
                    (this.fkiEzsignfolderID != null &&
                    this.fkiEzsignfolderID.Equals(input.fkiEzsignfolderID))
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
                if (this.fkiUserID != null)
                    hashCode = hashCode * 59 + this.fkiUserID.GetHashCode();
                if (this.fkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.fkiEzsignfolderID.GetHashCode();
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

 
            // fkiUserID (int) minimum
            if(this.fkiUserID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiUserID, must be a value greater than or equal to 1.", new [] { "fkiUserID" });
            }


 
            // fkiEzsignfolderID (int) minimum
            if(this.fkiEzsignfolderID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for fkiEzsignfolderID, must be a value greater than or equal to 1.", new [] { "fkiEzsignfolderID" });
            }

            yield break;
        }
    }

}
