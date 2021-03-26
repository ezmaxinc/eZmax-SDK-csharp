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
    /// An Ezsigndocument Object and children to create a complete structure
    /// </summary>
    [DataContract]
    public partial class EzsigndocumentRequestCompound :  IEquatable<EzsigndocumentRequestCompound>, IValidatableObject
    {
        /// <summary>
        /// Indicates where to look for the document binary content.
        /// </summary>
        /// <value>Indicates where to look for the document binary content.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EEzsigndocumentSourceEnum
        {
            /// <summary>
            /// Enum Base64 for value: Base64
            /// </summary>
            [EnumMember(Value = "Base64")]
            Base64 = 1

        }

        /// <summary>
        /// Indicates where to look for the document binary content.
        /// </summary>
        /// <value>Indicates where to look for the document binary content.</value>
        [DataMember(Name="eEzsigndocumentSource", EmitDefaultValue=true)]
        public EEzsigndocumentSourceEnum EEzsigndocumentSource { get; set; }
        /// <summary>
        /// Indicates the format of the document.
        /// </summary>
        /// <value>Indicates the format of the document.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EEzsigndocumentFormatEnum
        {
            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 1

        }

        /// <summary>
        /// Indicates the format of the document.
        /// </summary>
        /// <value>Indicates the format of the document.</value>
        [DataMember(Name="eEzsigndocumentFormat", EmitDefaultValue=true)]
        public EEzsigndocumentFormatEnum EEzsigndocumentFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentRequestCompound" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsigndocumentRequestCompound() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsigndocumentRequestCompound" /> class.
        /// </summary>
        /// <param name="eEzsigndocumentSource">Indicates where to look for the document binary content. (required).</param>
        /// <param name="eEzsigndocumentFormat">Indicates the format of the document. (required).</param>
        /// <param name="sEzsigndocumentBase64">The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64..</param>
        /// <param name="fkiEzsignfolderID">A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation. (required).</param>
        /// <param name="dtEzsigndocumentDuedate">Represent a Date Time. The timezone is the one configured in the User&#39;s profile. (required).</param>
        /// <param name="fkiLanguageID">The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English| (required).</param>
        /// <param name="sEzsigndocumentName">The name of the document that will be presented to Ezsignfoldersignerassociations (required).</param>
        public EzsigndocumentRequestCompound(EEzsigndocumentSourceEnum eEzsigndocumentSource = default(EEzsigndocumentSourceEnum), EEzsigndocumentFormatEnum eEzsigndocumentFormat = default(EEzsigndocumentFormatEnum), byte[] sEzsigndocumentBase64 = default(byte[]), int fkiEzsignfolderID = default(int), string dtEzsigndocumentDuedate = default(string), int fkiLanguageID = default(int), string sEzsigndocumentName = default(string))
        {
            // to ensure "eEzsigndocumentSource" is required (not null)
            if (eEzsigndocumentSource == null)
            {
                throw new InvalidDataException("eEzsigndocumentSource is a required property for EzsigndocumentRequestCompound and cannot be null");
            }
            else
            {
                this.EEzsigndocumentSource = eEzsigndocumentSource;
            }

            // to ensure "eEzsigndocumentFormat" is required (not null)
            if (eEzsigndocumentFormat == null)
            {
                throw new InvalidDataException("eEzsigndocumentFormat is a required property for EzsigndocumentRequestCompound and cannot be null");
            }
            else
            {
                this.EEzsigndocumentFormat = eEzsigndocumentFormat;
            }

            // to ensure "fkiEzsignfolderID" is required (not null)
            if (fkiEzsignfolderID == null)
            {
                throw new InvalidDataException("fkiEzsignfolderID is a required property for EzsigndocumentRequestCompound and cannot be null");
            }
            else
            {
                this.FkiEzsignfolderID = fkiEzsignfolderID;
            }

            // to ensure "dtEzsigndocumentDuedate" is required (not null)
            if (dtEzsigndocumentDuedate == null)
            {
                throw new InvalidDataException("dtEzsigndocumentDuedate is a required property for EzsigndocumentRequestCompound and cannot be null");
            }
            else
            {
                this.DtEzsigndocumentDuedate = dtEzsigndocumentDuedate;
            }

            // to ensure "fkiLanguageID" is required (not null)
            if (fkiLanguageID == null)
            {
                throw new InvalidDataException("fkiLanguageID is a required property for EzsigndocumentRequestCompound and cannot be null");
            }
            else
            {
                this.FkiLanguageID = fkiLanguageID;
            }

            // to ensure "sEzsigndocumentName" is required (not null)
            if (sEzsigndocumentName == null)
            {
                throw new InvalidDataException("sEzsigndocumentName is a required property for EzsigndocumentRequestCompound and cannot be null");
            }
            else
            {
                this.SEzsigndocumentName = sEzsigndocumentName;
            }

            this.SEzsigndocumentBase64 = sEzsigndocumentBase64;
        }



        /// <summary>
        /// The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64.
        /// </summary>
        /// <value>The Base64 encoded binary content of the document.  This field is Required when eEzsigndocumentSource &#x3D; Base64.</value>
        [DataMember(Name="sEzsigndocumentBase64", EmitDefaultValue=false)]
        public byte[] SEzsigndocumentBase64 { get; set; }

        /// <summary>
        /// A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.
        /// </summary>
        /// <value>A reference to a valid Ezsignfolder.  That value is returned after a successful Ezsignfolder Creation.</value>
        [DataMember(Name="fkiEzsignfolderID", EmitDefaultValue=true)]
        public int FkiEzsignfolderID { get; set; }

        /// <summary>
        /// Represent a Date Time. The timezone is the one configured in the User&#39;s profile.
        /// </summary>
        /// <value>Represent a Date Time. The timezone is the one configured in the User&#39;s profile.</value>
        [DataMember(Name="dtEzsigndocumentDuedate", EmitDefaultValue=true)]
        public string DtEzsigndocumentDuedate { get; set; }

        /// <summary>
        /// The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|
        /// </summary>
        /// <value>The unique ID of the Language.  Valid values:  |Value|Description| |-|-| |1|French| |2|English|</value>
        [DataMember(Name="fkiLanguageID", EmitDefaultValue=true)]
        public int FkiLanguageID { get; set; }

        /// <summary>
        /// The name of the document that will be presented to Ezsignfoldersignerassociations
        /// </summary>
        /// <value>The name of the document that will be presented to Ezsignfoldersignerassociations</value>
        [DataMember(Name="sEzsigndocumentName", EmitDefaultValue=true)]
        public string SEzsigndocumentName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsigndocumentRequestCompound {\n");
            sb.Append("  EEzsigndocumentSource: ").Append(EEzsigndocumentSource).Append("\n");
            sb.Append("  EEzsigndocumentFormat: ").Append(EEzsigndocumentFormat).Append("\n");
            sb.Append("  SEzsigndocumentBase64: ").Append(SEzsigndocumentBase64).Append("\n");
            sb.Append("  FkiEzsignfolderID: ").Append(FkiEzsignfolderID).Append("\n");
            sb.Append("  DtEzsigndocumentDuedate: ").Append(DtEzsigndocumentDuedate).Append("\n");
            sb.Append("  FkiLanguageID: ").Append(FkiLanguageID).Append("\n");
            sb.Append("  SEzsigndocumentName: ").Append(SEzsigndocumentName).Append("\n");
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
            return this.Equals(input as EzsigndocumentRequestCompound);
        }

        /// <summary>
        /// Returns true if EzsigndocumentRequestCompound instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsigndocumentRequestCompound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsigndocumentRequestCompound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EEzsigndocumentSource == input.EEzsigndocumentSource ||
                    (this.EEzsigndocumentSource != null &&
                    this.EEzsigndocumentSource.Equals(input.EEzsigndocumentSource))
                ) && 
                (
                    this.EEzsigndocumentFormat == input.EEzsigndocumentFormat ||
                    (this.EEzsigndocumentFormat != null &&
                    this.EEzsigndocumentFormat.Equals(input.EEzsigndocumentFormat))
                ) && 
                (
                    this.SEzsigndocumentBase64 == input.SEzsigndocumentBase64 ||
                    (this.SEzsigndocumentBase64 != null &&
                    this.SEzsigndocumentBase64.Equals(input.SEzsigndocumentBase64))
                ) && 
                (
                    this.FkiEzsignfolderID == input.FkiEzsignfolderID ||
                    (this.FkiEzsignfolderID != null &&
                    this.FkiEzsignfolderID.Equals(input.FkiEzsignfolderID))
                ) && 
                (
                    this.DtEzsigndocumentDuedate == input.DtEzsigndocumentDuedate ||
                    (this.DtEzsigndocumentDuedate != null &&
                    this.DtEzsigndocumentDuedate.Equals(input.DtEzsigndocumentDuedate))
                ) && 
                (
                    this.FkiLanguageID == input.FkiLanguageID ||
                    (this.FkiLanguageID != null &&
                    this.FkiLanguageID.Equals(input.FkiLanguageID))
                ) && 
                (
                    this.SEzsigndocumentName == input.SEzsigndocumentName ||
                    (this.SEzsigndocumentName != null &&
                    this.SEzsigndocumentName.Equals(input.SEzsigndocumentName))
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
                if (this.EEzsigndocumentSource != null)
                    hashCode = hashCode * 59 + this.EEzsigndocumentSource.GetHashCode();
                if (this.EEzsigndocumentFormat != null)
                    hashCode = hashCode * 59 + this.EEzsigndocumentFormat.GetHashCode();
                if (this.SEzsigndocumentBase64 != null)
                    hashCode = hashCode * 59 + this.SEzsigndocumentBase64.GetHashCode();
                if (this.FkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfolderID.GetHashCode();
                if (this.DtEzsigndocumentDuedate != null)
                    hashCode = hashCode * 59 + this.DtEzsigndocumentDuedate.GetHashCode();
                if (this.FkiLanguageID != null)
                    hashCode = hashCode * 59 + this.FkiLanguageID.GetHashCode();
                if (this.SEzsigndocumentName != null)
                    hashCode = hashCode * 59 + this.SEzsigndocumentName.GetHashCode();
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

 
            // FkiEzsignfolderID (int) minimum
            if(this.FkiEzsignfolderID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsignfolderID, must be a value greater than or equal to 1.", new [] { "FkiEzsignfolderID" });
            }


 
            // FkiLanguageID (int) maximum
            if(this.FkiLanguageID > (int)2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value less than or equal to 2.", new [] { "FkiLanguageID" });
            }

            // FkiLanguageID (int) minimum
            if(this.FkiLanguageID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiLanguageID, must be a value greater than or equal to 1.", new [] { "FkiLanguageID" });
            }

            yield break;
        }
    }

}
