/*
 * eZmax API Definition
 *
 * This API expose all the functionnalities for the eZmax and eZsign applications.
 *
 * The version of the OpenAPI document: 1.0.42
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
    /// An Ezsignfolder Object
    /// </summary>
    [DataContract]
    public partial class EzsignfolderResponse :  IEquatable<EzsignfolderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EzsignfolderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EzsignfolderResponse" /> class.
        /// </summary>
        /// <param name="fkiEzsignfoldertypeID">The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here. (required).</param>
        /// <param name="fkiEzsigntsarequirementID">The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**| (required).</param>
        /// <param name="sEzsignfolderDescription">The description of the Ezsign Folder (required).</param>
        /// <param name="tEzsignfolderNote">Somes extra notes about the eZsign Folder (required).</param>
        /// <param name="eEzsignfolderSendreminderfrequency">eEzsignfolderSendreminderfrequency (required).</param>
        /// <param name="pkiEzsignfolderID">The unique ID of the Ezsignfolder (required).</param>
        /// <param name="dtEzsignfolderSentdate">The date and time at which the Ezsign folder was sent the last time. (required).</param>
        /// <param name="eEzsignfolderStep">eEzsignfolderStep (required).</param>
        /// <param name="dtEzsignfolderClose">The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely. (required).</param>
        /// <param name="objAudit">objAudit (required).</param>
        public EzsignfolderResponse(int fkiEzsignfoldertypeID = default(int), int fkiEzsigntsarequirementID = default(int), string sEzsignfolderDescription = default(string), string tEzsignfolderNote = default(string), FieldEEzsignfolderSendreminderfrequency eEzsignfolderSendreminderfrequency = default(FieldEEzsignfolderSendreminderfrequency), int pkiEzsignfolderID = default(int), string dtEzsignfolderSentdate = default(string), FieldEEzsignfolderStep eEzsignfolderStep = default(FieldEEzsignfolderStep), string dtEzsignfolderClose = default(string), CommonAudit objAudit = default(CommonAudit))
        {
            // to ensure "fkiEzsignfoldertypeID" is required (not null)
            if (fkiEzsignfoldertypeID == null)
            {
                throw new InvalidDataException("fkiEzsignfoldertypeID is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.FkiEzsignfoldertypeID = fkiEzsignfoldertypeID;
            }

            // to ensure "fkiEzsigntsarequirementID" is required (not null)
            if (fkiEzsigntsarequirementID == null)
            {
                throw new InvalidDataException("fkiEzsigntsarequirementID is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.FkiEzsigntsarequirementID = fkiEzsigntsarequirementID;
            }

            // to ensure "sEzsignfolderDescription" is required (not null)
            if (sEzsignfolderDescription == null)
            {
                throw new InvalidDataException("sEzsignfolderDescription is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.SEzsignfolderDescription = sEzsignfolderDescription;
            }

            // to ensure "tEzsignfolderNote" is required (not null)
            if (tEzsignfolderNote == null)
            {
                throw new InvalidDataException("tEzsignfolderNote is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.TEzsignfolderNote = tEzsignfolderNote;
            }

            // to ensure "eEzsignfolderSendreminderfrequency" is required (not null)
            if (eEzsignfolderSendreminderfrequency == null)
            {
                throw new InvalidDataException("eEzsignfolderSendreminderfrequency is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.EEzsignfolderSendreminderfrequency = eEzsignfolderSendreminderfrequency;
            }

            // to ensure "pkiEzsignfolderID" is required (not null)
            if (pkiEzsignfolderID == null)
            {
                throw new InvalidDataException("pkiEzsignfolderID is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.PkiEzsignfolderID = pkiEzsignfolderID;
            }

            // to ensure "dtEzsignfolderSentdate" is required (not null)
            if (dtEzsignfolderSentdate == null)
            {
                throw new InvalidDataException("dtEzsignfolderSentdate is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.DtEzsignfolderSentdate = dtEzsignfolderSentdate;
            }

            // to ensure "eEzsignfolderStep" is required (not null)
            if (eEzsignfolderStep == null)
            {
                throw new InvalidDataException("eEzsignfolderStep is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.EEzsignfolderStep = eEzsignfolderStep;
            }

            // to ensure "dtEzsignfolderClose" is required (not null)
            if (dtEzsignfolderClose == null)
            {
                throw new InvalidDataException("dtEzsignfolderClose is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.DtEzsignfolderClose = dtEzsignfolderClose;
            }

            // to ensure "objAudit" is required (not null)
            if (objAudit == null)
            {
                throw new InvalidDataException("objAudit is a required property for EzsignfolderResponse and cannot be null");
            }
            else
            {
                this.ObjAudit = objAudit;
            }

        }

        /// <summary>
        /// The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.
        /// </summary>
        /// <value>The unique ID of the Ezsignfoldertype.    This value can be queried by the API and is also visible in the admin interface.    There are two types of Ezsignfoldertype. **User** and **Shared**. **User** can only be seen by the user who created the folder or its assistants. Access to **Shared** folders are configurable for access and email delivery. You should typically choose a **Shared** type here.</value>
        [DataMember(Name="fkiEzsignfoldertypeID", EmitDefaultValue=true)]
        public int FkiEzsignfoldertypeID { get; set; }

        /// <summary>
        /// The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|
        /// </summary>
        /// <value>The unique ID of the Ezsigntsarequirement.  Determine if a Time Stamping Authority should add a timestamp on each of the signature. Valid values:  |Value|Description| |-|-| |1|No. TSA Timestamping will requested. This will make all signatures a lot faster since no round-trip to the TSA server will be required. Timestamping will be made using eZsign server&#39;s time.| |2|Best effort. Timestamping from a Time Stamping Authority will be requested but is not mandatory. In the very improbable case it cannot be completed, the timestamping will be made using eZsign server&#39;s time. **Additional fee applies**| |3|Mandatory. Timestamping from a Time Stamping Authority will be requested and is mandatory. In the very improbable case it cannot be completed, the signature will fail and the user will be asked to retry. **Additional fee applies**|</value>
        [DataMember(Name="fkiEzsigntsarequirementID", EmitDefaultValue=true)]
        public int FkiEzsigntsarequirementID { get; set; }

        /// <summary>
        /// The description of the Ezsign Folder
        /// </summary>
        /// <value>The description of the Ezsign Folder</value>
        [DataMember(Name="sEzsignfolderDescription", EmitDefaultValue=true)]
        public string SEzsignfolderDescription { get; set; }

        /// <summary>
        /// Somes extra notes about the eZsign Folder
        /// </summary>
        /// <value>Somes extra notes about the eZsign Folder</value>
        [DataMember(Name="tEzsignfolderNote", EmitDefaultValue=true)]
        public string TEzsignfolderNote { get; set; }

        /// <summary>
        /// Gets or Sets EEzsignfolderSendreminderfrequency
        /// </summary>
        [DataMember(Name="eEzsignfolderSendreminderfrequency", EmitDefaultValue=true)]
        public FieldEEzsignfolderSendreminderfrequency EEzsignfolderSendreminderfrequency { get; set; }

        /// <summary>
        /// The unique ID of the Ezsignfolder
        /// </summary>
        /// <value>The unique ID of the Ezsignfolder</value>
        [DataMember(Name="pkiEzsignfolderID", EmitDefaultValue=true)]
        public int PkiEzsignfolderID { get; set; }

        /// <summary>
        /// The date and time at which the Ezsign folder was sent the last time.
        /// </summary>
        /// <value>The date and time at which the Ezsign folder was sent the last time.</value>
        [DataMember(Name="dtEzsignfolderSentdate", EmitDefaultValue=true)]
        public string DtEzsignfolderSentdate { get; set; }

        /// <summary>
        /// Gets or Sets EEzsignfolderStep
        /// </summary>
        [DataMember(Name="eEzsignfolderStep", EmitDefaultValue=true)]
        public FieldEEzsignfolderStep EEzsignfolderStep { get; set; }

        /// <summary>
        /// The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely.
        /// </summary>
        /// <value>The date and time at which the folder was closed. Either by applying the last signature or by completing it prematurely.</value>
        [DataMember(Name="dtEzsignfolderClose", EmitDefaultValue=true)]
        public string DtEzsignfolderClose { get; set; }

        /// <summary>
        /// Gets or Sets ObjAudit
        /// </summary>
        [DataMember(Name="objAudit", EmitDefaultValue=true)]
        public CommonAudit ObjAudit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EzsignfolderResponse {\n");
            sb.Append("  FkiEzsignfoldertypeID: ").Append(FkiEzsignfoldertypeID).Append("\n");
            sb.Append("  FkiEzsigntsarequirementID: ").Append(FkiEzsigntsarequirementID).Append("\n");
            sb.Append("  SEzsignfolderDescription: ").Append(SEzsignfolderDescription).Append("\n");
            sb.Append("  TEzsignfolderNote: ").Append(TEzsignfolderNote).Append("\n");
            sb.Append("  EEzsignfolderSendreminderfrequency: ").Append(EEzsignfolderSendreminderfrequency).Append("\n");
            sb.Append("  PkiEzsignfolderID: ").Append(PkiEzsignfolderID).Append("\n");
            sb.Append("  DtEzsignfolderSentdate: ").Append(DtEzsignfolderSentdate).Append("\n");
            sb.Append("  EEzsignfolderStep: ").Append(EEzsignfolderStep).Append("\n");
            sb.Append("  DtEzsignfolderClose: ").Append(DtEzsignfolderClose).Append("\n");
            sb.Append("  ObjAudit: ").Append(ObjAudit).Append("\n");
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
            return this.Equals(input as EzsignfolderResponse);
        }

        /// <summary>
        /// Returns true if EzsignfolderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EzsignfolderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EzsignfolderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FkiEzsignfoldertypeID == input.FkiEzsignfoldertypeID ||
                    (this.FkiEzsignfoldertypeID != null &&
                    this.FkiEzsignfoldertypeID.Equals(input.FkiEzsignfoldertypeID))
                ) && 
                (
                    this.FkiEzsigntsarequirementID == input.FkiEzsigntsarequirementID ||
                    (this.FkiEzsigntsarequirementID != null &&
                    this.FkiEzsigntsarequirementID.Equals(input.FkiEzsigntsarequirementID))
                ) && 
                (
                    this.SEzsignfolderDescription == input.SEzsignfolderDescription ||
                    (this.SEzsignfolderDescription != null &&
                    this.SEzsignfolderDescription.Equals(input.SEzsignfolderDescription))
                ) && 
                (
                    this.TEzsignfolderNote == input.TEzsignfolderNote ||
                    (this.TEzsignfolderNote != null &&
                    this.TEzsignfolderNote.Equals(input.TEzsignfolderNote))
                ) && 
                (
                    this.EEzsignfolderSendreminderfrequency == input.EEzsignfolderSendreminderfrequency ||
                    (this.EEzsignfolderSendreminderfrequency != null &&
                    this.EEzsignfolderSendreminderfrequency.Equals(input.EEzsignfolderSendreminderfrequency))
                ) && 
                (
                    this.PkiEzsignfolderID == input.PkiEzsignfolderID ||
                    (this.PkiEzsignfolderID != null &&
                    this.PkiEzsignfolderID.Equals(input.PkiEzsignfolderID))
                ) && 
                (
                    this.DtEzsignfolderSentdate == input.DtEzsignfolderSentdate ||
                    (this.DtEzsignfolderSentdate != null &&
                    this.DtEzsignfolderSentdate.Equals(input.DtEzsignfolderSentdate))
                ) && 
                (
                    this.EEzsignfolderStep == input.EEzsignfolderStep ||
                    (this.EEzsignfolderStep != null &&
                    this.EEzsignfolderStep.Equals(input.EEzsignfolderStep))
                ) && 
                (
                    this.DtEzsignfolderClose == input.DtEzsignfolderClose ||
                    (this.DtEzsignfolderClose != null &&
                    this.DtEzsignfolderClose.Equals(input.DtEzsignfolderClose))
                ) && 
                (
                    this.ObjAudit == input.ObjAudit ||
                    (this.ObjAudit != null &&
                    this.ObjAudit.Equals(input.ObjAudit))
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
                if (this.FkiEzsignfoldertypeID != null)
                    hashCode = hashCode * 59 + this.FkiEzsignfoldertypeID.GetHashCode();
                if (this.FkiEzsigntsarequirementID != null)
                    hashCode = hashCode * 59 + this.FkiEzsigntsarequirementID.GetHashCode();
                if (this.SEzsignfolderDescription != null)
                    hashCode = hashCode * 59 + this.SEzsignfolderDescription.GetHashCode();
                if (this.TEzsignfolderNote != null)
                    hashCode = hashCode * 59 + this.TEzsignfolderNote.GetHashCode();
                if (this.EEzsignfolderSendreminderfrequency != null)
                    hashCode = hashCode * 59 + this.EEzsignfolderSendreminderfrequency.GetHashCode();
                if (this.PkiEzsignfolderID != null)
                    hashCode = hashCode * 59 + this.PkiEzsignfolderID.GetHashCode();
                if (this.DtEzsignfolderSentdate != null)
                    hashCode = hashCode * 59 + this.DtEzsignfolderSentdate.GetHashCode();
                if (this.EEzsignfolderStep != null)
                    hashCode = hashCode * 59 + this.EEzsignfolderStep.GetHashCode();
                if (this.DtEzsignfolderClose != null)
                    hashCode = hashCode * 59 + this.DtEzsignfolderClose.GetHashCode();
                if (this.ObjAudit != null)
                    hashCode = hashCode * 59 + this.ObjAudit.GetHashCode();
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

 
            // FkiEzsigntsarequirementID (int) maximum
            if(this.FkiEzsigntsarequirementID > (int)3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntsarequirementID, must be a value less than or equal to 3.", new [] { "FkiEzsigntsarequirementID" });
            }

            // FkiEzsigntsarequirementID (int) minimum
            if(this.FkiEzsigntsarequirementID < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FkiEzsigntsarequirementID, must be a value greater than or equal to 1.", new [] { "FkiEzsigntsarequirementID" });
            }

            yield break;
        }
    }

}
